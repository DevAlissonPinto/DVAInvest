using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _20052024_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimentacaoEstoque_EstoqueMaterial_EstoqueMaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.DropTable(
                name: "EstoqueMaterial",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "EstoqueMaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MovimentacaoEstoque_EstoqueMaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "IX_MovimentacaoEstoque_MaterialId");

            migrationBuilder.AddColumn<int>(
                name: "EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoEstoque_EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                column: "EstoqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimentacaoEstoque_Estoque_EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                column: "EstoqueId",
                principalSchema: "dbo",
                principalTable: "Estoque",
                principalColumn: "EstoqueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovimentacaoEstoque_Material_MaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                column: "MaterialId",
                principalSchema: "dbo",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimentacaoEstoque_Estoque_EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.DropForeignKey(
                name: "FK_MovimentacaoEstoque_Material_MaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.DropIndex(
                name: "IX_MovimentacaoEstoque_EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.DropColumn(
                name: "EstoqueId",
                schema: "dbo",
                table: "MovimentacaoEstoque");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "EstoqueMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MovimentacaoEstoque_MaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                newName: "IX_MovimentacaoEstoque_EstoqueMaterialId");

            migrationBuilder.CreateTable(
                name: "EstoqueMaterial",
                schema: "dbo",
                columns: table => new
                {
                    EstoqueMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GetDate()"),
                    PrecoMedio = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    UsuarioAlteracao = table.Column<int>(type: "int", nullable: true),
                    UsuarioInclusao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueMaterial", x => x.EstoqueMaterialId);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Estoque_EstoqueId",
                        column: x => x.EstoqueId,
                        principalSchema: "dbo",
                        principalTable: "Estoque",
                        principalColumn: "EstoqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueMaterial_EstoqueId",
                schema: "dbo",
                table: "EstoqueMaterial",
                column: "EstoqueId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueMaterial_MaterialId",
                schema: "dbo",
                table: "EstoqueMaterial",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimentacaoEstoque_EstoqueMaterial_EstoqueMaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                column: "EstoqueMaterialId",
                principalSchema: "dbo",
                principalTable: "EstoqueMaterial",
                principalColumn: "EstoqueMaterialId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
