using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Item> Lanches { get; set; }
    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    public DbSet<CarrinhoCompra> CarrinhosCompra { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
