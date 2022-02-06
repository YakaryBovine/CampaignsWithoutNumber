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
  public class TestArrangementRepository : ITestArrangementRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public TestArrangementRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<TestArrangement>> Get()
    {
      return await _context.TestArrangement.ToListAsync();
    }

    public async Task<PagedList<TestArrangement>> GetList(TestArrangementParameters testArrangementParameters)
    {
      var students = await _context.TestArrangement
        .Search(testArrangementParameters.SearchTerm)
        .Sort(testArrangementParameters.OrderBy)
        .ToListAsync();

      return PagedList<TestArrangement>
        .ToPagedList(students, testArrangementParameters.PageNumber, testArrangementParameters.PageSize);
    }

    public async Task<TestArrangement> Get(int id)
    {
      var student = await _context.TestArrangement.FindAsync(id);
      return student;
    }

    public async Task<TestArrangement> Add(TestArrangement student)
    {
      _context.TestArrangement.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<TestArrangement> Update(TestArrangement student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<TestArrangement> Delete(int id)
    {
      var student = await _context.TestArrangement.FindAsync(id);
      _context.TestArrangement.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }
  }
}