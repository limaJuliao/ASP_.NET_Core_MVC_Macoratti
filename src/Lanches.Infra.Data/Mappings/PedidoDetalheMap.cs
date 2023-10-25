using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

class PedidoDetalheMap : IEntityTypeConfiguration<PedidoDetalhe>
{
    public void Configure(EntityTypeBuilder<PedidoDetalhe> builder)
    {
        builder.Property(x => x.Id)
            .HasColumnName("PedidoDetalheId");

        builder.Property(x => x.Preco).
            HasColumnType("decimal(18,2)");
    }
}
