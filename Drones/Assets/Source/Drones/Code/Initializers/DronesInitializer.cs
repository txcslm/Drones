using ME.BECS;
using UnityEngine;

namespace Drones 
{
    [DefaultExecutionOrder(-80)]
    public class DronesInitializer : WorldInitializer 
    {
        public static DronesInitializer Instance;
        
        protected override void Awake() 
        {
            Instance = this;
            base.Awake();
        }
            
        protected override void DoWorldAwake() 
        {
            world.parent = DronesInitializer.Instance.world;
            base.DoWorldAwake();
        }
    }
}