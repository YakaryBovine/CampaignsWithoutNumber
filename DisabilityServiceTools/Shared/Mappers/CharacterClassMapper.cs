using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Models;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterClassMapper
  {
    public static CharacterClass ToEntity(CharacterClassDto dto)
    {
      return new CharacterClass
      {
        Id = dto.Id,
        Name = dto.Name,
        AttackBonusPerLevel = dto.AttackBonusPerLevel,
        HitPointsPerLevel = dto.HitPointsPerLevel,
      };
    }

    public static CharacterClassDto ToDto(CharacterClass entity)
    {
      return new CharacterClassDto
      {
        Id = entity.Id,
        Name = entity.Name,
        AttackBonusPerLevel = entity.AttackBonusPerLevel,
        HitPointsPerLevel = entity.HitPointsPerLevel
      };
    }
  }
}