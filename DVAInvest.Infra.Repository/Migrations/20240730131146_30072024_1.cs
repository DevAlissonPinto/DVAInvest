using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVAInvest.Infra.Repository.Migrations
{
    /// <inheritdoc />
    public partial class _30072024_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                schema: "dbo",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Usuario",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                schema: "dbo",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                schema: "dbo",
                table: "Portfolio",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Portfolio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                schema: "dbo",
                table: "Portfolio",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Portfolio",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Portfolio",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                schema: "dbo",
                table: "Ativos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Ativos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                schema: "dbo",
                table: "Ativos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Ativos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Ativos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Ativo",
                schema: "dbo",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                schema: "dbo",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "Ativo",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                schema: "dbo",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "UsuarioInclusao",
                schema: "dbo",
                table: "Ativos");
        }
    }
}
