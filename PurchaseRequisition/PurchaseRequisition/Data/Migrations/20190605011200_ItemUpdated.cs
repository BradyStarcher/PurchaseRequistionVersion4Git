using Microsoft.EntityFrameworkCore.Migrations;

namespace PurchaseRequisition.Data.Migrations
{
    public partial class ItemUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerUnit",
                table: "Item",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PricePerUnit",
                table: "Item",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
