using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers;

[Route("api/worldmap")]
public class WorldMapController
{
  [HttpGet]
  [Route("get")]
  public object? Get()
  {
    var fullPath = Path.GetFullPath("map.geojson");
    var contents = File.ReadAllText(fullPath);
    return Newtonsoft.Json.JsonConvert.DeserializeObject<object>(contents);
  }
}