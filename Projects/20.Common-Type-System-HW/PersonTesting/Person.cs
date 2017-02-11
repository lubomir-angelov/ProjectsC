using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTesting
{
    class Person
    {
        private string name;
        private int age = int.MinValue;

        public string Name
        {
            get {return this.name;}
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person()
        { }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Name: ");
            result.Append(this.name + "\n");
            if(this.age != int.MinValue)
            {
                result.Append("Age: ");
                result.Append(age + "\n");
                return result.ToString();
            }
            result.Append("Age: unspecified\n");
            return result.ToString();
        }
    }
}
