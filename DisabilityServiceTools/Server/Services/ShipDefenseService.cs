using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Models;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.Services
{
  public class ShipDefenseService
  {
    private readonly CampaignDbContext _db = new();

    public IEnumerable<ShipDefense> GetAllShipDefenses()
    {
      return _db.ShipDefenseRecord.Find(_ => true).ToList();
    }
    
    public void AddShipDefense(ShipDefense shipDefense)
    {
      _db.ShipDefenseRecord.InsertOne(shipDefense);
    }
    
    public ShipDefense GetShipDefenseData(string id)
    {
      var filterShipDefenseData = Builders<ShipDefense>.Filter.Eq("Id", id);
      return _db.ShipDefenseRecord.Find(filterShipDefenseData).FirstOrDefault();
    }
    
    public void UpdateShipDefense(ShipDefense shipDefense)
    {
      _db.ShipDefenseRecord.ReplaceOne(g => g.Id == shipDefense.Id, shipDefense);
    }

    public void DeleteShipDefense(string id)
    {
      var shipDefenseData = Builders<ShipDefense>.Filter.Eq("Id", id);
      _db.ShipDefenseRecord.DeleteOne(shipDefenseData);
    }

    public List<Item> GetCityData()
    {
      return _db.ItemRecord.Find(_ => true).ToList();
    }
  }
}