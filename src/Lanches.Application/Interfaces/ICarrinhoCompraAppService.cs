using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;

namespace Lanches.Application.Interfaces;

public interface ICarrinhoCompraAppService
{
    CarrinhoCompraViewModel ObterCarrinhoDeCompras();
    void AdicionarAoCarrinhoCompra(int itemId);
    void RemoverDoCarrinho(int itemId);
    IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompras();
    void LimparCarrinho();
}
