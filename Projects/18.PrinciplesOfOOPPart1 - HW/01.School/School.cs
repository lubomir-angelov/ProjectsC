using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class School
    {
        static void Main(string[] args)
        {
            Teachers teacher = new Teachers("Ivan Ivanov");
            teacher.Discipline = new Disciplines("Mathematics", 1, 2);

            Console.WriteLine(teacher.Discipline.Name);

            People person = new People("Petkan Petkanov", "Student");

            person.Student.TextBlock = "Hmm, I'm a student";

            Console.WriteLine(person.Student.TextBlock);
        }
    }
}
