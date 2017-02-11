
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.


namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static string Encode(string toBeEncoded, string key)
        {
            char[] toCharArr = toBeEncoded.ToCharArray();
            char[] result = new char[toCharArr.Length];

            for (int indexKey = 0, indexArr = 0; indexArr < toCharArr.Length; indexArr++, indexKey++)
            {
                if (indexKey > key.Length - 1)
                {
                    indexKey = 0;
                }

                result[indexArr] = (char)(toCharArr[indexArr] ^ key[indexKey]);
            }

            return new string(result);
        }

        static string Decode(string encoded, string key)
        {
            char[] toCharArr = encoded.ToCharArray();
            char[] result = new char[encoded.Length];

            for (int indexEncoded = 0, indexKey = 0; indexEncoded < encoded.Length; indexEncoded++, indexKey++)
            {
                if (indexKey > key.Length - 1)
                {
                    indexKey = 0;
                }

                result[indexEncoded] = (char) (encoded[indexEncoded] ^ key[indexKey]);
            }

            return new string (result);
        }

        static void Main(string[] args)
        {
            string key = "primaballerina";
            string text = "Encode me NOW";
            string textEncoded = Encode(text, key);
            string textDecoded = Decode(textEncoded, key);

            Console.WriteLine("This is the encoded text --> {0}", textEncoded);
            Console.WriteLine("This is the original text --> {0}\nAnd this is the decoded text --> {1}", text, textDecoded);
        }
    }
}
