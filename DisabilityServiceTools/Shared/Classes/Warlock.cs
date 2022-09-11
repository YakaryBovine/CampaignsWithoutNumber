using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Classes
{
	public sealed class Warlock : ICharacterClass
	{
		public int Id => 4;
		
		public string Name => "Warlock";

		public float AttackBonusPerLevel => 0.5f;

		public float HitPointsPerLevel => 3.5f;

		public List<CharacterFeature> Features => new();
		
		public List<Art> Arts { get; } = new()
		{
			new Art("Accursed Blade", @"As an On Turn action manifest an occult melee weapon as a one-handed 1d8 weapon or a two-handed 2d6 weapon. Both add your Magic skill to the damage done, have a Shock rating of 2/15, and use Magic as the attack skill and Int/Cha as the attributes that modify its attack and damage.")
		};
	}
}