using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoresHardwareHardWareAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixDataInTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "Adress", "CreateDate", "Phone" },
                values: new object[] { "Bayakalskaya 88", new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2418), "84567892354" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Adress", "CreateDate", "Name", "Phone" },
                values: new object[] { "Partizanov 66", new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2420), "82223334567", null });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                columns: new[] { "Adress", "CreateDate", "Phone" },
                values: new object[] { "VolkovskoyShosse 12", new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2422), "89299206104" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "Adress", "CreateDate", "Phone" },
                values: new object[] { null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8267), 1231231234 });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Adress", "CreateDate", "Name", "Phone" },
                values: new object[] { null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8270), "Citilink", 1222222223 });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                columns: new[] { "Adress", "CreateDate", "Phone" },
                values: new object[] { null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8271), 890008001 });
        }
    }
}
