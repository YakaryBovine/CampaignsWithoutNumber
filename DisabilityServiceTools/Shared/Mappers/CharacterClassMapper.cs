using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterClassMapper
  {
    public static CharacterClassDto ToDto(ICharacterClass entity)
    {
      var dto = new CharacterClassDto
      {
        Id = entity.Id,
        Name = entity.Name,
        AttackBonusPerLevel = entity.AttackBonusPerLevel,
        HitPointsPerLevel = entity.HitPointsPerLevel,
        Features = new List<CharacterFeatureDto>()
      };
      // foreach (var feature in entity.GetFeatures())
      // {
      //   dto.Features.Add(CharacterFeatureMapper.ToDto(feature));
      // }
      return dto;
    }
  }
}