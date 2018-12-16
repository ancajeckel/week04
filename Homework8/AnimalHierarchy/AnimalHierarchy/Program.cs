using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Dog("Beagle",3,"male");
            d1.Print();
            var d2 = new Dog("Labrador", 6, "female");
            d2.Print();

            var f1 = new Frog("Broscuta", 1, "female");
            f1.Print();

            var c1 = new Cat("Pisica", 2, "female");
            c1.Print();

            var k1 = new Kitten("Kitten", 4);
            ((Cat)k1).Print();

            var t1 = new Tomcat("Tomcat", 5);
            t1.Age = 20;
            ((Cat)t1).Print();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Average age of all animals: {Animal.GetAverageAgeAnimals().ToString("#.##")}");
            Console.WriteLine($"Average age of all dogs: {Dog.GetAverageAgeDogs().ToString("#.##")}");
            Console.WriteLine($"Average age of all frogs: {Frog.GetAverageAgeFrogs().ToString("#.##")}");
            Console.WriteLine($"Average age of all cats: {Cat.GetAverageAgeCats().ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
