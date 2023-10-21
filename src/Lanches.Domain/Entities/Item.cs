namespace Lanches.Domain.Entities
{
    public class Item : BaseEntity
    {
        private Item() { }
        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoDetalhada { get; private set; }
        public decimal Preco { get; private set; }
        public string? ImagemUrl { get; private set; }
        public string? ImagemThumbnailUrl { get; private set; }
        public bool IsLanchePreferido { get; private set; }
        public bool EmEstoque { get; private set; }

        public int CategoriaId { get; private set; }
        public virtual Categoria Categoria { get; private set; }
    }
}
