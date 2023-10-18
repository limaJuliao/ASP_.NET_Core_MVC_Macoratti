using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

public sealed class CarrinhoCompraItemMap : IEntityTypeConfiguration<CarrinhoCompraItem>
{
    public void Configure(EntityTypeBuilder<CarrinhoCompraItem> builder)
    {
        builder.Property(x => x.Id)
            .HasColumnName("CarrinhoCompraItemId");

        builder.Property(x => x.CarrinhoCompraId)
            .HasMaxLength(200);
    }
}
