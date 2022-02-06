using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface ITestArrangementClientRepository
  {
    Task<PagingResponse<TestArrangement>> GetTestArrangements(TestArrangementParameters testArrangementParameters);
    Task<TestArrangement> GetTestArrangement(int id);
  }
}