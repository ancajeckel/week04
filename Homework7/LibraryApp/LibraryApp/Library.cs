using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Library
    {
        public Library(string aName)
        {
            Name = aName;
            Books = new List<Book>();
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public void AddBook(Book aBook)
        {
            Books.Add(aBook);
        }

        public void Print()
        {
            Console.WriteLine($"Library: {Name} contains {Books.Count} books:");
            foreach (var book in Books)
            {
                book.Print();
            }
        }
    }
}
