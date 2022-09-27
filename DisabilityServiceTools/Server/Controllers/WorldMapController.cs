using System.IO;
using System.Net;
using System.Web.Http;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using GeoJSON.Net.Feature;
using Newtonsoft.Json;

namespace CampaignsWithoutNumber.Server.Controllers;

[Microsoft.AspNetCore.Mvc.Route("api/worldmap")]
public class WorldMapController
{
  [Microsoft.AspNetCore.Mvc.HttpGet]
  [Microsoft.AspNetCore.Mvc.Route("get")]
  public WorldMapDto Get()
  {
    var statesPath = File.ReadAllText("map.geojson");
    var markersPath = File.ReadAllText("markers.geojson");

    var states = JsonConvert.DeserializeObject<object>(statesPath);
    var markers = JsonConvert.DeserializeObject<FeatureCollection>(markersPath);

    if (states == null || markers == null)
    {
      throw new HttpResponseException(HttpStatusCode.NotFound);
    }
    
    return new WorldMapDto {States = states, Markers = markers};
  }
}