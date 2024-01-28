using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoresHardwareHardWareAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name", "Phone" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5453), "AlibabaGroups", "82223334567" });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5455));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "CreateDate", "Name", "Phone" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2420), "82223334567", null });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 26, 54, 509, DateTimeKind.Local).AddTicks(2422));
        }
    }
}
