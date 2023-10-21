using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;

namespace Lanches.Infra.Data.Repositories;

public class CarrinhoCompraRepository : ICarrinhoCompraRepository
{
    private readonly AppDbContext _context;

    public CarrinhoCompraRepository(AppDbContext context)
    {
        _context = context;
    }

    public CarrinhoCompra Add(CarrinhoCompra entity)
    {
        _context.CarrinhosCompra.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public CarrinhoCompra Delete(CarrinhoCompra entity)
    {
        throw new NotImplementedException();
    }

    public CarrinhoCompra? GetById(string id)
    {
        return _context.CarrinhosCompra.Find(id);
    }

    public CarrinhoCompra GetById(int id)
    {
        throw new NotImplementedException();
    }
}
