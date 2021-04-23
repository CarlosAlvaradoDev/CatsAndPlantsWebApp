using Microsoft.EntityFrameworkCore.Migrations;

namespace CatsAndPlants.Migrations
{
    public partial class CustomerTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BillAddress", "BillCity", "BillPostal", "BillState", "Email", "FirstName", "LastName", "Password", "Phone", "ShipAddress", "ShipCity", "ShipPostal", "ShipState" },
                values: new object[] { 1, "123 North", "Phoenix", 52234, "AZ", "c@c.com", "Charlies", "Avocado", "Shnock123", "111-111-1111", "123 North", "Phoenix", 52234, "AZ" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BillAddress", "BillCity", "BillPostal", "BillState", "Email", "FirstName", "LastName", "Password", "Phone", "ShipAddress", "ShipCity", "ShipPostal", "ShipState" },
                values: new object[] { 2, "123 North", "Phoenix", 52234, "AZ", "J@N.com", "Josephina", "Navarro", "Shnock123", "222-222-2222", "456 South", "Flagstaff", 52233, "AZ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);
        }
    }
}
