using Lanches.Domain.Entities;

namespace Lanches.Application.Interfaces;

public interface ICarrinhoCompraAppService
{
    void AdicionarAoCarrinhoCompra(CarrinhoCompra carrinhoCompra, int itemId);
    void RemoverDoCarrinho(CarrinhoCompra carrinhoCompra, int itemId);
    IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompra(CarrinhoCompra carrinhoCompra);
    void LimparCarrinho(CarrinhoCompra carrinhoCompra);
}
