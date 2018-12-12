using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book
    {
        public Book(string aTitle, string aGenre, int aYear, decimal aPrice)
        {
            Title = aTitle;
            Genre = aGenre;
            Year = aYear;
            Price = aPrice;
            Authors = new List<Author>();
        }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public List<Author> Authors { get; set; }

        public void AddAuthor(Author aAuthor)
        {
            Authors.Add(aAuthor);
        }

        public decimal GetPrice()
        {
            if (Genre.ToLower() == "drama")
            {
                return Price - (decimal)0.10 * Price;
            }
            else if (Genre.ToLower() == "sf")
            {
                return Price - (decimal)0.15 * Price;
            }
            else
            {
                return Price;
            }
        }

        public void Print()
        {
            Console.WriteLine($"\tBook: {Title} ({Year}), Genre: {Genre}, Price: {GetPrice()}");
            foreach (var author in Authors)
            {
                author.Print();
            }
        }
    }
}
