# Run a Sandbox Command

Create a sandbox and run a Bash command inside it.

This example assumes `using E2B;` is in scope and `apiKey` contains your E2B API key.

```csharp
using var client = new E2BClient(apiKey);
var sandbox = await client.Sandboxes.CreateSandboxesAsync(
    new NewSandbox
    {
        TemplateID = "base",
        Timeout = 300,
        Secure = true,
    });

try
{
    // Stream output while a foreground command runs.
    var result = await sandbox.Commands.RunAsync(
        "echo 'Hello from E2B!'",
        new SandboxCommandOptions
        {
            OnStdout = Console.Write,
            OnStderr = Console.Error.Write,
        });

    // Start a background command with an open standard-input stream.
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
}
finally
{
    await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
}
```