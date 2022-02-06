using System.Collections.Generic;
using System.Threading.Tasks;
using CampaignsWithoutNumber.Server.Data;
using CampaignsWithoutNumber.Server.Paging;
using CampaignsWithoutNumber.Server.Repositories.RepositoryExtensions;
using CampaignsWithoutNumber.Shared.Models;
using CampaignsWithoutNumber.Shared.RequestFeatures;
using Microsoft.EntityFrameworkCore;

namespace CampaignsWithoutNumber.Server.Repositories
{
  public class StudentRepository : IStudentRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public StudentRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<Student>> Get()
    {
      return await _context.Student.ToListAsync();
    }

    public async Task<PagedList<Student>> GetList(StudentParameters testParameters)
    {
      var students = await _context.Student
        .Search(testParameters.SearchTerm)
        .Sort(testParameters.OrderBy)
        .ToListAsync();

      return PagedList<Student>
        .ToPagedList(students, testParameters.PageNumber, testParameters.PageSize);
    }

    public async Task<Student> Get(int id)
    {
      var student = await _context.Student.FindAsync(id);
      return student;
    }

    public async Task<Student> Add(Student student)
    {
      _context.Student.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Student> Update(Student student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<Student> Delete(int id)
    {
      var student = await _context.Student.FindAsync(id);
      _context.Student.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task Create(Student student)
    {
      _context.Add(student);
      await _context.SaveChangesAsync();
    }
  }
}