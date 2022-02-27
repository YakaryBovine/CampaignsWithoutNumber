using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
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

    public void Apply(CharacterDto characterDto)
    {
      characterDto.HitPoints = (int) (HitPointsPerLevel * characterDto.Level);
      characterDto.AttackBonus = (int) (AttackBonusPerLevel * characterDto.Level);
    }
  }
}