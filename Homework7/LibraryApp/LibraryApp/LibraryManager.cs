using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    static class LibraryManager
    {
        public static void CreateSampleLibrary()
        {
            // book 1
            Author author1 = new Author("JK Rowling", "rowling@gb.org");
            Author author2 = new Author("Tolkien", "tolkien@us.org");

            Book book1 = new Book("Harry Potter", "SF", 2008, (decimal)30);
            book1.AddAuthor(author1);
            book1.AddAuthor(author2);

            // book 2
            Author author3 = new Author("Teodoreanu", "teodoreanu@ro.org");
            Author author4 = new Author("Sadoveanu", "sadoveanu@ro.org");

            Book book2 = new Book("Baltagul", "Drama", 1980, (decimal)18.75);
            book2.AddAuthor(author3);
            book2.AddAuthor(author4);

            // book 3
            Book book3 = new Book("The Hobbit", "Mystery", 2011, (decimal)15.50);
            book3.AddAuthor(author2);

            Library library1 = new Library("BCU");
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);

            library1.Print();
        }
    }
}
