using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Wisdom : IAttribute
	{
		public string Id => nameof(Wisdom);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier => this.CalculateModifier();
		
		public string Name => "Wisdom";

		public string Description => "Noticing things, making judgments, reading situations, intuition";
	}
}