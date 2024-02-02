﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoresHardware_HardWareAPI.Data;

#nullable disable

namespace StoresHardwareHardWareAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoresHardware_HardWareAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ShopId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9663),
                            Price = 65000,
                            ProductModel = "11Pro_256Gb",
                            ProductName = "Iphone",
                            ShopId = 1,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9666),
                            Price = 65000,
                            ProductModel = "iPad air 2022",
                            ProductName = "Ipad",
                            ShopId = 1,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9667),
                            Price = 65000,
                            ProductModel = "2000ML",
                            ProductName = "Shinhizer",
                            ShopId = 1,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9669),
                            Price = 65000,
                            ProductModel = "6800_512GB",
                            ProductName = "Nokia",
                            ShopId = 2,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9671),
                            Price = 100000,
                            ProductModel = "Galaxsy10_512GB",
                            ProductName = "Samsung",
                            ShopId = 2,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9673),
                            Price = 65000,
                            ProductModel = "Ml3000",
                            ProductName = "Acer",
                            ShopId = 2,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9675),
                            Price = 65000,
                            ProductModel = "Wh30000",
                            ProductName = "Sony",
                            ShopId = 3,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9676),
                            Price = 65000,
                            ProductModel = "Ror Strix Scar",
                            ProductName = "Asus",
                            ShopId = 3,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9678),
                            Price = 65000,
                            ProductModel = "Dino V2",
                            ProductName = "Lenovo",
                            ShopId = 3,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StoresHardware_HardWareAPI.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Ноутбуки",
                            CategoryName = "Laptops",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9402),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Телефоны",
                            CategoryName = "Phones",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9416),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Планшеты",
                            CategoryName = "Tablet",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9417),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Наушники",
                            CategoryName = "Headphones",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9419),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StoresHardware_HardWareAPI.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Adress = "Bayakalskaya 88",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9639),
                            Name = "DNS",
                            Phone = "84567892354",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ShopId = 2,
                            Adress = "Partizanov 66",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9641),
                            Name = "AlibabaGroups",
                            Phone = "82223334567",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ShopId = 3,
                            Adress = "VolkovskoyShosse 12",
                            CreateDate = new DateTime(2024, 2, 2, 6, 12, 39, 462, DateTimeKind.Local).AddTicks(9643),
                            Name = "Ozon",
                            Phone = "89299206104",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StoresHardware_HardWareAPI.Models.Product", b =>
                {
                    b.HasOne("StoresHardware_HardWareAPI.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoresHardware_HardWareAPI.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("Shop");
                });
#pragma warning restore 612, 618
        }
    }
}
