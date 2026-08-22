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
            //// Run a command through the sandbox runtime service.
            var result = await sandbox.Commands.RunAsync("echo 'Hello from E2B!'");

            Console.WriteLine(result.Stdout);
            result.Stdout.Trim().Should().Be("Hello from E2B!");
        }
        finally
        {
            await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
        }
    }
}
