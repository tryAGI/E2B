# Snapshots

List sandbox snapshots for resuming paused sandboxes.

This example assumes `using E2B;` is in scope and `apiKey` contains your E2B API key.

```csharp
using var client = new E2BClient(apiKey);

// List all snapshots with pagination.
var snapshots = await client.Snapshots.GetSnapshotsAsync(
    limit: 10);
```