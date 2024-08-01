using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _20052024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoqueMaterial",
                schema: "dbo",
                columns: table => new
                {
                    EstoqueMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    PrecoMedio = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GetDate()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioInclusao = table.Column<int>(type: "int", nullable: true),
                    UsuarioAlteracao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueMaterial", x => x.EstoqueMaterialId);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Almoxarifado_EstoqueId",
                        column: x => x.EstoqueId,
                        principalSchema: "dbo",
                        principalTable: "Almoxarifado",
                        principalColumn: "AlmoxarifadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalSchema: "dbo",
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimentacaoEstoque",
                schema: "dbo",
                columns: table => new
                {
                    MovimentacaoEstoqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstoqueMaterialId = table.Column<int>(type: "int", nullable: false),
                    TipoMovimentacaoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GetDate()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioInclusao = table.Column<int>(type: "int", nullable: true),
                    UsuarioAlteracao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentacaoEstoque", x => x.MovimentacaoEstoqueId);
                    table.ForeignKey(
                        name: "FK_MovimentacaoEstoque_EstoqueMaterial_EstoqueMaterialId",
                        column: x => x.EstoqueMaterialId,
                        principalSchema: "dbo",
                        principalTable: "EstoqueMaterial",
                        principalColumn: "EstoqueMaterialId",
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

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacaoEstoque_EstoqueMaterialId",
                schema: "dbo",
                table: "MovimentacaoEstoque",
                column: "EstoqueMaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimentacaoEstoque",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "EstoqueMaterial",
                schema: "dbo");
        }
    }
}
