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
    public static unsafe class DebugJobsFunc {
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public static void InitializeJobsDebug() {
            { // ME.BECS.Attack.MoveToAttackerSystem+RemoveComebackAfterAttackComponentJob
                CacheJobDebugData1.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData1* data = (JobDebugData1*)CacheJobDebugData1.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData1*)_makeDefault(new JobDebugData1Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData1*)_makeDefault(new JobDebugData1(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData1.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData1Unsafe) : typeof(JobDebugData1));
            }
            { // ME.BECS.Commands.CommandAttackCleanSystem+RemoveJob
                CacheJobDebugData2.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData2* data = (JobDebugData2*)CacheJobDebugData2.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData2*)_makeDefault(new JobDebugData2Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData2*)_makeDefault(new JobDebugData2(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData2.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandAttackCleanSystem.RemoveJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandAttackCleanSystem.RemoveJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData2Unsafe) : typeof(JobDebugData2));
            }
            { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
                CacheJobDebugData3.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData3* data = (JobDebugData3*)CacheJobDebugData3.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData3*)_makeDefault(new JobDebugData3Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData3*)_makeDefault(new JobDebugData3(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData3.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData3Unsafe) : typeof(JobDebugData3));
            }
            { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
                CacheJobDebugData4.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData4* data = (JobDebugData4*)CacheJobDebugData4.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData4*)_makeDefault(new JobDebugData4Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData4*)_makeDefault(new JobDebugData4(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData4.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData4Unsafe) : typeof(JobDebugData4));
            }
            { // ME.BECS.DestroyWithLifetimeSystem+LifetimeJob
                CacheJobDebugData5.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData5* data = (JobDebugData5*)CacheJobDebugData5.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData5*)_makeDefault(new JobDebugData5Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData5*)_makeDefault(new JobDebugData5(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData5.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.DestroyWithLifetimeSystem.LifetimeJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.DestroyWithLifetimeSystem.LifetimeJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData5Unsafe) : typeof(JobDebugData5));
            }
            { // ME.BECS.DestroyWithLifetimeSystem+LifetimeMsJob
                CacheJobDebugData6.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData6* data = (JobDebugData6*)CacheJobDebugData6.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData6*)_makeDefault(new JobDebugData6Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData6*)_makeDefault(new JobDebugData6(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData6.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.DestroyWithLifetimeSystem.LifetimeMsJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetimeMs = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.DestroyWithLifetimeSystem.LifetimeMsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData6Unsafe) : typeof(JobDebugData6));
            }
            { // ME.BECS.DestroyWithTicksSystem+Job
                CacheJobDebugData7.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData7* data = (JobDebugData7*)CacheJobDebugData7.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData7*)_makeDefault(new JobDebugData7Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData7*)_makeDefault(new JobDebugData7(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData7.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.DestroyWithTicksSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithTicks = new SafetyComponentContainerRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.DestroyWithTicksSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData7Unsafe) : typeof(JobDebugData7));
            }
            { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
                CacheJobDebugData8.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData8* data = (JobDebugData8*)CacheJobDebugData8.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData8*)_makeDefault(new JobDebugData8Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData8*)_makeDefault(new JobDebugData8(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData8.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopySystem.CreateJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyRequiredRuntimeComponent = new SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopySystem.CreateJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData8Unsafe) : typeof(JobDebugData8));
            }
            { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
                CacheJobDebugData9.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData9* data = (JobDebugData9*)CacheJobDebugData9.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData9*)_makeDefault(new JobDebugData9Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData9*)_makeDefault(new JobDebugData9(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData9.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData9Unsafe) : typeof(JobDebugData9));
            }
            { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
                CacheJobDebugData10.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData10* data = (JobDebugData10*)CacheJobDebugData10.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData10*)_makeDefault(new JobDebugData10Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData10*)_makeDefault(new JobDebugData10(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData10.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent = new SafetyComponentContainerWO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData10Unsafe) : typeof(JobDebugData10));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
                CacheJobDebugData11.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData11* data = (JobDebugData11*)CacheJobDebugData11.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData11*)_makeDefault(new JobDebugData11Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData11*)_makeDefault(new JobDebugData11(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData11.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData11Unsafe) : typeof(JobDebugData11));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
                CacheJobDebugData12.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData12* data = (JobDebugData12*)CacheJobDebugData12.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData12*)_makeDefault(new JobDebugData12Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData12*)_makeDefault(new JobDebugData12(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData12.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData12Unsafe) : typeof(JobDebugData12));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
                CacheJobDebugData13.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData13* data = (JobDebugData13*)CacheJobDebugData13.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData13*)_makeDefault(new JobDebugData13Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData13*)_makeDefault(new JobDebugData13(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData13.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData13Unsafe) : typeof(JobDebugData13));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
                CacheJobDebugData14.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData14* data = (JobDebugData14*)CacheJobDebugData14.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData14*)_makeDefault(new JobDebugData14Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData14*)_makeDefault(new JobDebugData14(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData14.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData14Unsafe) : typeof(JobDebugData14));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
                CacheJobDebugData15.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData15* data = (JobDebugData15*)CacheJobDebugData15.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData15*)_makeDefault(new JobDebugData15Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData15*)_makeDefault(new JobDebugData15(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData15.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRectJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData15Unsafe) : typeof(JobDebugData15));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
                CacheJobDebugData16.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData16* data = (JobDebugData16*)CacheJobDebugData16.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData16*)_makeDefault(new JobDebugData16Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData16*)_makeDefault(new JobDebugData16(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData16.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerWO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData16Unsafe) : typeof(JobDebugData16));
            }
            { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
                CacheJobDebugData17.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData17* data = (JobDebugData17*)CacheJobDebugData17.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData17*)_makeDefault(new JobDebugData17Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData17*)_makeDefault(new JobDebugData17(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData17.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData17Unsafe) : typeof(JobDebugData17));
            }
            { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
                CacheJobDebugData18.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData18* data = (JobDebugData18*)CacheJobDebugData18.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData18*)_makeDefault(new JobDebugData18Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData18*)_makeDefault(new JobDebugData18(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData18.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerWO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData18Unsafe) : typeof(JobDebugData18));
            }
            { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
                CacheJobDebugData19.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData19* data = (JobDebugData19*)CacheJobDebugData19.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData19*)_makeDefault(new JobDebugData19Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData19*)_makeDefault(new JobDebugData19(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData19.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskRuntimeComponent = new SafetyComponentContainerWO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_IsGraphMaskDirtyComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData19Unsafe) : typeof(JobDebugData19));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
                CacheJobDebugData20.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData20* data = (JobDebugData20*)CacheJobDebugData20.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData20*)_makeDefault(new JobDebugData20Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData20*)_makeDefault(new JobDebugData20(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData20.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRO<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestTargetComponent = new SafetyComponentContainerWO<ME.BECS.Tests.TestTargetComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData20Unsafe) : typeof(JobDebugData20));
            }
            { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
                CacheJobDebugData21.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData21* data = (JobDebugData21*)CacheJobDebugData21.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData21*)_makeDefault(new JobDebugData21Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData21*)_makeDefault(new JobDebugData21(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData21.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerRO<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData21Unsafe) : typeof(JobDebugData21));
            }
            { // ME.BECS.Tests.Tests_Queries+Job1
                CacheJobDebugData22.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData22* data = (JobDebugData22*)CacheJobDebugData22.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData22*)_makeDefault(new JobDebugData22Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData22*)_makeDefault(new JobDebugData22(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData22.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job1*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job1>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData22Unsafe) : typeof(JobDebugData22));
            }
            { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
                CacheJobDebugData23.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData23* data = (JobDebugData23*)CacheJobDebugData23.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData23*)_makeDefault(new JobDebugData23Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData23*)_makeDefault(new JobDebugData23(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData23.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job1Unsafe*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test2Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test2Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job1Unsafe>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData23Unsafe) : typeof(JobDebugData23));
            }
            { // ME.BECS.Tests.Tests_Queries+Job2
                CacheJobDebugData24.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData24* data = (JobDebugData24*)CacheJobDebugData24.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData24*)_makeDefault(new JobDebugData24Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData24*)_makeDefault(new JobDebugData24(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData24.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job2*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job2>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData24Unsafe) : typeof(JobDebugData24));
            }
            { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
                CacheJobDebugData25.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData25* data = (JobDebugData25*)CacheJobDebugData25.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData25*)_makeDefault(new JobDebugData25Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData25*)_makeDefault(new JobDebugData25(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData25.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job2Unsafe*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job2Unsafe>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData25Unsafe) : typeof(JobDebugData25));
            }
            { // ME.BECS.Tests.Tests_Queries+JobComponents
                CacheJobDebugData26.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData26* data = (JobDebugData26*)CacheJobDebugData26.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData26*)_makeDefault(new JobDebugData26Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData26*)_makeDefault(new JobDebugData26(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData26.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.JobComponents*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerWO<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.JobComponents>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData26Unsafe) : typeof(JobDebugData26));
            }
            { // ME.BECS.Units.HitSystem+Job
                CacheJobDebugData27.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData27* data = (JobDebugData27*)CacheJobDebugData27.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData27*)_makeDefault(new JobDebugData27Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData27*)_makeDefault(new JobDebugData27(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData27.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Units.HitSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookComponent = new SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.HitSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData27Unsafe) : typeof(JobDebugData27));
            }
            { // ME.BECS.Views.Jobs+JobAddToScene
                CacheJobDebugData28.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData28* data = (JobDebugData28*)CacheJobDebugData28.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData28*)_makeDefault(new JobDebugData28Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData28*)_makeDefault(new JobDebugData28(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData28.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Views.Jobs.JobAddToScene*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRO<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobAddToScene>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData28Unsafe) : typeof(JobDebugData28));
            }
            { // ME.BECS.Views.Jobs+JobAssignViews
                CacheJobDebugData29.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData29* data = (JobDebugData29*)CacheJobDebugData29.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData29*)_makeDefault(new JobDebugData29Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData29*)_makeDefault(new JobDebugData29(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData29.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Views.Jobs.JobAssignViews*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.AssignViewComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_AssignViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRO<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobAssignViews>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData29Unsafe) : typeof(JobDebugData29));
            }
            { // ME.BECS.Views.Jobs+JobRemoveFromScene
                CacheJobDebugData30.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData30* data = (JobDebugData30*)CacheJobDebugData30.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData30*)_makeDefault(new JobDebugData30Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData30*)_makeDefault(new JobDebugData30(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData30.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Views.Jobs.JobRemoveFromScene*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobRemoveFromScene>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData30Unsafe) : typeof(JobDebugData30));
            }
            { // ME.BECS.Attack.CanFireSystem+Job
                CacheJobDebugData31.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData31* data = (JobDebugData31*)CacheJobDebugData31.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData31*)_makeDefault(new JobDebugData31Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData31*)_makeDefault(new JobDebugData31(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData31.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.CanFireSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeReloadComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireWhileMovesTag = new SafetyComponentContainerRO<ME.BECS.Attack.CanFireWhileMovesTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ReloadedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.CanFireSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData31Unsafe) : typeof(JobDebugData31));
            }
            { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetJob
                CacheJobDebugData32.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData32* data = (JobDebugData32*)CacheJobDebugData32.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData32*)_makeDefault(new JobDebugData32Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData32*)_makeDefault(new JobDebugData32(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData32.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData32Unsafe) : typeof(JobDebugData32));
            }
            { // ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem+TargetsJob
                CacheJobDebugData33.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData33* data = (JobDebugData33*)CacheJobDebugData33.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData33*)_makeDefault(new JobDebugData33Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData33*)_makeDefault(new JobDebugData33(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData33.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetsJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData33Unsafe) : typeof(JobDebugData33));
            }
            { // ME.BECS.Attack.FireSystem+FireTargetJob
                CacheJobDebugData34.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData34* data = (JobDebugData34*)CacheJobDebugData34.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData34*)_makeDefault(new JobDebugData34Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData34*)_makeDefault(new JobDebugData34(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData34.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.FireSystem.FireTargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackVisualComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_DamageOverrideComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_FirePointComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetimeMs = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.FireSystem.FireTargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData34Unsafe) : typeof(JobDebugData34));
            }
            { // ME.BECS.Attack.FireSystem+FireTargetsJob
                CacheJobDebugData35.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData35* data = (JobDebugData35*)CacheJobDebugData35.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData35*)_makeDefault(new JobDebugData35Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData35*)_makeDefault(new JobDebugData35(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData35.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.FireSystem.FireTargetsJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackVisualComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackVisualComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_DamageOverrideComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.DamageOverrideComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_FirePointComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.FirePointComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetimeMs = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.FireSystem.FireTargetsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData35Unsafe) : typeof(JobDebugData35));
            }
            { // ME.BECS.Attack.ReloadSystem+ReloadJob
                CacheJobDebugData36.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData36* data = (JobDebugData36*)CacheJobDebugData36.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData36*)_makeDefault(new JobDebugData36Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData36*)_makeDefault(new JobDebugData36(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData36.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.ReloadSystem.ReloadJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeReloadComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ReloadedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ReloadSystem.ReloadJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData36Unsafe) : typeof(JobDebugData36));
            }
            { // ME.BECS.Attack.ResetCanFireSystem+Job
                CacheJobDebugData37.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData37* data = (JobDebugData37*)CacheJobDebugData37.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData37*)_makeDefault(new JobDebugData37Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData37*)_makeDefault(new JobDebugData37(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData37.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.ResetCanFireSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ResetCanFireSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData37Unsafe) : typeof(JobDebugData37));
            }
            { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
                CacheJobDebugData38.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData38* data = (JobDebugData38*)CacheJobDebugData38.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData38*)_makeDefault(new JobDebugData38Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData38*)_makeDefault(new JobDebugData38(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData38.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.RotateWhileAttackSystem.IdleJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.RotateWhileAttackSystem.IdleJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData38Unsafe) : typeof(JobDebugData38));
            }
            { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
                CacheJobDebugData39.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData39* data = (JobDebugData39*)CacheJobDebugData39.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData39*)_makeDefault(new JobDebugData39Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData39*)_makeDefault(new JobDebugData39(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData39.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_RotateAttackSensorComponent = new SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData39Unsafe) : typeof(JobDebugData39));
            }
            { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
                CacheJobDebugData40.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData40* data = (JobDebugData40*)CacheJobDebugData40.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData40*)_makeDefault(new JobDebugData40Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData40*)_makeDefault(new JobDebugData40(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData40.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.SearchTargetSystem.SearchTargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRO<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.SearchTargetSystem.SearchTargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData40Unsafe) : typeof(JobDebugData40));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
                CacheJobDebugData41.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData41* data = (JobDebugData41*)CacheJobDebugData41.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData41*)_makeDefault(new JobDebugData41Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData41*)_makeDefault(new JobDebugData41(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData41.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobRemove*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobRemove>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData41Unsafe) : typeof(JobDebugData41));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobRotate
                CacheJobDebugData42.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData42* data = (JobDebugData42*)CacheJobDebugData42.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData42*)_makeDefault(new JobDebugData42Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData42*)_makeDefault(new JobDebugData42(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData42.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobRotate*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobRotate>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData42Unsafe) : typeof(JobDebugData42));
            }
            { // ME.BECS.Bullets.DestroySystem+DestroyJob
                CacheJobDebugData43.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData43* data = (JobDebugData43*)CacheJobDebugData43.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData43*)_makeDefault(new JobDebugData43Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData43*)_makeDefault(new JobDebugData43(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData43.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Bullets.DestroySystem.DestroyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Bullets.BulletAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletEffectOnDestroy = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_DamageOverrideComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.DamageOverrideComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetimeMs = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithTicks = new SafetyComponentContainerRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRO<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookComponent = new SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookEvent = new SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitEffectOnHitComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Bullets.DestroySystem.DestroyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData43Unsafe) : typeof(JobDebugData43));
            }
            { // ME.BECS.Bullets.FlySystem+FlyJob
                CacheJobDebugData44.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData44* data = (JobDebugData44*)CacheJobDebugData44.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData44*)_makeDefault(new JobDebugData44Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData44*)_makeDefault(new JobDebugData44(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData44.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Bullets.FlySystem.FlyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Bullets.BulletAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_TargetReachedComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Bullets.FlySystem.FlyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData44Unsafe) : typeof(JobDebugData44));
            }
            { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
                CacheJobDebugData45.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData45* data = (JobDebugData45*)CacheJobDebugData45.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData45*)_makeDefault(new JobDebugData45Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData45*)_makeDefault(new JobDebugData45(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData45.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandAttackSystem.CleanUpJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandAttackSystem.CleanUpJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData45Unsafe) : typeof(JobDebugData45));
            }
            { // ME.BECS.Commands.CommandAttackSystem+MoveJob
                CacheJobDebugData46.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData46* data = (JobDebugData46*)CacheJobDebugData46.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData46*)_makeDefault(new JobDebugData46Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData46*)_makeDefault(new JobDebugData46(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData46.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandAttackSystem.MoveJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandAttackSystem.MoveJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData46Unsafe) : typeof(JobDebugData46));
            }
            { // ME.BECS.Commands.CommandBuildSystem+Job
                CacheJobDebugData47.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData47* data = (JobDebugData47*)CacheJobDebugData47.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData47*)_makeDefault(new JobDebugData47Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData47*)_makeDefault(new JobDebugData47(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData47.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandBuildSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandBuild = new SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData47Unsafe) : typeof(JobDebugData47));
            }
            { // ME.BECS.Commands.CommandMoveSystem+Job
                CacheJobDebugData48.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData48* data = (JobDebugData48*)CacheJobDebugData48.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData48*)_makeDefault(new JobDebugData48Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData48*)_makeDefault(new JobDebugData48(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData48.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Commands.CommandMoveSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandMove = new SafetyComponentContainerRO<ME.BECS.Commands.CommandMove>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandMoveSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData48Unsafe) : typeof(JobDebugData48));
            }
            { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
                CacheJobDebugData49.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData49* data = (JobDebugData49*)CacheJobDebugData49.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData49*)_makeDefault(new JobDebugData49Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData49*)_makeDefault(new JobDebugData49(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData49.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.CreateSystem.CleanUpJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Players.TeamAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.CreateSystem.CleanUpJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData49Unsafe) : typeof(JobDebugData49));
            }
            { // ME.BECS.FogOfWar.CreateSystem+CreateJob
                CacheJobDebugData50.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData50* data = (JobDebugData50*)CacheJobDebugData50.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData50*)_makeDefault(new JobDebugData50Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData50*)_makeDefault(new JobDebugData50(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData50.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.CreateSystem.CreateJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Players.TeamAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.CreateSystem.CreateJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData50Unsafe) : typeof(JobDebugData50));
            }
            { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
                CacheJobDebugData51.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData51* data = (JobDebugData51*)CacheJobDebugData51.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData51*)_makeDefault(new JobDebugData51Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData51*)_makeDefault(new JobDebugData51(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData51.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Pathfinding_AgentComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData51Unsafe) : typeof(JobDebugData51));
            }
            { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
                CacheJobDebugData52.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData52* data = (JobDebugData52*)CacheJobDebugData52.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData52*)_makeDefault(new JobDebugData52Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData52*)_makeDefault(new JobDebugData52(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData52.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData52Unsafe) : typeof(JobDebugData52));
            }
            { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
                CacheJobDebugData53.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData53* data = (JobDebugData53*)CacheJobDebugData53.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData53*)_makeDefault(new JobDebugData53Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData53*)_makeDefault(new JobDebugData53(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData53.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Pathfinding_AgentComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRO<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData53Unsafe) : typeof(JobDebugData53));
            }
            { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
                CacheJobDebugData54.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData54* data = (JobDebugData54*)CacheJobDebugData54.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData54*)_makeDefault(new JobDebugData54Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData54*)_makeDefault(new JobDebugData54(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData54.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData54Unsafe) : typeof(JobDebugData54));
            }
            { // ME.BECS.Pathfinding.LookAtSystem+Job
                CacheJobDebugData55.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData55* data = (JobDebugData55*)CacheJobDebugData55.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData55*)_makeDefault(new JobDebugData55Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData55*)_makeDefault(new JobDebugData55(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData55.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Pathfinding.LookAtSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.LookAtSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData55Unsafe) : typeof(JobDebugData55));
            }
            { // ME.BECS.QuadTreeInsertSystem+CollectJob
                CacheJobDebugData56.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData56* data = (JobDebugData56*)CacheJobDebugData56.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData56*)_makeDefault(new JobDebugData56Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData56*)_makeDefault(new JobDebugData56(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData56.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.QuadTreeInsertSystem.CollectJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_QuadTreeElement = new SafetyComponentContainerRW<ME.BECS.QuadTreeElement>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeHeightComponent = new SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.QuadTreeInsertSystem.CollectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData56Unsafe) : typeof(JobDebugData56));
            }
            { // ME.BECS.QuadTreeInsertSystem+CollectRectJob
                CacheJobDebugData57.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData57* data = (JobDebugData57*)CacheJobDebugData57.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData57*)_makeDefault(new JobDebugData57Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData57*)_makeDefault(new JobDebugData57(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData57.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.QuadTreeInsertSystem.CollectRectJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_QuadTreeElement = new SafetyComponentContainerRW<ME.BECS.QuadTreeElement>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeElementRect = new SafetyComponentContainerRO<ME.BECS.QuadTreeElementRect>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeHeightComponent = new SafetyComponentContainerRO<ME.BECS.QuadTreeHeightComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.QuadTreeInsertSystem.CollectRectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData57Unsafe) : typeof(JobDebugData57));
            }
            { // ME.BECS.QuadTreeQuerySystem+Job
                CacheJobDebugData58.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData58* data = (JobDebugData58*)CacheJobDebugData58.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData58*)_makeDefault(new JobDebugData58Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData58*)_makeDefault(new JobDebugData58(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData58.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.QuadTreeQuerySystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRO<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.QuadTreeQuerySystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData58Unsafe) : typeof(JobDebugData58));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestJobFor
                CacheJobDebugData59.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData59* data = (JobDebugData59*)CacheJobDebugData59.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData59*)_makeDefault(new JobDebugData59Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData59*)_makeDefault(new JobDebugData59(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData59.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestJobFor*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.Test2Aspect>(buffer->state);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRW<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test4Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test4Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestJobFor>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData59Unsafe) : typeof(JobDebugData59));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestSetJob
                CacheJobDebugData60.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData60* data = (JobDebugData60*)CacheJobDebugData60.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData60*)_makeDefault(new JobDebugData60Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData60*)_makeDefault(new JobDebugData60(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData60.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestSetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.Test2Aspect>(buffer->state);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRW<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test4Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test4Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestSetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData60Unsafe) : typeof(JobDebugData60));
            }
            { // ME.BECS.Tests.Tests_Queries+TestA1Job
                CacheJobDebugData61.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData61* data = (JobDebugData61*)CacheJobDebugData61.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData61*)_makeDefault(new JobDebugData61Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData61*)_makeDefault(new JobDebugData61(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData61.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.TestA1Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.TestAspect>(buffer->state);
                    data->ME_BECS_Tests_Test5Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test5Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.TestA1Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData61Unsafe) : typeof(JobDebugData61));
            }
            { // ME.BECS.Tests.Tests_Queries+TestA2Job
                CacheJobDebugData62.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData62* data = (JobDebugData62*)CacheJobDebugData62.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData62*)_makeDefault(new JobDebugData62Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData62*)_makeDefault(new JobDebugData62(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData62.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.TestA2Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.TestAspect>(buffer->state);
                    data->ME_BECS_Tests_Test2Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test2Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.TestA2Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData62Unsafe) : typeof(JobDebugData62));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateJob
                CacheJobDebugData63.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData63* data = (JobDebugData63*)CacheJobDebugData63.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData63*)_makeDefault(new JobDebugData63Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData63*)_makeDefault(new JobDebugData63(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData63.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData63Unsafe) : typeof(JobDebugData63));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateLocalMatrixJob
                CacheJobDebugData64.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData64* data = (JobDebugData64*)CacheJobDebugData64.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData64*)_makeDefault(new JobDebugData64Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData64*)_makeDefault(new JobDebugData64(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData64.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateLocalMatrixJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateLocalMatrixJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData64Unsafe) : typeof(JobDebugData64));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
                CacheJobDebugData65.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData65* data = (JobDebugData65*)CacheJobDebugData65.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData65*)_makeDefault(new JobDebugData65Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData65*)_makeDefault(new JobDebugData65(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData65.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData65Unsafe) : typeof(JobDebugData65));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+ClearJob
                CacheJobDebugData66.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData66* data = (JobDebugData66*)CacheJobDebugData66.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData66*)_makeDefault(new JobDebugData66Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData66*)_makeDefault(new JobDebugData66(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData66.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.ClearJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.ClearJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData66Unsafe) : typeof(JobDebugData66));
            }
            { // ME.BECS.Units.DestroySystem+DestroyJob
                CacheJobDebugData67.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData67* data = (JobDebugData67*)CacheJobDebugData67.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData67*)_makeDefault(new JobDebugData67Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData67*)_makeDefault(new JobDebugData67(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData67.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Units.DestroySystem.DestroyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetimeMs = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetimeMs>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithTicks = new SafetyComponentContainerRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_SelectionGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitEffectOnDestroyComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsDeadTag = new SafetyComponentContainerRW<ME.BECS.Units.UnitIsDeadTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitSelectionGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.DestroySystem.DestroyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData67Unsafe) : typeof(JobDebugData67));
            }
            { // ME.BECS.Units.SteeringSystem+Job
                CacheJobDebugData68.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData68* data = (JobDebugData68*)CacheJobDebugData68.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData68*)_makeDefault(new JobDebugData68Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData68*)_makeDefault(new JobDebugData68(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData68.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Units.SteeringSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRO<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRO<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.SteeringSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData68Unsafe) : typeof(JobDebugData68));
            }
            { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
                CacheJobDebugData69.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData69* data = (JobDebugData69*)CacheJobDebugData69.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData69*)_makeDefault(new JobDebugData69Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData69*)_makeDefault(new JobDebugData69(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData69.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Units.SteeringWithAvoidanceSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRO<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRO<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.SteeringWithAvoidanceSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData69Unsafe) : typeof(JobDebugData69));
            }
            { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
                CacheJobDebugData70.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData70* data = (JobDebugData70*)CacheJobDebugData70.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData70*)_makeDefault(new JobDebugData70Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData70*)_makeDefault(new JobDebugData70(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData70.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_CameraComponent = new SafetyComponentContainerRO<ME.BECS.Views.CameraComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData70Unsafe) : typeof(JobDebugData70));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+ComebackAfterAttackJob
                CacheJobDebugData71.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData71* data = (JobDebugData71*)CacheJobDebugData71.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData71*)_makeDefault(new JobDebugData71Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData71*)_makeDefault(new JobDebugData71(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData71.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.ComebackAfterAttackJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Attack.ComebackAfterAttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackerFollowDistanceComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackerFollowDistanceComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ComebackAfterAttackComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandMove = new SafetyComponentContainerRW<ME.BECS.Commands.CommandMove>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRO<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.ComebackAfterAttackJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData71Unsafe) : typeof(JobDebugData71));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
                CacheJobDebugData72.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData72* data = (JobDebugData72*)CacheJobDebugData72.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData72*)_makeDefault(new JobDebugData72Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData72*)_makeDefault(new JobDebugData72(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData72.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackFilterComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ComebackAfterAttackComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerRW<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandMove = new SafetyComponentContainerRW<ME.BECS.Commands.CommandMove>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRO<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookEvent = new SafetyComponentContainerRW<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitBelongsToComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData72Unsafe) : typeof(JobDebugData72));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
                CacheJobDebugData73.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData73* data = (JobDebugData73*)CacheJobDebugData73.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData73*)_makeDefault(new JobDebugData73Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData73*)_makeDefault(new JobDebugData73(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData73.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackFilterComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ComebackAfterAttackComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ComebackAfterAttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerWO<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitBelongsToComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData73Unsafe) : typeof(JobDebugData73));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+UpdatePathJob
                CacheJobDebugData74.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData74* data = (JobDebugData74*)CacheJobDebugData74.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData74*)_makeDefault(new JobDebugData74Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData74*)_makeDefault(new JobDebugData74(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData74.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.UpdatePathJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackFilterComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerWO<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitBelongsToComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitIsCollideWithEnd = new SafetyComponentContainerRW<ME.BECS.Units.UnitIsCollideWithEnd>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.UpdatePathJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData74Unsafe) : typeof(JobDebugData74));
            }
            { // ME.BECS.Attack.SearchTargetSystem+SearchTargetsJob
                CacheJobDebugData75.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData75* data = (JobDebugData75*)CacheJobDebugData75.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData75*)_makeDefault(new JobDebugData75Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData75*)_makeDefault(new JobDebugData75(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData75.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.SearchTargetSystem.SearchTargetsJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Attack.AttackTargetsCountComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetsCountComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetsCountComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRO<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.SearchTargetSystem.SearchTargetsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData75Unsafe) : typeof(JobDebugData75));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
                CacheJobDebugData76.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData76* data = (JobDebugData76*)CacheJobDebugData76.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData76*)_makeDefault(new JobDebugData76Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData76*)_makeDefault(new JobDebugData76(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData76.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobSet*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobSet>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData76Unsafe) : typeof(JobDebugData76));
            }
            { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
                CacheJobDebugData77.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData77* data = (JobDebugData77*)CacheJobDebugData77.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData77*)_makeDefault(new JobDebugData77Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData77*)_makeDefault(new JobDebugData77(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData77.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter = new SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRO<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData77Unsafe) : typeof(JobDebugData77));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
                CacheJobDebugData78.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData78* data = (JobDebugData78*)CacheJobDebugData78.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData78*)_makeDefault(new JobDebugData78Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData78*)_makeDefault(new JobDebugData78(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData78.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerWO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData78Unsafe) : typeof(JobDebugData78));
            }
        }
        #endif
        
    }
     
}
