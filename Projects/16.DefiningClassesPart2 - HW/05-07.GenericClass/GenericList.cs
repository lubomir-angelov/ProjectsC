using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_07.GenericClass
{
    class MyGenericList<T>
        where T: IComparable<T>, new()
    {
        //private static int arrayCapacity;
        private T[] array;
        private int elementCounter = 0;

        public MyGenericList(int arrayCapacity)
        {
            array = new T[arrayCapacity];
        }

        public void AddElement(T elementToAdd)
        {
            if (elementCounter >= array.Length)
            {
                if (elementCounter == 0)
                    elementCounter = 1;
                AutoGrow();
            }
            
            array[elementCounter] = elementToAdd;
            elementCounter++;
        }

        public T AccesElementByIndex(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range of the list of elemnts.");               
            }

            return array[index];
        }

        public void RemoveElementByIndex(int index)
        {
            if (index <= 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range of the list of elements.");
            }

            //determine whether the type of the element is nullabale -- not needed, use default keyword
           /* Type t = array[index].GetType();
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                array[index] = null;
            } */

            array[index] = default(T);
            T[] tempArr = new T[elementCounter - 1];
            int tempIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    tempArr[tempIndex] = array[i];
                    tempIndex++;
                }
            }

            elementCounter = tempIndex;
            array = new T[elementCounter];
            Array.Copy(tempArr, array, tempArr.Length);
        }

        public void InsertAtIndex(int index, T elementToInsert)
        {
            if (elementCounter + 1 > array.Length)
            {
                AutoGrow();
            }

            T[] tempArray = new T[elementCounter + 1];
            tempArray[index] = elementToInsert;
            for (int i = 0; i < index; i++)
            {
                tempArray[i] = array[i];
            }
            for (int i = index + 1; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i - 1];
            }

            elementCounter = elementCounter + 1;
            array = new T[elementCounter];
            Array.Copy(tempArray, array, tempArray.Length);
        }

        public void AutoGrow()
        {
            T[] newArray = new T[elementCounter * 2];
            for (int i = 0; i < elementCounter; i++)
            {
                newArray[i] = array[i];
            }
            array = new T[newArray.Length];
            Array.Copy(newArray, array, newArray.Length);
        }


        //this class will return -1 if there is no such elemement
        public T FindElement(T elementToFind)
        {
            T element = new T();
            for (int i = 0; i < array.Length; i++)
            {
                if(elementToFind.Equals(array[i]))
                {
                    element = elementToFind;
                }
            }

            T checkElement = default(T);
            if (!element.Equals(checkElement))
                return element;
            else
            {
                element = (dynamic)(-1);    
            }

            return element;
        }
        public void ClearList()
        {
            elementCounter = 0;
            array = new T[1];
        }

        public override string ToString()
        {
            string result = null;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
                result += '\n';
            }

            return result;
        }

        public T Min<T>(T t1, T t2)
            where T : IComparable<T>
        {
            if (t1.CompareTo(t2) <= 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }

        public T Max<T>(T t1, T t2)
            where T : IComparable<T>
        {
            if (t1.CompareTo(t2) > 0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }


    }
}





/*public static T Min<T>(T first, T second)

 where T : IComparable<T>

{

 

} */