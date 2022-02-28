using MongoDB.Driver;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public class CampaignDbContext
  {
    private readonly IMongoDatabase _mongoDatabase;

    public CampaignDbContext()
    {
      var settings = MongoClientSettings.FromConnectionString(
        "mongodb+srv://YakaryBovine:coolNewPassword@campaignswithoutnumber.icyn6.mongodb.net/campaignDb?retryWrites=true&w=majority");
      settings.ServerApi = new ServerApi(ServerApiVersion.V1);
      var client = new MongoClient(settings);
      _mongoDatabase = client.GetDatabase("campaignDb");
    }

    public IMongoCollection<Character> CharacterCollection => _mongoDatabase.GetCollection<Character>("character");

    public IMongoCollection<Item> ItemCollection => _mongoDatabase.GetCollection<Item>("item");
    
    public IMongoCollection<ShipDefense> ShipDefenseCollection => _mongoDatabase.GetCollection<ShipDefense>("shipDefense");
    
    public IMongoCollection<CharacterClass> CharacterClassCollection => _mongoDatabase.GetCollection<CharacterClass>("characterClass");
  }
}