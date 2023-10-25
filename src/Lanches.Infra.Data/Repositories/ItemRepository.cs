using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class ItemRepository : EFCoreRepository<Item>, IItemRepository
{
    private readonly AppDbContext _context;
    public ItemRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
    public IEnumerable<Item> ItensPreferidos()
    {
        return _context.Itens
            .Where(l => l.IsItemPreferido)
            .Include(c => c.Categoria);
    }
}
