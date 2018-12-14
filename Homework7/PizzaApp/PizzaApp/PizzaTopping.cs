using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaTopping
    {
        private List<string> _toppingTypes = new List<string> { "cheese", "meat", "vegetables" };

        public PizzaTopping(string aName, decimal aCost)
        {
            if (_toppingTypes.Contains(aName.ToLower()))
            {
                this.Name = aName;
                this.Cost = aCost;
            }
            else
            {
                Console.WriteLine($"{aName} is an invalid topping");
            }
        }
        public string Name { get; private set; }

        public decimal Cost { get; }

        public void Print()
        {
            if (Name.ToLower() == "meat")
            {
                Name = Name.ToUpper();
            }
            Console.WriteLine($"\tPT: {Name} (${Cost})");
        }
    }
}