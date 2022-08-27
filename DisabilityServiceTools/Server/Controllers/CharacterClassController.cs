using System.Collections.Generic;
using System.Linq;
using CampaignsWithoutNumber.Server.Managers;
using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers
{
  [Route("api/characterclass")]
  public class CharacterClassController : Controller
  {
    [HttpGet]
    [Route("index")]
    public List<CharacterClassDto> Index()
    {
      return CharacterClassManager.GetAll().Select(CharacterClassMapper.ToDto).ToList();
    }

    [HttpGet]
    [Route("details/{id:int}")]
    public CharacterClassDto Details(int id)
    {
      return CharacterClassMapper.ToDto(CharacterClassManager.GetById(id));
    }
  }
}