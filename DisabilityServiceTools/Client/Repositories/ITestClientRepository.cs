using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface ITestClientRepository
  {
    Task<PagingResponse<Test>> GetTests(TestParameters testParameters);
    Task<Test> GetTest(int id);
    Task CreateTest(Test test);
  }
}