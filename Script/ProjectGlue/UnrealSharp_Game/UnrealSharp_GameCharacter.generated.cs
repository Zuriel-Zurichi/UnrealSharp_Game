using UnrealSharp.Engine;
using UnrealSharp.EnhancedInput;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.UnrealSharp_Game;

[UClass, GeneratedType("UnrealSharp_GameCharacter", "UnrealSharp.UnrealSharp_Game.UnrealSharp_GameCharacter")]
public partial class AUnrealSharp_GameCharacter : UnrealSharp.Engine.ACharacter
{
    static AUnrealSharp_GameCharacter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("UnrealSharp_GameCharacter");
        CameraBoom_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CameraBoom");
        FollowCamera_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FollowCamera");
        DefaultMappingContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultMappingContext");
        JumpAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "JumpAction");
        MoveAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MoveAction");
        LookAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAction");
    }
    
    static int CameraBoom_Offset;
    
    /// <summary>
    /// Camera boom positioning the camera behind the character
    /// </summary>
    public UnrealSharp.Engine.USpringArmComponent CameraBoom
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.USpringArmComponent>.FromNative(IntPtr.Add(NativeObject, CameraBoom_Offset), 0);
        }
    }
    
    
    static int FollowCamera_Offset;
    
    /// <summary>
    /// Follow camera
    /// </summary>
    public UnrealSharp.Engine.UCameraComponent FollowCamera
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.Engine.UCameraComponent>.FromNative(IntPtr.Add(NativeObject, FollowCamera_Offset), 0);
        }
    }
    
    
    static int DefaultMappingContext_Offset;
    
    /// <summary>
    /// MappingContext
    /// </summary>
    public UnrealSharp.EnhancedInput.UInputMappingContext DefaultMappingContext
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.EnhancedInput.UInputMappingContext>.FromNative(IntPtr.Add(NativeObject, DefaultMappingContext_Offset), 0);
        }
    }
    
    
    static int JumpAction_Offset;
    
    /// <summary>
    /// Jump Input Action
    /// </summary>
    public UnrealSharp.EnhancedInput.UInputAction JumpAction
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.EnhancedInput.UInputAction>.FromNative(IntPtr.Add(NativeObject, JumpAction_Offset), 0);
        }
    }
    
    
    static int MoveAction_Offset;
    
    /// <summary>
    /// Move Input Action
    /// </summary>
    public UnrealSharp.EnhancedInput.UInputAction MoveAction
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.EnhancedInput.UInputAction>.FromNative(IntPtr.Add(NativeObject, MoveAction_Offset), 0);
        }
    }
    
    
    static int LookAction_Offset;
    
    /// <summary>
    /// Look Input Action
    /// </summary>
    public UnrealSharp.EnhancedInput.UInputAction LookAction
    {
        get
        {
            return ObjectMarshaller<UnrealSharp.EnhancedInput.UInputAction>.FromNative(IntPtr.Add(NativeObject, LookAction_Offset), 0);
        }
    }
    
    
}