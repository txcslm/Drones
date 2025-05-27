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
    [UnityEngine.Scripting.PreserveAttribute]
    public static unsafe class AOTBurstHelper {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void AOT() {
            StaticSystemTypes<ME.BECS.Attack.CanFireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.CanFireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.CanFireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.CanFireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem>(default);
            StaticSystemTypes<ME.BECS.Attack.FireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.FireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.FireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.FireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.MoveToAttackerSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.MoveToAttackerSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.MoveToAttackerSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.MoveToAttackerSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.ReloadSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.ReloadSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.ReloadSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.ReloadSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.ResetCanFireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.ResetCanFireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.ResetCanFireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.ResetCanFireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.RotateWhileAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.RotateWhileAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.RotateWhileAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.RotateWhileAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.SearchTargetSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.SearchTargetSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.SearchTargetSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.SearchTargetSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.StopWhileAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.StopWhileAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.StopWhileAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.StopWhileAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Bullets.DestroySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Bullets.DestroySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Bullets.DestroySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Bullets.DestroySystem>(default);
            StaticSystemTypes<ME.BECS.Bullets.FlySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Bullets.FlySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Bullets.FlySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Bullets.FlySystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandAttackCleanSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandAttackCleanSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandAttackCleanSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandAttackCleanSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandBuildSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandBuildSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandBuildSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandBuildSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandBuildUpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandBuildUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandBuildUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandBuildUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandMoveSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandMoveSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandMoveSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandMoveSystem>(default);
            StaticSystemTypes<ME.BECS.DestroyWithLifetimeSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.DestroyWithLifetimeSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.DestroyWithLifetimeSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.DestroyWithLifetimeSystem>(default);
            StaticSystemTypes<ME.BECS.DestroyWithTicksSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.DestroyWithTicksSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.DestroyWithTicksSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.DestroyWithTicksSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.CreateSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.FogOfWar.CreateSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.CreateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.CreateTextureSystem>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.FogOfWar.CreateTextureSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.FogOfWar.CreateTextureSystem>.MakeMethod(null);
            StaticSystemTypes<ME.BECS.FogOfWar.DrawGizmosSystem>.Validate();
            BurstCompileOnDrawGizmos<ME.BECS.FogOfWar.DrawGizmosSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.FogOfWar.DrawGizmosSystem>.MakeMethod(null);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.FogOfWar.DrawGizmosSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.ShadowCopySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.ShadowCopySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.ShadowCopySystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.UpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.UpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.UpdateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.UpdateTextureSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.UpdateTextureSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystemGPU>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.FogOfWar.UpdateTextureSystemGPU>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.UpdateTextureSystemGPU>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.FogOfWar.UpdateTextureSystemGPU>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.FogOfWar.UpdateTextureSystemGPU>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.UpdateTextureSystemGPU>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.FogOfWar.UpdateTextureSystemGPU>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.BuildGraphSystem>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Pathfinding.BuildGraphSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Pathfinding.BuildGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Pathfinding.BuildGraphSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Pathfinding.BuildGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.BuildPathSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.BuildPathSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.BuildPathSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.BuildPathSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.DrawGizmosGraphSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Pathfinding.DrawGizmosGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.FollowPathSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.FollowPathSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.FollowPathSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.LookAtSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.LookAtSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.LookAtSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.LookAtSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.ShowBuildingGridSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.ShowBuildingGridSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Pathfinding.ShowBuildingGridSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.ShowBuildingGridSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Pathfinding.ShowBuildingGridSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.UpdateGraphSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.UpdateGraphSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.UpdateGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.UpdateGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Players.PlayersSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.Players.PlayersSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Players.PlayersSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Players.PlayersSystem>(default);
            StaticSystemTypes<ME.BECS.QuadTreeInsertSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.QuadTreeInsertSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.QuadTreeInsertSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.QuadTreeInsertSystem>(default);
            StaticSystemTypes<ME.BECS.QuadTreeQuerySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.QuadTreeQuerySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.QuadTreeQuerySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.QuadTreeQuerySystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.Validate();
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>(default);
            StaticSystemTypes<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnStart<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnStartNoBurst<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(default);
            BurstCompileMethod.MakeStart<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.Units.DestroySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.DestroySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.DestroySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.DestroySystem>(default);
            StaticSystemTypes<ME.BECS.Units.HitSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.HitSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.HitSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.HitSystem>(default);
            StaticSystemTypes<ME.BECS.Units.SteeringSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmos<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.SteeringSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Units.SteeringSystem>(default);
            StaticSystemTypes<ME.BECS.Units.SteeringWithAvoidanceSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmos<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.SteeringWithAvoidanceSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Units.SteeringWithAvoidanceSystem>(default);
            StaticSystemTypes<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>(default);
            StaticSystemTypes<Source.Drones.Code.Systems.ExampleSystem>.Validate();
            BurstCompileOnStartNoBurst<Source.Drones.Code.Systems.ExampleSystem>.MakeMethod(null);
            BurstCompileMethod.MakeStart<Source.Drones.Code.Systems.ExampleSystem>(default);
            StaticTypes<ME.BECS.Attack.AttackComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackFilterComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackTargetsComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackTargetsCountComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackVisualComponent>.AOT();
            StaticTypes<ME.BECS.Attack.CanFireComponent>.AOT();
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.AOT();
            StaticTypes<ME.BECS.Attack.ComebackAfterAttackComponent>.AOT();
            StaticTypes<ME.BECS.Attack.FireUsedComponent>.AOT();
            StaticTypes<ME.BECS.Attack.OnFireEvent>.AOT();
            StaticTypes<ME.BECS.Attack.ReloadedComponent>.AOT();
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.AOT();
            StaticTypes<ME.BECS.Attack.RotateToAttackWhileIdleComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.DamageOverrideComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.FirePointComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.TargetReachedComponent>.AOT();
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.AOT();
            StaticTypes<ME.BECS.Commands.BuildInProgress>.AOT();
            StaticTypes<ME.BECS.Commands.CommandAttack>.AOT();
            StaticTypes<ME.BECS.Commands.CommandBuild>.AOT();
            StaticTypes<ME.BECS.Commands.CommandMove>.AOT();
            StaticTypes<ME.BECS.Commands.ReceivedCommandFromUserEvent>.AOT();
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.AOT();
            StaticTypes<ME.BECS.DestroyWithLifetime>.AOT();
            StaticTypes<ME.BECS.DestroyWithLifetimeMs>.AOT();
            StaticTypes<ME.BECS.DestroyWithTicks>.AOT();
            StaticTypes<ME.BECS.Effects.EffectComponent>.AOT();
            StaticTypes<ME.BECS.EntityConfigComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>.AOT();
            StaticTypes<ME.BECS.IsInactive>.AOT();
            StaticTypes<ME.BECS.Pathfinding.AgentComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.RootGraphComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetInfoComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetPathComponent>.AOT();
            StaticTypes<ME.BECS.Players.IsPlayerDefeatTag>.AOT();
            StaticTypes<ME.BECS.Players.IsPlayerVictoryTag>.AOT();
            StaticTypes<ME.BECS.Players.OwnerChangedEvent>.AOT();
            StaticTypes<ME.BECS.Players.OwnerComponent>.AOT();
            StaticTypes<ME.BECS.Players.PlayerComponent>.AOT();
            StaticTypes<ME.BECS.Players.PlayerCurrentSelection>.AOT();
            StaticTypes<ME.BECS.Players.TeamComponent>.AOT();
            StaticTypes<ME.BECS.QuadTreeElement>.AOT();
            StaticTypes<ME.BECS.QuadTreeElementRect>.AOT();
            StaticTypes<ME.BECS.QuadTreeHeightComponent>.AOT();
            StaticTypes<ME.BECS.QuadTreeQuery>.AOT();
            StaticTypes<ME.BECS.QuadTreeQueryHasCustomFilterTag>.AOT();
            StaticTypes<ME.BECS.QuadTreeResult>.AOT();
            StaticTypes<ME.BECS.Tests.T1>.AOT();
            StaticTypes<ME.BECS.Tests.T2>.AOT();
            StaticTypes<ME.BECS.Tests.Test1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test2Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test3Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test4Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test5Component>.AOT();
            StaticTypes<ME.BECS.Tests.TestComponent>.AOT();
            StaticTypes<ME.BECS.Tests.TestComponentTag>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.AOT();
            StaticTypes<ME.BECS.Tests.TestTargetComponent>.AOT();
            StaticTypes<ME.BECS.TNull>.AOT();
            StaticTypes<ME.BECS.Transforms.BoundsSizeComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalMatrixComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.ParentComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.AOT();
            StaticTypes<ME.BECS.UI.UIComponent>.AOT();
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.DamageTookComponent>.AOT();
            StaticTypes<ME.BECS.Units.DamageTookEvent>.AOT();
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.AOT();
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.AOT();
            StaticTypes<ME.BECS.Units.PathFollowComponent>.AOT();
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitBelongsToComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitIsCollideWithEnd>.AOT();
            StaticTypes<ME.BECS.Units.UnitIsDeadTag>.AOT();
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.AOT();
            StaticTypes<ME.BECS.Views.AssignViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.CameraComponent>.AOT();
            StaticTypes<ME.BECS.Views.DrawMeshProviderTag>.AOT();
            StaticTypes<ME.BECS.Views.EntityViewProviderTag>.AOT();
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.IsViewRequested>.AOT();
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.AOT();
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.AOT();
            StaticTypes<ME.BECS.Views.ViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.ResourceTag>.AOT();
            AutoDestroyRegistryStatic<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.Destroy(null);
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.AOT();
            StaticTypesStatic<ME.BECS.Attack.AttackerFollowDistanceComponent>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletEffectOnDestroy>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoint>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoints>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestConfig1StaticComponent>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestConfig2StaticComponent>.AOT();
            StaticTypesStatic<ME.BECS.Units.UnitEffectOnDestroyComponent>.AOT();
            StaticTypesStatic<ME.BECS.Units.UnitEffectOnHitComponent>.AOT();
            StaticTypesStatic<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            StaticTypesStatic<ME.BECS.Views.InstantiateViewComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Attack.AttackComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Pathfinding.GraphMaskComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Views.InstantiateViewComponent>.AOT();
        }
    }
    public static unsafe class StaticTypesInitializer {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void Load() {
            JobUtils.Initialize();
            StaticSystemTypes<ME.BECS.Attack.CanFireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.FireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.MoveToAttackerSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.ReloadSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.ResetCanFireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.RotateWhileAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.SearchTargetSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.StopWhileAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Bullets.DestroySystem>.Validate();
            StaticSystemTypes<ME.BECS.Bullets.FlySystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandAttackCleanSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandBuildSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandBuildUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandMoveSystem>.Validate();
            StaticSystemTypes<ME.BECS.DestroyWithLifetimeSystem>.Validate();
            StaticSystemTypes<ME.BECS.DestroyWithTicksSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.CreateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.CreateTextureSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.DrawGizmosSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopySystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystemGPU>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.BuildGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.BuildPathSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.LookAtSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.ShowBuildingGridSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.UpdateGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Players.PlayersSystem>.Validate();
            StaticSystemTypes<ME.BECS.QuadTreeInsertSystem>.Validate();
            StaticSystemTypes<ME.BECS.QuadTreeQuerySystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.Validate();
            StaticSystemTypes<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.DestroySystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.HitSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.SteeringSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.SteeringWithAvoidanceSystem>.Validate();
            StaticSystemTypes<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.Validate();
            StaticSystemTypes<Source.Drones.Code.Systems.ExampleSystem>.Validate();
            StaticTypes<ME.BECS.Attack.AttackComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackerFollowDistanceComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackFilterComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackTargetsComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackTargetsCountComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackVisualComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.CanFireComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.ComebackAfterAttackComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.FireUsedComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.OnFireEvent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.ReloadedComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Attack.RotateToAttackWhileIdleComponent>.ApplyGroup(typeof(ME.BECS.Attack.AttackComponentGroup));
            StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.BulletEffectOnDestroy>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.BulletViewPoint>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.BulletViewPoints>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.DamageOverrideComponent>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.FirePointComponent>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Bullets.TargetReachedComponent>.ApplyGroup(typeof(ME.BECS.Bullets.BulletComponentGroup));
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.BuildInProgress>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandAttack>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandBuild>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandMove>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.ReceivedCommandFromUserEvent>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.DestroyWithLifetime>.ApplyGroup(typeof(ME.BECS.DestroyComponentGroup));
            StaticTypes<ME.BECS.DestroyWithLifetimeMs>.ApplyGroup(typeof(ME.BECS.DestroyComponentGroup));
            StaticTypes<ME.BECS.DestroyWithTicks>.ApplyGroup(typeof(ME.BECS.DestroyComponentGroup));
            StaticTypes<ME.BECS.Effects.EffectComponent>.ApplyGroup(typeof(ME.BECS.Effects.EffectComponentGroup));
            StaticTypes<ME.BECS.EntityConfigComponent>.ApplyGroup(typeof(ME.BECS.EntityConfigComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.IsInactive>.ApplyGroup(typeof(ME.BECS.CoreComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.AgentComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.RootGraphComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.TargetComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.TargetInfoComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Pathfinding.TargetPathComponent>.ApplyGroup(typeof(ME.BECS.Pathfinding.PathfindingComponentGroup));
            StaticTypes<ME.BECS.Players.IsPlayerDefeatTag>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.Players.IsPlayerVictoryTag>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.Players.OwnerChangedEvent>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.Players.OwnerComponent>.ApplyGroup(typeof(ME.BECS.Players.UnitOwnerComponentGroup));
            StaticTypes<ME.BECS.Players.PlayerComponent>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.Players.PlayerCurrentSelection>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.Players.TeamComponent>.ApplyGroup(typeof(ME.BECS.Players.PlayersComponentGroup));
            StaticTypes<ME.BECS.QuadTreeElement>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.QuadTreeElementRect>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.QuadTreeHeightComponent>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.QuadTreeQuery>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.QuadTreeQueryHasCustomFilterTag>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.QuadTreeResult>.ApplyGroup(typeof(ME.BECS.QuadTreeComponentGroup));
            StaticTypes<ME.BECS.Tests.TestComponent>.ApplyGroup(typeof(ME.BECS.Tests.TestGroup));
            StaticTypes<ME.BECS.TNull>.ApplyGroup(typeof(ME.BECS.CoreComponentGroup));
            StaticTypes<ME.BECS.Transforms.BoundsSizeComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalMatrixComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformMatrixComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.ParentComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformMatrixComponentGroup));
            StaticTypes<ME.BECS.UI.UIComponent>.ApplyGroup(typeof(ME.BECS.UI.UIComponentGroup));
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.DamageTookComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.DamageTookEvent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.PathFollowComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitBelongsToComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitEffectOnDestroyComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitEffectOnHitComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitIsCollideWithEnd>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitIsDeadTag>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Views.AssignViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.CameraComponent>.ApplyGroup(typeof(ME.BECS.Views.CameraComponentGroup));
            StaticTypes<ME.BECS.Views.DrawMeshProviderTag>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.EntityViewProviderTag>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.IsViewRequested>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.ViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackComponent>.SetDefaultValue(ME.BECS.Attack.AttackComponent.Default);
            StaticTypes<ME.BECS.Attack.AttackFilterComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackTargetsComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackTargetsCountComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackVisualComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.CanFireComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.ComebackAfterAttackComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.FireUsedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.OnFireEvent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.ReloadedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.SetDefaultValue(ME.BECS.Attack.RotateAttackSensorComponent.Default);
            StaticTypes<ME.BECS.Attack.RotateToAttackWhileIdleComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.DamageOverrideComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.FirePointComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.TargetReachedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.BuildInProgress>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandAttack>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandBuild>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandMove>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.ReceivedCommandFromUserEvent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.DestroyWithLifetime>.Validate(isTag: false);
            StaticTypes<ME.BECS.DestroyWithLifetimeMs>.Validate(isTag: false);
            StaticTypes<ME.BECS.DestroyWithTicks>.Validate(isTag: false);
            StaticTypes<ME.BECS.Effects.EffectComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.EntityConfigComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>.Validate(isTag: false);
            StaticTypes<ME.BECS.IsInactive>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.AgentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.RootGraphComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetInfoComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetPathComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.IsPlayerDefeatTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Players.IsPlayerVictoryTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Players.OwnerChangedEvent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.OwnerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.PlayerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.PlayerCurrentSelection>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.TeamComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeElement>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeElementRect>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeHeightComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeQuery>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeQueryHasCustomFilterTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.QuadTreeResult>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.T1>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.T2>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test2Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test3Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test4Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test5Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestComponentTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestTargetComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.TNull>.Validate(isTag: true);
            StaticTypes<ME.BECS.Transforms.BoundsSizeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.BoundsSizeComponent>.SetDefaultValue(ME.BECS.Transforms.BoundsSizeComponent.Default);
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Transforms.LocalMatrixComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.SetDefaultValue(ME.BECS.Transforms.LocalRotationComponent.Default);
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.SetDefaultValue(ME.BECS.Transforms.LocalScaleComponent.Default);
            StaticTypes<ME.BECS.Transforms.ParentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.UI.UIComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.DamageTookComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.DamageTookEvent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.NavAgentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.PathFollowComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitBelongsToComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.UnitIsCollideWithEnd>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.UnitIsDeadTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.AssignViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.CameraComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.DrawMeshProviderTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.EntityViewProviderTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.IsViewRequested>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.ViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.Validate(isTag: false);
            StaticTypes<Source.Drones.Code.Components.ResourceTag>.Validate(isTag: true);
            StaticTypesDestroy<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.RegisterAutoDestroy(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.ValidateShared(isTag: false, hasCustomHash: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.ValidateShared(isTag: false, hasCustomHash: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Attack.AttackerFollowDistanceComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletEffectOnDestroy>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoint>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoints>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1StaticComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2StaticComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnDestroyComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnHitComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.ValidateStatic(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            AspectTypeInfo<ME.BECS.Attack.AttackAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Attack.AttackComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.typeId;
            AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.typeId;
            AspectTypeInfo<ME.BECS.Effects.EffectAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Effects.EffectAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Effects.EffectAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Effects.EffectComponent>.typeId;
            AspectTypeInfo<ME.BECS.Players.PlayerAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.PlayerAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.PlayerAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Players.PlayerComponent>.typeId;
            AspectTypeInfo<ME.BECS.Players.TeamAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.TeamAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.TeamAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Players.TeamComponent>.typeId;
            AspectTypeInfo<ME.BECS.QuadTreeAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeAspect>.typeId).Get(0) = StaticTypes<ME.BECS.QuadTreeElement>.typeId;
            AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.typeId).Get(0) = StaticTypes<ME.BECS.QuadTreeQuery>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Aspect1>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.Test1Component>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Get(1) = StaticTypes<ME.BECS.Tests.Test2Component>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Aspect2>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.Test3Component>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Get(1) = StaticTypes<ME.BECS.Tests.Test4Component>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Test2Aspect>.Validate();
            AspectTypeInfo<ME.BECS.Tests.TestAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.TestAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.TestAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.TestComponent>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Tests_Aspects.TestAspect>.Validate();
            AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Resize(4);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(2) = StaticTypes<ME.BECS.Transforms.LocalMatrixComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(3) = StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Resize(5);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.NavAgentComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(2) = StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(3) = StaticTypes<ME.BECS.Units.UnitHealthComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(4) = StaticTypes<ME.BECS.Players.OwnerComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.CommandGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.SelectionGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.SelectionGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Views.CameraAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Views.CameraAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Views.CameraAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Views.CameraComponent>.typeId;
            StaticTypes.collectionsCount.Resize(StaticTypes.counter + 1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Bullets.BulletViewPoints>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.SetCollectionsCount(1u);
            #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
            DebugJobs.InitializeJobsDebug();
            #endif
            EarlyInit.DoComponents<ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job1>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job2>();
            EarlyInit.DoComponents<ME.BECS.Commands.CommandAttackCleanSystem.RemoveJob, ME.BECS.Commands.UnitAttackCommandComponent>();
            EarlyInit.DoComponents<ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob, ME.BECS.Commands.BuildingInProgress>();
            EarlyInit.DoComponents<ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob, ME.BECS.Commands.BuildInProgress>();
            EarlyInit.DoComponents<ME.BECS.DestroyWithLifetimeSystem.LifetimeJob, ME.BECS.DestroyWithLifetime>();
            EarlyInit.DoComponents<ME.BECS.DestroyWithLifetimeSystem.LifetimeMsJob, ME.BECS.DestroyWithLifetimeMs>();
            EarlyInit.DoComponents<ME.BECS.DestroyWithTicksSystem.Job, ME.BECS.DestroyWithTicks>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopySystem.CreateJob, ME.BECS.Players.OwnerComponent, ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob, ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob, ME.BECS.FogOfWar.FogOfWarShadowCopyComponent, ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent, ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRectJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob, ME.BECS.Pathfinding.TargetComponent>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob, ME.BECS.Pathfinding.TargetPathComponent>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob, ME.BECS.Pathfinding.GraphMaskComponent, ME.BECS.Pathfinding.GraphMaskRuntimeComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor, ME.BECS.Tests.TestTargetComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job1Unsafe, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job2Unsafe, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.JobComponents, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Units.HitSystem.Job, ME.BECS.Units.DamageTookComponent>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobAddToScene, ME.BECS.Views.IsViewRequested>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobAssignViews, ME.BECS.Views.AssignViewComponent>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobRemoveFromScene, ME.BECS.Views.ViewComponent>();
            EarlyInit.DoAspect<ME.BECS.Attack.CanFireSystem.Job, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetJob, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem.TargetsJob, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.FireSystem.FireTargetJob, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.FireSystem.FireTargetsJob, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ReloadSystem.ReloadJob, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ResetCanFireSystem.Job, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.RotateWhileAttackSystem.IdleJob, ME.BECS.Units.UnitAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.SearchTargetSystem.SearchTargetJob, ME.BECS.Attack.AttackAspect, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.StopWhileAttackSystem.JobRemove, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.StopWhileAttackSystem.JobRotate, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Bullets.DestroySystem.DestroyJob, ME.BECS.Bullets.BulletAspect, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Bullets.FlySystem.FlyJob, ME.BECS.Bullets.BulletAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandAttackSystem.CleanUpJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandAttackSystem.MoveJob, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandBuildSystem.Job, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandMoveSystem.Job, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.FogOfWar.CreateSystem.CleanUpJob, ME.BECS.Players.TeamAspect>();
            EarlyInit.DoAspect<ME.BECS.FogOfWar.CreateSystem.CreateJob, ME.BECS.Players.TeamAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.LookAtSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.QuadTreeInsertSystem.CollectJob, ME.BECS.QuadTreeAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.QuadTreeInsertSystem.CollectRectJob, ME.BECS.QuadTreeAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.QuadTreeQuerySystem.Job, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Aspects.TestJobFor, ME.BECS.Tests.Test2Aspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Aspects.TestSetJob, ME.BECS.Tests.Test2Aspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Queries.TestA1Job, ME.BECS.Tests.TestAspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Queries.TestA2Job, ME.BECS.Tests.TestAspect>();
            EarlyInit.DoAspect<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateJob, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateLocalMatrixJob, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.ClearJob, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.DestroySystem.DestroyJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.SteeringSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.SteeringWithAvoidanceSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspectsComponents2_1<ME.BECS.Attack.MoveToAttackerSystem.ComebackAfterAttackJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect, ME.BECS.Attack.ComebackAfterAttackComponent>();
            EarlyInit.DoAspectsComponents2_1<ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob, ME.BECS.Units.UnitAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.DamageTookEvent>();
            EarlyInit.DoAspectsComponents1_1<ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob, ME.BECS.Units.UnitAspect, ME.BECS.Commands.UnitAttackCommandComponent>();
            EarlyInit.DoAspectsComponents1_1<ME.BECS.Attack.MoveToAttackerSystem.UpdatePathJob, ME.BECS.Units.UnitCommandGroupAspect, ME.BECS.Commands.CommandAttack>();
            EarlyInit.DoAspectsComponents3_1<ME.BECS.Attack.SearchTargetSystem.SearchTargetsJob, ME.BECS.Attack.AttackAspect, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.Attack.AttackTargetsCountComponent>();
            EarlyInit.DoAspectsComponents1_1<ME.BECS.Attack.StopWhileAttackSystem.JobSet, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.ParentComponent>();
            EarlyInit.DoAspectsComponents2_1<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>();
            EarlyInit.DoAspectsComponents1_2<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Transforms.ParentComponent, ME.BECS.Transforms.IsFirstLevelComponent>();
        }
    }
    [UnityEngine.Scripting.PreserveAttribute]
    [UnityEngine.DefaultExecutionOrder(-100_000)]
    [BURST]
    public static unsafe class StaticMethods {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void Load() {
            Worlds.Initialize();
            SystemsStatic.Initialize();
            StaticTypesInitializer.Load();
            GlobalEvents.Initialize();
            CustomModules.InvokeResetPass();
            WorldStaticCallbacks.RegisterCallback<World>(AspectsConstruct);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponent);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestListComponent);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Bullets.BulletViewPoints>(EntityConfigComponentApplyME_BECS_Bullets_BulletViewPoints);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentStatic);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentShared);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Network.UnsafeNetworkModule.MethodsStorage>(NetworkLoad);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Views.ViewsModuleData>(ViewsLoad);
            EntityConfigRegistry.Initialize();
            EntityConfigsRegistry.Initialize(true);
            CustomModules.InvokeFirstPass();
            CustomModules.InvokeSecondPass();
        }
        private static s::Dictionary<System.Type, s::HashSet<System.Type>> systemDependenciesGraph;
        private static s::Dictionary<System.Type, s::List<ComponentDependencyGraphInfo>> systemDependenciesComponentsGraph;
        private static s::Dictionary<System.Type, s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>> systemDependenciesGraphErrors;
        public static s::List<ComponentDependencyGraphInfo> GetSystemComponentsDependencies(System.Type type) { InitializeSystemDependenciesInfo(); return systemDependenciesComponentsGraph[type]; }
        public static s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error> GetSystemDependenciesErrors(System.Type type) { InitializeSystemDependenciesInfo(); return systemDependenciesGraphErrors[type]; }
        public static s::HashSet<System.Type> GetSystemDependencies(System.Type type) { InitializeSystemDependenciesInfo(); return systemDependenciesGraph[type]; }
        public static void InitializeSystemDependenciesInfo() {
            if (systemDependenciesGraph != null) return;
            systemDependenciesGraph = new s::Dictionary<System.Type, s::HashSet<System.Type>>();
            systemDependenciesComponentsGraph = new s::Dictionary<System.Type, s::List<ComponentDependencyGraphInfo>>();
            systemDependenciesGraphErrors = new s::Dictionary<System.Type, s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>>();
            {
                // system: ME.BECS.Attack.CanFireSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.CanFireSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.CanFireSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Attack.CanFireWhileMovesTag
                // |--- ReadWrite: ME.BECS.Attack.ReloadedComponent
                // |--- ReadWrite: ME.BECS.Attack.CanFireComponent
                // |--- ReadWrite: ME.BECS.Attack.FireUsedComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireWhileMovesTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.ReloadedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.FireUsedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarShadowCopyComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadWrite: ME.BECS.Attack.CanFireComponent
                // |--- ReadWrite: ME.BECS.Attack.FireUsedComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.FireUsedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.FireSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.FireSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.FireSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Attack.AttackVisualComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadWrite: ME.BECS.Bullets.FirePointComponent
                // |--- ReadWrite: ME.BECS.Attack.FireUsedComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Bullets.BulletConfigComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadWrite: ME.BECS.DestroyWithLifetime
                // |--- ReadWrite: ME.BECS.DestroyWithLifetimeMs
                // |--- ReadWrite: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerChangedEvent
                // |--- ReadOnly: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Units.UnitQuadSizeComponent
                // |--- ReadWrite: ME.BECS.Bullets.DamageOverrideComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Views.ViewComponent
                // |--- ReadWrite: ME.BECS.Views.IsViewRequested
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadWrite: ME.BECS.QuadTreeQuery
                // |--- ReadWrite: ME.BECS.Bullets.BulletRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.EntityConfigComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadOnly: ME.BECS.Attack.ReloadedComponent
                // |--- ReadOnly: ME.BECS.Attack.CanFireComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackVisualComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.FirePointComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.FireUsedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletConfigComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetime), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetimeMs), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerChangedEvent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitQuadSizeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.DamageOverrideComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.ViewComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.IsViewRequested), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.EntityConfigComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.ReloadedComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.MoveToAttackerSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.MoveToAttackerSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.MoveToAttackerSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Units.DamageTookEvent
                // |--- ReadWrite: ME.BECS.Units.UnitLookAtComponent
                // |--- ReadWrite: ME.BECS.Attack.ComebackAfterAttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadWrite: ME.BECS.Commands.CommandMove
                // |--- ReadWrite: ME.BECS.Commands.CommandAttack
                // |--- ReadOnly: ME.BECS.EntityConfigComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.Units.UnitQuadSizeComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackFilterComponent
                // |--- ReadOnly: ME.BECS.Units.UnitBelongsToComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetInfoComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetComponent
                // |--- ReadWrite: ME.BECS.Units.PathFollowComponent
                // |--- ReadWrite: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadWrite: ME.BECS.Commands.UnitAttackCommandComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackerFollowDistanceComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadOnly: ME.BECS.Commands.ReceivedCommandFromUserEvent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.DamageTookEvent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitLookAtComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.ComebackAfterAttackComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.CommandMove), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.CommandAttack), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.EntityConfigComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitQuadSizeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackFilterComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitBelongsToComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetInfoComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.UnitAttackCommandComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackerFollowDistanceComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.ReceivedCommandFromUserEvent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.ReloadSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.ReloadSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.ReloadSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Attack.ReloadedComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.ReloadedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.ResetCanFireSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.ResetCanFireSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.ResetCanFireSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Attack.CanFireComponent
                // |--- ReadWrite: ME.BECS.Attack.FireUsedComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadOnly: ME.BECS.Attack.CanFireWhileMovesTag
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.FireUsedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireWhileMovesTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.RotateWhileAttackSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.RotateWhileAttackSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.RotateWhileAttackSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Attack.RotateAttackSensorComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Attack.RotateToAttackWhileIdleComponent
                // |--- ReadOnly: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.RotateAttackSensorComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.RotateToAttackWhileIdleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.SearchTargetSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.SearchTargetSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.SearchTargetSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Commands.UnitAttackCommandComponent
                // |--- ReadOnly: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackTargetsComponent
                // |--- ReadWrite: ME.BECS.Attack.CanFireComponent
                // |--- ReadWrite: ME.BECS.Attack.FireUsedComponent
                // |--- ReadWrite: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetsCountComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.UnitAttackCommandComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.FireUsedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetsCountComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Attack.StopWhileAttackSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Attack.StopWhileAttackSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Attack.StopWhileAttackSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeFireComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackTargetComponent
                // |--- ReadOnly: ME.BECS.Units.PathFollowComponent
                // |--- ReadWrite: ME.BECS.Units.UnitHoldComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Attack.CanFireWhileMovesTag
                // |--- ReadOnly: ME.BECS.Attack.RotateAttackSensorComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackComponent
                // |--- ReadOnly: ME.BECS.Attack.AttackRuntimeReloadComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeFireComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackTargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.CanFireWhileMovesTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.RotateAttackSensorComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Attack.AttackRuntimeReloadComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Bullets.DestroySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Bullets.DestroySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Bullets.DestroySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Bullets.BulletConfigComponent
                // |--- ReadOnly: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Bullets.BulletRuntimeComponent
                // |--- ReadOnly: ME.BECS.Bullets.BulletEffectOnDestroy
                // |--- ReadOnly: ME.BECS.Bullets.DamageOverrideComponent
                // |--- ReadWrite: ME.BECS.Units.DamageTookComponent
                // |--- ReadOnly: ME.BECS.Units.DamageTookEvent
                // |--- ReadOnly: ME.BECS.Units.UnitEffectOnHitComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadWrite: ME.BECS.DestroyWithTicks
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerChangedEvent
                // |--- ReadWrite: ME.BECS.DestroyWithLifetimeMs
                // |--- ReadWrite: ME.BECS.DestroyWithLifetime
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadWrite: ME.BECS.EntityConfigComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Bullets.TargetReachedComponent
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletConfigComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletEffectOnDestroy), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.DamageOverrideComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.DamageTookComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.DamageTookEvent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitEffectOnHitComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithTicks), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerChangedEvent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetimeMs), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetime), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.EntityConfigComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.TargetReachedComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Bullets.FlySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Bullets.FlySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Bullets.FlySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Bullets.BulletConfigComponent
                // |--- ReadWrite: ME.BECS.Bullets.TargetReachedComponent
                // |--- ReadWrite: ME.BECS.Bullets.BulletRuntimeComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.QuadTreeQuery
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.QuadTreeInsertSystem
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletConfigComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.TargetReachedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Bullets.BulletRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeInsertSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Commands.CommandAttackCleanSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Commands.CommandAttackCleanSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Commands.CommandAttackCleanSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Commands.UnitAttackCommandComponent
                // |--- ReadWrite: ME.BECS.Units.UnitHoldComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.UnitAttackCommandComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Commands.CommandAttackSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Commands.CommandAttackSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Commands.CommandAttackSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Commands.CommandAttack
                // |--- ReadWrite: ME.BECS.Commands.UnitAttackCommandComponent
                // |--- ReadOnly: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.UnitHoldComponent
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.CommandAttack), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.UnitAttackCommandComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Commands.CommandBuildSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Commands.CommandBuildSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Commands.CommandBuildSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Commands.CommandBuild
                // |--- ReadOnly: ME.BECS.Pathfinding.GraphMaskComponent
                // |--- ReadWrite: ME.BECS.Commands.BuildInProgress
                // |--- ReadWrite: ME.BECS.Commands.BuildingInProgress
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadWrite: ME.BECS.IsInactive
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.CommandBuild), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.GraphMaskComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.BuildInProgress), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.BuildingInProgress), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
            }
            {
                // system: ME.BECS.Commands.CommandBuildUpdateSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Commands.CommandBuildUpdateSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Commands.CommandBuildUpdateSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Commands.BuildInProgress
                // |--- ReadWrite: ME.BECS.Commands.BuildingInProgress
                // |--- ReadWrite: ME.BECS.IsInactive
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.BuildInProgress), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.BuildingInProgress), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
            }
            {
                // system: ME.BECS.Commands.CommandMoveSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Commands.CommandMoveSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Commands.CommandMoveSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Commands.CommandMove
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetInfoComponent
                // |--- ReadWrite: ME.BECS.Units.UnitHoldComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetComponent
                // |--- ReadWrite: ME.BECS.Units.PathFollowComponent
                // |--- ReadWrite: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Commands.CommandMove), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetInfoComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.DestroyWithLifetimeSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.DestroyWithLifetimeSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.DestroyWithLifetimeSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.DestroyWithLifetime
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.DestroyWithLifetimeMs
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetime), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetimeMs), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.DestroyWithTicksSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.DestroyWithTicksSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.DestroyWithTicksSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.DestroyWithTicks
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithTicks), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.FogOfWar.CreateSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.CreateSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.CreateSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.Players.TeamComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.Players.TeamComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.TeamComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 2 });
            }
            {
                // system: ME.BECS.FogOfWar.CreateTextureSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.CreateTextureSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.CreateTextureSystem), errors);
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Views.ViewComponent
                // |--- ReadWrite: ME.BECS.Views.IsViewRequested
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.ViewComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.IsViewRequested), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
            }
            {
                // system: ME.BECS.FogOfWar.DrawGizmosSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.DrawGizmosSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.DrawGizmosSystem), errors);
            }
            {
                // system: ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadWrite: ME.BECS.QuadTreeResult
                // |--- ReadWrite: ME.BECS.QuadTreeInsertSystem
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeInsertSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.FogOfWar.ShadowCopySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.ShadowCopySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.ShadowCopySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarShadowCopyComponent
                // |--- ReadWrite: ME.BECS.Views.IsViewRequested
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Players.PlayersSystem
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.IsViewRequested), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayersSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.FogOfWar.ShadowCopyUpdateSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarShadowCopyComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag
                // |--- ReadWrite: ME.BECS.Views.IsViewRequested
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadWrite: ME.BECS.IsInactive
                // |--- ReadWrite: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.IsViewRequested), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
            }
            {
                // system: ME.BECS.FogOfWar.UpdateSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.UpdateSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.UpdateSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerComponent
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.FogOfWar.UpdateTextureSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateTextureSystem
                // |--- ReadWrite: ME.BECS.Players.PlayersSystem
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateTextureSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayersSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
            }
            {
                // system: ME.BECS.FogOfWar.UpdateTextureSystemGPU
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystemGPU), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystemGPU), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadWrite: ME.BECS.Players.PlayersSystem
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateTextureSystem
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // 
                errors.Add(new Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error() { code = Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error.Code.MethodNotRequired, message = "Method OnAwake doesn't require context.dependsOn.Complete() call." });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayersSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateTextureSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
            }
            {
                // system: ME.BECS.Pathfinding.BuildGraphSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.BuildGraphSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.BuildGraphSystem), errors);
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.Pathfinding.RootGraphComponent
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 2 });
            }
            {
                // system: ME.BECS.Pathfinding.BuildPathSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.BuildPathSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.BuildPathSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.TargetInfoComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetInfoComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Pathfinding.DrawGizmosGraphSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.DrawGizmosGraphSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.DrawGizmosGraphSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
            }
            {
                // system: ME.BECS.Pathfinding.FollowPathSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.FollowPathSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.FollowPathSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Pathfinding.TargetComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.AgentComponent
                // |--- ReadWrite: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetInfoComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeSpeedComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.AgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetInfoComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeSpeedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Pathfinding.TargetComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadOnly: ME.BECS.Pathfinding.AgentComponent
                // |--- ReadWrite: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetInfoComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeSpeedComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Units.IsCommandGroupDirty
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.AgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetInfoComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeSpeedComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsCommandGroupDirty), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Pathfinding.LookAtSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.LookAtSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.LookAtSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Units.UnitLookAtComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitLookAtComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Pathfinding.ShowBuildingGridSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.PlaceholderInvalidTagComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.PlaceholderInvalidTagComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
            }
            {
                // system: ME.BECS.Pathfinding.UpdateGraphSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Pathfinding.UpdateGraphSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Pathfinding.UpdateGraphSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Pathfinding.IsGraphMaskDirtyComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.GraphMaskComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.GraphMaskRuntimeComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.TargetPathComponent
                // |--- ReadWrite: ME.BECS.Pathfinding.BuildGraphSystem
                // |--- ReadWrite: ME.BECS.Pathfinding.RootGraphComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                // 
                errors.Add(new Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error() { code = Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error.Code.MethodCallRequired, message = "Method OnUpdate requires a context.dependsOn.Complete() before accessing components." });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.IsGraphMaskDirtyComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.GraphMaskComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.GraphMaskRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.TargetPathComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.BuildGraphSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Pathfinding.RootGraphComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Players.PlayersSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Players.PlayersSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Players.PlayersSystem), errors);
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.Players.PlayerComponent
                // |--- ReadWrite: ME.BECS.Players.TeamComponent
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.TeamComponent), op = 2 });
            }
            {
                // system: ME.BECS.QuadTreeInsertSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.QuadTreeInsertSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.QuadTreeInsertSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.QuadTreeHeightComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadWrite: ME.BECS.QuadTreeElement
                // |--- ReadOnly: ME.BECS.QuadTreeElementRect
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeHeightComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeElement), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeElementRect), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.QuadTreeQuerySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.QuadTreeQuerySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.QuadTreeQuerySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadWrite: ME.BECS.QuadTreeResult
                // |--- ReadWrite: ME.BECS.QuadTreeInsertSystem
                // |--- ReadOnly: ME.BECS.QuadTreeQueryHasCustomFilterTag
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeInsertSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQueryHasCustomFilterTag), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Components_OneShot+TestCurrentTickSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem), errors);
                // 
                errors.Add(new Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error() { code = Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error.Code.MethodNotRequired, message = "Method OnUpdate doesn't require context.dependsOn.Complete() call." });
            }
            {
                // system: ME.BECS.Tests.Tests_Components_OneShot+TestNextTickSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem), errors);
                // 
                errors.Add(new Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error() { code = Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error.Code.MethodNotRequired, message = "Method OnUpdate doesn't require context.dependsOn.Complete() call." });
            }
            {
                // system: ME.BECS.Tests.Tests_GlobalEvents+TestSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_GlobalEvents.TestSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_GlobalEvents.TestSystem), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Queries_Static+TestSystem1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem1), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Queries_Static+TestSystem2
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem2), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem2), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Queries_Static+TestSystem3
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem3), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem3), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Queries_Static+TestSystem4
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem4), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem4), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Tests.TestComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.TestComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Queries_Static+TestSystemDefer1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem1_1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem1_2
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem1_3
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem1_4
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem2_1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem2_2
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem2_3
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem2_4
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestGraphSystem3_1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1), errors);
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestSystem1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem1), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Tests.TestComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.TestComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestSystem2_1
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Tests.Test2Component
                // |--- ReadOnly: ME.BECS.Tests.TestComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.Test2Component), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.TestComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestSystem2_2
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Tests.Test3Component
                // |--- ReadOnly: ME.BECS.Tests.TestComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.Test3Component), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.TestComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Tests.Tests_Systems_Graph+TestSystem3
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem3), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem3), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Tests.TestComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Tests.TestComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Transforms.TransformWorldMatrixUpdateSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                // |- OnAwake:
                // |--- ReadWrite: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                // |- OnStart:
                // |--- ReadWrite: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Units.DestroySystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Units.DestroySystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Units.DestroySystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Units.UnitEffectOnDestroyComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerChangedEvent
                // |--- ReadWrite: ME.BECS.DestroyWithLifetimeMs
                // |--- ReadWrite: ME.BECS.DestroyWithLifetime
                // |--- ReadWrite: ME.BECS.Units.UnitIsDeadTag
                // |--- ReadWrite: ME.BECS.DestroyWithTicks
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadWrite: ME.BECS.EntityConfigComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadWrite: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadWrite: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadWrite: ME.BECS.Units.SelectionGroupComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.CommandGroupComponent
                // |--- ReadWrite: ME.BECS.Transforms.ParentComponent
                // |--- ReadWrite: ME.BECS.Transforms.ChildrenComponent
                // |--- ReadWrite: ME.BECS.Transforms.IsFirstLevelComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitEffectOnDestroyComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerChangedEvent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetimeMs), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithLifetime), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsDeadTag), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.DestroyWithTicks), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.EntityConfigComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.SelectionGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.CommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ChildrenComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.IsFirstLevelComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Units.HitSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Units.HitSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Units.HitSystem), errors);
                // |- OnUpdate:
                // |--- ReadWrite: ME.BECS.Units.DamageTookComponent
                // |--- ReadWrite: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.DamageTookComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Units.SteeringSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Units.SteeringSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Units.SteeringSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadOnly: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.Units.SteeringWithAvoidanceSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.Units.SteeringWithAvoidanceSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.Units.SteeringWithAvoidanceSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.QuadTreeQuery
                // |--- ReadOnly: ME.BECS.QuadTreeResult
                // |--- ReadOnly: ME.BECS.Transforms.LocalRotationComponent
                // |--- ReadOnly: ME.BECS.Units.PathFollowComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHoldComponent
                // |--- ReadWrite: ME.BECS.Units.UnitIsCollideWithEnd
                // |--- ReadOnly: ME.BECS.Transforms.LocalPositionComponent
                // |--- ReadOnly: ME.BECS.Transforms.ParentComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalScaleComponent
                // |--- ReadWrite: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadWrite: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Units.IsUnitStaticComponent
                // |--- ReadOnly: ME.BECS.Transforms.LocalMatrixComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeQuery), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.QuadTreeResult), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalRotationComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.PathFollowComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHoldComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitIsCollideWithEnd), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalPositionComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.ParentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalScaleComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.IsUnitStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.LocalMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: ME.BECS.UnitsHealthBars.DrawHealthBarsSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem), list);
                systemDependenciesGraphErrors.Add(typeof(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem), errors);
                // |- OnUpdate:
                // |--- ReadOnly: ME.BECS.Units.UnitHealthComponent
                // |--- ReadOnly: ME.BECS.Units.NavAgentRuntimeComponent
                // |--- ReadOnly: ME.BECS.Players.PlayerComponent
                // |--- ReadOnly: ME.BECS.Players.OwnerComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarComponent
                // |--- ReadOnly: ME.BECS.FogOfWar.FogOfWarStaticComponent
                // |--- ReadOnly: ME.BECS.Transforms.WorldMatrixComponent
                // |--- ReadOnly: ME.BECS.Views.CameraComponent
                // |--- ReadWrite: ME.BECS.FogOfWar.CreateSystem
                // |--- ReadWrite: ME.BECS.Players.PlayersSystem
                // |--- ReadOnly: ME.BECS.Units.NavAgentComponent
                // |--- ReadOnly: ME.BECS.Units.UnitCommandGroupComponent
                // |--- ReadOnly: ME.BECS.Units.UnitSelectionGroupComponent
                // |--- ReadOnly: ME.BECS.IsInactive
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitHealthComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentRuntimeComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.OwnerComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.FogOfWarStaticComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Transforms.WorldMatrixComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Views.CameraComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.FogOfWar.CreateSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Players.PlayersSystem), op = 2 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.NavAgentComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitCommandGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.Units.UnitSelectionGroupComponent), op = 0 });
                list.Add(new ComponentDependencyGraphInfo() { type = typeof(ME.BECS.IsInactive), op = 0 });
            }
            {
                // system: Source.Drones.Code.Systems.ExampleSystem
                var list = new s::List<ComponentDependencyGraphInfo>();
                var errors = new s::List<Systems.SystemDependenciesCodeGenerator.MethodInfoDependencies.Error>();
                systemDependenciesComponentsGraph.Add(typeof(Source.Drones.Code.Systems.ExampleSystem), list);
                systemDependenciesGraphErrors.Add(typeof(Source.Drones.Code.Systems.ExampleSystem), errors);
            }
            // Nodes:
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.CanFireSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.ResetCanFireSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.ResetCanFireSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.FireSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.ResetCanFireSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.MoveToAttackerSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.ReloadSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.ResetCanFireSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.RotateWhileAttackSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.SearchTargetSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.ResetCanFireSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Attack.StopWhileAttackSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.CanFireSystem),
                typeof(ME.BECS.Attack.ChangeAttackTargetFromShadowCopySystem),
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.ReloadSystem),
                typeof(ME.BECS.Attack.ResetCanFireSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.SearchTargetSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Bullets.DestroySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Bullets.FlySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeInsertSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Commands.CommandAttackCleanSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Commands.CommandAttackSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Commands.CommandBuildSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Commands.CommandBuildUpdateSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Commands.CommandMoveSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.DestroyWithLifetimeSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.DestroyWithTicksSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.CreateSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Players.PlayersSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.CreateTextureSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeInsertSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.ShadowCopySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.UpdateSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Players.PlayersSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.FogOfWar.UpdateTextureSystemGPU),new s::HashSet<System.Type>() {
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Players.PlayersSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.BuildGraphSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.BuildPathSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.DrawGizmosGraphSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Pathfinding.BuildGraphSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.FollowPathSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.LookAtSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.UpdateGraphSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Pathfinding.UpdateGraphSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildGraphSystem),
                typeof(ME.BECS.Pathfinding.BuildPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Players.PlayersSystem),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.QuadTreeInsertSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.QuadTreeQuerySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeInsertSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_GlobalEvents.TestSystem),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem1),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem2),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem3),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystem4),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1),null);
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem1),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Tests.Tests_Systems_Graph.TestSystem3),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Units.DestroySystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Units.DestroySystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Units.HitSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Units.SteeringSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.Units.SteeringWithAvoidanceSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Attack.StopWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Bullets.FlySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandAttackSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.DestroyWithLifetimeSystem),
                typeof(ME.BECS.DestroyWithTicksSystem),
                typeof(ME.BECS.FogOfWar.CreateTextureSystem),
                typeof(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopySystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Pathfinding.LookAtSystem),
                typeof(ME.BECS.Pathfinding.ShowBuildingGridSystem),
                typeof(ME.BECS.QuadTreeQuerySystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem)
            });
            systemDependenciesGraph.Add(typeof(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem),new s::HashSet<System.Type>() {
                typeof(ME.BECS.Attack.FireSystem),
                typeof(ME.BECS.Attack.MoveToAttackerSystem),
                typeof(ME.BECS.Attack.RotateWhileAttackSystem),
                typeof(ME.BECS.Bullets.DestroySystem),
                typeof(ME.BECS.Commands.CommandAttackCleanSystem),
                typeof(ME.BECS.Commands.CommandBuildSystem),
                typeof(ME.BECS.Commands.CommandBuildUpdateSystem),
                typeof(ME.BECS.Commands.CommandMoveSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.CreateSystem),
                typeof(ME.BECS.FogOfWar.ShadowCopyUpdateSystem),
                typeof(ME.BECS.FogOfWar.UpdateSystem),
                typeof(ME.BECS.Pathfinding.FollowPathSystem),
                typeof(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Players.PlayersSystem),
                typeof(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem),
                typeof(ME.BECS.Units.DestroySystem),
                typeof(ME.BECS.Units.HitSystem),
                typeof(ME.BECS.Units.SteeringSystem),
                typeof(ME.BECS.Units.SteeringWithAvoidanceSystem)
            });
            systemDependenciesGraph.Add(typeof(Source.Drones.Code.Systems.ExampleSystem),null);
        }
        
        
        
        
        public static unsafe void AspectsConstruct(ref World world) {
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Attack.AttackAspect>();
                aspect.attackDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackComponent>(in world);
                aspect.attackRuntimeFireDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackRuntimeFireComponent>(in world);
                aspect.attackRuntimeReloadDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackRuntimeReloadComponent>(in world);
                aspect.targetDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackTargetComponent>(in world);
                aspect.targetsDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackTargetsComponent>(in world);
                aspect.attackVisualDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackVisualComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Bullets.BulletAspect>();
                aspect.bulletConfigDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Bullets.BulletConfigComponent>(in world);
                aspect.bulletRuntimeDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Bullets.BulletRuntimeComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Effects.EffectAspect>();
                aspect.effectDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Effects.EffectComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Players.PlayerAspect>();
                aspect.playerDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.PlayerComponent>(in world);
                aspect.playerCurrentSelectionDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.PlayerCurrentSelection>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Players.TeamAspect>();
                aspect.teamDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.TeamComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.QuadTreeAspect>();
                aspect.quadTreeElementPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeElement>(in world);
                aspect.quadTreeRectPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeElementRect>(in world);
                aspect.quadTreeHeightPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeHeightComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.QuadTreeQueryAspect>();
                aspect.queryPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeQuery>(in world);
                aspect.resultPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeResult>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Aspect1>();
                aspect.t1Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test1Component>(in world);
                aspect.t2Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test2Component>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Aspect2>();
                aspect.t1Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test3Component>(in world);
                aspect.t2Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test4Component>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Test2Aspect>();
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T1>(in world);
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T2>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.TestAspect>();
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test1Component>(in world);
                aspect.dataPtr2 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test2Component>(in world);
                aspect.dataPtr3 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test3Component>(in world);
                aspect.dataPtr4 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test4Component>(in world);
                aspect.dataPtr5 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test5Component>(in world);
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.TestComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Tests_Aspects.TestAspect>();
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T1>(in world);
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T2>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Transforms.TransformAspect>();
                aspect.boundsSizeData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.BoundsSizeComponent>(in world);
                aspect.childrenData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.ChildrenComponent>(in world);
                aspect.localMatrixData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalMatrixComponent>(in world);
                aspect.localPositionData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalPositionComponent>(in world);
                aspect.localRotationData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalRotationComponent>(in world);
                aspect.localScaleData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalScaleComponent>(in world);
                aspect.parentData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.ParentComponent>(in world);
                aspect.worldMatrixData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.WorldMatrixComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitAspect>();
                aspect.ownerDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.OwnerComponent>(in world);
                aspect.navAgentDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentComponent>(in world);
                aspect.navAgentRuntimeDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentRuntimeComponent>(in world);
                aspect.navAgentRuntimeSpeedDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(in world);
                aspect.unitCommandGroupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitCommandGroupComponent>(in world);
                aspect.healthDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitHealthComponent>(in world);
                aspect.unitSelectionGroupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitSelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitCommandGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.CommandGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitSelectionGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.SelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitSelectionTempGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.SelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Views.CameraAspect>();
                aspect.cameraDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Views.CameraComponent>(in world);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.UnsafeEntityConfig.MethodCallerDelegate))] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponent(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent.Test>(in ent, data, length);
                }
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.UnsafeEntityConfig.MethodCallerDelegate))] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestListComponent(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestListComponent*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.ListAuto<ME.BECS.Tests.Tests_EntityConfig.TestListComponent.Test>(in ent, data, length);
                }
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.UnsafeEntityConfig.MethodCallerDelegate))] public static unsafe void EntityConfigComponentApplyME_BECS_Bullets_BulletViewPoints(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Bullets.BulletViewPoints*)componentPtr;
                var res = config.GetCollectionById(component->points.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->points.IsCreated == true) component->points.Dispose();
                    component->points = new ME.BECS.MemArrayAuto<ME.BECS.Bullets.BulletViewPoint>(in ent, data, length);
                }
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.UnsafeEntityConfig.MethodCallerDelegate))] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentStatic(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic.Test>(in ent, data, length);
                }
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.UnsafeEntityConfig.MethodCallerDelegate))] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentShared(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared.Test>(in ent, data, length);
                }
            }
        }
        public static unsafe void NetworkLoad(ref ME.BECS.Network.UnsafeNetworkModule.MethodsStorage methods) {
            methods.Add(ME.BECS.Players.PlayersSystem.OnSetDefeatReceived);
        }
        public static unsafe void ViewsLoad(ref ME.BECS.Views.ViewsModuleData viewsModule) {
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.FogOfWar.FogOfWarView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)33,
                tracker = ViewsTracker.info[ViewsTracker.Tracker<ME.BECS.FogOfWar.FogOfWarView>.id],
            });
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.Pathfinding.Views.GridView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)49,
                tracker = ViewsTracker.info[ViewsTracker.Tracker<ME.BECS.Pathfinding.Views.GridView>.id],
            });
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.Views.DefaultView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)0,
                tracker = ViewsTracker.info[ViewsTracker.Tracker<ME.BECS.Views.DefaultView>.id],
            });
        }
    }
}
