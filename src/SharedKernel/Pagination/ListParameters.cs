namespace Nikan.Services.{ Service_Name }.SharedKernel.Pagination;

public class ListParameters : QueryStringParameters
{
  public ListParameters()
  {
    OrderBy = "DateCreated";
  }
}
