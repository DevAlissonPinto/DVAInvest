using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVAInvest.Infra.Repository.Maps;

public class AtivosMap : IEntityTypeConfiguration<Ativo>
{
    public void Configure(EntityTypeBuilder<Ativo> builder)
    {
        builder.ToTable("Ativos", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("AtivoId").HasColumnType("int");

    }
}
