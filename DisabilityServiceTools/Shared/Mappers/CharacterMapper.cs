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
        SelectedArts = new ArtBuildDto(entity.SelectedArts.ToDictionary(x => CharacterClassMapper.ToDto(x.Key),
          x => x.Value.Select(ArtMapper.ToDto)))
      };

      return dto;
    }

    public static Character ToEntity(CharacterDto dto)
    {
      if (dto == null)
      {
        throw new ArgumentNullException(nameof(dto));
      }
      
      var entity = new Character
      {
        Id = dto.Id,
        Level = dto.Level,
        Name = dto.Name,
        CharacterClasses = dto.Classes?.Select(CharacterClassMapper.ToEntity).ToList(),
        SelectedArts = dto.SelectedArts?.ToDictionary(x => CharacterClassMapper.ToEntity(x.Key),
          x => x.Value.Select(ArtMapper.ToEntity))
      };
      return entity;
    }
  }
}