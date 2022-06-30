using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nikan.Services.Template.Infrastructure.Data;

namespace Nikan.Services.Template.Infrastructure
{
  public static class StartupSetup
  {
    public static void AddDbContext(this IServiceCollection services, string connectionString) =>
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString)); // will be created in web project root
  }
}
