using DVAInvest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Regulacao.Repository.Maps;

public class MovimentacaoEstoqueMap : IEntityTypeConfiguration<MovimentacaoEstoque>
{
    public void Configure(EntityTypeBuilder<MovimentacaoEstoque> builder)
    {
        builder.ToTable("MovimentacaoEstoque", "dbo");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("MovimentacaoEstoqueId").HasColumnType("int");

        builder.Property(e => e.DataInclusao).HasColumnName("DataInclusao").HasColumnType("datetime").HasDefaultValueSql("GetDate()");
        builder.Property(e => e.UsuarioInclusao).HasColumnName("UsuarioInclusao").HasColumnType("int");
        builder.Property(e => e.DataAlteracao).HasColumnName("DataAlteracao").HasColumnType("datetime");
        builder.Property(e => e.UsuarioAlteracao).HasColumnName("UsuarioAlteracao").HasColumnType("int");
        builder.Property(e => e.Ativo).HasColumnName("Ativo").HasColumnType("bit").HasDefaultValue(true);

    }
}