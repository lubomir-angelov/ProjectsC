using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int bulls, cows;
            number = Console.ReadLine();
            bulls = int.Parse(Console.ReadLine());
            cows = int.Parse(Console.ReadLine());

            const char usedSecret = '*';
            const char usedGuess = '@';

            List<int> results = new List<int>();

            for (int num = 1000; num <= 9999; num++)
            {
                int countBulls = 0;
                int countCows = 0;
                char[] guessing = num.ToString().ToCharArray();

                char[] secret = number.ToCharArray();

                if (guessing[0] >= '1' && guessing[1] >= '1' && guessing[2] >= '1' && guessing[3] >= '1')
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (secret[i] == guessing[i])
                        {
                            countBulls++;
                            secret[i] = usedSecret;
                            guessing[i] = usedGuess;
                        }
                    }

                    for (int indexSecret = 0; indexSecret < 4; indexSecret++)
                    {
                        for (int indexGuess = 0; indexGuess < 4; indexGuess++)
                        {
                            if (secret[indexSecret] == guessing[indexGuess])
                            {
                                countCows++;
                                secret[indexSecret] = usedSecret;
                                guessing[indexGuess] = usedGuess;
                            }
                        }
                    }

                    if (countBulls == bulls && countCows == cows)
                    {
                        results.Add(num);
                    }
                }

            }

            if (results.Count == 0)
            {
                Console.WriteLine("No");
            }
            else 
            {
                for (int i = 0; i < results.Count; i++)
                {
                    Console.Write(results[i] + " ");
                }
            }
        }
    }
}
