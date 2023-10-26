using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Lanches.Infra.Data.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class CarrinhoCompraItemRepository : EFCoreRepository<CarrinhoCompraItem>, ICarrinhoCompraItemRepository
{
    private readonly AppDbContext _context;

    public CarrinhoCompraItemRepository(AppDbContext context):base(context)
    {
        _context = context;
    }

    public CarrinhoCompraItem? GetByCarrinhoCompraIdEItemId(string carrinhoCompraId, int itemId)
    {
        return _context.CarrinhoCompraItem.SingleOrDefault(s => s.Item.Id == itemId && s.CarrinhoCompraId == carrinhoCompraId);
    }

    public IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(string carrinhoCompraId)
    {
        return _context.CarrinhoCompraItem
            .Where(c => c.CarrinhoCompraId == carrinhoCompraId)
            .Include(s => s.Item);
    }

    public void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens)
    {
        _context.RemoveRange(carrinhoCompraItens);
        _context.SaveChanges();
    }
}
