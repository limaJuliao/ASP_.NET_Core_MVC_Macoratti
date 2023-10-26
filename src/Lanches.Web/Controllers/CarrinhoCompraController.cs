using Lanches.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICarrinhoCompraAppService _carrinhoCompraAppService;

        public CarrinhoCompraController(IHttpContextAccessor httpContextAccessor, ICarrinhoCompraAppService carrinhoCompraAppService)
        {
            _httpContextAccessor = httpContextAccessor;
            _carrinhoCompraAppService = carrinhoCompraAppService;
        }

        public IActionResult Index()
        {
            return View(_carrinhoCompraAppService.ObterCarrinhoDeCompras());
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int itemId)
        {
            _carrinhoCompraAppService.AdicionarAoCarrinhoCompra(itemId);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int itemId)
        {
            _carrinhoCompraAppService.RemoverDoCarrinho(itemId);

            return RedirectToAction(nameof(Index));
        }

    }
}
