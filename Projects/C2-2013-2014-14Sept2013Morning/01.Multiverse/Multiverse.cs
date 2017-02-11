using System;

namespace _01.Multiverse
{
    class Multiverse
    {
        static void Main(string[] args)
        {
            long result = 0;
            string text = Console.ReadLine();
            string[] dictionary = {"CHU", "TEL", "OFT", "IVA",
                                 "EMY", "VNB", "POQ", "ERI",
                                 "CAD", "K-A", "IIA", "YLO", "PLA"};

            int numberOfDigits = text.Length / 3 - 1;
            int countDigits = numberOfDigits;

                for (int i = 0; i <= text.Length - 3; i += 3)
                {
                    string currentDigit = text.Substring(i, 3);
                    int multiplier = 0;
                    for (int j = 0; j < dictionary.Length; j++)
                    {
                        if (currentDigit == dictionary[j])
                        {
                            multiplier = j;
                            break;
                        }
                    }

                    result += multiplier*(long)Math.Pow(13, countDigits);
                    countDigits--;
                }

                Console.WriteLine(result);
        }
    }
}
