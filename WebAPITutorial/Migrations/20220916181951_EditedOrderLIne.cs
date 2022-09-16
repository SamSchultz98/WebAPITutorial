using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPITutorial.Migrations
{
    public partial class EditedOrderLIne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "OrderLines",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderLines",
                newName: "MyProperty");
        }
    }
}
