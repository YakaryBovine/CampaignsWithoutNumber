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
  public class TestRepository : ITestRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public TestRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<Test>> Get()
    {
      return await _context.Test.ToListAsync();
    }

    public async Task<PagedList<Test>> GetList(TestParameters studentParameters)
    {
      var students = await _context.Test
        .Include(test => test.Course)
        .Search(studentParameters.SearchTerm)
        .Sort(studentParameters.OrderBy)
        .ToListAsync();

      return PagedList<Test>
        .ToPagedList(students, studentParameters.PageNumber, studentParameters.PageSize);
    }

    public async Task<Test> Get(int id)
    {
      var student = await _context.Test.Include(test => test.Course).FirstOrDefaultAsync(i => i.Id == id);
      return student;
    }

    public async Task<Test> Add(Test student)
    {
      _context.Test.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Test> Update(Test student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Test> Delete(int id)
    {
      var student = await _context.Test.FindAsync(id);
      _context.Test.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task Create(Test test)
    {
      _context.Add(test);
      await _context.SaveChangesAsync();
    }
  }
}