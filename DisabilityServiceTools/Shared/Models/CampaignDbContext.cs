using MongoDB.Driver;

namespace CampaignsWithoutNumber.Shared.Models
{
  public class CampaignDbContext
  {
    private readonly IMongoDatabase _mongoDatabase;

    public CampaignDbContext()
    {
      var client = new MongoClient("mongodb://localhost:27017");
      _mongoDatabase = client.GetDatabase("CampaignDB");
    }

    public IMongoCollection<Character> CharacterRecord => _mongoDatabase.GetCollection<Character>("CharacterRecord");

    public IMongoCollection<Item> ItemRecord => _mongoDatabase.GetCollection<Item>("ItemRecord");
  }
}