namespace CampaignsWithoutNumber.Domain;

public sealed class Character
{
  public required Guid Id { get; init; }

  public required string Name { get; init; }

  public required int Level { get; set; }
  
  public required GameClass Class { get; init; }
}