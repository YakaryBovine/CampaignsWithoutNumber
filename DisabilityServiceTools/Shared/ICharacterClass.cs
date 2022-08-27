using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared
{
  public interface ICharacterClass
  {
    public string Name { get; }

    public float AttackBonusPerLevel { get; }

    public float HitPointsPerLevel { get; }

    public List<CharacterFeature> Features { get; }

    public int Id { get; }

    public void Apply(CharacterDto characterDto)
    {
      characterDto.HitPoints = (int)(HitPointsPerLevel * characterDto.Level);
      characterDto.AttackBonus = (int)(AttackBonusPerLevel * characterDto.Level);
      foreach (var feature in Features) feature.Apply(characterDto);
    }
  }
}