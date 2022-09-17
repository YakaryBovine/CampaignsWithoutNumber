using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class BewitchedDistraction : IArt
{
	public string Id => nameof(BewitchedDistraction);
		
	public string Name => "Bewitched Distraction";

	public string Description => "Commit Effort for the day as a Main Action when talking to an intelligent target when not in combat. They must make a Mental save or become dazed, oblivious to their surroundings and forgetting you and all else that happened in that scene. Danger or threats break the daze.";
		
	public void Apply(CharacterDto character)
	{
		character.AddAction(new ActionDto(Name, Description));
	}
}