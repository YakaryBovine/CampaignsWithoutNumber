using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface ICourseClientRepository
  {
    Task<PagingResponse<Course>> GetCourses(CourseParameters courseParameters);
    Task<Course> GetCourse(int id);
  }
}