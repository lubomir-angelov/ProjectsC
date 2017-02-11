using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan : Account, IDeposit
    {
        public override decimal CalculateInterestAmount(int period)
        {
            if (Customer is Individual)
            {
                if(period < 3)
                {
                    throw new ArgumentException("Your time period does not qualify for interest.");
                }
                return (period - 3) * InterestRate;
            }

            if(period < 2)
                {
                    throw new ArgumentException("Your time period does not qualify for interest.");
                }

            return (period - 2) * InterestRate;
        }

        public void AddDeposit(decimal moneyToDeposit)
        {
            Balance += moneyToDeposit;
            Console.WriteLine("You have succesfully deposited this {0} amount.", moneyToDeposit);
        }

        public Loan(Customer customer, decimal interestRate, decimal balance)
        {
            Customer = customer;
            InterestRate = interestRate;
            Balance = balance;
        }
    }
}
