using Microsoft.EntityFrameworkCore;
using StoresHardware_HardWareAPI.Models;

namespace StoresHardware_HardWareAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add Data in ProductCategory table
            modelBuilder.Entity<ProductCategory>().HasData
            (
                new ProductCategory()
                {
                    CategoryId = 1,
                    CategoryName = "Laptops",
                    CategoryDescription = "Ноутбуки",
                    CreateDate = DateTime.Now
                },

                new ProductCategory()
                {
                    CategoryId = 2,
                    CategoryName = "Phones",
                    CategoryDescription = "Телефоны",
                    CreateDate = DateTime.Now
                },

                new ProductCategory()
                {
                    CategoryId = 3,
                    CategoryName = "Tablet",
                    CategoryDescription = "Планшеты",
                    CreateDate = DateTime.Now
                },

                new ProductCategory()
                {
                    CategoryId = 4,
                    CategoryName = "Headphones",
                    CategoryDescription = "Наушники",
                    CreateDate = DateTime.Now
                }

            );
            //Add Data in Shop table
            modelBuilder.Entity<Shop>().HasData
            (
                new Shop()
                {
                    ShopId = 1,
                    Name = "DNS",
                    Phone = "84567892354",
                    Adress = "Bayakalskaya 88",
                    CreateDate = DateTime.Now
                },

                new Shop()
                {
                    ShopId = 2,
                    Name = "AlibabaGroups",
                    Phone = "82223334567",
                    Adress = "Partizanov 66",
                    CreateDate = DateTime.Now
                },

                 new Shop()
                 {
                     ShopId = 3,
                     Name = "Ozon",
                     Phone = "89299206104",
                     Adress = "VolkovskoyShosse 12",
                     CreateDate = DateTime.Now
                 }

             );
            //Add Data in Product table
            modelBuilder.Entity<Product>().HasData
            (
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Iphone",
                    ProductModel = "11Pro_256Gb",
                    Price = 65000,
                    CategoryId = 2,
                    ShopId = 1,
                    CreateDate = DateTime.Now
                },

                new Product()
                {
                    ProductId = 4,
                    ProductName = "Ipad",
                    ProductModel = "iPad air 2022",
                    Price = 65000,
                    CategoryId = 3,
                    ShopId = 1,
                    CreateDate = DateTime.Now
                },

                 new Product()
                 {
                     ProductId = 6,
                     ProductName = "Shinhizer",
                     ProductModel = "2000ML",
                     Price = 65000,
                     CategoryId = 4,
                     ShopId = 1,
                     CreateDate = DateTime.Now
                 },


                new Product()
                {
                    ProductId = 2,
                    ProductName = "Nokia",
                    ProductModel = "6800_512GB",
                    Price = 65000,
                    CategoryId = 2,
                    ShopId = 2,
                    CreateDate = DateTime.Now
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Samsung",
                    ProductModel = "Galaxsy10_512GB",
                    Price = 100000,
                    CategoryId = 2,
                    ShopId = 2,
                    CreateDate = DateTime.Now
                },

                new Product()
                {
                    ProductId = 7,
                    ProductName = "Acer",
                    ProductModel = "Ml3000",
                    Price = 65000,
                    CategoryId = 1,
                    ShopId = 2,
                    CreateDate = DateTime.Now
                },

                new Product()
                {
                    ProductId = 5,
                    ProductName = "Sony",
                    ProductModel = "Wh30000",
                    Price = 65000,
                    CategoryId = 4,
                    ShopId = 3,
                    CreateDate = DateTime.Now
                },


                new Product()
                {
                    ProductId = 8,
                    ProductName = "Asus",
                    ProductModel = "Ror Strix Scar",
                    Price = 65000,
                    CategoryId = 1,
                    ShopId = 3,
                    CreateDate = DateTime.Now
                },

                new Product()
                {
                    ProductId = 9,
                    ProductName = "Lenovo",
                    ProductModel = "Dino V2",
                    Price = 65000,
                    CategoryId = 1,
                    ShopId = 3,
                    CreateDate = DateTime.Now
                }
             );
        }



    }    
}
