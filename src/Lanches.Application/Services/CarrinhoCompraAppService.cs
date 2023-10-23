using Lanches.Application.Interfaces;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;

namespace Lanches.Application.Services;

public class CarrinhoCompraAppService : ICarrinhoCompraAppService
{
    private readonly ICarrinhoCompraRepository _carrinhoCompraRepository;
    private readonly ICarrinhoCompraItemRepository _carrinhoCompraItemRepository;
    private readonly IItemRepository _itemRepository;

    public CarrinhoCompraAppService(ICarrinhoCompraRepository carrinhoCompraRepository, ICarrinhoCompraItemRepository carrinhoCompraItemRepository, IItemRepository itemRepository)
    {
        _carrinhoCompraRepository = carrinhoCompraRepository;
        _carrinhoCompraItemRepository = carrinhoCompraItemRepository;
        _itemRepository = itemRepository;
    }

    public CarrinhoCompra ObterCarrinhoCompra(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return CarrinhoCompra.ObterCarrinhoCompra();

        return _carrinhoCompraRepository.GetById(id) ?? CarrinhoCompra.ObterCarrinhoCompra();
    }

    public void AdicionarAoCarrinhoCompra(CarrinhoCompra carrinhoCompra, int itemId)
    {
        var ItemSelecionado = _itemRepository.GetById(itemId);
        var carrinhoCompraItem =
            _carrinhoCompraItemRepository.GetByCarrinhoCompraELanche(carrinhoCompra, ItemSelecionado);

        if (carrinhoCompraItem is null)
        {
            carrinhoCompraItem = new CarrinhoCompraItem(carrinhoCompra.Id, ItemSelecionado);
            _carrinhoCompraItemRepository.Add(carrinhoCompraItem);
        }
        else
            carrinhoCompraItem.AumentarQuantidade(ItemSelecionado);

        _carrinhoCompraItemRepository.Update(carrinhoCompraItem);
    }

    public void RemoverDoCarrinho(CarrinhoCompra carrinhoCompra, int itemId)
    {
        var itemSelecionado = _itemRepository.GetById(itemId);
        var itens =
            _carrinhoCompraItemRepository.GetByCarrinhoCompraELanche(carrinhoCompra, itemSelecionado);

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

    public IEnumerable<CarrinhoCompraItem> ObterItensDoCarrinhoDeCompra(CarrinhoCompra carrinhoCompra)
    {
        return _carrinhoCompraItemRepository.GetByCarrinhoCompra(carrinhoCompra);
    }

    public void LimparCarrinho(CarrinhoCompra carrinhoCompra)
    {
        var carrinhoCompraItens = _carrinhoCompraItemRepository.GetByCarrinhoCompra(carrinhoCompra);

        if (carrinhoCompraItens.Any())
            _carrinhoCompraItemRepository.DeleteEmLote(carrinhoCompraItens);
    }

    public decimal ObterValorTotalDoCarrinho(CarrinhoCompra carrinhoCompra)
    {
        return carrinhoCompra.PrecoTotal();
    }
}
