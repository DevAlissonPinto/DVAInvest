using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVAInvest.Infra.Repository.Maps;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("UsuarioId").HasColumnType("int");

    }
}