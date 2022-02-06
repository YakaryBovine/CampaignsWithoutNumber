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
  public class ExamRepository : IExamRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public ExamRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<Exam>> Get()
    {
      return await _context.Exam.ToListAsync();
    }

    public async Task<PagedList<Exam>> GetList(ExamParameters examParameters)
    {
      var exams = await _context.Exam
        .Include(exam => exam.CourseNavigation)
        .Search(examParameters.SearchTerm)
        .Sort(examParameters.OrderBy)
        .ToListAsync();

      return PagedList<Exam>
        .ToPagedList(exams, examParameters.PageNumber, examParameters.PageSize);
    }

    public async Task<Exam> Get(int id)
    {
      var student = await _context.Exam.FindAsync(id);
      return student;
    }

    public async Task<Exam> Add(Exam student)
    {
      _context.Exam.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Exam> Update(Exam student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Exam> Delete(int id)
    {
      var student = await _context.Exam.FindAsync(id);
      _context.Exam.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }
  }
}