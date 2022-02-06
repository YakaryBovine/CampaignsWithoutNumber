using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface IExamArrangementClientRepository
  {
    Task<PagingResponse<ExamArrangement>> GetExamArrangements(ExamArrangementParameters examArrangementParameters);
    Task<ExamArrangement> GetExamArrangement(int id);
  }
}