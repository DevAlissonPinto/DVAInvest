using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVAInvest.Infra.Repository.Maps;

public class PortfolioMap : IEntityTypeConfiguration<Portfolio>
{
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
        builder.ToTable("Portfolio", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("PortfolioId").HasColumnType("int");

    }
}

public class PortifolioAtivoMap : IEntityTypeConfiguration<PortfolioAtivo>
{
    public void Configure(EntityTypeBuilder<PortfolioAtivo> builder)
    {
        builder.ToTable("PortfolioAtivo", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("PortfolioAtivoId").HasColumnType("int");

    }
}