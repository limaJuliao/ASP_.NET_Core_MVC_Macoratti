namespace Lanches.Domain.Entities;

public class CarrinhoCompraItem: BaseEntity
{
    public Lanche Lanche { get; set; }
    public int Quantidade { get; set; }
    public string CarrinhoCompraId { get; set; }
    public CarrinhoCompra CarrinhoCompra { get; set; }
}
