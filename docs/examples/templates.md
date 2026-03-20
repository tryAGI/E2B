# Templates

List available sandbox templates.

This example assumes `using E2B;` is in scope and `apiKey` contains your E2B API key.

```csharp
using var client = new E2BClient(apiKey);

// List all sandbox templates available in your team.
var templates = await client.Templates.GetTemplatesAsync();
```