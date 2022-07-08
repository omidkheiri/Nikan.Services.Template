using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;

namespace Nikan.Services.{ Service_Name }.WebApi.V1.Endpoints.CompanyEndPoints;

public class ListCompanyResponse
{
  public PagedList<Company> Companies { get; set; }
}
