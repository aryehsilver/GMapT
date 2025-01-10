using GoogleMapsComponents.Maps;

namespace GMapT.Client.Pages;
public partial class MultiCard {
  public TClient TheClient { get; set; } = new() {
    Properties = [
      new() { Id = 1, Name = "Property 1", Lat = 53.6865494, Lng = -2.1476396 },
      new() { Id = 2, Name = "Property 2", Lat = 52.3823494, Lng = -1.2539326 },
      new() { Id = 3, Name = "Property 3", Lat = 51.9147064, Lng = -2.5837012 },
    ]
  };
}

public class TClient {
  public List<Property> Properties { get; set; } = [];
}

public class Property {
  public int Id { get; set; }
  public string Name { get; set; } = "";
  public double Lat { get; set; }
  public double Lng { get; set; }
}