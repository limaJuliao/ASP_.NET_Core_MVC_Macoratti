using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers;

public class ItemController : Controller
{
    private readonly IItemRepository _itemRepository;
    public ItemController(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    public IActionResult List(string categoria)
    {
        IEnumerable<Item> itens;
        string categoriaAtual = string.Empty;

        if (string.IsNullOrEmpty(categoria))
        {
            itens = _itemRepository.Itens.OrderBy(x => x.Id);
            categoriaAtual = "Todos os Itens";
        }
        else
        {
            if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
            {
                itens = _itemRepository.Itens
                    .Where(x => x.Categoria.Nome.Equals("Normal"))
                    .OrderBy(x => x.Nome);
            }
            else
            {
                itens = _itemRepository.Itens
                    .Where(x => x.Categoria.Nome.Equals("Natural"))
                    .OrderBy(x => x.Nome);
            }

            categoriaAtual = categoria;
        }

        return View(new ItemListViewModel { CategoriaAtual = categoriaAtual, Itens = itens});
    }
}
