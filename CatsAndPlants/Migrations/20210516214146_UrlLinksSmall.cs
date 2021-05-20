using Microsoft.EntityFrameworkCore.Migrations;

namespace CatsAndPlants.Migrations
{
    public partial class UrlLinksSmall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "PicUrl",
                value: "https://i.imgur.com/rpJUKWfs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "PicUrl",
                value: "https://i.imgur.com/2iE4Jais.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "PicUrl",
                value: "https://i.imgur.com/zSdT9XOs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "PicUrl",
                value: "https://i.imgur.com/h8dbvsXs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "PicUrl",
                value: "https://i.imgur.com/uwbBX0Vs.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "PicUrl",
                value: "https://i.imgur.com/6u4n3dNs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "PicUrl",
                value: "https://i.imgur.com/SUCow4cs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "PicUrl",
                value: "https://i.imgur.com/P5nV16Ts.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "PicUrl",
                value: "https://i.imgur.com/BxM2HW0s.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "PicUrl",
                value: "https://i.imgur.com/uW6K5dis.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "PicUrl",
                value: "https://i.imgur.com/vKANYKJs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "PicUrl",
                value: "https://i.imgur.com/4wQIspus.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "PicUrl",
                value: "https://i.imgur.com/1NYHFSPs.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "PicUrl",
                value: "https://i.imgur.com/tj3wfzns.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "PicUrl",
                value: "https://i.imgur.com/BxM2HW0.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "PicUrl",
                value: "https://i.imgur.com/uW6K5di.jpg");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "PicUrl",
                value: "https://i.imgur.com/vKANYKJ.jpg");

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
    }
}
