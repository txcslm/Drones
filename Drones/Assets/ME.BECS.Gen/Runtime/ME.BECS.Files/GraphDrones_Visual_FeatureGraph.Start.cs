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
    public static unsafe class GraphGraphDrones_Visual_FeatureGraphStart {
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnStart_0_1001_SystemsCodeGenerator_Burst(uint dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, safe_ptr<Unity.Jobs.JobHandle> dependencies
        ) {
            SystemContext systemContext = default;
            {
                systemContext = SystemContext.Create(dt, in world, dependencies[5]);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)systems[1])->OnStart(ref systemContext);
                dependencies[6] = Batches.Apply(systemContext.dependsOn, world.state);
            }
            dependencies[3] = dependencies[6];
            dependsOn = dependencies[3];
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_1001_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Drones-Visual-FeatureGraph
            var systems = (System.IntPtr*)GraphGraphDrones_Visual_FeatureGraphInitialize.graphNodes1001_SystemsCodeGenerator.GetUnsafePtr();
            var dependencies = _makeArray<Unity.Jobs.JobHandle>(7, Constants.ALLOCATOR_TEMP, false);
            dependencies[1] = dependsOn;
            dependencies[2] = dependencies[1];
            dependencies[4] = dependencies[2];
            dependencies[5] = dependencies[4];
            // BURST ENABLE CLOSE
            InnerMethodOnStart_0_1001_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, dependencies
            
            );
            
            dependsOn = dependencies[3];
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0_0         START                            [ SKIPPED ]
            // * dep1001_0_0                      => dep30_2_0           START                            [ SKIPPED ]
            // * dep30_2_0                        => dep30_4_0           ME.BECS.DestroyWithTicksSystem   [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_4_0                        => dep30_0_0           ME.BECS.DestroyWithLifetimeSy... [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * Batches.Apply                    :  dep30_0_0 => dep30_1_0                               [  SYNC   ]
            // * dep30_1_0                        => dep30_1_0           ME.BECS.Transforms.TransformW... [  BURST  ]
            // * EXIT dep1001_2_0 = dep30_1_0;
            // * EXIT dependsOn = dep1001_2_0;
            // * dependencies[3]                  => dependsOn       
        }
    }
     
}
