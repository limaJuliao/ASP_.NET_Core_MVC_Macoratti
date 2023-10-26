using Lanches.Application.ViewModels;
using Lanches.Domain.Interfaces;
using Lanches.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lanches.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel { ItensPreferidos = _itemRepository.GetPreferidos() });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}