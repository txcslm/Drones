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
    public static unsafe class DebugJobsCache {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        private struct CacheJobDebugData1 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData1>();
        }
        private struct CacheJobDebugData2 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData2>();
        }
        private struct CacheJobDebugData3 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData3>();
        }
        private struct CacheJobDebugData4 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData4>();
        }
        private struct CacheJobDebugData5 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData5>();
        }
        private struct CacheJobDebugData6 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData6>();
        }
        private struct CacheJobDebugData7 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData7>();
        }
        private struct CacheJobDebugData8 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData8>();
        }
        private struct CacheJobDebugData9 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData9>();
        }
        private struct CacheJobDebugData10 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData10>();
        }
        private struct CacheJobDebugData11 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData11>();
        }
        private struct CacheJobDebugData12 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData12>();
        }
        private struct CacheJobDebugData13 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData13>();
        }
        private struct CacheJobDebugData14 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData14>();
        }
        private struct CacheJobDebugData15 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData15>();
        }
        private struct CacheJobDebugData16 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData16>();
        }
        private struct CacheJobDebugData17 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData17>();
        }
        private struct CacheJobDebugData18 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData18>();
        }
        private struct CacheJobDebugData19 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData19>();
        }
        private struct CacheJobDebugData20 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData20>();
        }
        private struct CacheJobDebugData21 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData21>();
        }
        private struct CacheJobDebugData22 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData22>();
        }
        private struct CacheJobDebugData23 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData23>();
        }
        private struct CacheJobDebugData24 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData24>();
        }
        private struct CacheJobDebugData25 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData25>();
        }
        private struct CacheJobDebugData26 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData26>();
        }
        private struct CacheJobDebugData27 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData27>();
        }
        private struct CacheJobDebugData28 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData28>();
        }
        private struct CacheJobDebugData29 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData29>();
        }
        private struct CacheJobDebugData30 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData30>();
        }
        private struct CacheJobDebugData31 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData31>();
        }
        private struct CacheJobDebugData32 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData32>();
        }
        private struct CacheJobDebugData33 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData33>();
        }
        private struct CacheJobDebugData34 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData34>();
        }
        private struct CacheJobDebugData35 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData35>();
        }
        private struct CacheJobDebugData36 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData36>();
        }
        private struct CacheJobDebugData37 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData37>();
        }
        private struct CacheJobDebugData38 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData38>();
        }
        private struct CacheJobDebugData39 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData39>();
        }
        private struct CacheJobDebugData40 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData40>();
        }
        private struct CacheJobDebugData41 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData41>();
        }
        private struct CacheJobDebugData42 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData42>();
        }
        private struct CacheJobDebugData43 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData43>();
        }
        private struct CacheJobDebugData44 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData44>();
        }
        private struct CacheJobDebugData45 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData45>();
        }
        private struct CacheJobDebugData46 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData46>();
        }
        private struct CacheJobDebugData47 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData47>();
        }
        private struct CacheJobDebugData48 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData48>();
        }
        private struct CacheJobDebugData49 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData49>();
        }
        private struct CacheJobDebugData50 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData50>();
        }
        private struct CacheJobDebugData51 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData51>();
        }
        private struct CacheJobDebugData52 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData52>();
        }
        private struct CacheJobDebugData53 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData53>();
        }
        private struct CacheJobDebugData54 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData54>();
        }
        private struct CacheJobDebugData55 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData55>();
        }
        private struct CacheJobDebugData56 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData56>();
        }
        private struct CacheJobDebugData57 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData57>();
        }
        private struct CacheJobDebugData58 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData58>();
        }
        private struct CacheJobDebugData59 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData59>();
        }
        private struct CacheJobDebugData60 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData60>();
        }
        private struct CacheJobDebugData61 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData61>();
        }
        private struct CacheJobDebugData62 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData62>();
        }
        private struct CacheJobDebugData63 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData63>();
        }
        private struct CacheJobDebugData64 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData64>();
        }
        private struct CacheJobDebugData65 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData65>();
        }
        private struct CacheJobDebugData66 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData66>();
        }
        private struct CacheJobDebugData67 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData67>();
        }
        private struct CacheJobDebugData68 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData68>();
        }
        #endif
        
    }
     
}
