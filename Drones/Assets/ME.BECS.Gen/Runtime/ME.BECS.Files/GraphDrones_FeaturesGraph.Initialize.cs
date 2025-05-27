namespace ME.BECS {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using s = System.Collections.Generic;
    public static unsafe class GraphGraphDrones_FeaturesGraphInitialize {
        public static NativeArray<System.IntPtr> graphNodes1001_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1001_SystemsCodeGenerator() {
            // Drones-FeaturesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1001_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(0, allocator);
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1001_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1001_SystemsCodeGenerator[index];
        }
    }
     
}
