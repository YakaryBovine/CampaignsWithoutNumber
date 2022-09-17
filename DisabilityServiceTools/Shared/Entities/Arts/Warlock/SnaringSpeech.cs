using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class SnaringSpeech : IArt
{
  public string Id => nameof(SnaringSpeech);
		
  public string Name => "Snaring Speech";

  public string Description => "Once per round as an Instant action, Commit Effort for the day when failing a skill check to persuade or tempt someone. They must make a Mental save or agree with your proposal if it’s some- thing they would normally consider doing. Gain one System Strain when using this art.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}