using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. Write a method that from a given array of students 
finds all students whose first name is before its last 
name alphabetically. Use LINQ query operators.
*/

namespace _03.StudentsFirstLastNameCompare
{
    class Student
    {
        private string firstName = "DefaultFirst";
        private string secondName = "DefaultSecond";

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string SecondName
        {
            get { return this.secondName;  }
        }

        public Student()
        { 
        }

        public Student(string firstName, string secondName)
        {
            if (firstName == null || firstName == "" || secondName == null || secondName == "")
            {
                throw new ArgumentException("Names cannot be null or empty.");
            }

            this.firstName = firstName + " ";
            this.secondName = secondName;
        }
        public Student(string name)
        {
            this.secondName = " " + name;
        }

        public static IEnumerable<Student> CheckNames(Student[] studentsArray)
        {
            IEnumerable<Student> firstBeforeLast =
                from student in studentsArray
                where student.FirstName.CompareTo(student.SecondName) <= 0
                select student;

            return firstBeforeLast;
        }

        public override string ToString()
        {
            return this.FirstName + this.SecondName;
        }
    }

    class StudentsFirstLastNameCompare
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Draganov");
            Student secondStudent = new Student("Peter", "Stevenson");
            Student thirdStudent = new Student("Jack", "Black");
            Student fourthStudent = new Student("Davis", "Richardson");

            Student[] studentsArray = { firstStudent, secondStudent, thirdStudent, fourthStudent };
            IEnumerable<Student> checkedStudents = new Student[studentsArray.Length];

            checkedStudents = Student.CheckNames(studentsArray);
            foreach(var checkedStudent in checkedStudents)
            {
                Console.WriteLine(checkedStudent);
            }

            //tinkering
            Console.WriteLine(firstStudent);
            Console.WriteLine(new Student());
        }
    }
}
