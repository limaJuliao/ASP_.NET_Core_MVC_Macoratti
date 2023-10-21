using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces;

public interface ICarrinhoCompraRepository : IBaseRepository<CarrinhoCompra>
{
    CarrinhoCompra? GetById(string id);
}
