using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;


namespace Nikan.Services.{ Service_Name }.WebApi.V1.Endpoints.CompanyEndPoints;

public class ListCompanyRequest : ListParameters
{
  public const string Route = "/Companies";

  public string SearchTerm { get; set; }

}
