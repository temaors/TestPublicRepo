using Lab6TestTask.Enums;

namespace Lab6TestTask.Models;

/// <summary>
/// Product.
/// DO NOT change anything here.
/// </summary>
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = default!;
    public int Quantity { get; set; }
    public ProductStatus Status { get; set; }
    public DateTime ReceivedDate { get; set; }
    public decimal Price { get; set; }
    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = default!;
}
