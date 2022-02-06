using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface IStudentClientRepository
  {
    Task<PagingResponse<Student>> GetStudents(StudentParameters studentParameters);
    Task<Student> GetStudent(int id);

    Task Create(Student student);
  }
}