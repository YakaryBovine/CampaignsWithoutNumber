using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Entities.Arts;

namespace CampaignsWithoutNumber.Shared.Entities.Classes
{
	public sealed class Warlock : ICharacterClass
	{
		public int Id => 4;

		public string Name => "Warlock";

		public float AttackBonusPerLevel => 0.5f;

		public float HitPointsPerLevel => 3.5f;

		public List<CharacterFeature> Features => new();

		public List<IArt>? SelectedArts { get; set; }

		public List<IArt> Arts { get; } = new()
		{
			new AccursedBlade()
		};
	}
}