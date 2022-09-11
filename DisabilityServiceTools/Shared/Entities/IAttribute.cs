using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities
{
	public interface IAttribute
	{
		public string Id { get; }
		
		public void Apply(CharacterDto character);

		public int Value { get; set; }
		
		public int Modifier { get; set; }
		
		string Name { get; }
		
		string Description { get; }
	}
}