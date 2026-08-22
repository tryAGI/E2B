using System.Buffers.Binary;
using System.Net;
using System.Text;
using System.Text.Json;

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SandboxCommands_RunAsync_UsesEnvdConnectProtocol()
    {
        var handler = new RecordingHandler(CreateCommandResponse(
            MessageEnvelope("{\"event\":{\"start\":{\"pid\":42}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"SGVsbG8g\"}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"8J+MjQ==\",\"stderr\":\"d2FybmluZwo=\"}}}"),
            MessageEnvelope("{\"event\":{\"end\":{\"exitCode\":0,\"exited\":true,\"status\":\"exited\"}}}"),
            EndStreamEnvelope("{}")));
        using var httpClient = new HttpClient(handler);
        var sandbox = CreateSandbox(envdVersion: "0.6.4");
        var commands = new SandboxCommandsClient(sandbox, httpClient, new Uri("https://sandbox.example"));

        var result = await commands.RunAsync(
            "printf 'Hello 🌍'",
            new SandboxCommandOptions
            {
                WorkingDirectory = "/workspace",
                EnvironmentVariables = new Dictionary<string, string> { ["GREETING"] = "Hello" },
                User = "root",
                Timeout = TimeSpan.FromSeconds(12),
            });

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Be("Hello 🌍");
        result.Stderr.Should().Be("warning\n");
        handler.RequestUri.Should().Be(new Uri("https://sandbox.example/process.Process/Start"));
        handler.Headers["Connect-Protocol-Version"].Should().Be("1");
        handler.Headers["E2b-Sandbox-Id"].Should().Be("sandbox-id");
        handler.Headers["E2b-Sandbox-Port"].Should().Be("49983");
        handler.Headers["X-Access-Token"].Should().Be("envd-token");
        handler.Headers["Connect-Timeout-Ms"].Should().Be("12000");
        handler.Headers["Authorization"].Should().Be("Basic cm9vdDo=");
        handler.ContentType.Should().Be("application/connect+json");

        using var requestDocument = JsonDocument.Parse(ReadEnvelopePayload(handler.RequestBody));
        var root = requestDocument.RootElement;
        root.GetProperty("process").GetProperty("cmd").GetString().Should().Be("/bin/bash");
        root.GetProperty("process").GetProperty("args")[2].GetString().Should().Be("printf 'Hello 🌍'");
        root.GetProperty("process").GetProperty("cwd").GetString().Should().Be("/workspace");
        root.GetProperty("process").GetProperty("envs").GetProperty("GREETING").GetString().Should().Be("Hello");
        root.GetProperty("stdin").GetBoolean().Should().BeFalse();
    }

    [TestMethod]
    public async Task SandboxCommands_RunAsync_ThrowsResultForNonZeroExit()
    {
        var handler = new RecordingHandler(CreateCommandResponse(
            MessageEnvelope("{\"event\":{\"start\":{\"pid\":7}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stderr\":\"Ym9vbQ==\"}}}"),
            MessageEnvelope("{\"event\":{\"end\":{\"exitCode\":9,\"exited\":true,\"status\":\"exited\",\"error\":\"failed\"}}}"),
            EndStreamEnvelope("{}")));
        using var httpClient = new HttpClient(handler);
        var commands = new SandboxCommandsClient(
            CreateSandbox(envdVersion: "0.3.0"),
            httpClient,
            new Uri("https://sandbox.example"));

        var action = () => commands.RunAsync("exit 9");

        var exception = await action.Should().ThrowAsync<SandboxCommandExitException>();
        exception.Which.Result.ExitCode.Should().Be(9);
        exception.Which.Result.Stderr.Should().Be("boom");
        exception.Which.Result.Error.Should().Be("failed");
        handler.Headers["Authorization"].Should().Be("Basic dXNlcjo=");
    }

    private static Sandbox CreateSandbox(string envdVersion)
    {
        return new Sandbox
        {
            TemplateID = "base",
            SandboxID = "sandbox-id",
            ClientID = "client-id",
            EnvdVersion = envdVersion,
            EnvdAccessToken = "envd-token",
            Domain = "e2b.app",
        };
    }

    private static HttpResponseMessage CreateCommandResponse(params byte[][] envelopes)
    {
        var content = envelopes.SelectMany(static envelope => envelope).ToArray();
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(content),
        };
        response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/connect+json");
        return response;
    }

    private static byte[] MessageEnvelope(string json) => Envelope(0, json);

    private static byte[] EndStreamEnvelope(string json) => Envelope(0b0000_0010, json);

    private static byte[] Envelope(byte flags, string json)
    {
        var payload = Encoding.UTF8.GetBytes(json);
        var envelope = new byte[5 + payload.Length];
        envelope[0] = flags;
        BinaryPrimitives.WriteUInt32BigEndian(envelope.AsSpan(1, 4), checked((uint)payload.Length));
        payload.CopyTo(envelope, 5);
        return envelope;
    }

    private static ReadOnlyMemory<byte> ReadEnvelopePayload(byte[] envelope)
    {
        envelope[0].Should().Be(0);
        var length = BinaryPrimitives.ReadUInt32BigEndian(envelope.AsSpan(1, 4));
        length.Should().Be((uint)(envelope.Length - 5));
        return envelope.AsMemory(5, checked((int)length));
    }

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }
        public Dictionary<string, string> Headers { get; } = new(StringComparer.OrdinalIgnoreCase);
        public byte[] RequestBody { get; private set; } = [];
        public string? ContentType { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            foreach (var (name, values) in request.Headers)
            {
                Headers[name] = string.Join(",", values);
            }

            ContentType = request.Content?.Headers.ContentType?.MediaType;
            RequestBody = request.Content is null
                ? []
                : await request.Content.ReadAsByteArrayAsync(cancellationToken);
            return response;
        }
    }
}
