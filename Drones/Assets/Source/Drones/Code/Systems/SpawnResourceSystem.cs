using ME.BECS;
using ME.BECS.Jobs;
using ME.BECS.Views;
using Source.Drones.Code.Components.DefaultComp;
using Unity.Burst;
using UnityEngine;

namespace Source.Drones.Code.Systems
{
  [BurstCompile]
  public struct SpawnResourceSystem : IUpdate
  {
    public Config ResourceConfig;

    public void OnUpdate(ref SystemContext ctx)
    {
      var spawnJob = new SpawnJob
      {
        Config = ResourceConfig,
        DeltaTime = ctx.deltaTime
      };
      
      var handle = ctx.Query()
        .With<ResourceSpawnerComponent>()
        .Schedule<SpawnJob, ResourceSpawnerComponent>(spawnJob);
      
      ctx.SetDependency(handle);
    }
  }

  [BurstCompile]
  public struct SpawnJob : IJobForComponents<ResourceSpawnerComponent>
  {
    public Config Config;
    public float DeltaTime;

    public void Execute(in JobInfo jobInfo, in Ent ent, ref ResourceSpawnerComponent spawner)
    {
      spawner.Timer -= DeltaTime;
      
      if (spawner.Timer > 0f)
        return;
      
      spawner.Timer = spawner.SpawnInterval;

      var resEnt = Ent.New(jobInfo, "Resource");
      Config.Apply(resEnt);
      resEnt.InstantiateView(resEnt.Get<DefaultViewComponent>().View);
    }
  }
}