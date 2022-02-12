using System.Collections.Generic;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/character")]
  public class CharacterController : Controller
  {
    private readonly CharacterService _characterService = new();

    [HttpGet]
    [Route("index")]
    public IEnumerable<Character> Index()
    {
      return _characterService.GetAllCharacters();
    }

    [HttpPost]
    [Route("create")]
    public void Create([FromBody] Character character)
    {
      _characterService.AddCharacter(character);
    }

    [HttpGet]
    [Route("details/{id}")]
    public Character Details(string id)
    {
      return _characterService.GetCharacterData(id);
    }

    [HttpPut]
    [Route("edit")]
    public void Edit([FromBody] Character character)
    {
      _characterService.UpdateCharacter(character);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public void Delete(string id)
    {
      _characterService.DeleteCharacter(id);
    }

    [HttpGet]
    [Route("getitem")]
    public List<Item> GetItem()
    {
      return _characterService.GetCityData();
    }
  }
}