using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;

namespace Lanches.Application.Interfaces;

public interface IItemAppService
{
    ItemListViewModel ListarTodosDaCategoriaOrdenadosPorNome(int? categoriaId);
    ItemDetailsViewModel ObterDetalhes(int id);
}