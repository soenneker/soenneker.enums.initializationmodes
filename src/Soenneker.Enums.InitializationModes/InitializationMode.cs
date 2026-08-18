using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.InitializationModes;

/// <summary>
/// Identifies whether initialization is synchronous or asynchronous and whether it accepts a key or cancellation token.
/// </summary>
[EnumValue<string>]
public partial class InitializationMode
{
    /// <summary>
    /// Asynchronous initialization using a key.
    /// </summary>
    public static readonly InitializationMode AsyncKey = new(nameof(AsyncKey));

    /// <summary>
    /// Asynchronous initialization using a key and a cancellation token.
    /// </summary>
    public static readonly InitializationMode AsyncKeyToken = new(nameof(AsyncKeyToken));

    /// <summary>
    /// Asynchronous initialization without a key.
    /// </summary>
    public static readonly InitializationMode Async = new(nameof(Async));

    /// <summary>
    /// Synchronous initialization without a key.
    /// </summary>
    public static readonly InitializationMode Sync = new(nameof(Sync));

    /// <summary>
    /// Synchronous initialization using a key.
    /// </summary>
    public static readonly InitializationMode SyncKey = new(nameof(SyncKey));

    /// <summary>
    /// Synchronous initialization using a key and a cancellation token.
    /// </summary>
    public static readonly InitializationMode SyncKeyToken = new(nameof(SyncKeyToken));
}
