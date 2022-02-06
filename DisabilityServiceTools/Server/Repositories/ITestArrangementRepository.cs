using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface ITestArrangementRepository
  {
    Task<List<TestArrangement>> Get();
    Task<PagedList<TestArrangement>> GetList(TestArrangementParameters testArrangementParameters);
    Task<TestArrangement> Get(int id);
    Task<TestArrangement> Add(TestArrangement Student);
    Task<TestArrangement> Update(TestArrangement Student);
    Task<TestArrangement> Delete(int id);
  }
}