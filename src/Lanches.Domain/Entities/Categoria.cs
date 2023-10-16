namespace Lanches.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
