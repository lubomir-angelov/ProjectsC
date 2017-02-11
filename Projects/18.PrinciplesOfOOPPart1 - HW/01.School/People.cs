using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class People : Classes
    {
        private Student student;
        private Teachers teacher;

        public Student Student
        {
            get { return this.student; }
            set { this.student = value; }
        }
        public Teachers Teacher
        {
            get { return this.teacher; }
            set { this.teacher = value; }
        }

        public People()
        { 
        }
        public People(string name, string occupation)
        {
            switch (occupation)
            {
                case "Student": this.student = new Student(name, 0); break;
                case "Teacher": this.Teacher = new Teachers(name); break;
                default : break;
            }
        }

    }
}
