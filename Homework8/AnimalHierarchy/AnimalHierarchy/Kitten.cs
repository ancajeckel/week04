using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kitten : Cat, ISound
    {
        public Kitten (string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "female";
        }

        public new string Gender
        {
            get
            {
                return base.Gender;
            }

            set
            {
                Console.WriteLine("Gender of kitten can only be female!");
                base.Gender = "female";
            }
        }
    }
}
