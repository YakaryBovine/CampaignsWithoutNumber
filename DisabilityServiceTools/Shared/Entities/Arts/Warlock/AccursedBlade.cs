using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Arts.Warlock;

public sealed class AccursedBlade : IArt
{
	public string Id => nameof(AccursedBlade);
		
	public string Name => "Accursed Blade";

	public string Description => "As an On Turn action manifest an occult melee weapon as a one-handed 1d8 weapon or a two-handed 2d6 weapon. Both add your Magic skill to the damage done, have a Shock rating of 2/15, and use Magic as the attack skill and Int/Cha as the attributes that modify its attack and damage.";
		
	public void Apply(CharacterDto character)
	{
		character.AddAction(new ActionDto(Name, Description));
	}
}