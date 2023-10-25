using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

public class PedidoMap : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.Property(x => x.Id)
            .HasColumnName("PedidoId");

        builder.Property(x => x.Nome).HasMaxLength(50);
        builder.Property(x => x.Sobrenome).HasMaxLength(50);
        builder.Property(x => x.Endereco).HasMaxLength(100);
        builder.Property(x => x.Complemento).HasMaxLength(100);
        builder.Property(x => x.CEP).HasMaxLength(10);
        builder.Property(x => x.Estado).HasMaxLength(10);
        builder.Property(x => x.Cidade).HasMaxLength(50);
        builder.Property(x => x.Telefone).HasMaxLength(25);
        builder.Property(x => x.Email).HasMaxLength(50);

        builder.Property(x=>x.PedidoTotal)
            .HasColumnType("decimal(18,2)");
    }
}
