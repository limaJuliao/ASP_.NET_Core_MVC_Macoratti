namespace Lanches.Domain.Entities;

public class CarrinhoCompraItem : BaseEntity
{
    public Item Item { get; private set; }
    public int Quantidade { get; private set; }
    public string CarrinhoCompraId { get; private set; }
    public CarrinhoCompra CarrinhoCompra { get; private set; }

    private CarrinhoCompraItem() { }

    public CarrinhoCompraItem(string carrinhoCompraId, Item item)
    {
        CarrinhoCompraId = carrinhoCompraId;
        Item = item;
        Quantidade++;
    }

    public void AumentarQuantidade(Item item)
    {
        Quantidade++;
    }

    public void DiminuirQuantidade()
    {
        Quantidade--;
    }

    public decimal ObterSubtotal() => Item.Preco * Quantidade;
}
