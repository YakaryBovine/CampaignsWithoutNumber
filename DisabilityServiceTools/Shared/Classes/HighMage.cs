using System.Collections.Generic;
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
    
		public List<Art> Arts { get; } = new() { new Art("Arcane Lexicon", "Commit Effort for the scene. For the rest of the scene, you can read any script that was not intentionally obfuscated or encoded by its writer. Extremely esoteric or nonhuman scripts may not be comprehensible this way; the “plain meaning” of the text might be utterly foreign to human logic.")};
	}
}