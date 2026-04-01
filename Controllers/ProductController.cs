using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Models;
using ProductMicroservice.Services;

namespace ProductMicroservice.Controllers;
    
[ApiController]
[Route("api/[controller]")] // Routes to /api/product
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _service.GetAvailableProductsAsync();
        return Ok(products); // Returns 200 OK with JSON
    }
}