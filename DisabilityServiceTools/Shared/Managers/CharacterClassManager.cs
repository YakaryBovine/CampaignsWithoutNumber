using System.Collections.Generic;
using System.Linq;

namespace CampaignsWithoutNumber.Shared.Managers
{
  public static class CharacterClassManager
  {
    private static readonly Dictionary<int, ICharacterClass> CharacterClassesById = new();
    
    public static void Register(ICharacterClass characterClass)
    {
      CharacterClassesById.Add(characterClass.Id, characterClass);
    }

    public static IEnumerable<ICharacterClass> GetAll() => CharacterClassesById.Values.ToList().AsReadOnly();

    public static ICharacterClass GetById(int id) => CharacterClassesById[id];
  }
}