using ME.BECS;
using ME.BECS.Jobs;
using ME.BECS.Views;
using Source.Drones.Code.Components.DefaultComp;
using Unity.Burst;

namespace Source.Drones.Code.Systems
{
  [BurstCompile]
  public struct SpawnResourceSystem : IUpdate
  {
    public View ResourceView;
    public Config ResourceConfig;

    public void OnUpdate(ref SystemContext ctx)
    {
      var handle = ctx.Query()
        .With<ResourceSpawnerComponent>()
        .Schedule<SpawnJob, ResourceSpawnerComponent>(new SpawnJob
        {
          View = ResourceView,
          Config = ResourceConfig,
          DeltaTime = ctx.deltaTime
        });
      
      ctx.SetDependency(handle);
    }
  }

  [BurstCompile]
  public struct SpawnJob : IJobForComponents<ResourceSpawnerComponent>
  {
    public View View;
    public Config Config;
    public float DeltaTime;

    public void Execute(in JobInfo jobInfo, in Ent ent, ref ResourceSpawnerComponent spawner)
    {
      spawner.Timer -= DeltaTime;
      
      if (spawner.Timer > 0f)
        return;
      
      spawner.Timer = spawner.SpawnInterval;

      var resEnt = Ent.New(jobInfo.worldId);
      Config.Apply(resEnt);
      resEnt.InstantiateView(View);
    }
  }
}