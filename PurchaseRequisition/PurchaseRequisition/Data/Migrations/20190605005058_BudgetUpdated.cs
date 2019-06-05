using Microsoft.EntityFrameworkCore.Migrations;

namespace PurchaseRequisition.Data.Migrations
{
    public partial class BudgetUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BudgetCode",
                table: "Order",
                newName: "Budget");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Order",
                newName: "BudgetCode");
        }
    }
}
