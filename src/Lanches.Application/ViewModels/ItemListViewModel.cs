using Lanches.Domain.Entities;

namespace Lanches.Application.ViewModels;

public class ItemListViewModel
{
    public IEnumerable<Item> Itens { get; set; }
    public Categoria Categoria { get; set; }
}
