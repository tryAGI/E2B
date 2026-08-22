/*
order: 15
title: Run a Sandbox Command
slug: run-sandbox-command

Create a sandbox and run a Bash command inside it.
*/

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RunSandboxCommand()
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
            //// Stream output while a foreground command runs.
            var result = await sandbox.Commands.RunAsync(
                "echo 'Hello from E2B!'",
                new SandboxCommandOptions
                {
                    OnStdout = Console.Write,
                    OnStderr = Console.Error.Write,
                });

            result.Stdout.Trim().Should().Be("Hello from E2B!");

            //// Start a background command with an open standard-input stream.
            await using var handle = await sandbox.Commands.StartAsync(
                "read line; echo \"Received: $line\"",
                new SandboxCommandOptions
                {
                    Stdin = true,
                    OnStdout = Console.Write,
                });

            Console.WriteLine($"Background process ID: {handle.ProcessId}");
            await handle.SendStdinAsync("hello\n");
            await handle.CloseStdinAsync();

            var backgroundResult = await handle.WaitAsync();
            backgroundResult.Stdout.Trim().Should().Be("Received: hello");
        }
        finally
        {
            await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
        }
    }
}
