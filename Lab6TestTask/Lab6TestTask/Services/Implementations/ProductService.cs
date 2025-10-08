using Lab6TestTask.Data;
using Lab6TestTask.Models;
using Lab6TestTask.Services.Interfaces;
using Lab6TestTask.Enums;
using Microsoft.EntityFrameworkCore;

namespace Lab6TestTask.Services.Implementations;

/// <summary>
/// ProductService.
/// Implement methods here.
/// </summary>
public class ProductService : IProductService
{
    private readonly ApplicationDbContext _dbContext;

    public ProductService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Product> GetProductAsync() => 
        await _dbContext.Products
            .Where(p => p.Status == ProductStatus.Reserved)
            .OrderByDescending(p => p.Price)
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException("There are no reserved products");

    public async Task<IEnumerable<Product>> GetProductsAsync() =>
        await _dbContext.Products
            .Where(p => p.ReceivedDate.Year == 2025 && p.Quantity > 1000)
            .ToListAsync();
}
