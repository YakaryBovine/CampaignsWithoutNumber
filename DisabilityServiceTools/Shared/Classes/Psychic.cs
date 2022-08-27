using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Classes
{
  public sealed class Psychic : ICharacterClass
  {
    public string Name => "Psychic";

    public float AttackBonusPerLevel => 0.5f;

    public float HitPointsPerLevel => 3.5f;

    public List<CharacterFeature> Features => new();

    public int Id => 3;
  }
}