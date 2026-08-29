# E2B

[![Nuget package](https://img.shields.io/nuget/vpre/E2B)](https://www.nuget.org/packages/E2B/)
[![dotnet](https://github.com/tryAGI/E2B/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/E2B/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/E2B)](https://github.com/tryAGI/E2B/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official E2B OpenAPI specification](https://raw.githubusercontent.com/e2b-dev/E2B/main/spec/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
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
var sandboxes = await client.Sandboxes.GetSandboxes2Async();
```

### Run a Sandbox Command
Create a sandbox and run a Bash command inside it.

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
            OutputBufferCapacity = 8,
        });

    Console.WriteLine($"Background process ID: {handle.ProcessId}");
    var process = (await sandbox.Commands.ListAsync())
        .Single(process => process.ProcessId == handle.ProcessId);
    Console.WriteLine($"Running command: {process.Command}");

    // Disconnect without stopping the process, then reconnect by PID.
    await handle.DisconnectAsync();
    await using var reconnectedHandle = await sandbox.Commands.ConnectAsync(
        handle.ProcessId,
        new SandboxCommandConnectOptions { OutputBufferCapacity = 8 });
    await reconnectedHandle.SendStdinAsync("hello\n");
    await reconnectedHandle.CloseStdinAsync();

    // Consume stdout and stderr asynchronously in arrival order.
    await foreach (var chunk in reconnectedHandle.ReadOutputAsync())
    {
        Console.Write(chunk.Data);
    }

    var backgroundResult = await reconnectedHandle.WaitAsync();
}
finally
{
    await client.Sandboxes.DeleteSandboxesBySandboxIDAsync(sandbox.SandboxID);
}
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

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/E2B/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/E2B/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
