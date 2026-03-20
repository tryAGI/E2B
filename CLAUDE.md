# CLAUDE.md — E2B SDK

## Overview

Auto-generated C# SDK for [E2B](https://e2b.dev/) — secure cloud sandboxes for AI agents.
Covers sandbox lifecycle, templates, volumes, snapshots, API keys, and access tokens.

## Build & Test

```bash
dotnet build E2B.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with E2B API key:

```csharp
var client = new E2BClient(apiKey); // E2B_API_KEY env var
```

## Key Files

- `src/libs/E2B/generate.sh` — Regeneration script (downloads spec, converts apiKey→bearer, runs autosdk)
- `src/libs/E2B/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/e2b-dev/E2B/main/spec/openapi.yml`
- Spec defines 5 security schemes (ApiKeyAuth, Supabase, Admin, AccessToken); `generate.sh` converts ApiKeyAuth to bearer
- Most endpoints accept ApiKeyAuth; Supabase/Admin schemes are for internal dashboard use
