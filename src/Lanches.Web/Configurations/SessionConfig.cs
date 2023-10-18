namespace Lanches.Web.Configurations;

public static class SessionConfig
{
    public static void AddSessionConfiguration(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

        services.AddMemoryCache();
        services.AddSession();
    }
}
