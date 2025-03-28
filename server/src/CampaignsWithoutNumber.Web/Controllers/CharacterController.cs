using CampaignsWithoutNumber.Domain;
using CampaignsWithoutNumber.Web.DTOs;
using CampaignsWithoutNumber.Web.Mappers;

namespace CampaignsWithoutNumber.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
  [HttpGet("{id:guid}")]
  public ActionResult<CharacterDto> GetCharacter(Guid id)
  {
    var character = new Character
    {
      Id = id,
      Name = "Zakary Boven",
      Level = 7,
      Class = new GameClass
      {
        Name = "Fighter",
        HitPointsPerLevel = 3,
        AttackBonusPerLevel = 3
      }
    }.ToDto();
    return Ok(character);
  }
}