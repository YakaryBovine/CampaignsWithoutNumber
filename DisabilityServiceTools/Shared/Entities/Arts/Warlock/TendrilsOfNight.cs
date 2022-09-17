using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class TendrilsOfNight : IArt
{
  public string Id => nameof(TendrilsOfNight);
		
  public string Name => "Tendrils of Night";

  public string Description => "Commit Effort as an On Turn action. While Committed, you exude numerous tentacles or eldritch arms that can manipulate objects with your strength up to 20’ away. You gain no bonus actions, but the arms can melee at range. These arms have your AC, and you are damaged if they are hurt.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}