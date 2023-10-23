using Lanches.Domain.Entities;

namespace Lanches.Application.Interfaces;

public interface ICategoriaAppService
{
    IEnumerable<Categoria> ObterCategoriasOrdenadasPorNome();
}
