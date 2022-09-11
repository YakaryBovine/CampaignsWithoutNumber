using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public sealed class Character
  {
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    public string Name { get; set; }

    public List<ICharacterClass>? CharacterClasses { get; set; }
    
    public int Level { get; set; }

    /// <summary>
    /// A collection of <see cref="IArt"/>s the character has selected.
    /// </summary>
    public Dictionary<ICharacterClass, IEnumerable<IArt>>? SelectedArts { get; set; } = new();
  }
}