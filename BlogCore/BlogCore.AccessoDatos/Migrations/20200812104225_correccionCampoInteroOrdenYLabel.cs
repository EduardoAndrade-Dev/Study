using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogCore.AccessoDatos.Migrations
{
    public partial class correccionCampoInteroOrdenYLabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "Orden",
                table: "Categoria",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orden",
                table: "Categoria");

            migrationBuilder.AddColumn<string>(
                name: "Ordem",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
