namespace Lanches.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; private set; }

        public Categoria(string nome)
        {
            Nome = nome;
        }

        public string Descricao { get; private set; }

        private Categoria() { }

        public List<Item> Itens { get; private set; }
    }
}
