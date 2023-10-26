using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.Domain.Entities;

public class CarrinhoCompra
{
    public string Id { get; private set; }
    public ICollection<CarrinhoCompraItem> CarrinhoCompraItens { get; private set; }

    protected CarrinhoCompra()
    {
    }
    public CarrinhoCompra(string id, ICarrinhoCompraItemRepository carrinhoCompraItemRepository)
    {
        Id = id;
        CarrinhoCompraItens = carrinhoCompraItemRepository.GetByCarrinhoCompra(Id).ToList();
    }

    public decimal PrecoTotal()
    {
        return CarrinhoCompraItens.Select(i => i.Item.Preco * i.Quantidade).Sum();
    }
    public static CarrinhoCompra GetCarrinho(IServiceProvider serviceProvider)
    {
        var session = serviceProvider.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
        var carrinhoCompraId = session.GetString("carrinhoCompraId") ?? Guid.NewGuid().ToString();

        session.SetString("carrinhoCompraId", carrinhoCompraId);

        return new CarrinhoCompra(carrinhoCompraId, serviceProvider.GetService<ICarrinhoCompraItemRepository>()!);
    }
    public void AdicionarItem(Item item, ICarrinhoCompraItemRepository carrinhoCompraItemRepository)
    {
        var itemExistente = carrinhoCompraItemRepository.GetByCarrinhoCompraIdEItemId(Id, item.Id);

        if (itemExistente == null)
            carrinhoCompraItemRepository.Add(new CarrinhoCompraItem(Id, item));
        else
        {
            itemExistente.AumentarQuantidade();
            carrinhoCompraItemRepository.Update(itemExistente);
        }

    }
}
