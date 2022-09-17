using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class WeightOfSin : IArt
{
  public string Id => nameof(WeightOfSin);
		
  public string Name => "Weight of Sin";

  public string Description => "As a Main Action, Commit Effort for the day and target a visible foe. They must make a Physical save or lose their Move action for 1d6 rounds plus your level.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}