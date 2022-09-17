using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class SoulConsumption : IArt
{
  public string Id => nameof(SoulConsumption);
		
  public string Name => "Soul Consumption";

  public string Description => "As an Instant action, Commit Effort for the scene when you fell an intelligent target with Accursed Bolt or Accursed Blade. They die instantly. You heal 1d6 hit points plus your level and lose one accumulated System Strain.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}