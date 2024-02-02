using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoresHardwareHardWareAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9643));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 1, 28, 17, 29, 34, 124, DateTimeKind.Local).AddTicks(5455));
        }
    }
}
