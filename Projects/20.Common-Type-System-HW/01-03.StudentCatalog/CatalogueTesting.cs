using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1.Define a class Student, which contains data about a student – first, middle and last name, SSN, 
 * permanent address, mobile phone, e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, 
 * universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() 
 * and operators == and !=. 
 * 2.Add implementations of the ICloneable interface. The Clone() method should deeply copy 
 * all object's fields into a new object of type Student.
 * 3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
 * and by social security number (as second criteria, in increasing order).
*/

namespace _01_03.StudentCatalog
{
    class CatalogueTesting
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan", "Ivanov", "Ivanov", 5599, "Ivan Vazov 1 str, bl. 1, app. 3", "0889883447", "ivan@mail.bg", 2, 0, 1, 1);
            Student secondSt = new Student("Dragan", "Petkanov", "Draganov", 4422, "Vasil levski bl. N13, bl. 2, app 17", "0895758576", "draganov@abv.bg", 2, 1, 1, 1);

            Console.WriteLine(student);

            Object obj = secondSt as object;
            if(student.Equals(obj))
                Console.WriteLine("They are equal");

            //check if Equal() objects return tha same hashcode and viseversa
            int firstHash = student.GetHashCode();
            int secondHash = secondSt.GetHashCode();
            Console.WriteLine("{0} --- {1}", firstHash, secondHash);

            if(student == secondSt)
                Console.WriteLine("Hurray");
            if(student != secondSt)
                Console.WriteLine("Yupi");

            Student copiedStudent = (Student) student.Clone();
            //we can just rework the clone method to return a value of type student, but when changing the return type you get a CLR Interface not implemented exception, because the return type has been changed
            if(copiedStudent == student)
                Console.WriteLine("Deep copy succsessfull!?");
            if(copiedStudent.Equals(student))
                Console.WriteLine("It must be succsessfull.");

            //CompareTo info http://msdn.microsoft.com/en-us/library/system.icomparable.compareto%28v=vs.110%29.aspx
            int comparisonValue = 0;
            comparisonValue = secondSt.CompareTo(student);
            Console.WriteLine("Result of comparison = {0}", comparisonValue);
            comparisonValue = student.CompareTo(copiedStudent);
            Console.WriteLine("Result of copied students comparison = {0}", comparisonValue);
        }
    }
}
