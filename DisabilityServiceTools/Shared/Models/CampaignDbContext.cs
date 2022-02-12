using MongoDB.Driver;

namespace CampaignsWithoutNumber.Shared.Models
{
  public class CampaignDbContext
  {
    private readonly IMongoDatabase _mongoDatabase;

    public CampaignDbContext()
    {
      var settings = MongoClientSettings.FromConnectionString(
        "mongodb+srv://YakaryBovine:coolNewPassword@campaignswithoutnumber.icyn6.mongodb.net/campaignDb?retryWrites=true&w=majority");
      var client = new MongoClient(settings);
      _mongoDatabase = client.GetDatabase("campaignDb");
    }

    public IMongoCollection<Character> CharacterRecord => _mongoDatabase.GetCollection<Character>("character");

    public IMongoCollection<Item> ItemRecord => _mongoDatabase.GetCollection<Item>("item");
    
    public IMongoCollection<ShipDefense> ShipDefenseRecord => _mongoDatabase.GetCollection<ShipDefense>("shipDefense");
  }
}