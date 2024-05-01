using System;

namespace ConsoleApp
{
    public static class ElectronicExtensions
    {
        public static void PrintInfo(this Electronic electronic)
        {
            Console.WriteLine($"Product: {electronic.Id} — {electronic.Name}\nPrice: {electronic.Price}\nQuantity in Stock: {electronic.Stock}\nManufacturer: {electronic.Manufacturer}\nWarranty Period: {electronic.Warranty}\n");
        }
    }
}