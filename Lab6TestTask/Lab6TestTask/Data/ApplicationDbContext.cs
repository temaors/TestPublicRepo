using Lab6TestTask.Enums;
using Lab6TestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6TestTask.Data;

/// <summary>
/// ApplicationDbContext.
/// DO NOT change anything here.
/// </summary>
public class ApplicationDbContext : DbContext
{
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Warehouse>().HasData(
            new Warehouse { WarehouseId = 1, Name = "Warehouse 1", Location = "Berlin" },
            new Warehouse { WarehouseId = 2, Name = "Warehouse 2", Location = "Paris" },
            new Warehouse { WarehouseId = 3, Name = "Warehouse 3", Location = "Rome" },
            new Warehouse { WarehouseId = 4, Name = "Warehouse 4", Location = "Warsaw" },
            new Warehouse { WarehouseId = 5, Name = "Warehouse 5", Location = "Madrid" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Cement",
                Quantity = 500,
                Status = ProductStatus.ReadyForDistribution,
                ReceivedDate = new DateTime(2024, 10, 1),
                Price = 6.50m,
                WarehouseId = 1
            },
            new Product
            {
                ProductId = 2,
                Name = "Bricks",
                Quantity = 10000,
                Status = ProductStatus.Reserved,
                ReceivedDate = new DateTime(2024, 9, 20),
                Price = 0.45m,
                WarehouseId = 1
            },
            new Product
            {
                ProductId = 3,
                Name = "Steel Rebars",
                Quantity = 2000,
                Status = ProductStatus.InTransit,
                ReceivedDate = new DateTime(2025, 4, 25),
                Price = 2.10m,
                WarehouseId = 2
            },
            new Product
            {
                ProductId = 4,
                Name = "Timber Planks",
                Quantity = 1500,
                Status = ProductStatus.ReadyForDistribution,
                ReceivedDate = new DateTime(2025, 10, 2),
                Price = 15.00m,
                WarehouseId = 2
            },
            new Product
            {
                ProductId = 5,
                Name = "Roof Tiles",
                Quantity = 4000,
                Status = ProductStatus.ReadyForDistribution,
                ReceivedDate = new DateTime(2025, 6, 3),
                Price = 1.20m,
                WarehouseId = 3
            },
            new Product
            {
                ProductId = 6,
                Name = "Paint Buckets",
                Quantity = 600,
                Status = ProductStatus.Reserved,
                ReceivedDate = new DateTime(2025, 9, 30),
                Price = 25.00m,
                WarehouseId = 3
            },
            new Product
            {
                ProductId = 7,
                Name = "Hammer",
                Quantity = 300,
                Status = ProductStatus.ReadyForDistribution,
                ReceivedDate = new DateTime(2025, 10, 4),
                Price = 12.00m,
                WarehouseId = 4
            },
            new Product
            {
                ProductId = 8,
                Name = "Electric Drill",
                Quantity = 150,
                Status = ProductStatus.InTransit,
                ReceivedDate = new DateTime(2025, 5, 28),
                Price = 80.00m,
                WarehouseId = 4
            },
            new Product
            {
                ProductId = 9,
                Name = "Ladder",
                Quantity = 100,
                Status = ProductStatus.ReadyForDistribution,
                ReceivedDate = new DateTime(2025, 10, 5),
                Price = 60.00m,
                WarehouseId = 5
            },
            new Product
            {
                ProductId = 10,
                Name = "Wheelbarrow",
                Quantity = 70,
                Status = ProductStatus.Reserved,
                ReceivedDate = new DateTime(2024, 10, 1),
                Price = 95.00m,
                WarehouseId = 5
            }
        );
    }
}
