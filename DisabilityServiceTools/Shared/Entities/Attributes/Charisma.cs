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
		
		public int Modifier { get; set; }

		public string Name => "Charisma";
		
		public string Description { get; set; }
	}
}