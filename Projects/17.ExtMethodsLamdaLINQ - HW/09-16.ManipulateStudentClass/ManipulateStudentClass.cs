using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 9. Create a class student with properties FirstName, 
LastName, FN, Tel, Email, Marks (a List<int>)
, GroupNumber./ Create a List<Student> with 
sample students. Select only the students that are 
from group number 2. Use LINQ query. Order the 
students by FirstName.
*/

/*
 * 10. Implement the previous using the same query 
expressed with extension methods.
11. Extract all students that have email in abv.bg. Use 
string methods and LINQ.
12. Extract all students with phones in Sofia. Use LINQ.
 * 13. Select all students that have at least one mark 
Excellent (6) into a new anonymous class that has 
properties – FullName and Marks. Use LINQ.
 * 14. Write down a similar program that extracts 
the students with exactly two marks "2". Use 
extension methods.
 * 16. * Create a class Group with properties 
GroupNumber and DepartmentName. Introduce a 
property Group in the Student class. Extract all 
students from "Mathematics" department. Use the Join operator.
 */


namespace _09_16.ManipulateStudentClass
{
    class ManipulateStudentClass
    {
        static void Main(string[] args)
        {
            //a twodimensional array with arrays with phone numbers for easier declartion of students
            List<string> phoneList = new List<string>();
            for(int i = 0; i < 3; i ++)
            {
                int temp = 2980140;
                string addMe = (temp + i).ToString();
                phoneList.Add("0" + addMe);
            }

            List<int> marks1 = new List<int>();
            marks1.Add(6);
            List<int> marks2 = new List<int>();
            marks2.Add(5);
            marks2.Add(4);
            List<int> marks3 = new List<int>();
            marks3.Add(6);
            Student first = new Student("ZIvan", "Ivanov", 555909, phoneList[0], "mymail.com", marks1, 1);
            Student second = new Student("Petkan", "Petkov", 556006, phoneList[1], "yourmail.com", marks2, 2);
            Student third = new Student("Yordan", "Yordanov", 556105, phoneList[2], "myemail@abv.bg", marks3, 3);
            
            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(first);
            sampleStudents.Add(second);
            sampleStudents.Add(third);
            //Console.WriteLine();//put break on each CW for checking tha values of the list of students and etc.

            IEnumerable<Student> groupTwo =  
                from student in sampleStudents
                where student.GroupNumber == 2
                select student; 
            //Console.WriteLine();//in the ResultsView "object menu" we can check the value of groupTwo
            sampleStudents = Student.OrderByFirstName(sampleStudents);
            //Console.WriteLine();

            Student fourth = new Student("Dragan", "Draganov", 556206, "03980143", "dragan@mail.bg", marks1, 2);
            sampleStudents.Add(fourth);

            //extract the students from group two and order them by firstname:
            var ordered = sampleStudents.Where(group => group.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (var student in ordered)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", his group number --> " + student.GroupNumber);
            }

            Console.WriteLine(new string('-', 40));

            var abvmails = sampleStudents.Where(mail => mail.Email.EndsWith("@abv.bg"));

            foreach (var student in abvmails)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", his email --> " + student.Email );
            }

            Console.WriteLine(new string('-', 40));

            var sofiaPhones = sampleStudents.Where(phone => (phone.PhoneNumber[0] == '0' && phone.PhoneNumber[1] == '2'));

            foreach (var student in sofiaPhones)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + ", his phone number --> " + student.PhoneNumber);
            }


            var excelent = sampleStudents.Where(mark => Student.CheckForExcelentMarks(mark.Marks));

            Anonymous excelentStudent = new Anonymous();
            List<Anonymous> excelentStudents = new List<Anonymous>();

            foreach (var student in excelent)
            {
                excelentStudent = new Anonymous(student.FirstName, student.LastName, student.Marks);
                excelentStudents.Add(excelentStudent);
            }

            Console.WriteLine(new string('-', 40));

            foreach (var student in excelentStudents)
            {
                Console.WriteLine("This is one of our excelent students --> {0}", student.FullName);
            }

            var twoMarksStudents = sampleStudents.Where(mark => mark.Marks.Count == 2);

            Console.WriteLine(new string('-', 40));

            foreach (var student in twoMarksStudents)
            {
                Console.WriteLine("Student {0} has exactly {1} marks", student.FirstName + " " + student.LastName , student.Marks.Count);
            }

            var graduated06 = sampleStudents.Where(fn => (fn.FN % 10 == 6 && (fn.FN / 10) % 10 == 0));

            Console.WriteLine(new string('-', 40));

            foreach(var student in graduated06)
            {
                Console.WriteLine("Student {0} has a FN = {1}\nhis marks are:", student.LastName, student.FN);
                student.PrintMarks(student.Marks);
            }

            List<Student> listOfMathematicians = new List<Student>();


            // not with join -- TO DO -- fix
            var mathematicians = sampleStudents.Where(mat => mat.Group.DepartmentName.ToString() == "Mathematics");

            Console.WriteLine(new string('-', 40));

            foreach(var m in mathematicians)
            {
                Console.WriteLine("Student {0} in department {1}", m.LastName, m.Group.DepartmentName.ToString());
            }
        }
    }
}


 
