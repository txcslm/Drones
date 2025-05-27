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
    public static unsafe class GraphGraphDrones_FeaturesGraphStart {
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_1001_SystemsCodeGenerator(uint dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Drones-FeaturesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0_0         START                            [ SKIPPED ]
            // *                                  => dependsOn       
        }
    }
     
}
