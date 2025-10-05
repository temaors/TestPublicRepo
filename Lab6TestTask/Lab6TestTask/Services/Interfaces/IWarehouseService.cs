using Lab6TestTask.Models;

namespace Lab6TestTask.Services.Interfaces;

/// <summary>
/// IWarehouseService.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
public interface IWarehouseService
{
    Task<Warehouse> GetWarehouseAsync();
    Task<IEnumerable<Warehouse>> GetWarehousesAsync();
}
