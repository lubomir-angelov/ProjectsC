using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 *Override ToString() to display the information of a person and if age is not specified – to say so. 
 *Write a program to test this functionality.
*/

namespace PersonTesting
{
    class PersonTesting
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan");
            Person person2 = new Person("Petkan", 25);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
