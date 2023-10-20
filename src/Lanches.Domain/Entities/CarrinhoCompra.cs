namespace Lanches.Domain.Entities;

public class CarrinhoCompra : BaseEntity
{
    public string Id { get; set; }
    public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
}
