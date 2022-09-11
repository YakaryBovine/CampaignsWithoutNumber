using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Arts;
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
		
		public List<IArt> Arts { get; } = new()
		{
			new AccursedBlade()
		};
	}
}