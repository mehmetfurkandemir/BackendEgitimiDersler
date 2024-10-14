namespace StoreProduct;
using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public Product(string name, decimal price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public bool CheckStock(int quantity)
    {
        return StockQuantity >= quantity;
    }

    public void UpdateStock(int quantity)
    {
        StockQuantity += quantity;
    }
}

public class FoodProduct : Product
{
    public DateTime ExpirationDate { get; set; }

    public FoodProduct(string name, decimal price, int stockQuantity, DateTime expirationDate)
        : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }

    public bool IsExpired()
    {
        return DateTime.Now > ExpirationDate;
    }
}

public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; set; }

    public ElectronicProduct(string name, decimal price, int stockQuantity, int warrantyPeriod)
        : base(name, price, stockQuantity)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public bool IsUnderWarranty(DateTime purchaseDate)
    {
        return (DateTime.Now - purchaseDate).TotalDays < (WarrantyPeriod * 30);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FoodProduct apple = new FoodProduct("Apple", 1.5m, 100, DateTime.Now.AddDays(10));
        ElectronicProduct laptop = new ElectronicProduct("Laptop", 999.99m, 50, 24);

        Console.WriteLine($"10 adet elma stoğu mevcut mu? {apple.CheckStock(10)}");

        apple.UpdateStock(20);
        Console.WriteLine($"Elma stok miktarı: {apple.StockQuantity}");

        Console.WriteLine($"Elma tarihi geçti mi? {apple.IsExpired()}");

        DateTime purchaseDate = DateTime.Now.AddMonths(-10);
        Console.WriteLine($"Laptop garanti kapsamında mı? {laptop.IsUnderWarranty(purchaseDate)}");
    }
}

