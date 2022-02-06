using DisabilityServiceTools.Shared.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Server.Repositories.RepositoryExtensions;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Server.Data;

namespace DisabilityServiceTools.Server.Repositories
{
  public class CourseRepository : ICourseRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public CourseRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<Course>> Get()
    {
      return await _context.Course.ToListAsync();
    }

    public async Task<PagedList<Course>> GetList(CourseParameters courseParameters)
    {
      var courses = await _context.Course
        .Search(courseParameters.SearchTerm)
        .Sort(courseParameters.OrderBy)
        .ToListAsync();

      return PagedList<Course>
        .ToPagedList(courses, courseParameters.PageNumber, courseParameters.PageSize);
    }

    public async Task<Course> Get(int id)
    {
      var course = await _context.Course.FindAsync(id);
      return course;
    }

    public async Task<Course> Add(Course course)
    {
      _context.Course.Add(course);
      await _context.SaveChangesAsync();
      return course;
    }

    public async Task<Course> Update(Course course)
    {
      _context.Entry(course).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return course;
    }

    public async Task<Course> Delete(int id)
    {
      var course = await _context.Course.FindAsync(id);
      _context.Course.Remove(course);
      await _context.SaveChangesAsync();
      return course;
    }
  }
}