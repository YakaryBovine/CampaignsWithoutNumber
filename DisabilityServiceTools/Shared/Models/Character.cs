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
    
    public CharacterClass Class { get; set; }

    public string ClassName => Class == null ? "None" : Class.Name;

    public int AttackBonus
    {
      get
      {
        if (Class == null)
        {
          return 0;
        }
        return (int) (Level * Class.AttackBonusPerLevel);
      }
    }

    public int HitPoints
    {
      get
      {
        if (Class == null)
        {
          return 0;
        }
        return (int) (Level * Class.HitPointsPerLevel);
      }
    }

    public int Level { get; set; }

    public List<Item> Items { get; } = new();
  }
}