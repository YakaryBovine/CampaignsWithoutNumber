using System.Collections.Generic;
using CampaignsWithoutNumber.Shared.Models;
using MongoDB.Driver;

namespace CampaignsWithoutNumber.Server.DataAccess
{
  public class CharacterDataAccessLayer
  {
    readonly CampaignDbContext db = new CampaignDbContext();

    public List<Character> GetAllCharacters()
    {
      return db.CharacterRecord.Find(_ => true).ToList();
    }

    //To Add new Character record
    public void AddCharacter(Character character)
    {
      db.CharacterRecord.InsertOne(character);
    }

    //Get the details of a particular Character
    public Character GetCharacterData(string id)
    {
      var filterCharacterData = Builders<Character>.Filter.Eq("Id", id);
      return db.CharacterRecord.Find(filterCharacterData).FirstOrDefault();
    }

    //To Update the records of a particular Character
    public void UpdateCharacter(Character character)
    {
      db.CharacterRecord.ReplaceOne(filter: g => g.Id == character.Id, replacement: character);
    } //To Delete the record of a particular Character

    public void DeleteCharacter(string id)
    {
      var characterData = Builders<Character>.Filter.Eq("Id", id);
      db.CharacterRecord.DeleteOne(characterData);
    }

    public List<Item> GetCityData()
    {
      return db.ItemRecord.Find(_ => true).ToList();
    }
  }
}