using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class DirePact : IArt
{
  public string Id => nameof(DirePact);
		
  public string Name => "Dire Pact";

  public string Description => "Foes suffer a penalty equal to your Magic skill on all saves versus your Accursed arts. If they suc- ceed, however, you gain one System Strain.Foes suffer a penalty equal to your Magic skill on all saves versus your Accursed arts. If they suc- ceed, however, you gain one System Strain.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}