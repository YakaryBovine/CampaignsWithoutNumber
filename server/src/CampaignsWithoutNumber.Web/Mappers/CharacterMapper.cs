using CampaignsWithoutNumber.Domain;
using CampaignsWithoutNumber.Web.DTOs;

namespace CampaignsWithoutNumber.Web.Mappers
{
  public static class CharacterMapper
  {
    public static CharacterDto ToDto(this Character character) =>
      new()
      {
        Id = character.Id,
        Name = character.Name,
        Level = character.Level,
        HitPoints = (int)character.Class.HitPointsPerLevel * character.Level,
        HitPointsMaximum = (int)character.Class.HitPointsPerLevel * character.Level
      };
  }
}
