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
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IHttpContextAccessor httpContextAccessor,
            ICarrinhoCompraAppService carrinhoCompraAppService, IItemRepository itemRepository,
            CarrinhoCompra carrinhoCompra)
        {
            _httpContextAccessor = httpContextAccessor;
            _carrinhoCompraAppService = carrinhoCompraAppService;
            _itemRepository = itemRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View(new CarrinhoCompraViewModel()
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.PrecoTotal()
            });
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int itemId)
        {
            _carrinhoCompraAppService.AdicionarAoCarrinhoCompra(_carrinhoCompra, itemId);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int itemId)
        {
            _carrinhoCompraAppService.RemoverDoCarrinho(_carrinhoCompra, itemId);

            return RedirectToAction(nameof(Index));
        }

    }
}
