using DisabilityServiceTools.Shared.RequestFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;
using DisabilityServiceTools.Server.Paging;
using DisabilityServiceTools.Shared.Models;

namespace DisabilityServiceTools.Server.Repositories
{
  public interface ISupportStaffRepository
  {
    Task<List<SupportStaff>> Get();
    Task<PagedList<SupportStaff>> GetList(SupportStaffParameters supportStaffParameters);
    Task<SupportStaff> Get(int id);
    Task<SupportStaff> Add(SupportStaff SupportStaff);
    Task<SupportStaff> Update(SupportStaff SupportStaff);
    Task<SupportStaff> Delete(int id);
  }
}