using ME.BECS;
using ME.BECS.Jobs;
using ME.BECS.Views;
using Unity.Burst;

namespace Source.Drones.Code.Systems
{
  [BurstCompile]
  public struct LevelInitializeSystem : IAwake
  {
    public Config SpawnerConfig;

    public void OnAwake(ref SystemContext ctx)
    {
      var job = new LevelInitializeJob
      {
        SpawnerConfig = SpawnerConfig,
      };

      var handle = job.ScheduleSingle();

      ctx.SetDependency(handle);
    }
  }

  [BurstCompile]
  public struct LevelInitializeJob: IJobSingle
  {

    public Config SpawnerConfig;
    
    public void Execute()
    {
      var spawnerEnt = Ent.New("Spawner");
      SpawnerConfig.Apply(spawnerEnt);
    }
  }
}