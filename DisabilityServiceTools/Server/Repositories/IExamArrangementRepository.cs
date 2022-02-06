using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface IExamArrangementRepository
  {
    Task<List<ExamArrangement>> Get();
    Task<PagedList<ExamArrangement>> GetList(ExamArrangementParameters examParameters);
    Task<ExamArrangement> Get(int id);
    Task<ExamArrangement> Add(ExamArrangement ExamArrangement);
    Task<ExamArrangement> Update(ExamArrangement ExamArrangement);
    Task<ExamArrangement> Delete(int id);
  }
}