using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Mappers;
using CampaignsWithoutNumber.Shared.Models;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.Services
{
  public class CharacterService
  {
    private readonly CampaignDbContext _db = new();

    public IEnumerable<CharacterDto> GetAllCharacters()
    {
      var allCharacters = _db.CharacterCollection.Find(_ => true).ToList();
      foreach (var character in allCharacters)
      {
        yield return CharacterMapper.ToDto(character);
      }
    }
    
    public void AddCharacter(CharacterDto character)
    {
      _db.CharacterCollection.InsertOne(CharacterMapper.ToEntity(character));
    }
    
    public CharacterDto GetCharacterData(string id)
    {
      var filterCharacterData = Builders<Character>.Filter.Eq("Id", id);
      var character = _db.CharacterCollection.Find(filterCharacterData).FirstOrDefault();
      return CharacterMapper.ToDto(character);
    }
    
    public void UpdateCharacter(CharacterDto character)
    {
      _db.CharacterCollection.ReplaceOne(g => g.Id == character.Id, CharacterMapper.ToEntity(character));
    }

    public void DeleteCharacter(string id)
    {
      var characterData = Builders<Character>.Filter.Eq("Id", id);
      _db.CharacterCollection.DeleteOne(characterData);
    }
  }
}