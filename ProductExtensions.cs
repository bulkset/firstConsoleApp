using System;

namespace ConsoleApp
{
    public static class ProductExtensions
    {
        public static void DisplayInfo(this Product product)
        {
            Console.WriteLine($"Product: {product.Id} — {product.Name}\nPrice: {product.Price}\nQuantity in Stock: {product.Stock}\n");
        }
    }
}