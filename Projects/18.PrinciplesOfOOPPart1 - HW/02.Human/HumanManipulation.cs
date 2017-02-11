using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
 * and method MoneyPerHour() that returns money earned by hour by the worker. 
 * Define the proper constructors and properties for this hierarchy. 
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
 * Initialize a list of 10 workers and sort them by money per hour in descending order. 
 * Merge the lists and sort them by first name and last name.
*/

namespace _02.Human
{
    class HumanManipulation
    {
       
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] names = { "Ivan", "Petkan", "Dragan", "Pesho", "Gosho", "Ceco", "Atanas", "Stanislav", "Stanimir", "Nikolai" };
            string[] lastNames = { "Angelov", "Ivanov", "Petrov", "Petkov", "Burov", "Skarlatov", "Atanasov", "Nedev", "Bozov", "Parvanov" };
            
            /*Student st1 = new Student(5);
            st1.FirstName = "TryThis";
            Console.WriteLine(st1.FirstName);*/


            int secondIndex = 9;
            for (byte i = 0; i < 10; i++)
            {
                Student newSt = new Student(i);
                newSt.FirstName = names[i];
                newSt.LastName = lastNames[secondIndex];
                students.Add(newSt);
                secondIndex--;
            }

            students = students.OrderBy(student => student.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1} his grade --> {2}", student.FirstName, student.LastName, student.Grade);
            }

            List<Worker> workers = new List<Worker>();

            secondIndex = 9;
            for (int i = 9; i >= 0; i--)
            {
                Worker newWorker = new Worker(10, i);
                newWorker.FirstName = names[i];
                newWorker.LastName = lastNames[secondIndex];
                workers.Add(newWorker);
                secondIndex++;
            }

            //MoneyPerHour();

            //workers = workers.OrderBy(salary => )
            //IEnumerable<Worker> descSalary = workers.OrderByDescending(worker => )

            var merged = workers.Concat<Human>(students).ToList();

            merged = merged.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            Console.WriteLine(new string('-', 40));
            foreach (Human human in merged)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
