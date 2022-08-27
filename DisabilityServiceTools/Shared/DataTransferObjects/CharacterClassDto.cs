using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
  public sealed class CharacterClassDto
  {
    public int Id { get; set; }

    public string Name { get; set; }
    
    public float AttackBonusPerLevel { get; set; }
    
    public float HitPointsPerLevel { get; set; }

    public List<CharacterFeatureDto> Features { get; set; } = new();

    public override string ToString() => Name;
  }
}