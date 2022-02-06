using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Models
{
  public sealed class Character
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    public List<Item> Items { get; } = new();
  }
}