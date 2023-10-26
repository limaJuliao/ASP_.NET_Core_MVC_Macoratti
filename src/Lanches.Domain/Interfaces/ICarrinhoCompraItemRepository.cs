using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ICarrinhoCompraItemRepository : IBaseRepository<CarrinhoCompraItem>
{
    IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(string carrinhoCompraId);
    CarrinhoCompraItem? GetByCarrinhoCompraIdEItemId(string carrinhoCompraId, int itemId);
    void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens);
}
