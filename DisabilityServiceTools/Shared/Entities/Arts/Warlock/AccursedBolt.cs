using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class AccursedBolt : IArt
{
	public string Id => nameof(AccursedBolt);
		
	public string Name => "Accursed Bolt";

	public string Description => "As Accursed Blade, but you can launch blasts of occult force instead. Their damage is 1d8 plus your Magic skill, their range is 200’, and the bolts can be thrown in melee at a -4 penalty to hit. These bolts need both hands free to hurl them.";
		
	public void Apply(CharacterDto character)
	{
		character.AddAction(new ActionDto(Name, Description));
	}
}