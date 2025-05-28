using ME.BECS;
using UnityEngine;

namespace Drones 
{
    [DefaultExecutionOrder(-80)]
    public class DronesVisualWorldInitializer : WorldInitializer 
    {
        public static DronesVisualWorldInitializer Instance;
        
        protected override void Awake() 
        {
            Instance = this;
            base.Awake();
        }
            
        protected override void DoWorldAwake() 
        {
            world.parent = Instance.world;
            base.DoWorldAwake();
        }
    }
}