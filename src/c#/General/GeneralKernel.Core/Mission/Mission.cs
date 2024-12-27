using GeneralKernel.Core.Payload;

namespace GeneralKernel.Core;

public class Mission
{
    public string Name { get; set; }
    
    public IReadOnlyDictionary<string, Point> Locations { get; set; }
    
    public IReadOnlyDictionary<string, Attitude> Attitudes { get; set; }
    
    public IEnumerable<IPayload> Payloads { get; set; }
    
    public DateTime CreateDateTime { get; set; }
    
    public MissionModel Model { get; set; }
    
    public MapType Map { get; set; }
    
    public string Directory { get; set; }
}