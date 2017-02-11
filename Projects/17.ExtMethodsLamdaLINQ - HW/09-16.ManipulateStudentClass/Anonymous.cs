using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.ManipulateStudentClass
{
    class Anonymous
    {
        private string fullName = "Default";
        private List<int> marks = new List<int>();
        //private List<Anonymous> listOfExcelentStudents = new List<Anonymous>();

        public string FullName
        {
            get { return this.fullName; }
        }
        public List<int> Marks
        {
            get {return this.marks;}
        }
        /*public List<Anonymous> ListOfExcelentStudnets
        {
            get {return this.listOfExcelentStudents;}
            set {this.listOfExcelentStudents = value;}
        }*/

        public Anonymous()
        {
        }
        public Anonymous(string firstName, string lastName, List<int> marks)
        {
            this.fullName = firstName + " " + lastName;
            this.marks = marks;
        }


    }
}
