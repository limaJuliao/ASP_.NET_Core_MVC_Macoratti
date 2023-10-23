using Lanches.Application.Interfaces;
using Lanches.Application.Services;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.Infra.CrossCutting.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<ICarrinhoCompraAppService, CarrinhoCompraAppService>();
        services.AddScoped<ICategoriaAppService, CategoriaAppService>();

        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<ICarrinhoCompraRepository, CarrinhoCompraRepository>();
        services.AddScoped<ICarrinhoCompraItemRepository, CarrinhoCompraItemRepository>();
    }
}
