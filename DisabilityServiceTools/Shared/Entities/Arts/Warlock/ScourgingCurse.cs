using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class ScourgingCurse : IArt
{
  public string Id => nameof(ScourgingCurse);
		
  public string Name => "Night-Black Eyes";

  public string Description => "Commit Effort for the scene as a Main Action and target a visible foe. Your curse inflicts a -1 penalty to their hit, damage, and saving throw rolls for one round per level. At 4th level this penalty becomes -2, and at 9th it becomes -3. Only one such curse can be active at a given time.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}