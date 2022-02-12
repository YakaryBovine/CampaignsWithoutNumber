using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Models
{
  public class ShipDefense
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Power { get; set; }
    public int Mass { get; set; }
    public ShipClass Class { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
  }
}