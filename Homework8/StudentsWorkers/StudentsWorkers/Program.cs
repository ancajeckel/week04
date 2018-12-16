using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        public static List<Student> TestStudents()
        {
            Student s1 = new Student("Andrei", "B.", 9);
            Student s2 = new Student("Mihai", "C.", 7.2);
            Student s3 = new Student("Ionut", "A.", 8);
            Student s4 = new Student("Gigi", "D.", 8.75);
            Student s5 = new Student("Alex", "F.", 9.25);
            Student s6 = new Student("Cipi", "B.", 10);
            Student s7 = new Student("Vali", "C.", 9.20);
            Student s8 = new Student("Tudor", "M.", 6.5);
            Student s9 = new Student("Sebi", "T.", 8.5);
            Student s10 = new Student("Viorel", "D.", 7.8);

            var listStud = new List<Student>();
            listStud.Add(s1);
            listStud.Add(s2);
            listStud.Add(s3);
            listStud.Add(s4);
            listStud.Add(s5);
            listStud.Add(s6);
            listStud.Add(s7);
            listStud.Add(s8);
            listStud.Add(s9);
            listStud.Add(s10);

            foreach (var student in listStud.OrderBy(x => x.Grade).ToList() )
            {
                Console.WriteLine($"Student {student.FirstName} {student.LastName} grade:{student.Grade}");
            }
            Console.WriteLine();

            return listStud;
        }

        public static List<Worker> TestWorkers()
        {
            Worker s1 = new Worker("Gigi", "B.", 300,8);
            Worker s2 = new Worker("Valeriu", "C.", 325,8);
            Worker s3 = new Worker("Ion", "A.", 250,6);
            Worker s4 = new Worker("Pavel", "D.", 400,10);
            Worker s5 = new Worker("Gheorghe", "F.", 380,8);
            Worker s6 = new Worker("Nelu", "B.", 290,8);
            Worker s7 = new Worker("Dorin", "C.", 315,8);
            Worker s8 = new Worker("Teodor", "M.", 340,8);
            Worker s9 = new Worker("Sorin", "T.", 310,8);
            Worker s10 = new Worker("Calin", "D.", 240,6);

            var listWorkers = new List<Worker>();
            listWorkers.Add(s1);
            listWorkers.Add(s2);
            listWorkers.Add(s3);
            listWorkers.Add(s4);
            listWorkers.Add(s5);
            listWorkers.Add(s6);
            listWorkers.Add(s7);
            listWorkers.Add(s8);
            listWorkers.Add(s9);
            listWorkers.Add(s10);

            foreach (var Worker in listWorkers.OrderByDescending(x => x.MoneyPerHour()).ToList())
            {
                Console.WriteLine($"Worker {Worker.FirstName} {Worker.LastName} $:{Worker.MoneyPerHour().ToString("#.##")} /hour");
            }
            Console.WriteLine();

            return listWorkers;

        }

        static void Main(string[] args)
        {
            var list1 = TestStudents();
            var list2 = TestWorkers();

            var mergedList = new List<Human>();
            foreach (var item in list1)
            {
                mergedList.Add((Human)item);
            }
            foreach (var item in list2)
            {
                mergedList.Add((Human)item);
            }

            foreach (var person in mergedList.OrderBy(x => x.FirstName + x.LastName).ToList() )
            {
                Console.WriteLine($"Person {person.FirstName} {person.LastName}");
            }

            Console.ReadKey();
        }
    }
}
