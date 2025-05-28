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
    public static unsafe class GraphGraphDrones_Logic_FeatureGraphInitialize {
        public static NativeArray<System.IntPtr> graphNodes1002_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1002_SystemsCodeGenerator() {
            // Drones-Logic-FeatureGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1002_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(5, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = new ME.BECS.DestroyWithLifetimeSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(1002, item);
                graphNodes1002_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = new ME.BECS.Transforms.TransformWorldMatrixUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(1002, item);
                graphNodes1002_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = new ME.BECS.DestroyWithTicksSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(1002, item);
                graphNodes1002_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<Source.Drones.Code.Systems.SpawnResourceSystem>.sizeInt, TAlign<Source.Drones.Code.Systems.SpawnResourceSystem>.alignInt);
                *(Source.Drones.Code.Systems.SpawnResourceSystem*)item = new Source.Drones.Code.Systems.SpawnResourceSystem {
                    ResourceView = new ME.BECS.Views.View {
                        viewSource = new ME.BECS.Views.ViewSource {
                            providerId = 1,
                            prefabId = 223,
                        }
                        ,
                    }
                    ,
                    ResourceConfig = new ME.BECS.Config {
                        sourceId = 211,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<Source.Drones.Code.Systems.SpawnResourceSystem>(1002, item);
                graphNodes1002_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<Source.Drones.Code.Systems.LevelInitializeSystem>.sizeInt, TAlign<Source.Drones.Code.Systems.LevelInitializeSystem>.alignInt);
                *(Source.Drones.Code.Systems.LevelInitializeSystem*)item = new Source.Drones.Code.Systems.LevelInitializeSystem {
                    SpawnerConfig = new ME.BECS.Config {
                        sourceId = 24,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<Source.Drones.Code.Systems.LevelInitializeSystem>(1002, item);
                graphNodes1002_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1002_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1002_SystemsCodeGenerator[index];
        }
    }
     
}
