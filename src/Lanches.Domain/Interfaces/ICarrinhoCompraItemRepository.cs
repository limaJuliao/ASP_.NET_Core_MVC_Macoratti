using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ICarrinhoCompraItemRepository : IBaseRepository<CarrinhoCompraItem>
{
    IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(CarrinhoCompra carrinhoCompra);
    CarrinhoCompraItem? GetByCarrinhoCompraEItem(CarrinhoCompra carrinhoCompra, Item Item);
    CarrinhoCompraItem Update(CarrinhoCompraItem carrinhoCompraItem);
    void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens);
}
