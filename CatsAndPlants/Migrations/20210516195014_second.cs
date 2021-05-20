using Microsoft.EntityFrameworkCore.Migrations;

namespace CatsAndPlants.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWf.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicUrl",
                table: "Product");
        }
    }
}
