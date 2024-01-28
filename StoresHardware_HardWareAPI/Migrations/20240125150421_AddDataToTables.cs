using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoresHardwareHardWareAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "CreateDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Ноутбуки", "Laptops", new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Телефоны", "Phones", new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8087), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Планшеты", "Tablet", new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8088), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Наушники", "Headphones", new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Adress", "CreateDate", "Name", "Phone", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8267), "DNS", 1231231234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8270), "Citilink", 1222222223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8271), "Ozon", 890008001, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreateDate", "Price", "ProductDescription", "ProductModel", "ProductName", "ShopId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8292), 65000, null, "11Pro_256Gb", "Iphone", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8299), 65000, null, "6800_512GB", "Nokia", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8301), 100000, null, "Galaxsy10_512GB", "Samsung", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8295), 65000, null, "iPad air 2022", "Ipad", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8304), 65000, null, "Wh30000", "Sony", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8297), 65000, null, "2000ML", "Shinhizer", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8302), 65000, null, "Ml3000", "Acer", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8307), 65000, null, "Ror Strix Scar", "Asus", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, new DateTime(2024, 1, 25, 18, 4, 21, 7, DateTimeKind.Local).AddTicks(8309), 65000, null, "Dino V2", "Lenovo", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);
        }
    }
}
