using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E2B;

public sealed partial class Sandbox
{
    private SandboxCommandsClient? commands;

    /// <summary>
    /// Runs commands in this sandbox.
    /// </summary>
    [JsonIgnore]
    public SandboxCommandsClient Commands => commands ??= new SandboxCommandsClient(this);
}

/// <summary>
/// Options for running a command in an E2B sandbox.
/// </summary>
public sealed class SandboxCommandOptions
{
    /// <summary>
    /// Working directory for the command. The sandbox user's home directory is used by default.
    /// </summary>
    public string? WorkingDirectory { get; init; }

    /// <summary>
    /// Environment variables supplied to the command.
    /// </summary>
    public IReadOnlyDictionary<string, string>? EnvironmentVariables { get; init; }

    /// <summary>
    /// User to run the command as. The template's default user is used when omitted.
    /// </summary>
    public string? User { get; init; }

    /// <summary>
    /// Maximum command duration. Defaults to 60 seconds. Use <see cref="TimeSpan.Zero"/> to disable the timeout.
    /// </summary>
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(60);
}

/// <summary>
/// Result of a completed sandbox command.
/// </summary>
public sealed record SandboxCommandResult(
    int ExitCode,
    string Stdout,
    string Stderr,
    string? Error);

/// <summary>
/// Error returned by the E2B sandbox command service.
/// </summary>
[SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = "The SDK exposes only protocol-relevant exception constructors.")]
public class SandboxCommandException : Exception
{
    /// <summary>
    /// Creates an exception with the command-service error message.
    /// </summary>
    public SandboxCommandException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Creates an exception with the command-service error message and underlying exception.
    /// </summary>
    public SandboxCommandException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

/// <summary>
/// Error thrown when a sandbox command exits with a non-zero exit code.
/// </summary>
[SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = "A command exit exception always requires its command result.")]
public sealed class SandboxCommandExitException : SandboxCommandException
{
    /// <summary>
    /// Creates an exception for a command result with a non-zero exit code.
    /// </summary>
    public SandboxCommandExitException(SandboxCommandResult result)
        : base(GetMessage(result))
    {
        Result = result;
    }

    /// <summary>
    /// Command result, including captured standard output and standard error.
    /// </summary>
    public SandboxCommandResult Result { get; }

    private static string GetMessage(SandboxCommandResult result)
    {
        ArgumentNullException.ThrowIfNull(result);
        return result.Error ?? $"Command exited with code {result.ExitCode}.";
    }
}

/// <summary>
/// Executes commands through the E2B sandbox envd service.
/// </summary>
public sealed class SandboxCommandsClient
{
    private const int EnvdPort = 49983;
    private const int MaximumEnvelopeSize = 16 * 1024 * 1024;
    private const byte CompressedEnvelopeFlag = 0b0000_0001;
    private const byte EndStreamEnvelopeFlag = 0b0000_0010;
    private static readonly HttpClient SharedHttpClient = new();
    private static readonly HashSet<string> StableSandboxDomains = new(StringComparer.OrdinalIgnoreCase)
    {
        "e2b.app",
        "e2b.dev",
        "e2b.pro",
        "e2b-staging.dev",
    };

    private readonly Sandbox sandbox;
    private readonly HttpClient httpClient;
    private readonly Uri baseUri;

    /// <summary>
    /// Creates a command client for a sandbox.
    /// </summary>
    /// <param name="sandbox">Sandbox returned by the E2B control-plane API.</param>
    /// <param name="httpClient">Optional HTTP client used for command requests.</param>
    /// <param name="baseUri">Optional envd base URI for self-hosted or test environments.</param>
    public SandboxCommandsClient(Sandbox sandbox, HttpClient? httpClient = null, Uri? baseUri = null)
    {
        this.sandbox = sandbox ?? throw new ArgumentNullException(nameof(sandbox));
        this.httpClient = httpClient ?? SharedHttpClient;
        this.baseUri = baseUri ?? GetSandboxBaseUri(sandbox);
    }

    /// <summary>
    /// Runs a Bash command and waits for it to finish.
    /// </summary>
    /// <exception cref="SandboxCommandExitException">The command exited with a non-zero exit code.</exception>
    /// <exception cref="SandboxCommandException">The sandbox command service returned an invalid response or protocol error.</exception>
    public async Task<SandboxCommandResult> RunAsync(
        string command,
        SandboxCommandOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(command);
        options ??= new SandboxCommandOptions();

        if (options.Timeout < TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "Command timeout cannot be negative.");
        }

        using var timeoutCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        if (options.Timeout > TimeSpan.Zero)
        {
            timeoutCancellationTokenSource.CancelAfter(options.Timeout);
        }

        var effectiveCancellationToken = timeoutCancellationTokenSource.Token;
        using var request = CreateRequest(command, options);
        using var response = await httpClient.SendAsync(
                request,
                HttpCompletionOption.ResponseHeadersRead,
                effectiveCancellationToken)
            .ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync(effectiveCancellationToken).ConfigureAwait(false);
            throw new SandboxCommandException(
                $"E2B command request failed with HTTP {(int)response.StatusCode}: {responseContent}");
        }

        var responseStream = await response.Content.ReadAsStreamAsync(effectiveCancellationToken).ConfigureAwait(false);
        await using var configuredResponseStream = responseStream.ConfigureAwait(false);
        var result = await ReadResultAsync(responseStream, effectiveCancellationToken).ConfigureAwait(false);

        if (result.ExitCode != 0)
        {
            throw new SandboxCommandExitException(result);
        }

        return result;
    }

    private HttpRequestMessage CreateRequest(string command, SandboxCommandOptions options)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, new Uri(baseUri, "/process.Process/Start"))
        {
            Content = new ByteArrayContent(CreateStartEnvelope(command, options)),
            Version = System.Net.HttpVersion.Version11,
            VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher,
        };

        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/connect+json");
        request.Headers.TryAddWithoutValidation("Connect-Protocol-Version", "1");
        request.Headers.TryAddWithoutValidation("E2b-Sandbox-Id", sandbox.SandboxID);
        request.Headers.TryAddWithoutValidation("E2b-Sandbox-Port", EnvdPort.ToString(System.Globalization.CultureInfo.InvariantCulture));
        request.Headers.TryAddWithoutValidation("Keepalive-Ping-Interval", "50");

        if (options.Timeout > TimeSpan.Zero)
        {
            request.Headers.TryAddWithoutValidation(
                "Connect-Timeout-Ms",
                Math.Ceiling(options.Timeout.TotalMilliseconds).ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        if (!string.IsNullOrWhiteSpace(sandbox.EnvdAccessToken))
        {
            request.Headers.TryAddWithoutValidation("X-Access-Token", sandbox.EnvdAccessToken);
        }

        var user = options.User;
        if (user is null && IsOlderEnvdVersion(sandbox.EnvdVersion, 0, 4, 0))
        {
            user = "user";
        }

        if (!string.IsNullOrWhiteSpace(user))
        {
            var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user}:"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", credentials);
        }

        return request;
    }

    private static byte[] CreateStartEnvelope(string command, SandboxCommandOptions options)
    {
        using var messageStream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(messageStream))
        {
            writer.WriteStartObject();
            writer.WritePropertyName("process");
            writer.WriteStartObject();
            writer.WriteString("cmd", "/bin/bash");
            writer.WritePropertyName("args");
            writer.WriteStartArray();
            writer.WriteStringValue("-l");
            writer.WriteStringValue("-c");
            writer.WriteStringValue(command);
            writer.WriteEndArray();

            if (options.EnvironmentVariables is { Count: > 0 })
            {
                writer.WritePropertyName("envs");
                writer.WriteStartObject();
                foreach (var (name, value) in options.EnvironmentVariables)
                {
                    writer.WriteString(name, value);
                }

                writer.WriteEndObject();
            }

            if (!string.IsNullOrWhiteSpace(options.WorkingDirectory))
            {
                writer.WriteString("cwd", options.WorkingDirectory);
            }

            writer.WriteEndObject();
            writer.WriteBoolean("stdin", false);
            writer.WriteEndObject();
        }

        var message = messageStream.ToArray();
        var envelope = new byte[5 + message.Length];
        BinaryPrimitives.WriteUInt32BigEndian(envelope.AsSpan(1, 4), checked((uint)message.Length));
        message.CopyTo(envelope, 5);
        return envelope;
    }

    private static async Task<SandboxCommandResult> ReadResultAsync(Stream stream, CancellationToken cancellationToken)
    {
        using var standardOutput = new MemoryStream();
        using var standardError = new MemoryStream();
        CommandEnd? commandEnd = null;
        var endStreamReceived = false;
        var header = new byte[5];

        while (await ReadEnvelopeHeaderAsync(stream, header, cancellationToken).ConfigureAwait(false))
        {
            var flags = header[0];
            var length = BinaryPrimitives.ReadUInt32BigEndian(header.AsSpan(1, 4));
            if (length > MaximumEnvelopeSize)
            {
                throw new SandboxCommandException($"E2B command response envelope exceeded {MaximumEnvelopeSize} bytes.");
            }

            var payload = new byte[length];
            await stream.ReadExactlyAsync(payload, cancellationToken).ConfigureAwait(false);

            if ((flags & CompressedEnvelopeFlag) != 0)
            {
                throw new SandboxCommandException("Compressed E2B command response envelopes are not supported.");
            }

            if ((flags & EndStreamEnvelopeFlag) != 0)
            {
                if (endStreamReceived)
                {
                    throw new SandboxCommandException("E2B command response contained multiple end-stream envelopes.");
                }

                endStreamReceived = true;
                ThrowIfEndStreamError(payload);
                continue;
            }

            if (endStreamReceived)
            {
                throw new SandboxCommandException("E2B command response contained data after the end-stream envelope.");
            }

            ReadProcessEvent(payload, standardOutput, standardError, ref commandEnd);
        }

        if (!endStreamReceived)
        {
            throw new SandboxCommandException("E2B command response ended without an end-stream envelope.");
        }

        if (commandEnd is null)
        {
            throw new SandboxCommandException("E2B command response ended without a process result.");
        }

        return new SandboxCommandResult(
            commandEnd.ExitCode,
            Encoding.UTF8.GetString(standardOutput.ToArray()),
            Encoding.UTF8.GetString(standardError.ToArray()),
            commandEnd.Error);
    }

    private static async Task<bool> ReadEnvelopeHeaderAsync(
        Stream stream,
        byte[] header,
        CancellationToken cancellationToken)
    {
        var offset = 0;
        while (offset < header.Length)
        {
            var read = await stream.ReadAsync(header.AsMemory(offset), cancellationToken).ConfigureAwait(false);
            if (read == 0)
            {
                if (offset == 0)
                {
                    return false;
                }

                throw new SandboxCommandException("E2B command response ended with an incomplete envelope header.");
            }

            offset += read;
        }

        return true;
    }

    private static void ReadProcessEvent(
        ReadOnlyMemory<byte> payload,
        Stream standardOutput,
        Stream standardError,
        ref CommandEnd? commandEnd)
    {
        using var document = JsonDocument.Parse(payload);
        if (!document.RootElement.TryGetProperty("event", out var processEvent))
        {
            return;
        }

        if (processEvent.TryGetProperty("data", out var dataEvent))
        {
            if (dataEvent.TryGetProperty("stdout", out var stdout))
            {
                WriteBase64(stdout, standardOutput, "stdout");
            }

            if (dataEvent.TryGetProperty("stderr", out var stderr))
            {
                WriteBase64(stderr, standardError, "stderr");
            }
        }

        if (processEvent.TryGetProperty("end", out var endEvent))
        {
            commandEnd = new CommandEnd(
                endEvent.GetProperty("exitCode").GetInt32(),
                endEvent.TryGetProperty("error", out var error) ? error.GetString() : null);
        }
    }

    private static void WriteBase64(JsonElement value, Stream destination, string streamName)
    {
        try
        {
            var bytes = value.GetBytesFromBase64();
            destination.Write(bytes);
        }
        catch (FormatException exception)
        {
            throw new SandboxCommandException($"E2B command response contained invalid {streamName} data.", exception);
        }
    }

    private static void ThrowIfEndStreamError(ReadOnlyMemory<byte> payload)
    {
        using var document = JsonDocument.Parse(payload);
        if (!document.RootElement.TryGetProperty("error", out var error))
        {
            return;
        }

        var code = error.TryGetProperty("code", out var codeValue) ? codeValue.GetString() : null;
        var message = error.TryGetProperty("message", out var messageValue) ? messageValue.GetString() : null;
        throw new SandboxCommandException(
            string.IsNullOrWhiteSpace(code) ? message ?? "E2B command stream failed." : $"{code}: {message}");
    }

    private static Uri GetSandboxBaseUri(Sandbox sandbox)
    {
        var domain = string.IsNullOrWhiteSpace(sandbox.Domain) ? "e2b.app" : sandbox.Domain;
        var host = StableSandboxDomains.Contains(domain)
            ? $"sandbox.{domain}"
            : $"{EnvdPort}-{sandbox.SandboxID}.{domain}";
        return new Uri($"https://{host}", UriKind.Absolute);
    }

    private static bool IsOlderEnvdVersion(string version, int major, int minor, int patch)
    {
        var normalized = version.TrimStart('v', 'V');
        var suffixIndex = normalized.IndexOfAny(['-', '+']);
        if (suffixIndex >= 0)
        {
            normalized = normalized[..suffixIndex];
        }

        return Version.TryParse(normalized, out var parsed) && parsed < new Version(major, minor, patch);
    }

    private sealed record CommandEnd(int ExitCode, string? Error);
}
