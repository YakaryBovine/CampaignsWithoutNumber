//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using DisabilityServiceTools.Server.Data;
//using DisabilityServiceTools.Shared.Models;
//using DisabilityServiceTools.Server.Repositories;
//using DisabilityServiceTools.Shared.RequestFeatures;
//using Newtonsoft.Json;

//namespace DisabilityServiceTools.Server.Controllers
//{
//  [Route("api/[controller]")]
//  [ApiController]
//  public class CourseStreamsController : ControllerBase
//  {
//    private readonly ICourseStreamRepository _repository;

//    public CourseStreamsController(ICourseStreamRepository repository)
//    {
//      _repository = repository;
//    }

//    // GET: api/Students
//    [HttpGet]
//    public async Task<IActionResult> Get([FromQuery] CourseStreamParameters studentParameters)
//    {
//      var students = await _repository.GetList(studentParameters);
//      Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(students.MetaData));
//      return Ok(students);
//    }

//    // GET: api/CourseStreams/5
//    [HttpGet("{id}")]
//    public async Task<ActionResult<CourseStream>> GetCourseStream(int id)
//    {
//      var courseStream = await _context.CourseStream.FindAsync(id);

//      if (courseStream == null)
//      {
//        return NotFound();
//      }

//      return courseStream;
//    }

//    // PUT: api/CourseStreams/5
//    // To protect from overposting attacks, enable the specific properties you want to bind to, for
//    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//    [HttpPut("{id}")]
//    public async Task<IActionResult> PutCourseStream(int id, CourseStream courseStream)
//    {
//      if (id != courseStream.Id)
//      {
//        return BadRequest();
//      }

//      _context.Entry(courseStream).State = EntityState.Modified;

//      try
//      {
//        await _context.SaveChangesAsync();
//      }
//      catch (DbUpdateConcurrencyException)
//      {
//        if (!CourseStreamExists(id))
//        {
//          return NotFound();
//        }
//        else
//        {
//          throw;
//        }
//      }

//      return NoContent();
//    }

//    // POST: api/CourseStreams
//    // To protect from overposting attacks, enable the specific properties you want to bind to, for
//    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//    [HttpPost]
//    public async Task<ActionResult<CourseStream>> PostCourseStream(CourseStream courseStream)
//    {
//      _context.CourseStream.Add(courseStream);
//      await _context.SaveChangesAsync();

//      return CreatedAtAction("GetCourseStream", new { id = courseStream.Id }, courseStream);
//    }

//    // DELETE: api/CourseStreams/5
//    [HttpDelete("{id}")]
//    public async Task<ActionResult<CourseStream>> DeleteCourseStream(int id)
//    {
//      var courseStream = await _context.CourseStream.FindAsync(id);
//      if (courseStream == null)
//      {
//        return NotFound();
//      }

//      _context.CourseStream.Remove(courseStream);
//      await _context.SaveChangesAsync();

//      return courseStream;
//    }

//    private bool CourseStreamExists(int id)
//    {
//      return _context.CourseStream.Any(e => e.Id == id);
//    }
//  }
//}
