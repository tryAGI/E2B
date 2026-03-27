# Authentication

The E2B SDK uses Bearer token authentication. You can obtain an API key from your [E2B dashboard](https://e2b.dev/dashboard).

## Basic Usage

```csharp
using E2B;

var client = new E2BClient(apiKey: Environment.GetEnvironmentVariable("E2B_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `E2B_API_KEY` | Your E2B API key |
