using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.Book_Library_Modification
{
    public class BookLibraryModified
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            Library SoftUni = new Library(new List<Book>(), "SoftUni");
            for (int i = 0; i < lines; i++)
            {
                var parameters = Console.ReadLine().Split(' ').ToArray();
                var book = new Book(
                    parameters[0], //title
                    parameters[1], //author
                    parameters[2], //publisher
                    DateTime.ParseExact(parameters[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), //releaseDate
                    parameters[4], //isbNumber
                    decimal.Parse(parameters[5])); //price

                SoftUni.Books.Add(book);
            }
            
            var targetDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in SoftUni.Books.Where(s => s.ReleaseDate > targetDate).OrderBy(s => s.ReleaseDate).ThenBy(s => s.Title))
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("d.MM.yyyy"));
            }
        }

        internal class Library
        {
            public List<Book> Books { get; set; }

            public string Name { get; set; }

            public Library(List<Book> books, string name)
            {
                this.Books = books;
                this.Name = name;
            }
        }

        internal class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publish { get; set; }

            public DateTime ReleaseDate { get; set; }

            public string IsbNumber { get; set; }

            public decimal Price { get; set; }

            public Book(string title, string author, string publish, DateTime releaseDate, string isbNumber, decimal price)
            {
                this.Title = title;
                this.Author = author;
                this.Publish = publish;
                this.ReleaseDate = releaseDate;
                this.IsbNumber = isbNumber;
                this.Price = price;
            }
        }
    }
}
