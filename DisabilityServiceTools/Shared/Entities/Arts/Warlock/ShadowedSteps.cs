using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class ShadowedSteps : IArt
{
  public string Id => nameof(ShadowedSteps);
		
  public string Name => "Scourging Curse";

  public string Description => "As a Move Action, Commit Effort for the scene and teleport up to your Move distance. You cannot bypass physical barriers this way.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}