using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecargaApp.Infra.Data.Migrations
{
    public partial class RetiradaContraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstacaoRecarga",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstacaoRecarga", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstacaoRecarga");
        }
    }
}
