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
    public static unsafe class GraphGraphDrones_Logic_FeatureGraphDestroy {
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_1002_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Drones-Logic-FeatureGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1002_0_0         START                            [ SKIPPED ]
            // * dep1002_0_0                      => dep1002_4_0         Source.Drones.Code.Systems.Le... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep1002_4_0                      => dep1002_3_0         Source.Drones.Code.Systems.Sp... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep1002_3_0                      => dep30_2_0           START                            [ SKIPPED ]
            // * dep30_2_0                        => dep30_4_0           ME.BECS.DestroyWithTicksSystem   [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_4_0                        => dep30_0_0           ME.BECS.DestroyWithLifetimeSy... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_0_0                        => dep30_1_0           ME.BECS.Transforms.TransformW... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dep1002_2_0 = dep30_1_0;
            // * EXIT dependsOn = dep1002_2_0;
            // * dependencies[5]                  => dependsOn       
        }
    }
     
}
