using System.Collections.Generic;

namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
	public sealed class CharacterClassDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public float AttackBonusPerLevel { get; set; }

		public float HitPointsPerLevel { get; set; }

		public List<CharacterFeatureDto> Features { get; set; } = new();

		/// <summary>
		///    All arts available to this class.
		/// </summary>
		public IEnumerable<ArtDto> Arts { get; set; }

		/// <summary>
		///    All arts currently selected by the character holding this class.
		/// </summary>
		public IEnumerable<ArtDto>? SelectedArts { get; set; }

		public override bool Equals(object o)
		{
			var other = o as CharacterClassDto;
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