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
    public IEnumerable<Item> Itens => _context.Itens.Include(x => x.Categoria);

    public IEnumerable<Item> ItensPreferidos => _context.Itens
        .Where(l => l.IsItemPreferido)
        .Include(c=>c.Categoria);

    public Item? GetById(int id) => _context.Itens.Find(id);
}
