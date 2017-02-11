using System;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
//TO DO: extract all the methods into a c# library

public class BinToDec
{
    public static char[] baseChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static long FromAnyToLong(int fromBase, string number)
    {
        long result = 0;
        string s = ReverseString(number);

        for (int i = 0; i < s.Length; i++)
        {           
                switch (s[i])
                {
                    case 'A': result += 10 * (long)Math.Pow(fromBase, i); break;
                    case 'B': result += 11 * (long)Math.Pow(fromBase, i); break;
                    case 'C': result += 12 * (long)Math.Pow(fromBase, i); break;
                    case 'D': result += 13 * (long)Math.Pow(fromBase, i); break;
                    case 'E': result += 14 * (long)Math.Pow(fromBase, i); break;
                    case 'F': result += 15 * (long)Math.Pow(fromBase, i); break;
                    default: result += (long)(Char.GetNumericValue(s, i) * Math.Pow(fromBase, i)); break;
                }
        }

        return result;
    }


    public static string LongToString(long value, char[] baseChars)
    {
        string result = string.Empty;
        int targetBase = baseChars.Length;

        do
        {
            result = baseChars[value % targetBase] + result;
            value = value / targetBase;
        }
        while (value > 0);

        return result;
    }

    static void Main()
    {
        //get working data
        Console.WriteLine("Please input s");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input d");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the number you would like to convert");
        string number = Console.ReadLine();
  
        //process the data       
        long numberInDec = FromAnyToLong(s, number);
        char[] chosenBase = new char[d];
        Array.Copy(baseChars, chosenBase, d);
        string numberInChosenBase = LongToString(numberInDec, chosenBase);

        //write messages and result
        Console.WriteLine("This is the number in Dec --> {0}", numberInDec);
        Console.WriteLine("This is the number in chosen system ({0}) --> {1}", d, numberInChosenBase);
    }
}