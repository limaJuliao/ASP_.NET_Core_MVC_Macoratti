using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CarrinhoCompraController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            return View();
        }
    }
}
