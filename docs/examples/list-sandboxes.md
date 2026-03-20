# List Sandboxes

Basic example showing how to create a client and list running sandboxes.

This example assumes `using E2B;` is in scope and `apiKey` contains your E2B API key.

```csharp
using var client = new E2BClient(apiKey);

// List all currently running sandboxes.
var sandboxes = await client.Sandboxes.GetSandboxesAsync();
```