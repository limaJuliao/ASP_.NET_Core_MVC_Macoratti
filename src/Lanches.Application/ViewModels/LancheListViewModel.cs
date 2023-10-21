using Lanches.Domain.Entities;

namespace Lanches.Application.ViewModels;

public class LancheListViewModel
{
    public IEnumerable<Item> Lanches { get; set; }
    public string CategoriaAtual { get; set; }

}
