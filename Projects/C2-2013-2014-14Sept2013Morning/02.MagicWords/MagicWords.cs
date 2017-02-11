using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            //string[] reorderedWords = new string[words.Length];
            int maxLenght = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
                if (words[i].Length > maxLenght)
                    maxLenght = words[i].Length;
            }

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                int newIndex = currentWord.Length % (n + 1);
                words[i] = null;
                words.Insert(newIndex, currentWord);
                words.Remove(null);
            }

            int stringIndex = 0;
            StringBuilder result = new StringBuilder();
            while (stringIndex < maxLenght)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    string currentWord = words[i];
                    if (stringIndex < currentWord.Length)
                    {
                        result.Append(currentWord[stringIndex]);
                    }
                }

                stringIndex++;
            }

            Console.WriteLine(result);
        }
    }
}
