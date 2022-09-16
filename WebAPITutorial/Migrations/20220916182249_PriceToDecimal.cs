using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPITutorial.Migrations
{
    public partial class PriceToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderLines",
                type: "Decimal(11,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(11,2)");
        }
    }
}
