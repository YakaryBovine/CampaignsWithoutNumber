using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Server.Repositories;
using DisabilityServiceTools.Shared.RequestFeatures;
using Newtonsoft.Json;

namespace DisabilityServiceTools.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TestsController : ControllerBase
  {
    private readonly ITestRepository _repository;

    public TestsController(ITestRepository repository)
    {
      _repository = repository;
    }

    // GET: api/Students
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] TestParameters testParameters)
    {
      var tests = await _repository.GetList(testParameters);
      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(tests.MetaData));
      return Ok(tests);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Test>> GetTest(int id)
    {
      var test = await _repository.Get(id);

      if (test == null)
      {
        return NotFound();
      }

      return test;
    }

    // POST: api/Tests
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<Test>> PostTest(Test test)
    {
      if (test == null)
        return BadRequest("Test has not been set");

      await _repository.Create(test);

      return CreatedAtAction(nameof(Get), new { id = test.Id }, test);
    }
  }
}
