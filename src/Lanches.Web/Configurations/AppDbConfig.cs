using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Web.Configurations;

public static class AppDbConfig
{
    public static void AddAppDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
