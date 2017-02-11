using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Student : People
    {
        private string name = "Default";
        private byte classNumber = 0;
        private string textBlock = "Default";

        public string TextBlock
        {
            get { return this.textBlock; }
            set { this.textBlock = value; }
        }
        public string Name
        { get { return this.name; } }
        public byte ClassNumber
        { get { return this.classNumber; } }

        public Student()
        {
        }
        public Student(string name, byte classNumber)
        {
            this.name = name;
            this.classNumber = classNumber;
        }

    }
}
