namespace CampaignsWithoutNumber.Web.DTOs;

public sealed class CharacterDto
{
  public required Guid Id { get; init; }

  public required string Name { get; init; }

  public required int Level { get; set; }
  
  public required int HitPoints { get; init; }
  
  public required int HitPointsMaximum { get; init; }
}