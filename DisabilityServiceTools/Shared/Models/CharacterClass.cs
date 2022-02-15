using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Models
{
  public sealed class CharacterClass
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
    
    public float AttackBonusPerLevel { get; set; }
    
    public float HitPointsPerLevel { get; set; }

    public List<CharacterFeature> Features { get; set; }

    public override bool Equals(object o)
    {
      var other = o as CharacterClass;
      return other?.Name == Name;
    }
    
    public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    
    public override string ToString() => Name;
  }
}