using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Models;

namespace ProductMicroservice.Data;

public class MyDbContext : DbContext
{
    // The constructor receives configuration (like the connection string) 
    // from the Dependency Injection container in Program.cs
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    // This property is the equivalent of a Repository in Spring Data JPA.
    // It represents the "Products" table in your PostgreSQL database.
    // This represents the "Products" table in Postgres
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // This is the line that solves your issue:
        // It maps the C# class 'Product' to the Postgres table 'product'
        modelBuilder.Entity<Product>().ToTable("product");
        modelBuilder.Entity<Brand>().ToTable("brand");

        // Optional: Ensure column names match exactly if they are also lowercase/singular
        modelBuilder.Entity<Product>().Property(p => p.Id).HasColumnName("product_id");
        modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("name");
        modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnName("price");
        modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)           // One Product has One Brand
                .WithMany(b => b.Products)      // One Brand has Many Products
                .HasForeignKey(p => p.BrandId); // The FK is BrandId        
    }*/
}