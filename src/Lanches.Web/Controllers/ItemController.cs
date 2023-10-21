using Lanches.Application.ViewModels;
using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers;

public class ItemController : Controller
{
    private readonly IItemRepository _lancheRepository;
    public ItemController(IItemRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }
    public IActionResult List()
    {
        //var lanches = _itemRepository.Lanches;
        //return View(lanches);

        return View(new LancheListViewModel
        {
            Lanches = _lancheRepository.Lanches,
            CategoriaAtual = "Categoria Atual"
        });
    }
}
