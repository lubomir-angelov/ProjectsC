using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
//TO DO finish - this is not complete nor does it compile properly

namespace _05._64BitValues
{
    public class BitArray64 : IEnumerable<int>//, IComparable<BitArray64>
    {
        ulong[] values;
        private ulong index;

        public ulong[] Values
        {
            get { return this.values; }
            set { this.values = value; }
        }
        public ulong Index
        {
            get { return this.index; }
            private set { this.index = value; }
        }

        public BitArray64()
        {
            this.values = new ulong[64];
        }
        /*public BitArray64(uint wholeBit)
        {
            this.values = new ulong[length];
        } */
        public void Add(ulong wholeBit)
        {
            for (int i = 0; i < (int)(wholeBit / 64); i++)
            {
                this.values[this.index] = wholeBit % 10;
                wholeBit /= 10;
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            foreach(int element in this.values)
            {
                if (element == null)
                {
                    break;
                }

                yield return element;
            }
             
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            BitArray64 array = obj as BitArray64;
            if ((System.Object)array == null)
            {
                return false;
            }

            return this.values == obj;
        }
        public bool Equals(BitArray64 array)
        {
            if ((object)array == null)
            {
                return false;
            }

            return (object)this.values == array;
        }
        public override int GetHashCode()
        {
            int hashcode = 33;
            return (int)((uint)hashcode % (uint)values.Length);
        }
    }
}
