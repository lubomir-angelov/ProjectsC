using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2. Implement a set of extension methods for 
IEnumerable<T> that implement the following 
group functions: sum, product, min, max, average. */

namespace _02.IEnumberableExtensions
{
    static class IEnumberableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> someArray)
        {
            dynamic sum = 0;
            foreach (T element in someArray)
            {
                sum += element;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> someArray)
        {
            dynamic product = 1;
            foreach (T element in someArray)
            {
                product *= element;

                if (product == 0)
                    break;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> someArray)
        {
            dynamic min = someArray.ElementAt(0);

            foreach (T element in someArray)
            {
                if (min.CompareTo(element) > 0)
                    min = element;
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> someArray)
        {
            dynamic max = someArray.ElementAt(0);

            foreach (T element in someArray)
            {
                if (max.CompareTo(element) <= 0)
                    max = element;
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> someArray)
        {
            dynamic average = default(T);
            dynamic count = 0;

            foreach(T element in someArray)
            {
                count++;
            }

            average = someArray.Sum() / count;

            return average;
        }

        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(13);
            myList.Add(-5);

            int sum = myList.Sum();
            Console.WriteLine(sum);
            int max = myList.Max();
            Console.WriteLine(max);
            int min = myList.Min();
            Console.WriteLine(min);
            int product = myList.Product();
            Console.WriteLine(product);
            int average = myList.Average();
            Console.WriteLine(average);
        }
    }
}
