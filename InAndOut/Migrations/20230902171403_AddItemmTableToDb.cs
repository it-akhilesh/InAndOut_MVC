using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOut.Migrations
{
    /// <inheritdoc />
    public partial class AddItemmTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemName", "Lender" },
                values: new object[] { "Toy", "Bimal" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemName", "Lender" },
                values: new object[] { "Truck", "Rajesh" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Borrower", "ItemName", "Lender" },
                values: new object[] { 3, "Nitesh", "Car", "Devanti" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");
        }
    }
}
