namespace CampaignsWithoutNumber.Shared.DataTransferObjects
{
  public sealed class CharacterFeatureDto
  {
    public string Name { get; }
    
    public CharacterFeatureDto(string name)
    {
      Name = name;
    }
  }
}