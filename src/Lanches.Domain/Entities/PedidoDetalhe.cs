namespace Lanches.Domain.Entities;

public class PedidoDetalhe : BaseEntity
{
    public int Quantidade { get; private set; }
    public decimal Preco { get; private set; }
    public int LancheId { get; private set; }
    public int PedidoId { get; private set; }

    public virtual Item Item { get; private set; }
    public virtual Pedido Pedido { get; private set; }
}