using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVAInvest.Infra.Repository.Maps;

class MaterialMap : IEntityTypeConfiguration<Material>
{
    public void Configure(EntityTypeBuilder<Material> builder)
    {
        builder.ToTable("Material", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("MaterialId").HasColumnType("int");

        builder.Property(e => e.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100);
        builder.Property(e => e.Codigo).HasColumnName("Codigo").HasColumnType("varchar").HasMaxLength(10);

        builder.Property(e => e.DataInclusao).HasColumnName("DataInclusao").HasColumnType("datetime").HasDefaultValueSql("GetDate()");
        builder.Property(e => e.UsuarioInclusao).HasColumnName("UsuarioInclusao").HasColumnType("int");
        builder.Property(e => e.DataAlteracao).HasColumnName("DataAlteracao").HasColumnType("datetime");
        builder.Property(e => e.UsuarioAlteracao).HasColumnName("UsuarioAlteracao").HasColumnType("int");
        builder.Property(e => e.Ativo).HasColumnName("Ativo").HasColumnType("bit").HasDefaultValue(true);
    }
}
