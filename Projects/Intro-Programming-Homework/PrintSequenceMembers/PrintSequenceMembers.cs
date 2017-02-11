using System;

    class PrintSequenceMembers
    {
        static void Main()
        {
            int [] a = new int[12];
                for (int i = 1; i < 12; i++)
                {
                    a[i]=i;
                    if(i%2!=0) 
                    {
                        a[i]=i*-1;
                    }

                }
                for (int i = 2; i < 12; i++)
                    Console.WriteLine(a[i]);
        }
    }

