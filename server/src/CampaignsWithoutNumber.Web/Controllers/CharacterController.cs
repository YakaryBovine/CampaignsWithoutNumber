using CampaignsWithoutNumber.Infrastructure.Repositories;
using CampaignsWithoutNumber.Web.DTOs;
using CampaignsWithoutNumber.Web.Mappers;

namespace CampaignsWithoutNumber.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public sealed class CharacterController(ICharacterRepository characterRepository) : ControllerBase
{
  [HttpGet("{id:guid}")]
  public ActionResult<CharacterDto> GetCharacter(Guid id)
  {
    var character = characterRepository.GetCharacter(id)?.ToDto();
    if (character == null) 
      return NotFound();

    return Ok(character);
  }
}