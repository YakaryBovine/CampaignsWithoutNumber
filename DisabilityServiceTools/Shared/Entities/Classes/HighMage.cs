using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Arts;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Classes
{
	public sealed class HighMage : ICharacterClass
	{
		public string Name => "High Mage";

		public float AttackBonusPerLevel => 0.5f;

		public float HitPointsPerLevel => 3.5f;

		public List<CharacterFeature> Features => new();

		public int Id => 5;
    
		public List<IArt> Arts { get; } = new() { new ArcaneLexicon() };
	}
}