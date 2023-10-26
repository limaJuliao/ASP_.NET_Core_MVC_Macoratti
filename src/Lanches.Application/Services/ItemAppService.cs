using Lanches.Application.Interfaces;
using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;

namespace Lanches.Application.Services;

public class ItemAppService : IItemAppService
{
    private readonly IItemRepository _itemRepository;
    private readonly ICategoriaRepository _categoryRepository;

    public ItemAppService(IItemRepository itemRepository, ICategoriaRepository categoryRepository)
    {
        _itemRepository = itemRepository;
        _categoryRepository = categoryRepository;
    }

    public ItemListViewModel ListarTodosDaCategoriaOrdenadosPorNome(int? categoriaId)
    {
        if (categoriaId == null)
            return new ItemListViewModel
            {
                Categoria = new Categoria("Todos os Itens"),
                Itens = _itemRepository.GetAll().OrderBy(x => x.Nome)
            };

        var categoria = _categoryRepository.GetById(categoriaId.Value)!;

        return new ItemListViewModel { Categoria = categoria, Itens = _itemRepository.GetByCategoriaId(categoria.Id).OrderBy(x=> x.Nome) };
    }

    public ItemDetailsViewModel ObterDetalhes(int id)
    {
        return new() { Item = _itemRepository.GetById(id)! };
    }
}

