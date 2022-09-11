using System.Collections.Generic;
using System.Linq;
using CampaignsWithoutNumber.Shared.Classes;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Managers;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterClassMapper
  {
    public static ICharacterClass ToEntity(CharacterClassDto dto) => CharacterClassManager.GetById(dto.Id);

    public static CharacterClassDto ToDto(ICharacterClass entity)
    {
      var dto = new CharacterClassDto
      {
        Id = entity.Id,
        Name = entity.Name,
        AttackBonusPerLevel = entity.AttackBonusPerLevel,
        HitPointsPerLevel = entity.HitPointsPerLevel,
        Features = new List<CharacterFeatureDto>(),
        Arts = entity.Arts.Select(ArtMapper.ToDto)
      };
      // foreach (var feature in entity.GetFeatures())
      // {
      //   dto.Features.Add(CharacterFeatureMapper.ToDto(feature));
      // }
      return dto;
    }
  }
}