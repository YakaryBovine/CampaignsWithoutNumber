namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class ActionDto
	{
		public string Name { get; }
		
		public string Description { get; }

		public ActionDto(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}
}