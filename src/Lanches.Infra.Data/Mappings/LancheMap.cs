﻿using Lanches.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanches.Infra.Data.Mappings;

public class LancheMap : IEntityTypeConfiguration<Lanche>
{
    public void Configure(EntityTypeBuilder<Lanche> builder)
    {
        builder.Property(x => x.Id)
            .HasColumnName("LancheId");

        builder.Property(x => x.Nome)
            .HasMaxLength(80);

        builder.Property(x => x.DescricaoCurta)
            .HasMaxLength(200);

        builder.Property(x => x.DescricaoDetalhada)
            .HasMaxLength(200);

        builder.Property(x => x.Preco)
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.ImagemUrl)
            .HasMaxLength(200);

        builder.Property(x => x.ImagemThumbnailUrl)
            .HasMaxLength(200);

        builder.Property(x => x.IsLanchePreferido);
        builder.Property(x => x.EmEstoque);
    }
}