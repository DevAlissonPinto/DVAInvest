using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _20052024_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueMaterial_Almoxarifado_EstoqueId",
                schema: "dbo",
                table: "EstoqueMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Almoxarifado",
                schema: "dbo",
                table: "Almoxarifado");

            migrationBuilder.RenameTable(
                name: "Almoxarifado",
                schema: "dbo",
                newName: "Estoque",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "AlmoxarifadoId",
                schema: "dbo",
                table: "Estoque",
                newName: "EstoqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estoque",
                schema: "dbo",
                table: "Estoque",
                column: "EstoqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueMaterial_Estoque_EstoqueId",
                schema: "dbo",
                table: "EstoqueMaterial",
                column: "EstoqueId",
                principalSchema: "dbo",
                principalTable: "Estoque",
                principalColumn: "EstoqueId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueMaterial_Estoque_EstoqueId",
                schema: "dbo",
                table: "EstoqueMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estoque",
                schema: "dbo",
                table: "Estoque");

            migrationBuilder.RenameTable(
                name: "Estoque",
                schema: "dbo",
                newName: "Almoxarifado",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "EstoqueId",
                schema: "dbo",
                table: "Almoxarifado",
                newName: "AlmoxarifadoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Almoxarifado",
                schema: "dbo",
                table: "Almoxarifado",
                column: "AlmoxarifadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueMaterial_Almoxarifado_EstoqueId",
                schema: "dbo",
                table: "EstoqueMaterial",
                column: "EstoqueId",
                principalSchema: "dbo",
                principalTable: "Almoxarifado",
                principalColumn: "AlmoxarifadoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
