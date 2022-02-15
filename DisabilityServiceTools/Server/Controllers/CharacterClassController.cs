using System.Collections.Generic;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/characterclass")]
  public class CharacterClassController : Controller
  {
    private readonly CharacterClassService _characterClassService = new();

    [HttpGet]
    [Route("index")]
    public IEnumerable<CharacterClass> Index()
    {
      return _characterClassService.GetAllCharacterClasss();
    }

    [HttpPost]
    [Route("create")]
    public void Create([FromBody] CharacterClass character)
    {
      _characterClassService.AddCharacterClass(character);
    }

    [HttpGet]
    [Route("details/{id}")]
    public CharacterClass Details(string id)
    {
      return _characterClassService.GetCharacterClassData(id);
    }

    [HttpPut]
    [Route("edit")]
    public void Edit([FromBody] CharacterClass character)
    {
      _characterClassService.UpdateCharacterClass(character);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public void Delete(string id)
    {
      _characterClassService.DeleteCharacterClass(id);
    }
  }
}