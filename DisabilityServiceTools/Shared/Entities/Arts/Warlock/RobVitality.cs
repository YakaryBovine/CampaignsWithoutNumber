using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class RobVitality : IArt
{
  public string Id => nameof(RobVitality);
		
  public string Name => "Rob Vitality";

  public string Description => "Once per scene, as an On Turn action, Commit Effort for the scene and target a visible foe. They must make a Physical save or lose their next Main Action, which you immediately gain instead.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}