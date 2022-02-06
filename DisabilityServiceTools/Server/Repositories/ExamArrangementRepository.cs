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
  public class ExamArrangementRepository : IExamArrangementRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public ExamArrangementRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<ExamArrangement>> Get()
    {
      return await _context.ExamArrangement.ToListAsync();
    }

    public async Task<PagedList<ExamArrangement>> GetList(ExamArrangementParameters examArrangementParameters)
    {
      var examArrangements = await _context.ExamArrangement
        .Search(examArrangementParameters.SearchTerm)
        .Sort(examArrangementParameters.OrderBy)
        .ToListAsync();

      return PagedList<ExamArrangement>
        .ToPagedList(examArrangements, examArrangementParameters.PageNumber, examArrangementParameters.PageSize);
    }

    public async Task<ExamArrangement> Get(int id)
    {
      var student = await _context.ExamArrangement.FindAsync(id);
      return student;
    }

    public async Task<ExamArrangement> Add(ExamArrangement student)
    {
      _context.ExamArrangement.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<ExamArrangement> Update(ExamArrangement student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<ExamArrangement> Delete(int id)
    {
      var student = await _context.ExamArrangement.FindAsync(id);
      _context.ExamArrangement.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }
  }
}