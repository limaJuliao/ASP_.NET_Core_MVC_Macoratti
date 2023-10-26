using Lanches.Application.Interfaces;
using Lanches.Application.Services;
using Lanches.Domain.Entities;
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
        services.AddScoped<IItemAppService, ItemAppService>();

        services.AddScoped(s => CarrinhoCompra.GetCarrinho(s));

        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<ICarrinhoCompraItemRepository, CarrinhoCompraItemRepository>();
    }
}
