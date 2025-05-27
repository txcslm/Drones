using scg = System.Collections.Generic;

namespace ME.BECS {
    
    using ME.BECS.Internal;
    using Unity.Burst;

    public static class WorldStaticCallbacksTypes {

        public static uint counter;

    }
    
    public static class WorldStaticCallbacksTypes<T> where T : unmanaged {

        public static uint id;
        public static readonly scg::Dictionary<uint, WorldStaticCallbacks.CallbackDelegate<T>> callbacks = new scg::Dictionary<uint, WorldStaticCallbacks.CallbackDelegate<T>>();

    }

    public class WorldStaticConfigComponentCallbacksTypes {

        public static readonly SharedStatic<Array<FunctionPointer<WorldStaticCallbacks.ConfigComponentCallbackDelegate>>> callbacks = SharedStatic<Array<FunctionPointer<WorldStaticCallbacks.ConfigComponentCallbackDelegate>>>.GetOrCreatePartiallyUnsafeWithHashCode<WorldStaticConfigComponentCallbacksTypes>(TAlign<Array<FunctionPointer<WorldStaticCallbacks.ConfigComponentCallbackDelegate>>>.align, 20001);

    }

    public class WorldStaticCopyFromComponentCallbacksTypes {

        public static readonly SharedStatic<Array<FunctionPointer<WorldStaticCallbacks.CopyFromComponentCallbackDelegate>>> callbacks = SharedStatic<Array<FunctionPointer<WorldStaticCallbacks.CopyFromComponentCallbackDelegate>>>.GetOrCreatePartiallyUnsafeWithHashCode<WorldStaticCopyFromComponentCallbacksTypes>(TAlign<Array<FunctionPointer<WorldStaticCallbacks.CopyFromComponentCallbackDelegate>>>.align, 20002);

    }

    public static class WorldStaticCallbacks {

        private static scg::HashSet<System.Collections.IDictionary> allDics = new scg::HashSet<System.Collections.IDictionary>();
        
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize() {
            
            CustomModules.RegisterResetPass(Reset);
            
        }
        
        public static void Reset() {

            foreach (var dic in allDics) {
                dic.Clear();
            }
            
        }

        public delegate void CallbackDelegate<T>(ref T data) where T : unmanaged;
        public unsafe delegate void ConfigComponentCallbackDelegate(in UnsafeEntityConfig config, void* componentPtr, in Ent ent);
        public unsafe delegate void CopyFromComponentCallbackDelegate(void* componentPtr, in Ent ent);

        public static void RegisterCopyFromComponentCallback<T>(CopyFromComponentCallbackDelegate callback) where T : unmanaged, IComponentBase {

            var maxTypeId = StaticTypes.counter;
            WorldStaticCopyFromComponentCallbacksTypes.callbacks.Data.Resize(maxTypeId + 1u);
            WorldStaticCopyFromComponentCallbacksTypes.callbacks.Data.Get(StaticTypes<T>.typeId) = BurstCompiler.CompileFunctionPointer(callback);

        }

        public static unsafe void RaiseCopyFromComponentCallback(uint typeId, void* component, in Ent ent) {

            if (WorldStaticCopyFromComponentCallbacksTypes.callbacks.Data.Length == 0u) return;
            var callback = WorldStaticCopyFromComponentCallbacksTypes.callbacks.Data.Get(typeId);
            if (callback.IsCreated == true) callback.Invoke(component, in ent);

        }

        public static void RegisterConfigComponentCallback<T>(ConfigComponentCallbackDelegate callback) where T : unmanaged, IComponentBase {

            var maxTypeId = StaticTypes.counter;
            WorldStaticConfigComponentCallbacksTypes.callbacks.Data.Resize(maxTypeId + 1u);
            WorldStaticConfigComponentCallbacksTypes.callbacks.Data.Get(StaticTypes<T>.typeId) = BurstCompiler.CompileFunctionPointer(callback);

        }
        
        public static unsafe void RaiseConfigComponentCallback<T>(in UnsafeEntityConfig config, void* component, in Ent ent) where T : unmanaged, IComponentBase {

            if (WorldStaticConfigComponentCallbacksTypes.callbacks.Data.Length == 0u) return;
            var callback = WorldStaticConfigComponentCallbacksTypes.callbacks.Data.Get(StaticTypes<T>.typeId);
            if (callback.IsCreated == true) callback.Invoke(in config, component, in ent);

        }

        public static void RaiseCallback<T>(ref T data, uint subId = 0u) where T : unmanaged {

            if (WorldStaticCallbacksTypes<T>.id == 0u) {
                WorldStaticCallbacksTypes<T>.id = ++WorldStaticCallbacksTypes.counter;
            }

            if (WorldStaticCallbacksTypes<T>.callbacks.TryGetValue(subId, out var callbackDelegate) == true) {
                
                callbackDelegate.Invoke(ref data);
                
            }
            
        }

        public static void RegisterCallback<T>(CallbackDelegate<T> callback, uint subId = 0u) where T : unmanaged {
            
            if (WorldStaticCallbacksTypes<T>.id == 0u) {
                WorldStaticCallbacksTypes<T>.id = ++WorldStaticCallbacksTypes.counter;
            }
            
            allDics.Add(WorldStaticCallbacksTypes<T>.callbacks);
            if (WorldStaticCallbacksTypes<T>.callbacks.ContainsKey(subId) == false) {
                
                WorldStaticCallbacksTypes<T>.callbacks.Add(subId, callback);
                
            } else {
                
                WorldStaticCallbacksTypes<T>.callbacks[subId] += callback;

            }
            
        }
        
        public static void UnregisterCallback<T>(CallbackDelegate<T> callback, uint subId = 0u) where T : unmanaged {
            
            if (WorldStaticCallbacksTypes<T>.callbacks.TryGetValue(subId, out var callbacks) == true) {

                callbacks -= callback;
                WorldStaticCallbacksTypes<T>.callbacks[subId] = callbacks;

            }
            
        }

    }

}