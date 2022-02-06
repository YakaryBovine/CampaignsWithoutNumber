using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface ICourseRepository
  {
    Task<List<Course>> Get();
    Task<PagedList<Course>> GetList(CourseParameters courseParameters);
    Task<Course> Get(int id);
    Task<Course> Add(Course Student);
    Task<Course> Update(Course Student);
    Task<Course> Delete(int id);
  }
}