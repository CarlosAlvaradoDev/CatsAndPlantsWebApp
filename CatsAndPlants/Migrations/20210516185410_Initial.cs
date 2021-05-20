using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatsAndPlants.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipPostal = table.Column<int>(type: "int", nullable: false),
                    BillAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillPostal = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<float>(type: "real", nullable: false),
                    Freight = table.Column<float>(type: "real", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BillAddress", "BillCity", "BillPostal", "BillState", "Email", "FirstName", "LastName", "Password", "Phone", "ShipAddress", "ShipCity", "ShipPostal", "ShipState" },
                values: new object[,]
                {
                    { 1, "123 North", "Phoenix", 52234, "AZ", "c@c.com", "Charlies", "Avocado", "Shnock123", "111-111-1111", "123 North", "Phoenix", 52234, "AZ" },
                    { 2, "123 North", "Phoenix", 52234, "AZ", "J@N.com", "Josephina", "Navarro", "Shnock123", "222-222-2222", "456 South", "Flagstaff", 52233, "AZ" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, "Plants", "Fluffy moss.", "Mood Moss", 3.99f, 0.2f },
                    { 2, "Plants", "Cushiony, plump moss.", "Pillow Moss", 3.99f, 0.2f },
                    { 3, "Plants", "Carnivorous plant with sticky broad leaves.", "Pinguicula Moranesis", 9.99f, 0.05f },
                    { 4, "Plants", "Creeping vine that grows alongside walls.", "Ficus Pumila", 2.99f, 0.05f },
                    { 5, "Plants", "Vine like plant that resembles turtle shell like leaves.", "Peperomia Prostrata", 3.99f, 0.1f },
                    { 6, "Vivariums", "5in x 5in x 5in.", "Small", 24.99f, 1.2f },
                    { 7, "Vivariums", "10in x 10in x 12in.", "Medium", 39.99f, 4.5f },
                    { 8, "Vivariums", "18in x 18in x 18in.", "Large", 59.99f, 6.3f },
                    { 9, "Stands", "For small vivariums.", "Small", 10.99f, 1.2f },
                    { 10, "Stands", "For medium vivariums.", "Medium", 15.99f, 2f },
                    { 11, "Stands", "For large vivariums.", "Large", 20.99f, 3.4f },
                    { 12, "Supplies", "Special soil mix made to withstand high humdity that won't break down quickly.", "Soil Mix", 9.99f, 1.5f },
                    { 13, "Supplies", "A continuous mister that sprays a fine mist.", "Spray Bottle", 3.99f, 0.3f },
                    { 14, "Supplies", "Mild fertilizer that will boost plant growth. Mix in spray bottle", "Fertilizer", 3.99f, 0.3f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
