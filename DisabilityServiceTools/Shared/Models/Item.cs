using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Models
{
  public class Item
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    public string Name { get; set; }
  }
}