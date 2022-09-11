using System.Collections.Generic;
using CampaignsWithoutNumber.Server.Services;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers;

[Route("api/character")]
public class CharacterController : Controller
{
  private readonly CharacterService _characterService = new();

  [HttpGet]
  [Route("index")]
  public IEnumerable<CharacterDto> Index()
  {
    return _characterService.GetAllCharacters();
  }

  [HttpPost]
  [Route("create")]
  public void Create([FromBody] CharacterDto character)
  {
    _characterService.AddCharacter(character);
  }

  [HttpGet]
  [Route("details/{id}")]
  public CharacterDto Details(string id)
  {
    return _characterService.GetCharacterData(id);
  }

  [HttpPut("{character}")]
  [Route("edit")]
  public void Edit([FromBody] CharacterDto character)
  {
    _characterService.UpdateCharacter(character);
  }

  [HttpDelete]
  [Route("delete/{id}")]
  public void Delete(string id)
  {
    _characterService.DeleteCharacter(id);
  }
}