using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

public class CategoriaMap : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("Categorias");

        builder.Property(x => x.Id)
            .HasColumnName("CategoriaId");

        builder.Property(x => x.Nome)
            .HasMaxLength(100);

        builder.Property(x => x.Descricao)
            .HasMaxLength(200);
    }
}
