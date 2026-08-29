[![](https://img.shields.io/nuget/v/soenneker.enums.initializationmodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.initializationmodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.initializationmodes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.initializationmodes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.initializationmodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.initializationmodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.initializationmodes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.initializationmodes/actions/workflows/codeql.yml)

# Soenneker.Enums.InitializationModes

Identifies whether initialization is synchronous or asynchronous and whether it accepts a key or cancellation token.

## Install

```bash
dotnet add package Soenneker.Enums.InitializationModes
```

## What you get

- `InitializationMode` — Identifies whether initialization is synchronous or asynchronous and whether it accepts a key or cancellation token.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `InitializationMode.AsyncKey` | Asynchronous initialization using a key. | Asynchronous initialization using a key. |
| `InitializationMode.AsyncKeyToken` | Asynchronous initialization using a key and a cancellation token. | Asynchronous initialization using a key and a cancellation token. |
| `InitializationMode.Async` | Asynchronous initialization without a key. | Asynchronous initialization without a key. |
| `InitializationMode.Sync` | Synchronous initialization without a key. | Synchronous initialization without a key. |
| `InitializationMode.SyncKey` | Synchronous initialization using a key. | Synchronous initialization using a key. |
| `InitializationMode.SyncKeyToken` | Synchronous initialization using a key and a cancellation token. | Synchronous initialization using a key and a cancellation token. |
