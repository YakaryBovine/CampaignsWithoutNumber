using System.Linq;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Managers;

namespace CampaignsWithoutNumber.Shared.Mappers
{
	public static class CharacterMapper
	{
		/// <summary>
		///    Converts a <see cref="Character" /> entity into a <see cref="CharacterDto" />.
		/// </summary>
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
				SkillPoints = 3 * entity.Level,
				Attributes = entity.Attributes?.Select(AttributeMapper.ToDto),
				ArmorClass = 10
			};

			dto.Attributes ??= AttributeManager.GetAll().Select(AttributeMapper.ToDto);
			
			if (entity.CharacterClasses != null)
			{
				var arts = entity.CharacterClasses
					.Where(characterClass => characterClass.SelectedArts != null)
					.SelectMany(characterClass => characterClass.SelectedArts);

				foreach (var art in arts) art.Apply(dto);
			}

			if (entity.Attributes != null)
				foreach (var attribute in entity.Attributes)
				{
					attribute.Apply(dto);
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
				Attributes = dto.Attributes?.Select(AttributeMapper.ToEntity)
			};
			return entity;
		}
	}
}