using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabilityServiceTools.Shared.RequestFeatures;
using DisabilityServiceTools.Server.Repositories;
using Newtonsoft.Json;

namespace DisabilityServiceTools.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TestArrangementsController : ControllerBase
  {
    private readonly ITestArrangementRepository _repository;

    public TestArrangementsController(ITestArrangementRepository repository)
    {
      _repository = repository;
    }

    // GET: api/Students
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] TestArrangementParameters testArrangementParameters)
    {
      var testArrangements = await _repository.GetList(testArrangementParameters);
      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(testArrangements.MetaData));
      return Ok(testArrangements);
    }
  }
}
