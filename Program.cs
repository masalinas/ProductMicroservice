using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Data;
using ProductMicroservice.Repositories;
using ProductMicroservice.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Extract the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2. Register the DbContext for PostgreSQL
// This is the equivalent of your datasource and dialect config in Spring
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
