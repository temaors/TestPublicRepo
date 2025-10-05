using Lab6TestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab6TestTask.Controllers;

/// <summary>
/// Warehouses controller.
/// DO NOT change anything here. Use created contract and provide only needed implementation.
/// </summary>
[Route("api/warehouses")]
[ApiController]
public class WarehousesController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;

    public WarehousesController(IWarehouseService warehouseService)
    {
        _warehouseService = warehouseService;
    }

    /// <summary>
    /// Returns selected warehouse. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet("selected-warehouse")]
    public async Task<IActionResult> GetWarehouse()
    {
        var result = await _warehouseService.GetWarehouseAsync();
        return Ok(result);
    }

    /// <summary>
    /// Returns selected warehouses. 
    /// Selection rules are specified in Task description provided by recruiter
    /// </summary>
    [HttpGet("selected-warehouses")]
    public async Task<IActionResult> GetWarehouses()
    {
        var result = await _warehouseService.GetWarehousesAsync();
        return Ok(result);
    }
}
