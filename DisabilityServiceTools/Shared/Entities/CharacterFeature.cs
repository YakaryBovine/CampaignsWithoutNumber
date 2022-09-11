using CampaignsWithoutNumber.Shared.DataTransferObjects;

namespace CampaignsWithoutNumber.Shared.Entities
{
  public abstract class CharacterFeature
  {
    public abstract string ClassName { get; }

    public abstract string Name { get; }
    
    public abstract void Apply(CharacterDto character);
  }
}