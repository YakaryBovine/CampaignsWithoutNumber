using CampaignsWithoutNumber.Domain;

namespace CampaignsWithoutNumber.Infrastructure.Repositories
{
  public interface ICharacterRepository
  {
    Character? GetCharacter(Guid id);
  }
}