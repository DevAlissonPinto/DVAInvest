using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class material : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                schema: "dbo",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GetDate()"),
                    DataAlteracao = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioInclusao = table.Column<int>(type: "int", nullable: true),
                    UsuarioAlteracao = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material",
                schema: "dbo");
        }
    }
}
