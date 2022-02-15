using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Models;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.Services
{
  public class CharacterClassService
  {
    private readonly CampaignDbContext _db = new();

    public IEnumerable<CharacterClass> GetAllCharacterClasss()
    {
      return _db.CharacterClassCollection.Find(_ => true).ToList();
    }
    
    public void AddCharacterClass(CharacterClass character)
    {
      _db.CharacterClassCollection.InsertOne(character);
    }
    
    public CharacterClass GetCharacterClassData(string id)
    {
      var filterCharacterClassData = Builders<CharacterClass>.Filter.Eq("Id", id);
      return _db.CharacterClassCollection.Find(filterCharacterClassData).FirstOrDefault();
    }
    
    public void UpdateCharacterClass(CharacterClass characterClass)
    {
      _db.CharacterClassCollection.ReplaceOne(g => g.Id == characterClass.Id, characterClass);
    }

    public void DeleteCharacterClass(string id)
    {
      var characterData = Builders<CharacterClass>.Filter.Eq("Id", id);
      _db.CharacterClassCollection.DeleteOne(characterData);
    }
  }
}