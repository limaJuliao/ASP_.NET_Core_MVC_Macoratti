namespace Lanches.Domain.Entities;

public class Pedido : BaseEntity
{
    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }
    public string Endereco { get; private set; }
    public string Complemento { get; private set; }
    public string CEP { get; private set; }
    public string Estado { get; private set; }
    public string Cidade { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public decimal PedidoTotal { get; private set; }
    public int TotalItensPedido { get; private set; }
    public DateTime PedidoEnviado { get; private set; }
    public DateTime? PedidoEntregueEm { get; private set; }

    public List<PedidoDetalhe> PedidoItens { get; private set; }
}
