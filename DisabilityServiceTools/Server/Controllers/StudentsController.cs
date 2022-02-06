using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabilityServiceTools.Shared.RequestFeatures;
using DisabilityServiceTools.Server.Repositories;
using Newtonsoft.Json;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentsController : ControllerBase
  {
    private readonly IStudentRepository _repository;

    public StudentsController(IStudentRepository repository)
    {
      _repository = repository;
    }

    // GET: api/Students
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] StudentParameters studentParameters)
    {
      var students = await _repository.GetList(studentParameters);
      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(students.MetaData));
      return Ok(students);
    }

    // GET: api/Students/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
      var student = await _repository.Get(id);

      if (student == null)
      {
        return NotFound();
      }

      return student;
    }

    // POST: api/Students
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(Student student)
    {
      if (student == null)
        return BadRequest("Student has not been set");
      await _repository.Create(student);

      return CreatedAtAction("GetStudent", new { id = student.Id }, student);
    }
  }
}
