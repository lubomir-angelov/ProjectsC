using System;

    class MarketingFirmRecords
    {
        static void Main()
        {
            string FirstName = "Ivan", FamilyName ="Ivanov"; 
            int Age = 25, IdNumber = 5096; // for age and ID Number there is no range specified, so it is safe to use int
            uint UniqueEmployeeNumber = 27569999; //uint is better suited than long, because the used values are unsigned, int - will be overloaded 
            char Gender = 'm';

            Console.WriteLine("FirstName: {0}\nFamilyName: {1}\nAge: {2}\nID Number: {3}\nUnique Employee Number: {4}\nGender: {5}", FirstName, FamilyName, Age, IdNumber, UniqueEmployeeNumber, Gender);
        }
    }

