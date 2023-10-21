using Lanches.Application.Interfaces;
using Lanches.Application.ViewModels;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICarrinhoCompraAppService _carrinhoCompraAppService;
        private readonly IItemRepository _itemRepository;
        private static readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IHttpContextAccessor httpContextAccessor, ICarrinhoCompraAppService carrinhoCompraAppService, IItemRepository itemRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _carrinhoCompraAppService = carrinhoCompraAppService;
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            var session = _httpContextAccessor.HttpContext?.Session;

            var carrinhoCompraId = session.GetString("CarrinhoCompraId");
            var _carrinhoCompra = _carrinhoCompraAppService.ObterCarrinhoCompra(carrinhoCompraId);

            return View(new CarrinhoCompraViewModel() { CarrinhoCompra = _carrinhoCompra });
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            _carrinhoCompraAppService.AdicionarAoCarrinhoCompra(_carrinhoCompra, lancheId);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            _carrinhoCompraAppService.RemoverDoCarrinho(_carrinhoCompra, lancheId);

            return RedirectToAction(nameof(Index));
        }

    }
}
