using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;

namespace CampaignsWithoutNumber.Shared.Arts
{
	public sealed class ArcaneLexicon : IArt
	{
		public string Id => nameof(ArcaneLexicon);
		
		public string Name => "Arcane Lexicon";
		
		public string Description => "Commit Effort for the scene. For the rest of the scene, you can read any script that was not intentionally obfuscated or encoded by its writer. Extremely esoteric or nonhuman scripts may not be comprehensible this way; the “plain meaning” of the text might be utterly foreign to human logic.";
		
		public void Apply(CharacterDto character)
		{
			
		}
	}
}