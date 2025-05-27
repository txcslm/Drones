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
    public static unsafe class GraphGraphDrones_Visual_FeatureGraphDrawGizmos {
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_1001_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Drones-Visual-FeatureGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0_0         START                            [ SKIPPED ]
            // * dep1001_0_0                      => dep30_2_0           START                            [ SKIPPED ]
            // * dep30_2_0                        => dep30_4_0           ME.BECS.DestroyWithTicksSystem   [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_4_0                        => dep30_0_0           ME.BECS.DestroyWithLifetimeSy... [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_0_0                        => dep30_1_0           ME.BECS.Transforms.TransformW... [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dep1001_2_0 = dep30_1_0;
            // * EXIT dependsOn = dep1001_2_0;
            // * dependencies[3]                  => dependsOn       
        }
    }
     
}
