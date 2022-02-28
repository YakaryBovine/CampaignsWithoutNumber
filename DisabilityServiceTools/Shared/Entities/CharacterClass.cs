using System.Collections.Generic;
using System.Linq;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.Core.Misc;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public sealed class CharacterClass
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
    
    public float AttackBonusPerLevel { get; set; }
    
    public float HitPointsPerLevel { get; set; }

    public List<CharacterFeature> Features { get; set; } = new();

    public override bool Equals(object o)
    {
      var other = o as CharacterClass;
      return other?.Name == Name;
    }

    public void Apply(CharacterDto characterDto)
    {
      characterDto.HitPoints = (int) (HitPointsPerLevel * characterDto.Level);
      characterDto.AttackBonus = (int) (AttackBonusPerLevel * characterDto.Level);
      foreach (var feature in Features)
      {
        feature.Apply(characterDto);
      }
    }

    public List<CharacterFeature> GetFeatures()
    {
      return Features.ToList();
    }
  }
}