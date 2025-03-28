namespace CampaignsWithoutNumber.Domain;

public sealed class GameClass
{
  public required string Name { get; init; }
  
  public float HitPointsPerLevel { get; init; }
  
  public float AttackBonusPerLevel { get; init; }
}