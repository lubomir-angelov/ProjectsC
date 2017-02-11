using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TO DO finish - this is not complete nor does it compile properly

namespace _05._64BitValues
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 fArray = new BitArray64();
            BitArray64 sArray = new BitArray64();
            fArray.Add(1);
            sArray.Add(2);

            int fHash = fArray.GetHashCode();
            int sHash = sArray.GetHashCode();

            Console.WriteLine("Hashes 1 - {0} --- 2 - {1}", fHash, sHash);
        }
    }
}
