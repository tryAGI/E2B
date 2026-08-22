namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [TestCategory("Live")]
    public async Task SandboxCommands_LiveBackgroundStreamAndReconnectLifecycle()
    {
        using var client = GetAuthenticatedClient();
        var sandbox = await client.Sandboxes.CreateSandboxesAsync(
            new NewSandbox
            {
                TemplateID = "base",
                Timeout = 300,
                Secure = true,
            });

        try
        {
            await using var initialHandle = await sandbox.Commands.StartAsync(
                "printf 'ready\\n'; read line; printf 'received:%s\\n' \"$line\"",
                new SandboxCommandOptions
                {
                    Stdin = true,
                    OutputBufferCapacity = 1,
                });

            await using (var initialOutput = initialHandle.ReadOutputAsync().GetAsyncEnumerator())
            {
                var initialStdout = string.Empty;
                while (!initialStdout.Contains("ready\n", StringComparison.Ordinal))
                {
                    (await initialOutput.MoveNextAsync()).Should().BeTrue();
                    if (initialOutput.Current.Source == SandboxCommandOutputSource.Stdout)
                    {
                        initialStdout += initialOutput.Current.Data;
                    }
                }
            }

            var processes = await sandbox.Commands.ListAsync();
            processes.Should().Contain(process => process.ProcessId == initialHandle.ProcessId);

            var processId = initialHandle.ProcessId;
            await initialHandle.DisconnectAsync();

            await using var reconnectedHandle = await sandbox.Commands.ConnectAsync(
                processId,
                new SandboxCommandConnectOptions { OutputBufferCapacity = 1 });
            var reconnectedOutputTask = ReadLiveOutputAsync(reconnectedHandle);

            await reconnectedHandle.SendStdinAsync("hello\n");
            await reconnectedHandle.CloseStdinAsync();

            var result = await reconnectedHandle.WaitAsync();
            var output = await reconnectedOutputTask;
            result.ExitCode.Should().Be(0);
            result.Stdout.Should().Contain("received:hello");
            output.Should().Contain(chunk =>
                chunk.Source == SandboxCommandOutputSource.Stdout &&
                chunk.Data.Contains("received:hello", StringComparison.Ordinal));
        }
        finally
        {
            await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
        }
    }

    private static async Task<IReadOnlyList<SandboxCommandOutputChunk>> ReadLiveOutputAsync(
        SandboxCommandHandle handle)
    {
        var output = new List<SandboxCommandOutputChunk>();
        await foreach (var chunk in handle.ReadOutputAsync())
        {
            output.Add(chunk);
        }

        return output;
    }
}
