using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabilityServiceTools.Server.Repositories;
using DisabilityServiceTools.Shared.RequestFeatures;
using Newtonsoft.Json;

namespace DisabilityServiceTools.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExamArrangementsController : ControllerBase
  {
    private readonly IExamArrangementRepository _repository;

    public ExamArrangementsController(IExamArrangementRepository repository)
    {
      _repository = repository;
    }

    // GET: api/Students
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] ExamArrangementParameters studentParameters)
    {
      var students = await _repository.GetList(studentParameters);
      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(students.MetaData));
      return Ok(students);
    }
  }
}
