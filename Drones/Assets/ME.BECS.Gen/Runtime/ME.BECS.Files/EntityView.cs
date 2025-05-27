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
    public class EntityViewsStaticTracker {
        public static void InitializeViewsTracker() {
            StaticTypes.SetTracker(18u);
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.TrackVersion();
            StaticTypes<ME.BECS.Units.NavAgentComponent>.TrackVersion();
            StaticTypes<ME.BECS.Attack.AttackTargetsComponent>.TrackVersion();
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.TrackVersion();
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.TrackVersion();
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.TrackVersion();
            StaticTypes<ME.BECS.Attack.AttackComponent>.TrackVersion();
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.TrackVersion();
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.TrackVersion();
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.TrackVersion();
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.TrackVersion();
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.TrackVersion();
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.TrackVersion();
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.TrackVersion();
            StaticTypes<ME.BECS.Transforms.ParentComponent>.TrackVersion();
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.TrackVersion();
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.TrackVersion();
            StaticTypes<ME.BECS.Views.CameraComponent>.TrackVersion();
            ViewsTracker.SetTracker(15u);
            // ==============================
            // ME.BECS.FogOfWar.FogOfWarView
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                viewInfo.tracker.Resize(6u);
                // OnUpdate:
                viewInfo.tracker.Get(0u) = StaticTypes<ME.BECS.Views.CameraComponent>.trackerIndex;
                // [ADD] ME.BECS.Views.CameraComponent + ReadOnly
                viewInfo.tracker.Get(1u) = StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalRotationComponent + ReadOnly
                viewInfo.tracker.Get(2u) = StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalPositionComponent + ReadOnly
                viewInfo.tracker.Get(3u) = StaticTypes<ME.BECS.Transforms.ParentComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.ParentComponent + ReadOnly
                viewInfo.tracker.Get(4u) = StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalScaleComponent + ReadOnly
                viewInfo.tracker.Get(5u) = StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.WorldMatrixComponent + ReadOnly
                ViewsTracker.TrackView<ME.BECS.FogOfWar.FogOfWarView>(viewInfo);
            }
            // ==============================
            // ME.BECS.Pathfinding.Views.GridView
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                viewInfo.tracker.Resize(7u);
                // ApplyState:
                viewInfo.tracker.Get(0u) = StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.trackerIndex;
                // [ADD] ME.BECS.Units.UnitQuadSizeComponent + ReadOnly
                viewInfo.tracker.Get(1u) = StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.trackerIndex;
                // [ADD] ME.BECS.Pathfinding.IsShowGridComponent + ReadOnly
                viewInfo.tracker.Get(2u) = StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.trackerIndex;
                // [ADD] ME.BECS.Pathfinding.PlaceholderInvalidTagComponent + ReadOnly
                viewInfo.tracker.Get(3u) = StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalRotationComponent + ReadOnly
                viewInfo.tracker.Get(4u) = StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalPositionComponent + ReadOnly
                viewInfo.tracker.Get(5u) = StaticTypes<ME.BECS.Transforms.ParentComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.ParentComponent + ReadOnly
                viewInfo.tracker.Get(6u) = StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.trackerIndex;
                // [ADD] ME.BECS.Transforms.LocalScaleComponent + ReadOnly
                ViewsTracker.TrackView<ME.BECS.Pathfinding.Views.GridView>(viewInfo);
            }
            // ==============================
            // ME.BECS.Views.DefaultView
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                ViewsTracker.TrackView<ME.BECS.Views.DefaultView>(viewInfo);
            }
            // ==============================
            // ME.BECS.Attack.AnimatorAttackViewModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                viewInfo.tracker.Resize(7u);
                // ApplyState:
                viewInfo.tracker.Get(0u) = StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.trackerIndex;
                // [ADD] ME.BECS.Units.NavAgentRuntimeComponent + ReadOnly
                viewInfo.tracker.Get(1u) = StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.trackerIndex;
                // [ADD] ME.BECS.Attack.AttackRuntimeFireComponent + ReadOnly
                viewInfo.tracker.Get(2u) = StaticTypes<ME.BECS.Attack.AttackComponent>.trackerIndex;
                // [ADD] ME.BECS.Attack.AttackComponent + ReadOnly
                viewInfo.tracker.Get(3u) = StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.trackerIndex;
                // [ADD] ME.BECS.Attack.AttackRuntimeReloadComponent + ReadOnly
                viewInfo.tracker.Get(4u) = StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.trackerIndex;
                // [ADD] ME.BECS.Attack.CanFireWhileMovesTag + ReadOnly
                viewInfo.tracker.Get(5u) = StaticTypes<ME.BECS.Attack.AttackTargetComponent>.trackerIndex;
                // [ADD] ME.BECS.Attack.AttackTargetComponent + ReadOnly
                viewInfo.tracker.Get(6u) = StaticTypes<ME.BECS.Attack.AttackTargetsComponent>.trackerIndex;
                // [ADD] ME.BECS.Attack.AttackTargetsComponent + ReadOnly
                // OnUpdate not found
                // OnInitialize not found
                // OnDeInitialize not found
                // OnEnableFromPool not found
                // OnDisableToPool not found
                ViewsTracker.TrackViewModule<ME.BECS.Attack.AnimatorAttackViewModule>(viewInfo);
            }
            // ==============================
            // ME.BECS.FogOfWar.FogOfWarViewModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                // Ignore tracker
                ViewsTracker.TrackViewModule<ME.BECS.FogOfWar.FogOfWarViewModule>(viewInfo);
            }
            // ==============================
            // ME.BECS.FogOfWar.ForOfWarCrossFadeViewModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                // Ignore tracker
                ViewsTracker.TrackViewModule<ME.BECS.FogOfWar.ForOfWarCrossFadeViewModule>(viewInfo);
            }
            // ==============================
            // ME.BECS.Units.AnimatorModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                viewInfo.tracker.Resize(2u);
                // ApplyState:
                viewInfo.tracker.Get(0u) = StaticTypes<ME.BECS.Units.NavAgentComponent>.trackerIndex;
                // [ADD] ME.BECS.Units.NavAgentComponent + ReadOnly
                viewInfo.tracker.Get(1u) = StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.trackerIndex;
                // [ADD] ME.BECS.Units.NavAgentRuntimeSpeedComponent + ReadOnly
                // OnUpdate not found
                // OnInitialize not found
                // OnDeInitialize not found
                // OnEnableFromPool not found
                // OnDisableToPool not found
                ViewsTracker.TrackViewModule<ME.BECS.Units.AnimatorModule>(viewInfo);
            }
            // ==============================
            // ME.BECS.Views.AnimatorViewModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                // OnUpdate not found
                // OnInitialize not found
                // OnDeInitialize not found
                // OnEnableFromPool not found
                // OnDisableToPool not found
                ViewsTracker.TrackViewModule<ME.BECS.Views.AnimatorViewModule>(viewInfo);
            }
            // ==============================
            // ME.BECS.Views.ResetTrailsModule
            {
                var viewInfo = new ViewsTracker.ViewInfo();
                // ApplyState not found
                // OnUpdate not found
                // OnDeInitialize not found
                // OnDisableToPool not found
                ViewsTracker.TrackViewModule<ME.BECS.Views.ResetTrailsModule>(viewInfo);
            }
        }
    }
    
     
}
