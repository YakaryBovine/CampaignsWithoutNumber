using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class PactedProtection : IArt
{
  public string Id => nameof(PactedProtection);
		
  public string Name => "Pacted Protection";

  public string Description => "Choose a type of harmful energy: fire, frost, acid, electricity, or the like. You become immune to natural degrees of this energy and take half damage from magical attacks involving it.";
		
  public void Apply(CharacterDto character)
  {
    character.AddAction(new ActionDto(Name, Description));
  }
}