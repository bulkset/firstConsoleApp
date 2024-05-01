using System;

namespace ConsoleApp
{
    public  class Electronic : Product
    {
        public string Manufacturer { get; set; }
        public int Warranty { get; set; }

        public Electronic(string id, string name, decimal price, int stock, string manufacturer, int warranty) : base(
            id, name, price, stock)
        {
            Manufacturer = manufacturer;
            Warranty = warranty;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine(
                $"Product: {Id} — {Name}\nPrice: {Price}\nQuantity in Stock: {Stock}\nManufacturer: {Manufacturer}\nWarranty Period: {Warranty}\n");
        }
    }
}