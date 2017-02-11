using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    abstract class Human
    {
        private string firstName = "Default";
        private string lastName = "Default";
        private Student student;
        private Worker worker;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public Student Student
        {
            get { return this.student; }
            set { this.student = value; }
        }
        public Worker Worker
        {
            get { return this.worker; }
            set { this.worker = value; }
        }


        public Human()
        { }
        public Human(string firstName, string lastName, string occupation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            switch (occupation)
            {
                case "Student": this.student = new Student(); break;
                case "Worker": this.worker = new Worker(); break;
                default: break;
            }
        }
    }
}
