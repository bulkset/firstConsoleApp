namespace ConsoleApp
{
    class Program
    {
        
        static void Main()
        {
            Book book = new Book("B001", "The Great Gatsby", 12.99m, 10, "F. Scott Fitzgerald", "Classic");
            Electronic electronic = new Electronic("E001", "Smartphone", 799.99m, 5, "Apple", 12);
            Clothing clothing = new Clothing("C001", "T-Shirt", 19.99m, 20, "M", "Blue");

            // Displaying product information
            book.PrintInfo();
            electronic.PrintInfo();
            clothing.PrintInfo();

            // Updating quantity of a product
            book.UpdateQuantity(5);
            clothing.UpdateQuantity(10);

            // Displaying updated quantity
            book.PrintInfo();
            clothing.PrintInfo();
            
        }
    }
}