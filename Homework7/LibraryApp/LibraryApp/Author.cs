using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Author
    {
        public Author(string aName, string aEmail)
        {
            this.Name = aName;
            if (aEmail.Contains("@") && aEmail.Contains("."))
            {
                this.Email = aEmail;
            }
            else
            {
                Console.WriteLine("Email is not valid");
                this.Email = "";
            }
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\tAuthor {Name} ({Email})");
        }
    }
}
