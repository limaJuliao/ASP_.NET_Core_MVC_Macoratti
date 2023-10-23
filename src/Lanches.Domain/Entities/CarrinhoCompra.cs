using Lanches.Domain.Interfaces;

namespace Lanches.Domain.Entities;

public class CarrinhoCompra : BaseEntity
{
    public string Id { get; private set; }
    public List<CarrinhoCompraItem> CarrinhoCompraItens { get; private set; }

    private CarrinhoCompra() { }
    public CarrinhoCompra(string id)
    {
        Id = id;
        CarrinhoCompraItens = new(); //Todo Rever esta instanciação da lista no contrutor
    }

    public decimal PrecoTotal()
    {
        return CarrinhoCompraItens.Select(i => i.Item.Preco * i.Quantidade).Sum();
    }

    public static CarrinhoCompra ObterCarrinhoCompra()
    {
        return new CarrinhoCompra(Guid.NewGuid().ToString());
    }
}
