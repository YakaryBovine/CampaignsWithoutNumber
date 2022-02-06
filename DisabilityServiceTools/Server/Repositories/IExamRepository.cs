using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface IExamRepository
  {
    Task<List<Exam>> Get();
    Task<PagedList<Exam>> GetList(ExamParameters examParameters);
    Task<Exam> Get(int id);
    Task<Exam> Add(Exam Exam);
    Task<Exam> Update(Exam Exam);
    Task<Exam> Delete(int id);
  }
}