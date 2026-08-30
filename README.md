[![](https://img.shields.io/nuget/v/soenneker.enums.initializationmodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.initializationmodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.initializationmodes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.initializationmodes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.initializationmodes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.initializationmodes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.initializationmodes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.initializationmodes/actions/workflows/codeql.yml)

# Soenneker.Enums.InitializationModes

A string-backed enum-value type for selecting an initializer signature by execution style and accepted arguments.

## Install

```bash
dotnet add package Soenneker.Enums.InitializationModes
```

## Usage

```csharp
using Soenneker.Enums.InitializationModes;

InitializationMode mode = InitializationMode.AsyncKeyToken;
string wireValue = mode.Value; // "AsyncKeyToken"

if (InitializationMode.TryFromValue(input, out InitializationMode? parsed))
{
    // Select the initializer signature represented by parsed
}
```

| Value | Async | Key | Cancellation token |
| --- | --- | --- | --- |
| `Async` | Yes | No | No |
| `AsyncKey` | Yes | Yes | No |
| `AsyncKeyToken` | Yes | Yes | Yes |
| `Sync` | No | No | No |
| `SyncKey` | No | Yes | No |
| `SyncKeyToken` | No | Yes | Yes |

`System.Text.Json` serializes the type as the shown string value. `FromValue` throws for unknown input; use `TryFromValue` at configuration or request boundaries. `FromName` and `TryFromName` are also generated.

This package describes an initialization shape; it does not invoke an initializer, store a key, create a cancellation token, or enforce cancellation. The consuming component defines the key type and the exact semantics of each mode.
