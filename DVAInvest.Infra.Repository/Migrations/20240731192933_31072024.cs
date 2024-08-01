using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _31072024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ativos_Portfolio_PortfolioId1",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropIndex(
                name: "IX_Ativos_PortfolioId1",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "PortfolioId1",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "Situacao",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoAtivo",
                schema: "dbo",
                table: "Ativos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PortfolioAtivo",
                schema: "dbo",
                columns: table => new
                {
                    PortfolioAtivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<int>(type: "int", nullable: false),
                    AtivoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioInclusao = table.Column<int>(type: "int", nullable: true),
                    UsuarioAlteracao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioAtivo", x => x.PortfolioAtivoId);
                    table.ForeignKey(
                        name: "FK_PortfolioAtivo_Ativos_AtivoId",
                        column: x => x.AtivoId,
                        principalSchema: "dbo",
                        principalTable: "Ativos",
                        principalColumn: "AtivoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioAtivo_Portfolio_PortfolioId",
                        column: x => x.PortfolioId,
                        principalSchema: "dbo",
                        principalTable: "Portfolio",
                        principalColumn: "PortfolioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioAtivo_AtivoId",
                schema: "dbo",
                table: "PortfolioAtivo",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioAtivo_PortfolioId",
                schema: "dbo",
                table: "PortfolioAtivo",
                column: "PortfolioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioAtivo",
                schema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "TipoAtivo",
                schema: "dbo",
                table: "Ativos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "PortfolioId",
                schema: "dbo",
                table: "Ativos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "PortfolioId1",
                schema: "dbo",
                table: "Ativos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Situacao",
                schema: "dbo",
                table: "Ativos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_PortfolioId1",
                schema: "dbo",
                table: "Ativos",
                column: "PortfolioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ativos_Portfolio_PortfolioId1",
                schema: "dbo",
                table: "Ativos",
                column: "PortfolioId1",
                principalSchema: "dbo",
                principalTable: "Portfolio",
                principalColumn: "PortfolioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
