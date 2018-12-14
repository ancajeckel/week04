using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaBase
    {
        public PizzaBase(string name, decimal baseCost)
        {
            switch (name)
            {
                case "Italian":
                    this.Name = name;
                    this.Cost = (decimal)1.5 * baseCost;
                    break;
                case "Thick":
                case "Regular":
                    this.Name = name;
                    this.Cost = baseCost;
                    break;
                default:
                    Console.WriteLine($"{name} is not a valid PizzaBase");
                    break;
            }

        }

        public string Name { get; }

        public decimal Cost { get; }

        public void Print()
        {
            Console.WriteLine($"Base: {this.Name} (${this.Cost})");
        }
    }
}
