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
    public static unsafe class GraphGraphDrones_VisualFeaturesGraphInitialize {
        public static NativeArray<System.IntPtr> graphNodes1001_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1001_SystemsCodeGenerator() {
            // Drones-VisualFeaturesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1001_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(3, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = new ME.BECS.DestroyWithLifetimeSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = new ME.BECS.Transforms.TransformWorldMatrixUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = new ME.BECS.DestroyWithTicksSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1001_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1001_SystemsCodeGenerator[index];
        }
    }
     
}
