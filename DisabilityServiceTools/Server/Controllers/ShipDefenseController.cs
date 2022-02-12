using System.Collections.Generic;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/shipdefense")]
  public class ShipDefenseController : Controller
  {
    private readonly ShipDefenseService _shipDefenseService = new();

    [HttpGet]
    [Route("index")]
    public IEnumerable<ShipDefense> Index()
    {
      return _shipDefenseService.GetAllShipDefenses();
    }

    [HttpPost]
    [Route("create")]
    public void Create([FromBody] ShipDefense shipDefense)
    {
      _shipDefenseService.AddShipDefense(shipDefense);
    }

    [HttpGet]
    [Route("details/{id}")]
    public ShipDefense Details(string id)
    {
      return _shipDefenseService.GetShipDefenseData(id);
    }

    [HttpPut]
    [Route("edit")]
    public void Edit([FromBody] ShipDefense shipDefense)
    {
      _shipDefenseService.UpdateShipDefense(shipDefense);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public void Delete(string id)
    {
      _shipDefenseService.DeleteShipDefense(id);
    }

    [HttpGet]
    [Route("getitem")]
    public List<Item> GetItem()
    {
      return _shipDefenseService.GetCityData();
    }
  }
}