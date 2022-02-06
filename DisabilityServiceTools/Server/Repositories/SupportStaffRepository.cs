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
  public class SupportStaffRepository : ISupportStaffRepository
  {
    private readonly DisabilityServiceDBContext _context;

    public SupportStaffRepository(DisabilityServiceDBContext context)
    {
      _context = context;
    }

    public async Task<List<SupportStaff>> Get()
    {
      return await _context.SupportStaff.ToListAsync();
    }

    public async Task<PagedList<SupportStaff>> GetList(SupportStaffParameters studentParameters)
    {
      var students = await _context.SupportStaff
        .Search(studentParameters.SearchTerm)
        .Sort(studentParameters.OrderBy)
        .ToListAsync();

      return PagedList<SupportStaff>
        .ToPagedList(students, studentParameters.PageNumber, studentParameters.PageSize);
    }

    public async Task<SupportStaff> Get(int id)
    {
      var student = await _context.SupportStaff.FindAsync(id);
      return student;
    }

    public async Task<SupportStaff> Add(SupportStaff student)
    {
      _context.SupportStaff.Add(student);
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<SupportStaff> Update(SupportStaff student)
    {
      _context.Entry(student).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return student;
    }

    public async Task<SupportStaff> Delete(int id)
    {
      var student = await _context.SupportStaff.FindAsync(id);
      _context.SupportStaff.Remove(student);
      await _context.SaveChangesAsync();
      return student;
    }
  }
}