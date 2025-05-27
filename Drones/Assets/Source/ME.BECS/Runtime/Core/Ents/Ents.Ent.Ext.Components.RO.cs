namespace ME.BECS {

    using INLINE = System.Runtime.CompilerServices.MethodImplAttribute;

    public static partial class EntExt {

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static bool IsEnabled<T>(in this EntRO ent) where T : unmanaged, IComponent => ent.ent.IsEnabled<T>();

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static bool Has<T>(in this EntRO ent, bool checkEnabled = true) where T : unmanaged, IComponent => ent.ent.Has<T>(checkEnabled);

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static ref readonly T Read<T>(in this EntRO ent) where T : unmanaged, IComponent => ref ent.ent.Read<T>();

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static ref readonly T TryRead<T>(in this EntRO ent, out bool exists) where T : unmanaged, IComponent => ref ent.ent.TryRead<T>(out exists);

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static bool TryRead<T>(in this EntRO ent, out T component) where T : unmanaged, IComponent => ent.ent.TryRead(out component);

        [INLINE(256)]
        [SafetyCheck(RefOp.ReadOnly)] public static bool HasTag<T>(in this EntRO ent, bool value) where T : unmanaged, IComponent => ent.ent.HasTag<T>(value);

    }

}