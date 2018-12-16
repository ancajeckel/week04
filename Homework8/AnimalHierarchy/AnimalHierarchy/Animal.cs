using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        protected List<string> listGender = new List<string>() { "male", "female"};

        protected static int sumAgeAnimals;

        protected static int countAnimals;

        public Animal()
        {
            countAnimals++;
        }
 
        public string Name { get; set; }

        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                sumAgeAnimals = sumAgeAnimals - this.age;
                this.age = value;
                sumAgeAnimals = sumAgeAnimals + value;
            }
        }

        private string gender;

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (listGender.Contains(value))
                {
                    this.gender = value;
                }
                else
                {
                    Console.WriteLine($"Gender {value} is not valid!");
                    this.gender = "";
                }
            }
        }

        public static decimal GetAverageAgeAnimals()
        {
            if (countAnimals == 0)
            {
                return (decimal)0;
            }
            return (decimal)sumAgeAnimals / countAnimals;
        }
    }
}
