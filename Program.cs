using ConsoleAppHomework_Core0502.Context;
using ConsoleAppHomework_Core0502.Models;

namespace ConsoleAppHomework_Core0502;
class Program
{
    static void Main()
    {
        //    using (var db = new BookStoreContext())
        //    {
        //        var authors = new List<Author>
        //{
        //    new Author {Name = "Лев Толстой" },
        //    new Author {Name = "Федор Достоевский" },
        //    new Author {Name = "Антон Чехов" }
        //};

        //        db.Authors.AddRange(authors);
        //        db.SaveChanges();
        //    }

        //    using (var db = new BookStoreContext())
        //    {
        //        var books = new List<Book>
        //{
        //    new Book { Title = "Война и мир", AuthorId = 1, Price = 500.00m },
        //    new Book { Title = "Анна Каренина", AuthorId = 1, Price = 450.00m },
        //    new Book { Title = "Преступление и наказание", AuthorId = 2, Price = 550.00m },
        //    new Book { Title = "Братья Карамазовы", AuthorId = 2, Price = 600.00m },
        //    new Book {Title = "Вишневый сад", AuthorId = 3, Price = 300.00m },
        //    new Book { Title = "Чайка", AuthorId = 3, Price = 320.00m }
        //};

        //        db.Books.AddRange(books);
        //        db.SaveChanges();
        //    }

        //using (var db = new BookStoreContext())
        //{
        //    int authorIdToUpdate = 1; 
        //    decimal newPrice = 724; 

        //    db.UpdateBookPricesByAuthor(authorIdToUpdate, newPrice);
        //}
        //using (var db = new BookStoreContext())
        //{
        //    int authorIdToUpdate = 1; 
        //    var oldPrices = db.Books
        //                            .Where(b => b.AuthorId == authorIdToUpdate)
        //                            .Select(b => new { b.Title, b.Price })
        //                            .ToList();

        //    Console.WriteLine("Старые цены книг:");
        //    foreach (var book in oldPrices)
        //    {
        //        Console.WriteLine($"Название: {book.Title}, Цена: {book.Price}");
        //    }
        //    decimal newPrice = 500.00m; 
        //    db.UpdateBookPricesByAuthor(authorIdToUpdate, newPrice);
        //    db.SaveChanges();
        //    var newPrices = db.Books
        //                            .Where(b => b.AuthorId == authorIdToUpdate)
        //                            .Select(b => new { b.Title, b.Price })
        //                            .ToList();
        //    Console.WriteLine("\nНовые цены книг:");
        //    foreach (var book in newPrices)
        //    {
        //        Console.WriteLine($"Название: {book.Title}, Цена: {book.Price}");
        //    }
        //}

    }
}
