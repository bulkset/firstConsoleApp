using System;

namespace ConsoleApp
{
    public class Clothing : Product
    {
        public string Size;
        public string Color;

        public Clothing(string id, string name, decimal price, int stock, string size, string color) : base(id, name,
            price, stock)
        {
            Size = size;
            Color = color;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine(
                $"Product: {Id} — {Name}\nPrice: {Price}\nQuantity in Stock: {Stock}\nSize: {Size}\nColor: {Color}\n");
        }
    }
}