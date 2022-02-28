using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities.CharacterFeatures
{
  public sealed class QuickLearner : CharacterFeature
  {
    public override string ClassName => "QuickLearner";
    
    public override string Name => "Quick Learner";
    
    public override void Apply(CharacterDto character)
    {
      character.SkillPoints += character.Level * 1;
    }
  }
}