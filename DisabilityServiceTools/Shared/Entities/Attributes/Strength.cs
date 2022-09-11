using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Strength : IAttribute
	{
		public string Id => nameof(Strength);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier { get; set; }
		
		public string Name => "Strength";
		
		public string Description { get; set; }
	}
}