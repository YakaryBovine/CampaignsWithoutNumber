using System.Collections.Generic;

namespace CampaignsWithoutNumber.Shared.Entities.Classes
{
	public sealed class Expert : ICharacterClass
	{
		public string Name => "Expert";

		public float AttackBonusPerLevel => 0.5f;

		public float HitPointsPerLevel => 3.5f;

		public List<CharacterFeature> Features => new();

		public List<IArt>? SelectedArts { get; set; }

		public List<IArt> Arts { get; } = new();

		public int Id => 2;
	}
}