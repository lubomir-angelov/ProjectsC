using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 05. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the 
elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
Implement methods for adding element, accessing element by index, removing element by index, inserting 
element at given position, clearing the list, finding element by its value and ToString(). Check all input 
parameters to avoid accessing elements at invalid positions. */

/*06. Implement auto-grow functionality: when the internal array is full, create a new array of double size and 
move all elements to it. */

/*07. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the 
GenericList<T>. You may need to add a generic constraints for the type T. */

namespace _05_07.GenericClass
{
    class GenericClass
    {
        static void Main(string[] args)
        {
            MyGenericList<int> MyList = new MyGenericList<int>(5);
            MyList.AddElement(4);
            MyList.AddElement(15);
            int test = MyList.AccesElementByIndex(1);
            Console.WriteLine(MyList);
            Console.WriteLine(test);
            MyList.FindElement(15);
            test = MyList.FindElement(99);
            MyList.ClearList();
            Console.WriteLine(MyList); 

            for (int i = 0; i < 7; i++)
            {
                MyList.AddElement(i);
            }

            Console.WriteLine(MyList);
            MyList.ClearList();
            MyList.AddElement(5);
            MyList.AddElement(1);


            int max = MyList.Max(MyList.AccesElementByIndex(0), MyList.AccesElementByIndex(1));
            int min = MyList.Min(MyList.AccesElementByIndex(0), MyList.AccesElementByIndex(1));

            Console.WriteLine("Max = {0}\nMin = {1}", max, min);
           // Console.WriteLine();
        }
    }
}
