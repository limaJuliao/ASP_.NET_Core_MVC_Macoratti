using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ICarrinhoCompraItemRepository : IBaseRepository<CarrinhoCompraItem>
{
    IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(CarrinhoCompra carrinhoCompra);
    CarrinhoCompraItem? GetByCarrinhoCompraEItem(CarrinhoCompra carrinhoCompra, Item Item);
    void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens);
}
