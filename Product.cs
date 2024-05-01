namespace ConsoleApp;

public class Product
{
    public string Id { get; }
    public string Name { get; set; }
    public decimal Price{ get; set; }
    public int Stock{ get; set; }

    public Product(string id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public virtual void UpdateQuantity(int newStock)
    {
        Stock += newStock;
    }
    public virtual void DisplayProduct()
    {
        Console.WriteLine($"Product: {Id} — {Name}\nPrice: {Price}\nQuantity in Stock: {Stock}\n");
    } 
}