using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using GeoJSON.Text.Feature;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers;

[Route("api/worldmap")]
public class WorldMapController
{
  [HttpGet]
  [Route("index")]
  public async Task<ActionResult<WorldMapDto>> Get()
  {
    var statesPath = await File.ReadAllTextAsync("map.geojson");
    var markersPath = await File.ReadAllTextAsync("markers.geojson");

    var states = JsonSerializer.Deserialize<FeatureCollection>(statesPath);
    var markers = JsonSerializer.Deserialize<FeatureCollection>(markersPath);

    return new WorldMapDto {States = states, Markers = markers};
  }
}