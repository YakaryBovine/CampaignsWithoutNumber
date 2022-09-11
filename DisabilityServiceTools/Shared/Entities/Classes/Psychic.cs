using System.Collections.Generic;

namespace CampaignsWithoutNumber.Shared.Entities.Classes
{
	public sealed class Psychic : ICharacterClass
	{
		public string Name => "Psychic";

		public float AttackBonusPerLevel => 0.5f;

		public float HitPointsPerLevel => 3.5f;

		public List<CharacterFeature> Features => new();

		public List<IArt>? SelectedArts { get; set; }

		public int Id => 3;

		public List<IArt> Arts { get; } = new();
	}
}