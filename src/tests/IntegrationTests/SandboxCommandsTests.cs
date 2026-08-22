using System.Buffers.Binary;
using System.Net;
using System.Text;
using System.Text.Json;

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SandboxCommands_RunAsync_StreamsDecodedOutput()
    {
        var handler = new RecordingHandler(CreateCommandResponse(
            MessageEnvelope("{\"event\":{\"start\":{\"pid\":42}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"SGVsbG8g\"}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"8J8=\"}}}"),
            MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"jI0=\",\"stderr\":\"d2FybmluZwo=\"}}}"),
            MessageEnvelope("{\"event\":{\"end\":{\"exitCode\":0,\"exited\":true,\"status\":\"exited\"}}}"),
            EndStreamEnvelope("{}")));
        using var httpClient = new HttpClient(handler);
        var sandbox = CreateSandbox(envdVersion: "0.6.4");
        var commands = new SandboxCommandsClient(sandbox, httpClient, new Uri("https://sandbox.example"));
        var stdoutChunks = new List<string>();
        var stderrChunks = new List<string>();

        var result = await commands.RunAsync(
            "printf 'Hello 🌍'",
            new SandboxCommandOptions
            {
                WorkingDirectory = "/workspace",
                EnvironmentVariables = new Dictionary<string, string> { ["GREETING"] = "Hello" },
                User = "root",
                Stdin = true,
                OnStdout = stdoutChunks.Add,
                OnStderr = stderrChunks.Add,
                Timeout = TimeSpan.FromSeconds(12),
            });

        result.ExitCode.Should().Be(0);
        result.Stdout.Should().Be("Hello 🌍");
        result.Stderr.Should().Be("warning\n");
        string.Concat(stdoutChunks).Should().Be(result.Stdout);
        string.Concat(stderrChunks).Should().Be(result.Stderr);
        stdoutChunks.Should().NotContain(string.Empty);

        var request = handler.Requests.Should().ContainSingle().Which;
        request.RequestUri.Should().Be(new Uri("https://sandbox.example/process.Process/Start"));
        request.Headers["Connect-Protocol-Version"].Should().Be("1");
        request.Headers["E2b-Sandbox-Id"].Should().Be("sandbox-id");
        request.Headers["E2b-Sandbox-Port"].Should().Be("49983");
        request.Headers["X-Access-Token"].Should().Be("envd-token");
        request.Headers["Connect-Timeout-Ms"].Should().Be("12000");
        request.Headers["Authorization"].Should().Be("Basic cm9vdDo=");
        request.ContentType.Should().Be("application/connect+json");

        using var requestDocument = JsonDocument.Parse(ReadEnvelopePayload(request.RequestBody));
        var root = requestDocument.RootElement;
        root.GetProperty("process").GetProperty("cmd").GetString().Should().Be("/bin/bash");
        root.GetProperty("process").GetProperty("args")[2].GetString().Should().Be("printf 'Hello 🌍'");
        root.GetProperty("process").GetProperty("cwd").GetString().Should().Be("/workspace");
        root.GetProperty("process").GetProperty("envs").GetProperty("GREETING").GetString().Should().Be("Hello");
        root.GetProperty("stdin").GetBoolean().Should().BeTrue();
    }

    [TestMethod]
    public async Task SandboxCommands_StartAsync_ControlsBackgroundProcess()
    {
        var handler = new RecordingHandler(
            CreateCommandResponse(
                MessageEnvelope("{\"event\":{\"start\":{\"pid\":73}}}"),
                MessageEnvelope("{\"event\":{\"data\":{\"stdout\":\"cmVhZHkK\"}}}"),
                MessageEnvelope("{\"event\":{\"end\":{\"exitCode\":0,\"exited\":true,\"status\":\"exited\"}}}"),
                EndStreamEnvelope("{}")),
            CreateUnaryResponse(),
            CreateUnaryResponse(),
            CreateUnaryResponse());
        using var httpClient = new HttpClient(handler);
        var commands = new SandboxCommandsClient(
            CreateSandbox(envdVersion: "0.6.4"),
            httpClient,
            new Uri("https://sandbox.example"));

        await using var handle = await commands.StartAsync(
            "read line; echo ready",
            new SandboxCommandOptions { Stdin = true });

        handle.ProcessId.Should().Be(73);
        handle.Stdout.Should().Be("ready\n");
        await handle.SendStdinAsync("hello\n");
        await handle.CloseStdinAsync();
        (await handle.KillAsync()).Should().BeTrue();
        var result = await handle.WaitAsync();
        result.Stdout.Should().Be("ready\n");
        handle.ExitCode.Should().Be(0);

        handler.Requests.Select(static request => request.RequestUri.AbsolutePath).Should().Equal(
            "/process.Process/Start",
            "/process.Process/SendInput",
            "/process.Process/CloseStdin",
            "/process.Process/SendSignal");

        using var stdinDocument = JsonDocument.Parse(handler.Requests[1].RequestBody);
        stdinDocument.RootElement.GetProperty("process").GetProperty("pid").GetInt32().Should().Be(73);
        stdinDocument.RootElement.GetProperty("input").GetProperty("stdin").GetBytesFromBase64()
            .Should().Equal(Encoding.UTF8.GetBytes("hello\n"));

        using var closeDocument = JsonDocument.Parse(handler.Requests[2].RequestBody);
        closeDocument.RootElement.GetProperty("process").GetProperty("pid").GetInt32().Should().Be(73);

        using var killDocument = JsonDocument.Parse(handler.Requests[3].RequestBody);
        killDocument.RootElement.GetProperty("process").GetProperty("pid").GetInt32().Should().Be(73);
        killDocument.RootElement.GetProperty("signal").GetString().Should().Be("SIGNAL_SIGKILL");
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
        handler.Requests.Single().Headers["Authorization"].Should().Be("Basic dXNlcjo=");
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

    private static HttpResponseMessage CreateUnaryResponse()
    {
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("{}", Encoding.UTF8, "application/json"),
        };
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

    private sealed record RecordedRequest(
        Uri RequestUri,
        Dictionary<string, string> Headers,
        byte[] RequestBody,
        string? ContentType);

    private sealed class RecordingHandler(params HttpResponseMessage[] responses) : HttpMessageHandler
    {
        private readonly Queue<HttpResponseMessage> responses = new(responses);

        public List<RecordedRequest> Requests { get; } = [];

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var (name, values) in request.Headers)
            {
                headers[name] = string.Join(",", values);
            }

            Requests.Add(new RecordedRequest(
                request.RequestUri!,
                headers,
                request.Content is null ? [] : await request.Content.ReadAsByteArrayAsync(cancellationToken),
                request.Content?.Headers.ContentType?.MediaType));
            return responses.Dequeue();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (var response in responses)
                {
                    response.Dispose();
                }
            }

            base.Dispose(disposing);
        }
    }
}
