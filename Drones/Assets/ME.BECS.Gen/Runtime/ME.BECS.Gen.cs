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
            StaticTypes<CurrentResourceCountComponent>.AOT();
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
            StaticTypes<PositionComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.BaseComp.BaseTag>.AOT();
            StaticTypes<Source.Drones.Code.Components.BusyTagComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.DefaultComp.CurrentMoveSpeedComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.DefaultComp.InitialMoveSpeedComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.DefaultComp.SpawnPointComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.DroneComp.DroneTagComponent>.AOT();
            StaticTypes<Source.Drones.Code.Components.ResourceTagComponent>.AOT();
            AutoDestroyRegistryStatic<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.Destroy(null);
            StaticTypesStatic<ME.BECS.Attack.AttackerFollowDistanceComponent>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletEffectOnDestroy>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoint>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoints>.AOT();
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
            StaticTypes<CurrentResourceCountComponent>.Validate(isTag: false);
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
            StaticTypes<PositionComponent>.Validate(isTag: false);
            StaticTypes<Source.Drones.Code.Components.BaseComp.BaseTag>.Validate(isTag: true);
            StaticTypes<Source.Drones.Code.Components.BusyTagComponent>.Validate(isTag: true);
            StaticTypes<Source.Drones.Code.Components.DefaultComp.CurrentMoveSpeedComponent>.Validate(isTag: false);
            StaticTypes<Source.Drones.Code.Components.DefaultComp.InitialMoveSpeedComponent>.Validate(isTag: false);
            StaticTypes<Source.Drones.Code.Components.DefaultComp.SpawnPointComponent>.Validate(isTag: false);
            StaticTypes<Source.Drones.Code.Components.DroneComp.DroneTagComponent>.Validate(isTag: true);
            StaticTypes<Source.Drones.Code.Components.ResourceTagComponent>.Validate(isTag: true);
            StaticTypesDestroy<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.RegisterAutoDestroy(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackerFollowDistanceComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletEffectOnDestroy>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoint>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoints>.ValidateStatic(isTag: false);
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
            StaticTypes<ME.BECS.Bullets.BulletViewPoints>.SetCollectionsCount(1u);
            EntityViewsStaticTracker.InitializeViewsTracker();
            #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
            DebugJobs.InitializeJobsDebug();
            #endif
            EarlyInit.DoComponents<ME.BECS.Attack.MoveToAttackerSystem.RemoveComebackAfterAttackComponentJob>();
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
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Load() {
            Worlds.Initialize();
            SystemsStatic.Initialize();
            StaticTypesInitializer.Load();
            GlobalEvents.Initialize();
            CustomModules.InvokeResetPass();
            WorldStaticCallbacks.RegisterCallback<World>(AspectsConstruct);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Attack.AttackTargetsComponent>(CopyFromME_BECS_Attack_AttackTargetsComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Bullets.FirePointComponent>(CopyFromME_BECS_Bullets_FirePointComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Commands.BuildingInProgress>(CopyFromME_BECS_Commands_BuildingInProgress);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.FogOfWar.FogOfWarComponent>(CopyFromME_BECS_FogOfWar_FogOfWarComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>(CopyFromME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>(CopyFromME_BECS_FogOfWar_FogOfWarShadowCopyRequiredRuntimeComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.FogOfWar.FogOfWarStaticComponent>(CopyFromME_BECS_FogOfWar_FogOfWarStaticComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>(CopyFromME_BECS_Pathfinding_GraphMaskRuntimeComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Pathfinding.RootGraphComponent>(CopyFromME_BECS_Pathfinding_RootGraphComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Pathfinding.TargetPathComponent>(CopyFromME_BECS_Pathfinding_TargetPathComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.QuadTreeResult>(CopyFromME_BECS_QuadTreeResult);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Transforms.ChildrenComponent>(CopyFromME_BECS_Transforms_ChildrenComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Units.CommandGroupComponent>(CopyFromME_BECS_Units_CommandGroupComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Units.SelectionGroupComponent>(CopyFromME_BECS_Units_SelectionGroupComponent);
            WorldStaticCallbacks.RegisterCopyFromComponentCallback<ME.BECS.Views.CameraComponent>(CopyFromME_BECS_Views_CameraComponent);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Bullets.BulletViewPoints>(EntityConfigComponentApplyME_BECS_Bullets_BulletViewPoints);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Network.UnsafeNetworkModule.MethodsStorage>(NetworkLoad);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Views.ViewsModuleData>(ViewsLoad);
            EntityConfigRegistry.Initialize();
            EntityConfigsRegistry.Initialize();
            CustomModules.InvokeFirstPass();
            CustomModules.InvokeSecondPass();
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize() {
            CustomModules.RegisterFirstPass(SystemsLoad);
        }
        [UnityEngine.Scripting.PreserveAttribute]
        public static void SystemsLoad() {
            // Graph: Drones-Visual-FeatureGraph
            {
                SystemsStatic.RegisterMethod(GraphGraphDrones_Visual_FeatureGraphInitialize.GraphInitialize_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterAwakeMethod(GraphGraphDrones_Visual_FeatureGraphAwake.GraphOnAwake_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterStartMethod(GraphGraphDrones_Visual_FeatureGraphStart.GraphOnStart_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterUpdateMethod(GraphGraphDrones_Visual_FeatureGraphUpdate.GraphOnUpdate_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphGraphDrones_Visual_FeatureGraphDrawGizmos.GraphOnDrawGizmos_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterDestroyMethod(GraphGraphDrones_Visual_FeatureGraphDestroy.GraphOnDestroy_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGraphDrones_Visual_FeatureGraphInitialize.GraphGetSystem_1001_SystemsCodeGenerator, 1001, false);
            }
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
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Attack_AttackTargetsComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Attack.AttackTargetsComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Attack.AttackTargetsComponent>();
                target.targets = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->targets);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Bullets_FirePointComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Bullets.FirePointComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Bullets.FirePointComponent>();
                target.points = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->points);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Commands_BuildingInProgress(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Commands.BuildingInProgress*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Commands.BuildingInProgress>();
                target.builders = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->builders);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_FogOfWar_FogOfWarComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.FogOfWar.FogOfWarComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.FogOfWar.FogOfWarComponent>();
                target.nodes = new ME.BECS.MemArrayAuto<System.Byte>(in ent, in source->nodes);
            }
            {
                var source = (ME.BECS.FogOfWar.FogOfWarComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.FogOfWar.FogOfWarComponent>();
                target.explored = new ME.BECS.MemArrayAuto<System.Byte>(in ent, in source->explored);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>();
                target.points = new ME.BECS.MemArrayAuto<ME.BECS.FogOfWar.RectUInt>(in ent, in source->points);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_FogOfWar_FogOfWarShadowCopyRequiredRuntimeComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredRuntimeComponent>();
                target.shadowCopy = new ME.BECS.MemArrayAuto<ME.BECS.Ent>(in ent, in source->shadowCopy);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_FogOfWar_FogOfWarStaticComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.FogOfWar.FogOfWarStaticComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.FogOfWar.FogOfWarStaticComponent>();
                target.heights = new ME.BECS.MemArrayAuto<System.Single>(in ent, in source->heights);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Pathfinding_GraphMaskRuntimeComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Pathfinding.GraphMaskRuntimeComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>();
                target.nodes = new ME.BECS.ListAuto<ME.BECS.Pathfinding.GraphNodeMemory>(in ent, in source->nodes);
            }
            {
                var source = (ME.BECS.Pathfinding.GraphMaskRuntimeComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>();
                target.heights = new ME.BECS.MemArrayAuto<System.Single>(in ent, in source->heights);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Pathfinding_RootGraphComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Pathfinding.RootGraphComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Pathfinding.RootGraphComponent>();
                target.chunks = new ME.BECS.MemArrayAuto<ME.BECS.Pathfinding.ChunkComponent>(in ent, in source->chunks);
            }
            {
                var source = (ME.BECS.Pathfinding.RootGraphComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Pathfinding.RootGraphComponent>();
                target.changedChunks = new ME.BECS.MemArrayAuto<System.UInt64>(in ent, in source->changedChunks);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Pathfinding_TargetPathComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Pathfinding.TargetPathComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Pathfinding.TargetPathComponent>();
                target.chunksToUpdate = new ME.BECS.MemArrayAuto<System.Byte>(in ent, in source->chunksToUpdate);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_QuadTreeResult(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.QuadTreeResult*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.QuadTreeResult>();
                target.results = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->results);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Transforms_ChildrenComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Transforms.ChildrenComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Transforms.ChildrenComponent>();
                target.list = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->list);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Units_CommandGroupComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Units.CommandGroupComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Units.CommandGroupComponent>();
                target.units = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->units);
            }
            {
                var source = (ME.BECS.Units.CommandGroupComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Units.CommandGroupComponent>();
                target.targets = new ME.BECS.MemArrayAuto<ME.BECS.Ent>(in ent, in source->targets);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Units_SelectionGroupComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Units.SelectionGroupComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Units.SelectionGroupComponent>();
                target.units = new ME.BECS.ListAuto<ME.BECS.Ent>(in ent, in source->units);
            }
        }
        [BURST] [AOT.MonoPInvokeCallbackAttribute(typeof(ME.BECS.WorldStaticCallbacks.CopyFromComponentCallbackDelegate))] public static unsafe void CopyFromME_BECS_Views_CameraComponent(void* componentPtr, in Ent ent) {
            {
                var source = (ME.BECS.Views.CameraComponent*)componentPtr;
                ref var target = ref ent.Get<ME.BECS.Views.CameraComponent>();
                target.localPlanes = new ME.BECS.MemArrayAuto<UnityEngine.Plane>(in ent, in source->localPlanes);
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
