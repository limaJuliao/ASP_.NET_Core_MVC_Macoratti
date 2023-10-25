using Lanches.Application.Interfaces;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;

namespace Lanches.Application.Services;

public class CategoriaAppService : ICategoriaAppService
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaAppService(ICategoriaRepository cateuriaRepository)
    {
        _categoriaRepository = cateuriaRepository;
    }

    public IEnumerable<Categoria> ObterCategoriasOrdenadasPorNome()
    {
        return _categoriaRepository.GetAll().OrderBy(c => c.Nome);
    }
}
