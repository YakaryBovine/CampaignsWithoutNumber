namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class ArtDto
	{
		public string Name { get; set; }

		public string Description { get; set; }
		
		public override bool Equals(object o)
		{
			var other = o as ArtDto;
			return other?.Name == Name;
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}

		public override string ToString()
		{
			return Name;
		}
	}
}