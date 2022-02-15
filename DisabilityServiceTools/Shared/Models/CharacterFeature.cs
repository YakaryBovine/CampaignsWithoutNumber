namespace CampaignsWithoutNumber.Shared.Models
{
  public sealed class CharacterFeature
  {
    public CharacterFeature(string name)
    {
      Name = name;
    }
    
    public string Name { get; }
  }
}