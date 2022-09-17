using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class SorcerousBattery : IArt
{
  public string Id => nameof(SorcerousBattery);
		
  public string Name => "Sorcerous Battery";

  public string Description => "Once per day, as an On Turn action, Commit Effort for the day. You or a visible ally refresh the spell slot of a spell that has been cast since the start of the prior round. Gain one System Strain when you use this art.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}