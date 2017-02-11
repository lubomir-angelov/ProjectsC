   /*     string str = Convert.ToString(number, 2).PadLeft(32, '0');
        char[] array = new char[str.Length];
        Console.WriteLine("Before : {0}",str);
 
        if((isNum && isP && isQ && isK) && (p<q && (k+q)<=32)){
        for (int i = 0; i < str.Length; i++)
        {
            array[i] = str[i];
        }
 
        for (int i = 0; i < k; i++)
        {
            char t = array[str.Length-q];
            array[str.Length - q] = array[str.Length - p];
            array[str.Length - p] = t;
            q++;
            p++;
        }
        Console.Write("After :  ");
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
        } */