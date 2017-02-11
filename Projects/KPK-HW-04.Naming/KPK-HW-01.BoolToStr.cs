class InputOutput
{
    const int max_count = 6;

    class Printing
    {
        void print(bool toConv)
        {
            string print = toConv.ToString();
            Console.WriteLine(print);
        }
    }

    public static void input()
    {
        InputOutput.Printing callPrint = new InputOutput.Printing();
        callPrint.print(true);
    }
}

