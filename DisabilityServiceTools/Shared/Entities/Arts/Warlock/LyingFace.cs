using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class LyingFace : IArt
{
  public string Id => nameof(LyingFace);
		
  public string Name => "Lying Face";

  public string Description => "Commit Effort as a Main Action; while it remains Committed, you can disguise yourself as any humanoid of the same general size, including clothing, scent, and voice.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}