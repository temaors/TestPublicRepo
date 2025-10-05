namespace Lab6TestTask.Models;

/// <summary>
/// Warehouse.
/// DO NOT change anything here.
/// </summary>
public class Warehouse
{
    public int WarehouseId { get; set; }
    public string Name { get; set; } = default!;
    public string Location { get; set; } = default!;
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
