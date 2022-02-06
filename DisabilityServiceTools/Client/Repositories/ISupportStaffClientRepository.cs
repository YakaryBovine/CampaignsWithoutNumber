using DisabilityServiceTools.Client.Features;
using DisabilityServiceTools.Shared.Models;
using DisabilityServiceTools.Shared.RequestFeatures;
using System.Threading.Tasks;

namespace DisabilityServiceTools.Client.Repositories
{
  public interface ISupportStaffClientRepository
  {
    Task<PagingResponse<SupportStaff>> GetSupportStaffs(SupportStaffParameters supportStaffParameters);
    Task<SupportStaff> GetSupportStaff(int id);
  }
}