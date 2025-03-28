using CampaignsWithoutNumber.Domain;

namespace CampaignsWithoutNumber.Infrastructure.Repositories
{
  public sealed class CharacterRepository : ICharacterRepository
  {
    public Character? GetCharacter(Guid id)
    {
      return new Character
      {
        Id = id,
        Name = "Zakary Boven",
        Level = 7,
        Class = new GameClass
        {
          Name = "Fighter",
          HitPointsPerLevel = 3,
          AttackBonusPerLevel = 3
        }
      };
    }
  }
}