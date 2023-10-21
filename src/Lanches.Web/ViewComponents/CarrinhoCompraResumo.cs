using Lanches.Application.Interfaces;
using Lanches.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.ViewComponents;

public class CarrinhoCompraResumo : ViewComponent
{
    private readonly ICarrinhoCompraAppService _carrinhoCompraAppService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CarrinhoCompraResumo(ICarrinhoCompraAppService carrinhoCompraAppService, IHttpContextAccessor contextAccessor)
    {
        _carrinhoCompraAppService = carrinhoCompraAppService;
        _httpContextAccessor = contextAccessor;
    }

    public IViewComponentResult Invoke()
    {
        var session = _httpContextAccessor.HttpContext?.Session;

        var carrinhoCompraId = session.GetString("CarrinhoCompraId");
        var _carrinhoCompra = _carrinhoCompraAppService.ObterCarrinhoCompra(carrinhoCompraId);

        return View(new CarrinhoCompraViewModel() { CarrinhoCompra = _carrinhoCompra });
    }
}
