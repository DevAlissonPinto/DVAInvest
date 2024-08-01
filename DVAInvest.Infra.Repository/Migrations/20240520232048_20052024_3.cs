using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _20052024_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.RenameColumn(
                name: "TipoMovimentacaoId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "TipoMovimentacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoMovimentacao",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "TipoMovimentacaoId");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
