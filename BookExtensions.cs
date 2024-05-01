using System;

namespace ConsoleApp
{
    public static class BookExtensions
    {
        public static void PrintInfo(this Book book)
        {
            Console.WriteLine($"Product: {book.Id} — {book.Name}\nPrice: {book.Price}\nQuantity in Stock: {book.Stock}\nAuthor: {book.Author}\nGenre: {book.Genre}\n");
        }
    }
}