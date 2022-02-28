using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public class Item
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name => Definition.Name;

    public ItemDefinition Definition { get; }
    
    public Item(ItemDefinition definition)
    {
      Definition = definition;
    }
  }
}