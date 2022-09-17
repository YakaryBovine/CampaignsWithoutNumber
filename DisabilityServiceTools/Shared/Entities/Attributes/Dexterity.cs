using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Dexterity : IAttribute
	{
		public string Id => nameof(Dexterity);
		
		public void Apply(CharacterDto character)
		{
			character.ArmorClass += Modifier;
		}

		public int Value { get; set; }
		
		public int Modifier => this.CalculateModifier();

		public string Name => "Dexterity";

		public string Description => "Speed, evasion, manual dexterity, reaction time, combat initiative";
	}
}