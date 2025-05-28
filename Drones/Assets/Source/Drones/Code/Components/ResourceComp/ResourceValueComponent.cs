using ME.BECS;

namespace Source.Drones.Code.Components
{
  public struct ResourceValueComponent : IConfigComponent
  {
    public static ResourceValueComponent Default => new ResourceValueComponent() { Value = 1 };
    
    public int Value;
  }
}