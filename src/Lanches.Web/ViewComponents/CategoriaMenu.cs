using Lanches.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.ViewComponents
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaMenu(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_categoriaAppService.ObterCategoriasOrdenadasPorNome());
        }
    }
}
