using Lanches.Application.Interfaces;
using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;

namespace Lanches.Application.Services;

public class CarrinhoCompraAppService : ICarrinhoCompraAppService
{
    private readonly ICarrinhoCompraItemRepository _carrinhoCompraItemRepository;
    private readonly IItemRepository _itemRepository;
    private readonly CarrinhoCompra _carrinhoCompra;

    public CarrinhoCompraAppService(ICarrinhoCompraItemRepository carrinhoCompraItemRepository, IItemRepository itemRepository,
        CarrinhoCompra carrinhoCompra)
    {
        _carrinhoCompraItemRepository = carrinhoCompraItemRepository;
        _itemRepository = itemRepository;
        _carrinhoCompra = carrinhoCompra;
    }

    public void AdicionarAoCarrinhoCompra(int itemId)
    {
        var item = _itemRepository.GetById(itemId);

        if (item is not null)
            _carrinhoCompra.AdicionarItem(item, _carrinhoCompraItemRepository);
    }

    public void RemoverDoCarrinho(int itemId)
    {
        var item = _carrinhoCompraItemRepository.GetByCarrinhoCompraIdEItemId(_carrinhoCompra.Id, itemId);

        if (item is not null)
            if (item.Quantidade > 1)
            {
                item.DiminuirQuantidade();

                _carrinhoCompraItemRepository.Update(item);
            }
            else
            {
                _carrinhoCompraItemRepository.Delete(item);
            }
    }

    public void LimparCarrinho()
    {
        var carrinhoCompraItens = _carrinhoCompraItemRepository.GetByCarrinhoCompra(_carrinhoCompra.Id);

        if (carrinhoCompraItens.Any())
            _carrinhoCompraItemRepository.DeleteEmLote(carrinhoCompraItens);
    }

    public IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompras()
    {
        return _carrinhoCompraItemRepository.GetByCarrinhoCompra(_carrinhoCompra.Id);
    }

    public CarrinhoCompraViewModel ObterCarrinhoDeCompras()
    {
        return new CarrinhoCompraViewModel { CarrinhoCompra = _carrinhoCompra };
    }
}
