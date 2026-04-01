using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Data;
using ProductMicroservice.Models;

namespace ProductMicroservice.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly MyDbContext _context; // Your Database Context (EntityManager equivalent)

    public ProductRepository(MyDbContext context) => _context = context;

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        // Use .Include() to perform a JOIN (Equivalent to JOIN FETCH in JPQL)
        return await _context.Products
            .Include(p => p.Brand)
            .ToListAsync();
    }

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }
}