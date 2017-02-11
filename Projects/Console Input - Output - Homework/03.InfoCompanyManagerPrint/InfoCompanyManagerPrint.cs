//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
//age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class InfoCompanyManagerPrint
    {
        static void Main()
        {
            Console.WriteLine("Please input company name:");
            string companyName = (Console.ReadLine());
            Console.WriteLine("Please input company address:");
            string address = Console.ReadLine();
            Console.WriteLine("Please input company phone number:");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input company fax number:");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input manager first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please input manager last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please input manager age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input manager phone number");
            int managerPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The company's Info is:\n{0},\n{1},\n{2},\n{3}", companyName, address, companyPhoneNumber, faxNumber);
            Console.WriteLine("The manager's Info is:\n{0},\n{1},\n{2},\n{3}", firstName, lastName, age, managerPhoneNumber);
        }
    }

