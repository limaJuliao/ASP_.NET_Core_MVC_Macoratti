using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

public class CarrinhoCompraMap : IEntityTypeConfiguration<CarrinhoCompra>
{
    public void Configure(EntityTypeBuilder<CarrinhoCompra> builder)
    {
        builder.Property(x => x.Id)
            .HasMaxLength(200);
    }
}
