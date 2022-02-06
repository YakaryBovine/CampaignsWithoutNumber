using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface ITestRepository
  {
    Task<List<Test>> Get();
    Task<PagedList<Test>> GetList(TestParameters testParameters);
    Task<Test> Get(int id);
    Task<Test> Add(Test test);
    Task<Test> Update(Test test);
    Task<Test> Delete(int id);
    Task Create(Test test);
  }
}