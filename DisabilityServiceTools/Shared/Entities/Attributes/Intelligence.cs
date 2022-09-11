using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Intelligence : IAttribute
	{
		public string Id => nameof(Intelligence);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier { get; set; }
		
		public string Name => "Intelligence";
		
		public string Description { get; set; }
	}
}