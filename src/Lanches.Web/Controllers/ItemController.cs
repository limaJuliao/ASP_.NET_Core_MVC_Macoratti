using Lanches.Application.Interfaces;
using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers;

public class ItemController : Controller
{
    private readonly IItemAppService _itemAppService;
    public ItemController(IItemAppService itemAppService)
    {
        _itemAppService = itemAppService;
    }

    public IActionResult List(int? categoriaId)
    {
        return View(_itemAppService.ListarTodosDaCategoriaOrdenadosPorNome(categoriaId));
    }

    public IActionResult Details(int id)
    {
        return View(_itemAppService.ObterDetalhes(id));
    }
}
