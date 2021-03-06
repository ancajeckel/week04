﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase b1 = new PizzaBase("Italian", 5);
            PizzaBase b2 = new PizzaBase("Regular", 5);

            PizzaTopping t1 = new PizzaTopping("Meat",7);
            PizzaTopping t2 = new PizzaTopping("Cheese",10);
            PizzaTopping t3 = new PizzaTopping("Vegetables",(decimal)2.5);

            Pizza p1 = new Pizza(b1);
            p1.Name = "Capriciosa";
            p1.AddTopping(t1);
            p1.AddTopping(t2);
            p1.AddTopping(t3);
            p1.Print();


            Console.ReadKey();
        }
    }
}