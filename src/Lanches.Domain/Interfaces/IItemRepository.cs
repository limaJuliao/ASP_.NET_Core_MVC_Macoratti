using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface IItemRepository
{
    IEnumerable<Item> Lanches { get; }
    IEnumerable<Item> LanchesPreferidos { get; }
    Item GetById(int id);
}
