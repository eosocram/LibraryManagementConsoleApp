namespace LibraryManagementConsoleApp;
using LibraryManagementConsoleApp.Models;
public class Program
{
    public static void Main()
    {
        Book book = new Book("AlecrimDourado", "Marcos", "2000", "7870-9897", 10, 0);
        
        Console.WriteLine(book.QuantityAvailable);
    }
}