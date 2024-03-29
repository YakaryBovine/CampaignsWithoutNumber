﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class CharacterDto
	{
		public string? Id { get; set; }

		public int HitPoints { get; set; }

		public int AttackBonus { get; set; }

		public int Level { get; set; }

		public int SkillPoints { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		public string? Name { get; set; }

		/// <summary>
		/// How many readied items this character can hold without slowing down.
		/// </summary>
		public int ReadiedItemCapacity { get; set; }

		/// <summary>
		/// How many stowed items this character can hold without slowing down.
		/// </summary>
		public int StowedItemCapacity { get; set; }

		public IEnumerable<CharacterClassDto>? Classes { get; set; }

		public List<ActionDto>? Actions { get; set; }
		
		/// <summary>
		/// Attributes which help determine this character's core statistics.
		/// </summary>
		public IEnumerable<AttributeDto>? Attributes { get; set; }

		public int ArmorClass { get; set; }

		public void AddAction(ActionDto action)
		{
			Actions ??= new List<ActionDto>();
			Actions.Add(action);
		}
	}
}