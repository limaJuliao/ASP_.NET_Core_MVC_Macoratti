using Lanches.Application.ViewModels;

namespace Lanches.Application.Interfaces;

public interface ICategoriaAppService
{
    CategoriaViewModel ObterCategoriasOrdenadasPorNome();
}
