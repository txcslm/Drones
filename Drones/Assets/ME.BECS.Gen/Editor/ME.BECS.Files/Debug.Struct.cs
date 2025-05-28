namespace ME.BECS.Editor {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using s = System.Collections.Generic;
    using UnityEditor;
    public static unsafe class DebugJobsStruct {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1 { // ME.BECS.Attack.MoveToAttackerSystem+RemoveComebackAfterAttackComponentJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData2 { // ME.BECS.Commands.CommandAttackCleanSystem+RemoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackCleanSystem.RemoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData3 { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Commands.BuildingInProgress> c0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
        }
        public struct JobDebugData4 { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Commands.BuildInProgress> c0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData5 { // ME.BECS.DestroyWithLifetimeSystem+LifetimeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.LifetimeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.DestroyWithLifetime> c0;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData6 { // ME.BECS.DestroyWithLifetimeSystem+LifetimeMsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.LifetimeMsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.DestroyWithLifetimeMs> c0;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData7 { // ME.BECS.DestroyWithTicksSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithTicksSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.DestroyWithTicks> c0;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData8 { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopySystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Players.OwnerComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent> c1;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyRequiredRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData9 { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData10 { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData11 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData12 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData13 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public RefRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData14 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData15 { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData16 { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData17 { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.TargetComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData18 { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.TargetPathComponent> c0;
            public SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData19 { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.GraphMaskComponent> c0;
            public RefRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> c1;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            public SafetyComponentContainerWO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> ME_BECS_Pathfinding_GraphMaskRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent> ME_BECS_Pathfinding_IsGraphMaskDirtyComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData20 { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestTargetComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerWO<ME.BECS.Tests.TestTargetComponent> ME_BECS_Tests_TestTargetComponent;
        }
        public struct JobDebugData21 { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData22 { // ME.BECS.Tests.Tests_Queries+Job1
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData23 { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData24 { // ME.BECS.Tests.Tests_Queries+Job2
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData25 { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
        }
        public struct JobDebugData26 { // ME.BECS.Tests.Tests_Queries+JobComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.JobComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerWO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData27 { // ME.BECS.Units.HitSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.HitSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Units.DamageTookComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData28 { // ME.BECS.Views.Jobs+JobAddToScene
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAddToScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.IsViewRequested> c0;
            public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData29 { // ME.BECS.Views.Jobs+JobAssignViews
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAssignViews jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.AssignViewComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent> ME_BECS_Views_AssignViewComponent;
            public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData30 { // ME.BECS.Views.Jobs+JobRemoveFromScene
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobRemoveFromScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.ViewComponent> c0;
        }
        public struct JobDebugData31 { // Source.Drones.Code.Systems.SpawnJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public Source.Drones.Code.Systems.SpawnJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<Source.Drones.Code.Components.DefaultComp.ResourceSpawnerComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
            public SafetyComponentContainerRW<Source.Drones.Code.Components.DefaultComp.ResourceSpawnerComponent> Source_Drones_Code_Components_DefaultComp_ResourceSpawnerComponent;
        }
        public struct JobDebugData32 { // ME.BECS.Attack.CanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.CanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.CanFireWhileMovesTag> ME_BECS_Attack_CanFireWhileMovesTag;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData33 { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        public struct JobDebugData34 { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        public struct JobDebugData35 { // ME.BECS.Attack.FireSystem+FireTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent> ME_BECS_Attack_AttackVisualComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData36 { // ME.BECS.Attack.FireSystem+FireTargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireTargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent> ME_BECS_Attack_AttackVisualComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData37 { // ME.BECS.Attack.ReloadSystem+ReloadJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ReloadSystem.ReloadJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        public struct JobDebugData38 { // ME.BECS.Attack.ResetCanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ResetCanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
        }
        public struct JobDebugData39 { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.IdleJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        public struct JobDebugData40 { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent> ME_BECS_Attack_RotateAttackSensorComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData41 { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.QuadTreeQueryAspect a1;
            public ME.BECS.Transforms.TransformAspect a2;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData42 { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRemove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData43 { // ME.BECS.Attack.StopWhileAttackSystem+JobRotate
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRotate jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
        }
        public struct JobDebugData44 { // ME.BECS.Bullets.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Bullets.BulletAspect a0;
            public ME.BECS.QuadTreeQueryAspect a1;
            public ME.BECS.Transforms.TransformAspect a2;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy> ME_BECS_Bullets_BulletEffectOnDestroy;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.DamageOverrideComponent> ME_BECS_Bullets_DamageOverrideComponent;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent> ME_BECS_Units_UnitEffectOnHitComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData45 { // ME.BECS.Bullets.FlySystem+FlyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.FlySystem.FlyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Bullets.BulletAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent> ME_BECS_Bullets_TargetReachedComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData46 { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData47 { // ME.BECS.Commands.CommandAttackSystem+MoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.MoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
        }
        public struct JobDebugData48 { // ME.BECS.Commands.CommandBuildSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild> ME_BECS_Commands_CommandBuild;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData49 { // ME.BECS.Commands.CommandMoveSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandMoveSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        public struct JobDebugData50 { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Players.TeamAspect a0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData51 { // ME.BECS.FogOfWar.CreateSystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Players.TeamAspect a0;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData52 { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        public struct JobDebugData53 { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData54 { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        public struct JobDebugData55 { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData56 { // ME.BECS.Pathfinding.LookAtSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.LookAtSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        public struct JobDebugData57 { // ME.BECS.QuadTreeInsertSystem+CollectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent> ME_BECS_QuadTreeHeightComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData58 { // ME.BECS.QuadTreeInsertSystem+CollectRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeElementRect> ME_BECS_QuadTreeElementRect;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent> ME_BECS_QuadTreeHeightComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData59 { // ME.BECS.QuadTreeQuerySystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeQuerySystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeQueryAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData60 { // ME.BECS.Tests.Tests_Aspects+TestJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.Test2Aspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        public struct JobDebugData61 { // ME.BECS.Tests.Tests_Aspects+TestSetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestSetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.Test2Aspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        public struct JobDebugData62 { // ME.BECS.Tests.Tests_Queries+TestA1Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA1Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.TestAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test5Component> ME_BECS_Tests_Test5Component;
            public SafetyComponentContainerRW<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData63 { // ME.BECS.Tests.Tests_Queries+TestA2Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA2Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.TestAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData64 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData65 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateLocalMatrixJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateLocalMatrixJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
        }
        public struct JobDebugData66 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData67 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+ClearJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.ClearJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData68 { // ME.BECS.Units.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs> ME_BECS_DestroyWithLifetimeMs;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent> ME_BECS_Units_SelectionGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent> ME_BECS_Units_UnitEffectOnDestroyComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitIsDeadTag> ME_BECS_Units_UnitIsDeadTag;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent> ME_BECS_Units_UnitSelectionGroupComponent;
        }
        public struct JobDebugData69 { // ME.BECS.Units.SteeringSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        public struct JobDebugData70 { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringWithAvoidanceSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
        }
        public struct JobDebugData71 { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            public SafetyComponentContainerRO<ME.BECS.Views.CameraComponent> ME_BECS_Views_CameraComponent;
        }
        public struct JobDebugData72 { // ME.BECS.Attack.MoveToAttackerSystem+ComebackAfterAttackJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.ComebackAfterAttackJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public RefRW<ME.BECS.Attack.ComebackAfterAttackComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackerFollowDistanceComponent> ME_BECS_Attack_AttackerFollowDistanceComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            public SafetyComponentContainerRO<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData73 { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public RefRW<ME.BECS.Units.DamageTookEvent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            public SafetyComponentContainerRO<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        public struct JobDebugData74 { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent> ME_BECS_Attack_ComebackAfterAttackComponent;
            public SafetyComponentContainerWO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        public struct JobDebugData75 { // ME.BECS.Attack.MoveToAttackerSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public RefRW<ME.BECS.Commands.CommandAttack> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            public SafetyComponentContainerWO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd> ME_BECS_Units_UnitIsCollideWithEnd;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
        }
        public struct JobDebugData76 { // ME.BECS.Attack.SearchTargetSystem+SearchTargetsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.QuadTreeQueryAspect a1;
            public ME.BECS.Transforms.TransformAspect a2;
            public RefRW<ME.BECS.Attack.AttackTargetsCountComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent> ME_BECS_Attack_AttackTargetsComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsCountComponent> ME_BECS_Attack_AttackTargetsCountComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData77 { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobSet jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData78 { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeQueryAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public RefRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> c0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter;
            public SafetyComponentContainerRO<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData79 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.Transforms.IsFirstLevelComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent> ME_BECS_Transforms_LocalMatrixComponent;
            public SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        #endif
        
    }
     
}
