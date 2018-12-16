using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        private static List<Frog> listFrogs = new List<Frog>();

        public Frog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            listFrogs.Add(this);
        }

        public string Sound()
        {
            return "oac-oac";
        }

        public void Print()
        {
            Console.WriteLine($"Frog {this.Name} ({this.Gender}), age:{this.Age}, sound:{this.Sound()}");
        }

        public static decimal GetAverageAgeFrogs()
        {
            int sumAge = 0;
            foreach (var dog in listFrogs)
            {
                sumAge = sumAge + dog.Age;

            }
            return (decimal)sumAge / listFrogs.Count;
        }
    }
}
