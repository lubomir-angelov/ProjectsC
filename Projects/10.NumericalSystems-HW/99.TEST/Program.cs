





using System;


//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
//TO DO: extract all the methods into a c# library
    class AnyNumeralSystem
    {
        public static char[] baseChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static long BinToDec(string binNumber)
        {
            long decimalNumber = 0;
            string s = ReverseString(binNumber);
            
            for(int i = 0; i < s.Length; i ++)
            {
                if (s[i] != '0')
                {
                    decimalNumber += (long)(Char.GetNumericValue(s, i) * Math.Pow(2, i));
                }

            }

            return decimalNumber;
        }

        public static long TernToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(3, i));
                }

            }

            return result;
        }

        public static long QuatToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(4, i));
                }

            }

            return result;
        }

        public static long FiveToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(5, i));
                }

            }

            return result;
        }

        public static long SixToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(6, i));
                }

            }

            return result;
        }

        public static long SevenToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(7, i));
                }

            }

            return result;
        }

        public static long EightToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(8, i));
                }

            }

            return result;
        }

        public static long NineToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(9, i));
                }

            }

            return result;
        }

        public static long ElevenToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    result += 10 * (long) Math.Pow(11, i);
                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long TwelveToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A' || s[i] == 'B')
                {
                    switch(s[i])
                    {
                        case 'A': result += 10 * (long)Math.Pow(11, i); break;
                        case 'B': result += 11 * (long)Math.Pow(11, i); break;
                        default: break;
                    }
                    
                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long ThirtToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' || s[i] <= 'C')
                {
                    switch (s[i])
                    {
                        case 'A': result += 10 * (long)Math.Pow(11, i); break;
                        case 'B': result += 11 * (long)Math.Pow(11, i); break;
                        case 'C': result += 12 * (long)Math.Pow(11, i); break;
                        default: break;
                    }

                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long FourtToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' || s[i] <= 'D')
                {
                    switch (s[i])
                    {
                        case 'A': result += 10 * (long)Math.Pow(11, i); break;
                        case 'B': result += 11 * (long)Math.Pow(11, i); break;
                        case 'C': result += 12 * (long)Math.Pow(11, i); break;
                        case 'D': result += 13 * (long)Math.Pow(11, i); break;
                        default: break;
                    }

                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long FiftToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' || s[i] <= 'E')
                {
                    switch (s[i])
                    {
                        case 'A': result += 10 * (long)Math.Pow(11, i); break;
                        case 'B': result += 11 * (long)Math.Pow(11, i); break;
                        case 'C': result += 12 * (long)Math.Pow(11, i); break;
                        case 'D': result += 13 * (long)Math.Pow(11, i); break;
                        case 'E': result += 14 * (long)Math.Pow(11, i); break;
                        default: break;
                    }

                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long HexToDec(string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' || s[i] <= 'F')
                {
                    switch (s[i])
                    {
                        case 'A': result += 10 * (long)Math.Pow(11, i); break;
                        case 'B': result += 11 * (long)Math.Pow(11, i); break;
                        case 'C': result += 12 * (long)Math.Pow(11, i); break;
                        case 'D': result += 13 * (long)Math.Pow(11, i); break;
                        case 'E': result += 14 * (long)Math.Pow(11, i); break;
                        case 'F': result += 15 * (long)Math.Pow(11, i); break;
                        default: break;
                    }

                }
                else
                {
                    result += (long)(Char.GetNumericValue(s, i) * Math.Pow(11, i));
                }

            }

            return result;
        }

        public static long StringToLong(int numberBase, string number)
        {
            switch (numberBase)
            {
                case 2: return BinToDec(number);
                case 3: return TernToDec(number);
                case 4: return QuatToDec(number);
                case 5: return FiveToDec(number);
                case 6: return SixToDec(number);
                case 7: return SevenToDec(number);
                case 8: return EightToDec(number);
                case 9: return NineToDec(number);
                case 11: return ElevenToDec(number);
                case 12: return TwelveToDec(number);
                case 13: return ThirtToDec(number);
                case 14: return FourtToDec(number);
                case 15: return FiftToDec(number);
                case 16: return HexToDec(number);
                default: long ourResult = Convert.ToInt64(number, 10); return ourResult;
            }
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
            long numberInDec = StringToLong(s, number);
            char[] chosenBaseChars = new char[d];
            Array.Copy(baseChars, chosenBaseChars, d);

            string NumberInChosenBase = LongToString(numberInDec, chosenBaseChars);

            //write messages and result
            Console.WriteLine("This is the number in Dec {0}", numberInDec);
            Console.WriteLine("This is the number in {0} --> {1}", d, NumberInChosenBase);
           
        }
    }


