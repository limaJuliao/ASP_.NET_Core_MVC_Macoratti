using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Infra.Data.Repositories;

public class CarrinhoCompraItemRepository : ICarrinhoCompraItemRepository
{
    private readonly AppDbContext _context;

    public CarrinhoCompraItemRepository(AppDbContext context)
    {
        _context = context;
    }

    public CarrinhoCompraItem Add(CarrinhoCompraItem entity)
    {
        _context.CarrinhoCompraItens.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public CarrinhoCompraItem GetById(int id)
    {
        throw new NotImplementedException();
    }

    public CarrinhoCompraItem? GetByCarrinhoCompraELanche(CarrinhoCompra carrinhoCompra, Item lanche)
    {
        return _context.CarrinhoCompraItens.SingleOrDefault(s => s.Item.Id == lanche.Id && s.CarrinhoCompraId == carrinhoCompra.Id);
    }

    public CarrinhoCompraItem Update(CarrinhoCompraItem carrinhoCompraItem)
    {
        _context.Entry(carrinhoCompraItem).State = EntityState.Modified;
        _context.SaveChanges();

        return carrinhoCompraItem;
    }

    public CarrinhoCompraItem Delete(CarrinhoCompraItem entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();

        return entity;
    }

    public IEnumerable<CarrinhoCompraItem> GetByCarrinhoCompra(CarrinhoCompra carrinhoCompra)
    {
        return _context.CarrinhoCompraItens
            .Where(c => c.CarrinhoCompraId == carrinhoCompra.Id)
            .Include(s => s.Item);
    }

    public void DeleteEmLote(IEnumerable<CarrinhoCompraItem> carrinhoCompraItens)
    {
        _context.RemoveRange(carrinhoCompraItens);
        _context.SaveChanges();
    }
}
