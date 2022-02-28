using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using CampaignsWithoutNumber.Shared.Mappers;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.Services
{
  public class CharacterClassService
  {
    private readonly CampaignDbContext _db = new();

    public IEnumerable<CharacterClassDto> GetAllCharacterClasss()
    {
      var allCharacterClasses = _db.CharacterClassCollection.Find(_ => true).ToList();
      foreach (var character in allCharacterClasses)
      {
        yield return CharacterClassMapper.ToDto(character);
      }
    }
    
    public void AddCharacterClass(CharacterClassDto character)
    {
      _db.CharacterClassCollection.InsertOne(CharacterClassMapper.ToEntity(character));
    }
    
    public CharacterClassDto GetCharacterClassData(string id)
    {
      var filterCharacterClassData = Builders<CharacterClass>.Filter.Eq("Id", id);
      var characterClass = _db.CharacterClassCollection.Find(filterCharacterClassData).FirstOrDefault();
      return CharacterClassMapper.ToDto(characterClass);
    }
    
    public void UpdateCharacterClass(CharacterClassDto characterClass)
    {
      _db.CharacterClassCollection.ReplaceOne(g => g.Id == characterClass.Id, CharacterClassMapper.ToEntity(characterClass));
    }

    public void DeleteCharacterClass(string id)
    {
      var characterData = Builders<CharacterClass>.Filter.Eq("Id", id);
      _db.CharacterClassCollection.DeleteOne(characterData);
    }
  }
}