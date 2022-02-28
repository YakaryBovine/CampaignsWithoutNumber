using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Mappers
{
  public static class CharacterMapper
  {
    /// <summary>
    /// Converts a <see cref="Character"/> entity into a <see cref="CharacterDto"/>.
    /// </summary>
    /// <returns></returns>
    public static CharacterDto ToDto(Character entity)
    {
      var dto = new CharacterDto
      {
        Id = entity.Id,
        Level = entity.Level,
        Name = entity.Name,
        Class = CharacterClassMapper.ToDto(entity.CharacterClass),
        HitPoints = (int) (entity.CharacterClass.HitPointsPerLevel * entity.Level),
        AttackBonus = (int) (entity.CharacterClass.AttackBonusPerLevel * entity.Level),
        SkillPoints = 3*entity.Level
      };
      entity.CharacterClass?.Apply(dto);
      return dto;
    }

    public static Character ToEntity(CharacterDto dto)
    {
      var entity = new Character
      {
        Id = dto.Id,
        Level = dto.Level,
        Name = dto.Name,
        CharacterClass = CharacterClassMapper.ToEntity(dto.Class)
      };
      return entity;
    }
  }
}