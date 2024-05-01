using System;

namespace ConsoleApp
{
    public static class ClothingExtensions
    {
        public static void PrintInfo(this Clothing clothing)
        {
            Console.WriteLine($"Product: {clothing.Id} — {clothing.Name}\nPrice: {clothing.Price}\nQuantity in Stock: {clothing.Stock}\nSize: {clothing.Size}\nColor: {clothing.Color}\n");
        }
    }
}