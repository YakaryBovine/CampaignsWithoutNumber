using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Charisma : IAttribute
	{
		public string Id => nameof(Charisma);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier => this.CalculateModifier();

		public string Name => "Charisma";

		public string Description => "Force of character, charming others, attracting attention, winning loyalty";
	}
}