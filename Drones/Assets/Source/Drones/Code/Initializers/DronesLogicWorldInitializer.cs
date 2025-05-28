using ME.BECS.Network;
using UnityEngine;

namespace Drones
{
  [DefaultExecutionOrder(-100)]
  public class DronesLogicWorldInitializer : NetworkWorldInitializer
  {
    public static DronesLogicWorldInitializer Instance;
        
    public NetworkModule GetNetworkModule() => Instance.networkModule;

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