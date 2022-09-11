namespace CampaignsWithoutNumber.Shared.Entities
{
	public sealed class Art
	{
		public string Name { get; }
		
		public string Description { get; }

		public Art(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}