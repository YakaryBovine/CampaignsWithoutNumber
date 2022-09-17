using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class WeepingWounds : IArt
{
  public string Id => nameof(WeepingWounds);
		
  public string Name => "Weeping Wounds";

  public string Description => "Once per round, Commit Effort for the scene as an Instant action when a visible ene- my takes damage. They must make a Physical save or suffer 1d6 damage per round for one round per level. They cannot heal or regenerate any hit point damage during this effect. This art does not stack.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}