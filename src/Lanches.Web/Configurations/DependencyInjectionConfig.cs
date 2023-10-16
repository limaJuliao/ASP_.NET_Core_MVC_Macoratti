using Lanches.Infra.CrossCutting.IoC;

namespace Lanches.Web.Configurations;

public static class DependencyInjectionConfig
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        DependencyContainer.RegisterServices(services);
    }
}
