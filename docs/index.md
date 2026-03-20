# E2B

[![Nuget package](https://img.shields.io/nuget/vpre/E2B)](https://www.nuget.org/packages/E2B/)
[![dotnet](https://github.com/tryAGI/E2B/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/E2B/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/E2B)](https://github.com/tryAGI/E2B/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official E2B OpenAPI specification](https://raw.githubusercontent.com/E2B/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using E2B;

using var client = new E2BClient(apiKey);
```

<!-- EXAMPLES:START -->
### List Sandboxes
Basic example showing how to create a client and list running sandboxes.

```csharp
using var client = new E2BClient(apiKey);

// List all currently running sandboxes.
var sandboxes = await client.Sandboxes.GetSandboxesAsync();
```

### Templates
List available sandbox templates.

```csharp
using var client = new E2BClient(apiKey);

// List all sandbox templates available in your team.
var templates = await client.Templates.GetTemplatesAsync();
```

### Snapshots
List sandbox snapshots for resuming paused sandboxes.

```csharp
using var client = new E2BClient(apiKey);

// List all snapshots with pagination.
var snapshots = await client.Snapshots.GetSnapshotsAsync(
    limit: 10);
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/E2B/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/E2B/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).