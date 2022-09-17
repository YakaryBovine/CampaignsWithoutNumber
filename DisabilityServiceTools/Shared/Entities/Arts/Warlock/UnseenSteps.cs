using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class UnseenSteps : IArt
{
  public string Id => nameof(UnseenSteps);
		
  public string Name => "Unseen Steps";

  public string Description => "As an On Turn action, Commit Effort for the day to turn invisible for 1d6 rounds plus your level. This invisibility breaks before you attack, cast spells, or perform other violent actions.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}