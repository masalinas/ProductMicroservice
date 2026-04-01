using ProductMicroservice.Models;
using ProductMicroservice.Repositories;

namespace ProductMicroservice.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository) => _repository = repository;

    public async Task<IEnumerable<Product>> GetAvailableProductsAsync()
    {
        // Add your business logic here (filtering, calculations, etc.)
        return await _repository.GetAllAsync();
    }
}