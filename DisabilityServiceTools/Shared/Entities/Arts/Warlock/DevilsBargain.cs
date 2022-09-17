using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class DevilsBargain : IArt
{
	public string Id => nameof(DevilsBargain);
		
	public string Name => "Devil's Bargain";

	public string Description => "As a Main Action, consecrate a deal you’ve made with an uncoerced person. If they vi- olate the deal or its spirit, you know instantly and may inflict 1d6 damage per level on them if desired.";
		
	public void Apply(CharacterDto character)
	{
		character.AddAction(new ActionDto(Name, Description));
	}
}