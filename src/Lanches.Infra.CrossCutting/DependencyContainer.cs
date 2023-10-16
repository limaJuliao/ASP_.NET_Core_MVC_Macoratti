using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.Infra.CrossCutting.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<ILancheRepository, LancheRepository>();
    }
}
