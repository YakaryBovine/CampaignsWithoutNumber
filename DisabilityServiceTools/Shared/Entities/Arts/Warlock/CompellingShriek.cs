using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class CompellingShriek : IArt
{
	public string Id => nameof(CompellingShriek);
		
	public string Name => "Compelling Shriek";

	public string Description => "Once per scene, Commit Effort for the day as a Main Action and shout a command of no more than seven words. Chosen targets who hear and understand must make a Mental save or perform that action for one round, provided it is not totally contrary to their character.";
		
	public void Apply(CharacterDto character)
	{
		character.AddAction(new ActionDto(Name, Description));
	}
}