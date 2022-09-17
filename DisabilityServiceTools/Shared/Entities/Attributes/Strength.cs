using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Strength : IAttribute
	{
		public string Id => nameof(Strength);
		
		public void Apply(CharacterDto character)
		{
			character.StowedItemCapacity += Value;
			character.ReadiedItemCapacity += Value / 2;
		}

		public int Value { get; set; }
		
		public int Modifier => this.CalculateModifier();
		
		public string Name => "Strength";

		public string Description => "Lifting heavy weights, breaking things, melee combat, carrying gear";
	}
}