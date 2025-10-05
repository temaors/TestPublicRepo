using Lab6TestTask.Models;

namespace Lab6TestTask.Services.Interfaces;

/// <summary>
/// IProductService.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
public interface IProductService
{
    Task<Product> GetProductAsync();
    Task<IEnumerable<Product>> GetProductsAsync();
}
