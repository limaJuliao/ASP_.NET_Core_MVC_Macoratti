using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly AppDbContext _context;
    public ItemRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Item> Itens => _context.Lanches.Include(x => x.Categoria);

    public IEnumerable<Item> ItensPreferidos => _context.Lanches
        .Where(l => l.IsLanchePreferido)
        .Include(c=>c.Categoria);

    public Item GetById(int id) => _context.Lanches.FirstOrDefault(x => x.Id == id);
}
