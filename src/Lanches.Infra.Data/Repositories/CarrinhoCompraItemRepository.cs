using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class CarrinhoCompraItemRepository : EFCoreRepository<CarrinhoCompraItem>, ICarrinhoCompraItemRepository
{
    private readonly AppDbContext _context;

    public CarrinhoCompraItemRepository(AppDbContext context):base(context)
    {
        _context = context;
    }

    public CarrinhoCompraItem? GetByCarrinhoCompraEItem(CarrinhoCompra carrinhoCompra, Item Item)
    {
        return _context.CarrinhoCompraItem.SingleOrDefault(s => s.Item.Id == Item.Id && s.CarrinhoCompraId == carrinhoCompra.Id);
    }

    public IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(CarrinhoCompra carrinhoCompra)
    {
        return _context.CarrinhoCompraItem
            .Where(c => c.CarrinhoCompraId == carrinhoCompra.Id)
            .Include(s => s.Item);
    }

    public void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens)
    {
        _context.RemoveRange(carrinhoCompraItens);
        _context.SaveChanges();
    }
}
