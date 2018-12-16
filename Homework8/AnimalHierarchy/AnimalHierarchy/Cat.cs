using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        private static List<Cat> listCats = new List<Cat>();

        public Cat()
        {
            listCats.Add(this);
        }

        public Cat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            listCats.Add(this);
        }

        public string Sound()
        {
            return "miau";
        }

        public void Print()
        {
            Console.WriteLine($"Cat {this.Name} ({this.Gender}), age:{this.Age}, sound:{this.Sound()}");
        }

        public static decimal GetAverageAgeCats()
        {
            int sumAge = 0;
            foreach (var dog in listCats)
            {
                sumAge = sumAge + dog.Age;

            }
            return (decimal)sumAge / listCats.Count;
        }
    }
}
