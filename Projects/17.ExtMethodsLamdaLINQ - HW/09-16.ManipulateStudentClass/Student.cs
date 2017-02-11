using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.ManipulateStudentClass
{
    class Student
    {
        private string firstName = "Default";
        private string lastName = "Default";
        private long facultyNumber = 000000;
        private string phoneNumber = "00000000"; //format 02/980-800
        private string email = "default@gmail.com";
        List<int> marks = new List<int>();
        private byte groupNumber = 0;
        private Group group = new Group();

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public long FN
        {
            get { return this.facultyNumber; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public List<int> Marks
        {
            get { return this.marks; } 
        }
        public byte GroupNumber
        {
            get { return this.groupNumber; }
        }
        public Group Group
        {
            get { return this.group; } 
        }

        public Student()
        { 
        }
        public Student(string firstName, string lastName, long fn, string phoneNumber, string email, List<int> marks, byte groupNumber)
        {
            if (groupNumber <= 0)
            {
                throw new ArgumentException("Group number cannot be equal to 0, except by default.");
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = fn;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
            this.group = new Group(this.groupNumber);
        }

        public static List<Student> OrderByFirstName(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student tempStudent = new Student();
                if (students[i - 1].firstName.CompareTo(students[i].firstName) > 0)
                {
                    tempStudent = students[i - 1];
                    students[i - 1] = students[i];
                    students[i] = tempStudent;
                }
            }
            return students;
        }
        public static bool CheckForExcelentMarks(List<int> marks)
        {
            bool result = false;

            for(int i = 0; i < marks.Count; i ++)
            {
                if(marks[i] == 6)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        public void PrintMarks(List<int> marks)
        {
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
