using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.CharacterFeatures
{
  public sealed class MasterfulExpertise : CharacterFeature
  {
    public override string ClassName => "MasterfulExpertise";

    public override string Name => "Masterful Expertise";

    public override void Apply(CharacterDto character)
    {
    }
  }
}