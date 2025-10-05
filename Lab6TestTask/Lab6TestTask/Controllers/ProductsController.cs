using Lab6TestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab6TestTask.Controllers;

/// <summary>
/// Products controller.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    /// <summary>
    /// Returns selected product. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet("selected-product")]
    public async Task<IActionResult> GetProduct()
    {
        var result = await _productService.GetProductAsync();
        return Ok(result);
    }

    /// <summary>
    /// Returns selected products. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet("selected-products")]
    public async Task<IActionResult> GetProducts()
    {
        var result = await _productService.GetProductsAsync();
        return Ok(result);
    }
}
