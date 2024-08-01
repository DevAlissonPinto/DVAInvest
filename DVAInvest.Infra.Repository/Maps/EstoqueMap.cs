using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Regulacao.Repository.Maps;

class EstoqueMap : IEntityTypeConfiguration<Estoque>
{
    public void Configure(EntityTypeBuilder<Estoque> builder)
    {
        builder.ToTable("Estoque", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("EstoqueId").HasColumnType("int");

        builder.Property(e => e.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(50);

        builder.Property(e => e.DataInclusao).HasColumnName("DataInclusao").HasColumnType("datetime").HasDefaultValueSql("GetDate()");
        builder.Property(e => e.UsuarioInclusao).HasColumnName("UsuarioInclusao").HasColumnType("int");
        builder.Property(e => e.DataAlteracao).HasColumnName("DataAlteracao").HasColumnType("datetime");
        builder.Property(e => e.UsuarioAlteracao).HasColumnName("UsuarioAlteracao").HasColumnType("int");
        builder.Property(e => e.Ativo).HasColumnName("Ativo").HasColumnType("bit").HasDefaultValue(true);

    }
}
