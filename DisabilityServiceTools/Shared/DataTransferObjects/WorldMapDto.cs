using GeoJSON.Net.Feature;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects;

public sealed class WorldMapDto
{
  public FeatureCollection Markers { get; set; }
  public object? States { get; set; }
}