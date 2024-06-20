using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadCliBlazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Idade = table.Column<byte>(type: "tinyint", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "DataAtualizacao", "DataCadastro", "Email", "Idade", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 20, 21, 28, 8, 254, DateTimeKind.Local).AddTicks(8990), "fabiano.nalin@gmail.com", (byte)45, "Fabiano" },
                    { 2, null, new DateTime(2024, 6, 20, 21, 28, 8, 254, DateTimeKind.Local).AddTicks(9060), "lucas@teste.com", (byte)25, "Lucas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
