using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    class Student : Human
    {
        private byte grade;

        public byte Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public Student()
        { }
        public Student(byte grade)
        {
            this.grade = grade;
        }
    }
}
