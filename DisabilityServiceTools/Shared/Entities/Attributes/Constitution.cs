using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Constitution : IAttribute
	{
		public string Id => nameof(Constitution);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier { get; set; }
		
		public string Name => "Constitution";
		
		public string Description { get; set; }
	}
}