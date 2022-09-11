using System;
using System.Linq;
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
        Classes = entity.CharacterClasses?.Select(CharacterClassMapper.ToDto).ToList(),
        HitPoints = 5,
        AttackBonus = 5,
        SkillPoints = 3*entity.Level,
        Arts = entity.Arts?.Select(ArtMapper.ToDto).ToList()
      };

      if (entity.Arts != null)
      {
        foreach (var art in entity.Arts)
        {
          art.Apply(dto);
        }
        //entity.CharacterClass?.Apply(dto);
      }

      return dto;
    }

    public static Character ToEntity(CharacterDto dto)
    {
      var entity = new Character
      {
        Id = dto.Id,
        Level = dto.Level,
        Name = dto.Name,
        CharacterClasses = dto.Classes?.Select(CharacterClassMapper.ToEntity).ToList(),
        Arts = dto.Arts?.Select(ArtMapper.ToEntity).ToList()
      };
      return entity;
    }
  }
}