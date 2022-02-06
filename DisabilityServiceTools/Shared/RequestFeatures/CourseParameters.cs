
namespace DisabilityServiceTools.Shared.RequestFeatures
{
  public class CourseParameters
  {
    const int maxPageSize = 200;
    public int PageNumber { get; set; } = 1;
    private int _pageSize = 10;
    public int PageSize
    {
      get
      {
        return _pageSize;
      }
      set
      {
        _pageSize = (value > maxPageSize) ? maxPageSize : value;
      }
    }

    public string SearchTerm { get; set; }
    public string OrderBy { get; set; } = "code";
  }
}