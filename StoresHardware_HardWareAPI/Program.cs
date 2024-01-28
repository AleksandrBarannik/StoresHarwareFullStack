using StoresHardware_HardWareAPI.Data;
using Microsoft.EntityFrameworkCore;
using StoresHardware_HardWareAPI.Repository.IRepository;
using StoresHardware_HardWareAPI.Repository;
using StoresHardware_HardWareAPI;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

                        // Add services to the container.

                //registration service Repository(pattern Repository)(our Services)
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddResponseCaching();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddCors();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

                 //Service for EntityFraemwork
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
                    //DefaultSQLConnection write in  appsettings.json
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});

builder.Services.AddControllers(option =>
{
    option.CacheProfiles.Add("Default30",
        new CacheProfile()
        {
            Duration = 30
        });
});

var app = builder.Build();

                // Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Политика безовасности
app.UseCors(builder => builder.AllowAnyOrigin());

app.Run();
