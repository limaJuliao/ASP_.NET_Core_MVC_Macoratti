using Lanches.Application.Interfaces;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;

namespace Lanches.Application.Services;

public class CarrinhoCompraAppService : ICarrinhoCompraAppService
{
    private readonly ICarrinhoCompraItemRepository _carrinhoCompraItemRepository;
    private readonly IItemRepository _itemRepository;

    public CarrinhoCompraAppService(ICarrinhoCompraItemRepository carrinhoCompraItemRepository, IItemRepository itemRepository)
    {
        _carrinhoCompraItemRepository = carrinhoCompraItemRepository;
        _itemRepository = itemRepository;
    }

    public void AdicionarAoCarrinhoCompra(CarrinhoCompra carrinhoCompra, int itemId)
    {
        var item = _itemRepository.GetById(itemId);

        if (item is not null)
            carrinhoCompra.AdicionarItem(item, _carrinhoCompraItemRepository);
    }

    public void RemoverDoCarrinho(CarrinhoCompra carrinhoCompra, int itemId)
    {
        var itemSelecionado = _itemRepository.GetById(itemId);
        var itens =
            _carrinhoCompraItemRepository.GetByCarrinhoCompraEItem(carrinhoCompra, itemSelecionado);

        if (itens is not null)
            if (itens.Quantidade > 1)
            {
                itens.DiminuirQuantidade();

                _carrinhoCompraItemRepository.Update(itens);
            }
            else
            {
                _carrinhoCompraItemRepository.Delete(itens);
            }
    }

    public void LimparCarrinho(CarrinhoCompra carrinhoCompra)
    {
        var carrinhoCompraItens = _carrinhoCompraItemRepository.GetByCarrinhoCompra(carrinhoCompra);

        if (carrinhoCompraItens.Any())
            _carrinhoCompraItemRepository.DeleteEmLote(carrinhoCompraItens);
    }

    public IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompra(CarrinhoCompra carrinhoCompra)
    {
        return _carrinhoCompraItemRepository.GetByCarrinhoCompra(carrinhoCompra);
    }
}
