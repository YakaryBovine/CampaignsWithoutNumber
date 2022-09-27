using System;
using System.IO;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using GeoJSON.Net.Feature;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CampaignsWithoutNumber.Server.Controllers;

[Route("api/worldmap")]
public sealed class WorldMapController
{
  [HttpGet]
  [Route("get")]
  public async Task<ActionResult<WorldMapDto>> Get()
  {
    var statesJson = await File.ReadAllTextAsync("map.geojson");
    var markersJson = await File.ReadAllTextAsync("markers.geojson");

    return new WorldMapDto
    {
      States = JsonConvert.DeserializeObject<FeatureCollection>(statesJson) ?? throw new InvalidOperationException(), 
      Markers = JsonConvert.DeserializeObject<FeatureCollection>(markersJson) ?? throw new InvalidOperationException(),
      StatesRaw = JsonConvert.DeserializeObject<object>(statesJson) ?? throw new InvalidOperationException()
    };
  }
}