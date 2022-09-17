namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class AttributeDto
	{
		public AttributeDto(string id, string name, string description)
		{
			Name = name;
			Description = description;
			Id = id;
		}

		/// <summary>
		/// A unique identifier for the attribute.
		/// </summary>
		public string Id { get; }
		
		public string Name { get; }
		
		public string Description { get; }
		
		/// <summary>
		/// The raw numerical value of the attribute.
		/// </summary>
		public int Value { get; set; }

		public override bool Equals(object? o)
		{
			var other = o as AttributeDto;
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