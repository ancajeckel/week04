using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animal, ISound
    {
        private static List<Dog> listDogs = new List<Dog>();

        public Dog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            listDogs.Add(this);
        }

        public string Sound()
        {
            return "ham-ham";
        }

        public void Print()
        {
            Console.WriteLine($"Dog {this.Name} ({this.Gender}), age:{this.Age}, sound:{this.Sound()}");
        }

        public static decimal GetAverageAgeDogs()
        {
            int sumAge = 0;
            foreach (var dog in listDogs)
            {
                sumAge = sumAge + dog.Age;

            }
            return (decimal)sumAge / listDogs.Count;
        }
    }
}
