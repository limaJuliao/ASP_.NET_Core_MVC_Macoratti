using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface IItemRepository: IBaseRepository<Item>
{
    IEnumerable<Item> ItensPreferidos();
}
