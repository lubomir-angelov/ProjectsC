using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 2.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
 * Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based). 
 * Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as 
 * follows: number_of_months * interest_rate. Loan accounts have no interest for the first 3 months if are held by individuals 
 * and for the first 2 months if are held by a company. Deposit accounts have no interest if their balance is positive and 
 * less than 1000. Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 
 * 6 months for individuals. Your task is to write a program to model the bank system by classes and interfaces. 
 * You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of 
 * the interest functionality through overridden methods.
 */
namespace Bank
{
    public class Bank
    {
        static void Main(string[] args)
        {
            Deposit individualDeposit = new Deposit (new Individual("Ivan Ivanov"), 0.05m, 1000m);
            Account individualLoan = new Loan(new Individual("Petkan Draganov"), 0.03m, 2000m);
            Account companyDeposit = new Deposit (new Company("GreTech"), 0.08m, 10000m);

            decimal result = 0;
            result = individualDeposit.CalculateInterestAmount(10);

            Console.WriteLine(result);

            individualDeposit.Draw(10);
            individualDeposit.AddDeposit(1000);

            result = individualDeposit.CalculateInterestAmount(10);
            Console.WriteLine(result);
        }
    }
}
