using System;

namespace ConsoleApp
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string id, string name, decimal price, int stock, string author, string genre) : base(id, name, price, stock)
        {
            Author = author;
            Genre = genre;
        }

        public override void DisplayProduct()
        {
            Console.WriteLine($"Product: {Id} — {Name}\nPrice: {Price}\nQuantity in Stock: {Stock}\nAuthor: {Author}\nGenre: {Genre}\n");
        }
    }
}