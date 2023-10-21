namespace Lanches.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        private Categoria() { }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public List<Item> Lanches { get; private set; }
    }
}
