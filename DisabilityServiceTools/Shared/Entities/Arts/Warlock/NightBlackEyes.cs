using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class NightBlackEyes : IArt
{
  public string Id => nameof(NightBlackEyes);
		
  public string Name => "Night-Black Eyes";

  public string Description => "You can see clearly in perfect dark- ness. As a Main Action, focus on a particular visible object, person, or location; you can tell if it is en- chanted, though no details about the magic are seen.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}