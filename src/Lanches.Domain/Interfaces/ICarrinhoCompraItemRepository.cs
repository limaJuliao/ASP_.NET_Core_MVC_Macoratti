using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ICarrinhoCompraItemRepository : IBaseRepository<CarrinhoCompraItem>
{
    IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(CarrinhoCompra carrinhoCompra);
    CarrinhoCompraItem? GetByCarrinhoCompraELanche(CarrinhoCompra carrinhoCompra, Item lanche);
    CarrinhoCompraItem Update(CarrinhoCompraItem carrinhoCompraItem);
    void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens);
}
