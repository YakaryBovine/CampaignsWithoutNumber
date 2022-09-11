using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities
{
	public interface IArt
	{
		public string Id { get; }
		
		public string Name { get; }
		
		public string Description { get; }

		/// <summary>
		/// Bestows the effects of this <see cref="IArt"/> upon the specified <see cref="CharacterDto"/>.
		/// </summary>
		public void Apply(CharacterDto character);
	}
}