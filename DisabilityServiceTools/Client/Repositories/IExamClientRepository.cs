using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface IExamClientRepository
  {
    Task<PagingResponse<Exam>> GetExams(ExamParameters examParameters);
    Task<Exam> GetExam(int id);
  }
}