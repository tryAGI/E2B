using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace E2B;

public sealed partial class Sandbox
{
    private SandboxCommandsClient? commands;

    /// <summary>
    /// Runs and manages commands in this sandbox.
    /// </summary>
    [JsonIgnore]
    public SandboxCommandsClient Commands => commands ??= new SandboxCommandsClient(this);
}

/// <summary>
/// Options for starting a command in an E2B sandbox.
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
    /// Keeps standard input open so data can be sent through <see cref="SandboxCommandHandle.SendStdinAsync(string, CancellationToken)"/>.
    /// </summary>
    public bool Stdin { get; init; }

    /// <summary>
    /// Receives decoded standard-output chunks while the command is running.
    /// </summary>
    public Action<string>? OnStdout { get; init; }

    /// <summary>
    /// Receives decoded standard-error chunks while the command is running.
    /// </summary>
    public Action<string>? OnStderr { get; init; }

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
        var handle = await StartAsync(command, options, cancellationToken).ConfigureAwait(false);
        await using (handle.ConfigureAwait(false))
        {
            return await handle.WaitAsync(cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>
    /// Starts a Bash command and returns a handle as soon as envd reports its process ID.
    /// </summary>
    /// <exception cref="SandboxCommandException">The sandbox command service returned an invalid response or protocol error.</exception>
    [SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Response, stream, and cancellation ownership transfers to the returned command handle.")]
    [SuppressMessage("Reliability", "CA2025:Do not pass IDisposable instances into unawaited tasks", Justification = "The parser task and its stream are owned and awaited by the returned command handle.")]
    public async Task<SandboxCommandHandle> StartAsync(
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

        CancellationTokenSource? executionCancellationTokenSource =
            CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        if (options.Timeout > TimeSpan.Zero)
        {
            executionCancellationTokenSource.CancelAfter(options.Timeout);
        }

        HttpResponseMessage? response = null;
        Stream? responseStream = null;
        SandboxCommandExecution? execution = null;
        try
        {
            using var request = CreateStartRequest(command, options);
            response = await httpClient.SendAsync(
                    request,
                    HttpCompletionOption.ResponseHeadersRead,
                    executionCancellationTokenSource.Token)
                .ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                await ThrowCommandRequestFailureAsync(response, executionCancellationTokenSource.Token).ConfigureAwait(false);
            }

            responseStream = await response.Content
                .ReadAsStreamAsync(executionCancellationTokenSource.Token)
                .ConfigureAwait(false);
            var started = new TaskCompletionSource<int>(TaskCreationOptions.RunContinuationsAsynchronously);
            var stdout = new SandboxCommandOutput(options.OnStdout);
            var stderr = new SandboxCommandOutput(options.OnStderr);
            var completion = ReadResultAsync(
                responseStream,
                stdout,
                stderr,
                started,
                executionCancellationTokenSource.Token);
            execution = new SandboxCommandExecution(
                response,
                responseStream,
                executionCancellationTokenSource,
                completion,
                stdout,
                stderr);
            response = null;
            responseStream = null;
            executionCancellationTokenSource = null;

            await Task.WhenAny(started.Task, completion).ConfigureAwait(false);
            if (!started.Task.IsCompletedSuccessfully)
            {
                await completion.ConfigureAwait(false);
                throw new SandboxCommandException("E2B command response ended without a process start event.");
            }

            var processId = await started.Task.ConfigureAwait(false);
            var handle = new SandboxCommandHandle(processId, this, execution);
            execution = null;
            return handle;
        }
        catch
        {
            if (execution is not null)
            {
                await execution.DisposeAsync().ConfigureAwait(false);
            }
            else
            {
                if (responseStream is not null)
                {
                    await responseStream.DisposeAsync().ConfigureAwait(false);
                }

                response?.Dispose();
                executionCancellationTokenSource?.Dispose();
            }

            throw;
        }
    }

    /// <summary>
    /// Sends data to a running command's standard input.
    /// </summary>
    public Task SendStdinAsync(
        int processId,
        string data,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(data);
        return SendStdinAsync(processId, Encoding.UTF8.GetBytes(data), cancellationToken);
    }

    /// <summary>
    /// Sends bytes to a running command's standard input.
    /// </summary>
    public Task SendStdinAsync(
        int processId,
        ReadOnlyMemory<byte> data,
        CancellationToken cancellationToken = default)
    {
        ValidateProcessId(processId);
        return SendUnaryAsync(
            "/process.Process/SendInput",
            CreateSendInputPayload(processId, data.Span),
            cancellationToken);
    }

    /// <summary>
    /// Closes a running command's standard input, signaling end-of-file.
    /// </summary>
    public Task CloseStdinAsync(int processId, CancellationToken cancellationToken = default)
    {
        ValidateProcessId(processId);
        if (IsOlderEnvdVersion(sandbox.EnvdVersion, 0, 5, 2))
        {
            throw new SandboxCommandException(
                $"Sandbox envd version {sandbox.EnvdVersion} does not support closing command stdin.");
        }

        return SendUnaryAsync(
            "/process.Process/CloseStdin",
            CreateProcessSelectorPayload(processId),
            cancellationToken);
    }

    /// <summary>
    /// Kills a running command with SIGKILL.
    /// </summary>
    /// <returns><see langword="true"/> when the signal was accepted; otherwise <see langword="false"/> when the process was not found.</returns>
    public async Task<bool> KillAsync(int processId, CancellationToken cancellationToken = default)
    {
        ValidateProcessId(processId);
        using var request = CreateUnaryRequest(
            "/process.Process/SendSignal",
            CreateSendSignalPayload(processId));
        using var response = await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        if (response.IsSuccessStatusCode)
        {
            return true;
        }

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        if (response.StatusCode == HttpStatusCode.NotFound || IsConnectNotFound(responseContent))
        {
            return false;
        }

        throw CreateCommandRequestFailure(response, responseContent);
    }

    private HttpRequestMessage CreateStartRequest(string command, SandboxCommandOptions options)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, new Uri(baseUri, "/process.Process/Start"))
        {
            Content = new ByteArrayContent(CreateStartEnvelope(command, options)),
            Version = HttpVersion.Version11,
            VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher,
        };

        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/connect+json");
        AddSandboxHeaders(request);
        request.Headers.TryAddWithoutValidation("Keepalive-Ping-Interval", "50");

        if (options.Timeout > TimeSpan.Zero)
        {
            request.Headers.TryAddWithoutValidation(
                "Connect-Timeout-Ms",
                Math.Ceiling(options.Timeout.TotalMilliseconds).ToString(System.Globalization.CultureInfo.InvariantCulture));
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

    private HttpRequestMessage CreateUnaryRequest(string path, byte[] payload)
    {
        var request = new HttpRequestMessage(HttpMethod.Post, new Uri(baseUri, path))
        {
            Content = new ByteArrayContent(payload),
            Version = HttpVersion.Version11,
            VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher,
        };
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        AddSandboxHeaders(request);
        return request;
    }

    private void AddSandboxHeaders(HttpRequestMessage request)
    {
        request.Headers.TryAddWithoutValidation("Connect-Protocol-Version", "1");
        request.Headers.TryAddWithoutValidation("E2b-Sandbox-Id", sandbox.SandboxID);
        request.Headers.TryAddWithoutValidation(
            "E2b-Sandbox-Port",
            EnvdPort.ToString(System.Globalization.CultureInfo.InvariantCulture));

        if (!string.IsNullOrWhiteSpace(sandbox.EnvdAccessToken))
        {
            request.Headers.TryAddWithoutValidation("X-Access-Token", sandbox.EnvdAccessToken);
        }
    }

    private async Task SendUnaryAsync(string path, byte[] payload, CancellationToken cancellationToken)
    {
        using var request = CreateUnaryRequest(path, payload);
        using var response = await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        if (!response.IsSuccessStatusCode)
        {
            await ThrowCommandRequestFailureAsync(response, cancellationToken).ConfigureAwait(false);
        }
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
            writer.WriteBoolean("stdin", options.Stdin);
            writer.WriteEndObject();
        }

        return CreateEnvelope(messageStream.ToArray());
    }

    private static byte[] CreateSendInputPayload(int processId, ReadOnlySpan<byte> data)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            writer.WriteStartObject();
            WriteProcessSelector(writer, processId);
            writer.WritePropertyName("input");
            writer.WriteStartObject();
            writer.WriteBase64String("stdin", data);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        return stream.ToArray();
    }

    private static byte[] CreateProcessSelectorPayload(int processId)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            writer.WriteStartObject();
            WriteProcessSelector(writer, processId);
            writer.WriteEndObject();
        }

        return stream.ToArray();
    }

    private static byte[] CreateSendSignalPayload(int processId)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            writer.WriteStartObject();
            WriteProcessSelector(writer, processId);
            writer.WriteString("signal", "SIGNAL_SIGKILL");
            writer.WriteEndObject();
        }

        return stream.ToArray();
    }

    private static void WriteProcessSelector(Utf8JsonWriter writer, int processId)
    {
        writer.WritePropertyName("process");
        writer.WriteStartObject();
        writer.WriteNumber("pid", processId);
        writer.WriteEndObject();
    }

    private static byte[] CreateEnvelope(byte[] message)
    {
        var envelope = new byte[5 + message.Length];
        BinaryPrimitives.WriteUInt32BigEndian(envelope.AsSpan(1, 4), checked((uint)message.Length));
        message.CopyTo(envelope, 5);
        return envelope;
    }

    private static async Task<SandboxCommandResult> ReadResultAsync(
        Stream stream,
        SandboxCommandOutput stdout,
        SandboxCommandOutput stderr,
        TaskCompletionSource<int> started,
        CancellationToken cancellationToken)
    {
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

            ReadProcessEvent(payload, stdout, stderr, started, ref commandEnd);
        }

        if (!endStreamReceived)
        {
            throw new SandboxCommandException("E2B command response ended without an end-stream envelope.");
        }

        if (commandEnd is null)
        {
            throw new SandboxCommandException("E2B command response ended without a process result.");
        }

        stdout.Complete();
        stderr.Complete();
        return new SandboxCommandResult(commandEnd.ExitCode, stdout.Text, stderr.Text, commandEnd.Error);
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
        SandboxCommandOutput stdout,
        SandboxCommandOutput stderr,
        TaskCompletionSource<int> started,
        ref CommandEnd? commandEnd)
    {
        using var document = JsonDocument.Parse(payload);
        if (!document.RootElement.TryGetProperty("event", out var processEvent))
        {
            return;
        }

        if (processEvent.TryGetProperty("start", out var startEvent) &&
            startEvent.TryGetProperty("pid", out var processId))
        {
            started.TrySetResult(processId.GetInt32());
        }

        if (processEvent.TryGetProperty("data", out var dataEvent))
        {
            if (dataEvent.TryGetProperty("stdout", out var stdoutValue))
            {
                WriteBase64(stdoutValue, stdout, "stdout");
            }

            if (dataEvent.TryGetProperty("stderr", out var stderrValue))
            {
                WriteBase64(stderrValue, stderr, "stderr");
            }
        }

        if (processEvent.TryGetProperty("end", out var endEvent))
        {
            commandEnd = new CommandEnd(
                endEvent.GetProperty("exitCode").GetInt32(),
                endEvent.TryGetProperty("error", out var error) ? error.GetString() : null);
        }
    }

    private static void WriteBase64(JsonElement value, SandboxCommandOutput destination, string streamName)
    {
        try
        {
            destination.Write(value.GetBytesFromBase64());
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

    private static async Task ThrowCommandRequestFailureAsync(
        HttpResponseMessage response,
        CancellationToken cancellationToken)
    {
        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        throw CreateCommandRequestFailure(response, responseContent);
    }

    private static SandboxCommandException CreateCommandRequestFailure(
        HttpResponseMessage response,
        string responseContent)
    {
        return new SandboxCommandException(
            $"E2B command request failed with HTTP {(int)response.StatusCode}: {responseContent}");
    }

    private static bool IsConnectNotFound(string responseContent)
    {
        try
        {
            using var document = JsonDocument.Parse(responseContent);
            return document.RootElement.TryGetProperty("code", out var code) &&
                string.Equals(code.GetString(), "not_found", StringComparison.OrdinalIgnoreCase);
        }
        catch (JsonException)
        {
            return false;
        }
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

    private static void ValidateProcessId(int processId)
    {
        if (processId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(processId), "Process ID must be positive.");
        }
    }

    private sealed record CommandEnd(int ExitCode, string? Error);
}

internal sealed class SandboxCommandOutput(Action<string>? callback)
{
    private readonly Decoder decoder = Encoding.UTF8.GetDecoder();
    private readonly StringBuilder text = new();
    private readonly object syncRoot = new();

    public string Text
    {
        get
        {
            lock (syncRoot)
            {
                return text.ToString();
            }
        }
    }

    public void Write(ReadOnlySpan<byte> bytes)
    {
        var characters = new char[Encoding.UTF8.GetMaxCharCount(bytes.Length)];
        decoder.Convert(bytes, characters, flush: false, out _, out var charactersUsed, out _);
        Publish(characters.AsSpan(0, charactersUsed));
    }

    public void Complete()
    {
        var characters = new char[Encoding.UTF8.GetMaxCharCount(0)];
        decoder.Convert([], characters, flush: true, out _, out var charactersUsed, out _);
        Publish(characters.AsSpan(0, charactersUsed));
    }

    private void Publish(ReadOnlySpan<char> characters)
    {
        if (characters.IsEmpty)
        {
            return;
        }

        var chunk = new string(characters);
        lock (syncRoot)
        {
            text.Append(chunk);
        }

        callback?.Invoke(chunk);
    }
}

internal sealed class SandboxCommandExecution(
    HttpResponseMessage response,
    Stream responseStream,
    CancellationTokenSource cancellationTokenSource,
    Task<SandboxCommandResult> completion,
    SandboxCommandOutput stdout,
    SandboxCommandOutput stderr) : IAsyncDisposable
{
    private int disposed;

    public Task<SandboxCommandResult> Completion { get; } = completion;
    public SandboxCommandOutput Stdout { get; } = stdout;
    public SandboxCommandOutput Stderr { get; } = stderr;

    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Disposal must not mask command or callback failures already exposed by Completion.")]
    public async ValueTask DisposeAsync()
    {
        if (Interlocked.Exchange(ref disposed, 1) != 0)
        {
            return;
        }

        await cancellationTokenSource.CancelAsync().ConfigureAwait(false);
        try
        {
            await Completion.ConfigureAwait(false);
        }
        catch (Exception)
        {
            // Disposal disconnects from the stream and must not mask the command outcome.
        }

        await responseStream.DisposeAsync().ConfigureAwait(false);
        response.Dispose();
        cancellationTokenSource.Dispose();
    }
}
