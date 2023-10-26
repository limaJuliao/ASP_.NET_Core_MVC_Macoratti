using Lanches.Application.Interfaces;
using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.ViewComponents;

public class CarrinhoCompraResumo : ViewComponent
{
    private readonly CarrinhoCompra _carrinhoCompra;
    private readonly ICarrinhoCompraAppService _carrinhoCompraAppService;

    public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra, ICarrinhoCompraAppService carrinhoCompraAppService)
    {
        _carrinhoCompra = carrinhoCompra;
        _carrinhoCompraAppService = carrinhoCompraAppService;
    }

    public IViewComponentResult Invoke()
    {
        var itens = _carrinhoCompraAppService.ObterItensDoCarrinhoDeCompras();

        foreach (var item in itens)
            _carrinhoCompra.CarrinhoCompraItens.Add(item);

        return View(new CarrinhoCompraViewModel() { CarrinhoCompra = _carrinhoCompra});
    }
}
