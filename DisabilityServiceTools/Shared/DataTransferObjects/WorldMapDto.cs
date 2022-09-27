using GeoJSON.Text.Feature;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects;

public sealed class WorldMapDto
{
  public FeatureCollection Markers { get; set; }
  public FeatureCollection States { get; set; }
}