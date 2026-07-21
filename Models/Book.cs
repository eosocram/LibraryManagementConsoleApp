namespace LibraryManagementConsoleApp.Models;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Year {get; set;} = string.Empty;
    public enum Category
    {
        Adventure, //0
        Comedy, //1
        Drama, //2
        Horror, //3
    }
    public Category BookCategory { get; set; }
    public string ISBN { get; set; }
    public int QuantityTotal { get; set; }
    public int QuantityAvailable { get; private set; }

    public Book(string title, string author, string year, string isbn, int quantityTotal, Category category)
    {
        Title = title;
        Author = author;
        Year = year;
        ISBN = isbn;
        QuantityTotal = quantityTotal;
        QuantityAvailable = QuantityTotal;
        
        BookCategory = category;

    }
    
}
