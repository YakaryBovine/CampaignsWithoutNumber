using CampaignsWithoutNumber.Shared.DataTransferObjects;
using CampaignsWithoutNumber.Shared.Managers;
using CampaignsWithoutNumber.Shared.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace CampaignsWithoutNumber.Server.Controllers;

[Route("api/art")]
public class ArtController : Controller
{
	[HttpGet]
	[Route("details/{id}")]
	public ArtDto Details(string id)
	{
		return ArtMapper.ToDto(ArtManager.GetById(id));
	}
}