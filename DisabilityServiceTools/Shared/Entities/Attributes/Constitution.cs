using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.Attributes
{
	public sealed class Constitution : IAttribute
	{
		public string Id => nameof(Constitution);
		
		public void Apply(CharacterDto character)
		{
			character.HitPoints += Modifier;
		}

		public int Value { get; set; }

		public int Modifier => this.CalculateModifier();

		public string Name => "Constitution";

		public string Description => "Hardiness, enduring injury, resisting poisons, going without food or rest";
	}
}