using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOut.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItesSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Borrower", "ItemName", "Lender" },
                values: new object[] { 5, "Dhillon", "Bike", "Hero" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
