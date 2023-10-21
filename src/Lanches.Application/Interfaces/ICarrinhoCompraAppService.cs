using Lanches.Domain.Entities;

namespace Lanches.Application.Interfaces;

public interface ICarrinhoCompraAppService
{
    CarrinhoCompra ObterCarrinhoCompra(string id);
    void AdicionarAoCarrinhoCompra(CarrinhoCompra carrinhoCompra, int lancheId);
    void RemoverDoCarrinho(CarrinhoCompra carrinhoCompra, int lancheId);
    IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompra(CarrinhoCompra carrinhoCompra);
    void LimparCarrinho(CarrinhoCompra carrinhoCompra);
    decimal ObterValorTotalDoCarrinho(CarrinhoCompra carrinhoCompra);

}
