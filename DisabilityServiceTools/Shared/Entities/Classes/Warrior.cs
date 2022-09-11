using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Classes
{
  public sealed class Warrior : ICharacterClass
  {
    public string Name => "Warrior";

    public float AttackBonusPerLevel => 1;

    public float HitPointsPerLevel => 5.5f;

    public List<CharacterFeature> Features => new();

    public int Id => 1;
    
    public List<IArt> Arts { get; } = new();
  }
}