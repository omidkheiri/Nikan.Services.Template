using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.Infrastructure.Data;
using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;

namespace Nikan.Services.{ Service_Name }.Infrastructure;

public static class StartupSetup
{
  public static void AddDbContext(this IServiceCollection services, string connectionString)
  {
    services.AddDbContext<AppDbContext>(options =>
      options.UseNpgsql(connectionString));
    // will be created in web project root

  }



}
