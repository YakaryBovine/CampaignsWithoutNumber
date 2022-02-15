using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Models;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.Services
{
  public class CharacterService
  {
    private readonly CampaignDbContext _db = new();

    public IEnumerable<Character> GetAllCharacters()
    {
      return _db.CharacterCollection.Find(_ => true).ToList();
    }
    
    public void AddCharacter(Character character)
    {
      _db.CharacterCollection.InsertOne(character);
    }
    
    public Character GetCharacterData(string id)
    {
      var filterCharacterData = Builders<Character>.Filter.Eq("Id", id);
      return _db.CharacterCollection.Find(filterCharacterData).FirstOrDefault();
    }
    
    public void UpdateCharacter(Character character)
    {
      _db.CharacterCollection.ReplaceOne(g => g.Id == character.Id, character);
    }

    public void DeleteCharacter(string id)
    {
      var characterData = Builders<Character>.Filter.Eq("Id", id);
      _db.CharacterCollection.DeleteOne(characterData);
    }

    public List<Item> GetCityData()
    {
      return _db.ItemCollection.Find(_ => true).ToList();
    }
  }
}