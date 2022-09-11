namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class ArtDto
	{
		public ArtDto(string id)
		{
			Id = id;
		}
		
		public string Id { get; }
		
		public string Name { get; set; }

		public string Description { get; set; }
		
		public override bool Equals(object o)
		{
			var other = o as ArtDto;
			return other?.Id == Id;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public override string ToString()
		{
			return Name;
		}
	}
}