using GeoJSON.Net.Feature;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects;

public sealed class WorldMapDto
{
  public object StatesRaw { get; set; }
  public FeatureCollection Markers { get; set; }
  public FeatureCollection States { get; set; }
}