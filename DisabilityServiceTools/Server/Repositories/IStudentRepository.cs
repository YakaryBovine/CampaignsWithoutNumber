using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface IStudentRepository
  {
    Task<List<Student>> Get();
    Task<PagedList<Student>> GetList(StudentParameters studentParameters);
    Task<Student> Get(int id);
    Task<Student> Add(Student Student);
    Task<Student> Update(Student Student);
    Task<Student> Delete(int id);
    Task Create(Student student);
  }
}