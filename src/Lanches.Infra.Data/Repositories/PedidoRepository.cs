using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;
using Lanches.Infra.Data.Repositories.EFCore;

namespace Lanches.Infra.Data.Repositories;

public class PedidoRepository : EFCoreRepository<Pedido>, IPedidoRepository
{
    public PedidoRepository(AppDbContext context) : base(context)
    {
    }
}
