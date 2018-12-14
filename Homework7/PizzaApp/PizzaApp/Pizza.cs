using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Pizza
    {
        public Pizza(PizzaBase pb)
        {
            this.Name = Name;
            this.PizzaBase = pb;
            this.PizzaTopping = new List<PizzaTopping>();
        }

        public string Name { get; set; }

        public PizzaBase PizzaBase { get; set; }

        private List<PizzaTopping> PizzaTopping { get; set; }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            PizzaTopping.Add(pizzaTopping);
        }

        public decimal CalculateTotalCost()
        {
            decimal total_cost = 0;
            total_cost = total_cost + this.PizzaBase.Cost;

            foreach (var topping in this.PizzaTopping)
            {
                total_cost = total_cost + topping.Cost;
            }

            return total_cost;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza: {Name}");
            this.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var topping in this.PizzaTopping)
            {
                topping.Print();
            }
            Console.WriteLine("Total cost: $" + this.CalculateTotalCost());
        }
    }
}