using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface IItemRepository
{
    IEnumerable<Item> Itens { get; }
    IEnumerable<Item> ItensPreferidos { get; }
    Item GetById(int id);
}
