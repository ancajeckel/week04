using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaBase
    {
        public PizzaBase(string name, double baseCost)
        {
            if (name != "Regular" && name != "Thick" && name != "Italian")
            {
                throw new Exception("Base can be: Regular / Thick / Italian");
            }
            this.Name = name;
            this.Cost = baseCost;
        }
        public string Name { get; set; }

        public double Cost { get; set; }

        public double GetCost()
        {
            if (Name == "Italian")
            {
                return 1.5 * Cost;
            }
            return Cost;
        }

        public void Print()
        {
            Console.WriteLine($"Base: {Name} (${GetCost()})");
        }
    }
}
