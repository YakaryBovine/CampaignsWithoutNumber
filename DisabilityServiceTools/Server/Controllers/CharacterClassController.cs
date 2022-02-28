using System.Collections.Generic;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/characterclass")]
  public class CharacterClassController : Controller
  {
    private readonly CharacterClassService _characterClassService = new();

    [HttpGet]
    [Route("index")]
    public IEnumerable<CharacterClassDto> Index()
    {
      return _characterClassService.GetAllCharacterClasss();
    }

    [HttpPost]
    [Route("create")]
    public void Create([FromBody] CharacterClassDto character)
    {
      _characterClassService.AddCharacterClass(character);
    }

    [HttpGet]
    [Route("details/{id}")]
    public CharacterClassDto Details(string id)
    {
      return _characterClassService.GetCharacterClassData(id);
    }

    [HttpPut]
    [Route("edit")]
    public void Edit([FromBody] CharacterClassDto character)
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