using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterClassMapper
  {
    public static CharacterClass ToEntity(CharacterClassDto dto)
    {
      var entity = new CharacterClass()
      {
        Id = dto.Id,
        Name = dto.Name,
        AttackBonusPerLevel = dto.AttackBonusPerLevel,
        HitPointsPerLevel = dto.HitPointsPerLevel
      };
      foreach (var feature in dto.Features)
      {
        entity.Features.Add(CharacterFeatureMapper.ToEntity(feature));
      }
      return entity;
    }

    public static CharacterClassDto ToDto(CharacterClass entity)
    {
      var dto = new CharacterClassDto
      {
        Id = entity.Id,
        Name = entity.Name,
        AttackBonusPerLevel = entity.AttackBonusPerLevel,
        HitPointsPerLevel = entity.HitPointsPerLevel,
        Features = new List<CharacterFeatureDto>()
      };
      foreach (var feature in entity.GetFeatures())
      {
        dto.Features.Add(CharacterFeatureMapper.ToDto(feature));
      }
      return dto;
    }
  }
}