using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Dexterity : IAttribute
	{
		public string Id => nameof(Dexterity);
		
		public void Apply(CharacterDto character)
		{
			
		}

		public int Value { get; set; }
		
		public int Modifier { get; set; }
		
		public string Name => "Dexterity";
		
		public string Description { get; set; }
	}
}