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
    // Run a command through the sandbox runtime service.
    var result = await sandbox.Commands.RunAsync("echo 'Hello from E2B!'");

    Console.WriteLine(result.Stdout);
}
finally
{
    await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
}
```