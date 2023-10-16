using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class LancheRepository : ILancheRepository
{
    private readonly AppDbContext _context;
    public LancheRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<Lanche> Lanches => _context.Lanches.Include(x => x.Categoria);

    public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
        .Where(l => l.IsLanchePreferido)
        .Include(c=>c.Categoria);

    public Lanche GetById(int id) => _context.Lanches.FirstOrDefault(x => x.Id == id);
}
