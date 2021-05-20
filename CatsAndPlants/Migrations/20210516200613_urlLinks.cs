using Microsoft.EntityFrameworkCore.Migrations;

namespace CatsAndPlants.Migrations
{
    public partial class urlLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "Fluffy, wave like moss.");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "PicUrl",
                value: "https://i.imgur.com/2iE4Jai.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "PicUrl",
                value: "https://i.imgur.com/zSdT9XO.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "PicUrl",
                value: "https://i.imgur.com/h8dbvsX.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "PicUrl",
                value: "https://i.imgur.com/uwbBX0V.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "PicUrl",
                value: "https://i.imgur.com/6u4n3dN.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "PicUrl",
                value: "https://i.imgur.com/SUCow4c.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "PicUrl",
                value: "https://i.imgur.com/P5nV16T.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For small vivariums. Includes base and grow light", "https://i.imgur.com/BxM2HW0.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For medium vivariums. Includes base and grow light", "https://i.imgur.com/uW6K5di.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For large vivariums. Includes base and grow light", "https://i.imgur.com/vKANYKJ.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "PicUrl",
                value: "https://i.imgur.com/4wQIspu.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "PicUrl",
                value: "https://i.imgur.com/1NYHFSP.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "PicUrl",
                value: "https://i.imgur.com/tj3wfzn.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "Fluffy moss.");

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
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For small vivariums.", "https://i.imgur.com/rpJUKWf.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For medium vivariums.", "https://i.imgur.com/rpJUKWf.jpg" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Description", "PicUrl" },
                values: new object[] { "For large vivariums.", "https://i.imgur.com/rpJUKWf.jpg" });

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
    }
}
