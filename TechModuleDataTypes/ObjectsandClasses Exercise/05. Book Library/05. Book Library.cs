using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Book_Library
{
    public class BookLibrary
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            Library softUni = new Library(new List<Book>(), "SoftUni");

            for (int i = 0; i < lines; i++)
            {
                var parameters = Console.ReadLine().Split(' ').ToArray();
                var date = parameters[3].Split('.').ToArray();
                var book = new Book(
                    parameters[0], //title
                    parameters[1], //author
                    parameters[2], //publisher
                    new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])), //releaseDate
                    parameters[4], //ISBN number
                    decimal.Parse(parameters[5])); //price

                softUni.Books.Add(book);
            }

            //total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
            var authors = softUni.Books.Select(s => s.Author).Distinct().ToList();
            Dictionary<string, decimal> output = new Dictionary<string, decimal>();

            foreach (var author in authors.OrderBy(s => s))
            {
                var sum = softUni.Books.Where(s => s.Author == author).Sum(s => s.Price);
                output.Add(author, sum);
            }

            foreach (var pair in output.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", pair.Key, pair.Value);
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
