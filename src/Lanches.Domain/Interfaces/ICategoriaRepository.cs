using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> Categorias { get; }
    }
}
