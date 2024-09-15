using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.CSharpForUE;

[UEnum, GeneratedType("EAutomaticHotReloadMethod", "UnrealSharp.CSharpForUE.EAutomaticHotReloadMethod")]
public enum EAutomaticHotReloadMethod : byte
{
    /// <summary>
    /// Automatically Hot Reloads when script changes are saved
    /// </summary>
    OnScriptSave = 0,
    /// <summary>
    /// Wait for the Editor to gain focus before Hot Reloading
    /// </summary>
    OnEditorFocus = 1,
    /// <summary>
    /// Will not Hot Reload automatically
    /// </summary>
    Off = 2,
}