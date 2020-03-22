using Microsoft.EntityFrameworkCore.Migrations;

namespace RecargaApp.Infra.Data.Migrations
{
    public partial class AddConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateCheckConstraint(
                name: "CK_EstacaoRecarga_Tipo",
                table: "EstacaoRecarga",
                sql: "([Tipo] = 'ESTACAOMOVEL' or [Tipo] = 'ESTACAOVEICULAR')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_EstacaoRecarga_Tipo",
                table: "EstacaoRecarga");
        }
    }
}
