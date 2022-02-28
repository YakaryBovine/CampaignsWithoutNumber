using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.CharacterFeatures
{
  public class VeteransLuck : CharacterFeature
  {
    public override string ClassName => "VeteransLuck";

    public override string Name => "Veteran's Luck";

    public override void Apply(CharacterDto character)
    {
    }
  }
}