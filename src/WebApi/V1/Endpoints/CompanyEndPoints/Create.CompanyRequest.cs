using System.ComponentModel.DataAnnotations;

namespace Nikan.Services.{ Service_Name }.WebApi.V1.Endpoints.CompanyEndPoints;

public class CreateCompanyRequest
{
  public const string Route = "/Companies";

  [Required] public string? Title { get; set; }
  [Required] public string? Phone { get; set; }
  [Required] public string? EmailAddress { get; set; }
  public string? PostalAddress { get; set; }

}
