using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabilityServiceTools.Server.Repositories;
using DisabilityServiceTools.Shared.RequestFeatures;
using Newtonsoft.Json;

namespace DisabilityServiceTools.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExamsController : ControllerBase
  {
    private readonly IExamRepository _repository;

    public ExamsController(IExamRepository repository)
    {
      _repository = repository;
    }

    // GET: api/Exams
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] ExamParameters examParameters)
    {
      var exams = await _repository.GetList(examParameters);
      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(exams.MetaData));
      return Ok(exams);
    }
  }
}
