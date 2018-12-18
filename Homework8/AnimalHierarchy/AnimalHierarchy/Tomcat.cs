using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "male";
        }

        public new string Gender
        {
            get
            {
                return base.Gender;
            }

            set
            {
                Console.WriteLine("Gender of tomcat can only be male!");
                base.Gender = "male";
            }
        }
    }
}
