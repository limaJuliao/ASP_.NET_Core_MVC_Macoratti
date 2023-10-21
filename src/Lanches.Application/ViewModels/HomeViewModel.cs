using Lanches.Domain.Entities;

namespace Lanches.Application.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Item> ItensPreferidos { get; set; }
}
