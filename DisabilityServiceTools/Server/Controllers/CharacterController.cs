using System.Collections.Generic;
using CampaignsWithoutNumber.Server.DataAccess;
using CampaignsWithoutNumber.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/Character")]
  public class CharacterController : Controller
  {
    private readonly CharacterDataAccessLayer _objCharacter = new CharacterDataAccessLayer();

    [HttpGet]
    [Route("Index")]
    public IEnumerable<Character> Index()
    {
      return _objCharacter.GetAllCharacters();
    }

    [HttpPost]
    [Route("Create")]
    public void Create([FromBody] Character character)
    {
      _objCharacter.AddCharacter(character);
    }

    [HttpGet]
    [Route("Details/{id}")]
    public Character Details(string id)
    {
      return _objCharacter.GetCharacterData(id);
    }

    [HttpPut]
    [Route("Edit")]
    public void Edit([FromBody] Character character)
    {
      _objCharacter.UpdateCharacter(character);
    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public void Delete(string id)
    {
      _objCharacter.DeleteCharacter(id);
    }

    [HttpGet]
    [Route("GetItem")]
    public List<Item> GetItem()
    {
      return _objCharacter.GetCityData();
    }
  }
}