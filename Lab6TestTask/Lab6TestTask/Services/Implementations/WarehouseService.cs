using Lab6TestTask.Data;
using Lab6TestTask.Models;
using Lab6TestTask.Services.Interfaces;
using Lab6TestTask.Enums;
using Microsoft.EntityFrameworkCore;

namespace Lab6TestTask.Services.Implementations;

/// <summary>
/// WarehouseService.
/// Implement methods here.
/// </summary>
public class WarehouseService : IWarehouseService
{
    private readonly ApplicationDbContext _dbContext;

    public WarehouseService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Warehouse> GetWarehouseAsync() =>
        await _dbContext.Warehouses
            .Include(w => w.Products)
            .OrderByDescending(w => w.Products
                .Where(p => p.Status == ProductStatus.ReadyForDistribution)
                .Sum(p => p.Price * p.Quantity))
            .FirstOrDefaultAsync() ?? throw new InvalidOperationException("There are no warehouses with products ready for distribution.");

    public async Task<IEnumerable<Warehouse>> GetWarehousesAsync() =>
        await _dbContext.Warehouses
            .Include(w => w.Products)
            .Where(w => w.Products
                .Any(p => p.ReceivedDate.Year == 2025 && 
                          p.ReceivedDate.Month >= 4 && 
                          p.ReceivedDate.Month <= 6))
            .ToListAsync();
}
