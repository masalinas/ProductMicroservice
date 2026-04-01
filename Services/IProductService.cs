using ProductMicroservice.Models;

namespace ProductMicroservice.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAvailableProductsAsync();
}