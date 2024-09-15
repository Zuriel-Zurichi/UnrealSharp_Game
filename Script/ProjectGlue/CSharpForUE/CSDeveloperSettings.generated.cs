using UnrealSharp.DeveloperSettings;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.CSharpForUE;

[UClass, GeneratedType("CSDeveloperSettings", "UnrealSharp.CSharpForUE.CSDeveloperSettings")]
public partial class UCSDeveloperSettings : UnrealSharp.DeveloperSettings.UDeveloperSettings
{
    static UCSDeveloperSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CSDeveloperSettings");
        bCrashOnException_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCrashOnException");
        AutomaticHotReloading_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AutomaticHotReloading");
    }
    
    static int bCrashOnException_Offset;
    
    /// <summary>
    /// Should we exit PIE when an exception is thrown in C#?
    /// </summary>
    public bool CrashOnException
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bCrashOnException_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bCrashOnException_Offset), 0, value);
        }
    }
    
    
    static int AutomaticHotReloading_Offset;
    
    /// <summary>
    /// Whether Hot Reload should automatically start on script save, gaining Editor focus, or not at all.
    /// </summary>
    public UnrealSharp.CSharpForUE.EAutomaticHotReloadMethod AutomaticHotReloading
    {
        get
        {
            return BlittableMarshaller<UnrealSharp.CSharpForUE.EAutomaticHotReloadMethod>.FromNative(IntPtr.Add(NativeObject, AutomaticHotReloading_Offset), 0);
        }
        set
        {
            BlittableMarshaller<UnrealSharp.CSharpForUE.EAutomaticHotReloadMethod>.ToNative(IntPtr.Add(NativeObject, AutomaticHotReloading_Offset), 0, value);
        }
    }
    
    
}