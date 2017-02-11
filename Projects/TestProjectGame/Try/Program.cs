using System;
using System.Text;
// Remark - Used the idea for two consecutively printed strigns from: 
// http://forums.academy.telerik.com/87367/c%23-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-primitive-data-types-and-variables-1-14-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B8
// I tried with only one string, could not figure out how to assign the correct value
class CopyrightSymbolTriangle
{
    static int Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        //  1 possible "easy" way to print if we are using predefined values (in this case 9 symbols)
        //  char Symbol = '\u00A9';                   
        //  Console.WriteLine("  {0}", Symbol);
        //  Console.WriteLine(" {0}{0}{0}", Symbol);
        //  Console.WriteLine("{0}{0}{0}{0}{0}", Symbol);                     

   //     Console.WriteLine("Please input a symbol you would like to use:");
   //     char Symbol = char.Parse(Console.ReadLine());

   //     Console.WriteLine("Please input number of {0} you would like to use to create an isosceles triangle:", Symbol);
        int NumberOfSymbols = int.Parse(Console.ReadLine());

        if (Math.Sqrt(NumberOfSymbols) != (int)Math.Sqrt(NumberOfSymbols))   //  - check for correct input 
        {
            Console.WriteLine("Cannot create an isosceles triangle with that number of symbols!"); return 0;
        }

        int rows = (int)Math.Sqrt(NumberOfSymbols);
        int NumberOfIntervalsPerRow = rows - 1;
        int NumberOfSymbolsPerRow = 1;

        for (int i = 1; i <= rows; i++)
        {
            string blankstring = new String(' ', NumberOfIntervalsPerRow);
            string symbolstring = new String(Symbol, NumberOfSymbolsPerRow);

            Console.WriteLine("{0}{1}", blankstring, symbolstring);

            NumberOfIntervalsPerRow--;
            NumberOfSymbolsPerRow += 2;
        }
        return 0;
    }
}

