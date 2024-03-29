﻿using MongoDB.Driver;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public class CampaignDbContext
  {
    private readonly IMongoDatabase _mongoDatabase;

    public CampaignDbContext()
    {
      var settings = MongoClientSettings.FromConnectionString(
        "mongodb+srv://YakaryBovine:AvNb6iVw9JROAXkD@campaignswithoutnumber.icyn6.mongodb.net/?retryWrites=true&w=majority");
      settings.ServerApi = new ServerApi(ServerApiVersion.V1);
      var client = new MongoClient(settings);
      _mongoDatabase = client.GetDatabase("campaignDb");
    }

    public IMongoCollection<Character> CharacterCollection => _mongoDatabase.GetCollection<Character>("character");
  }
}