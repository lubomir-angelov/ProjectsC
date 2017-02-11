using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Mortgage : Account, IDeposit
    {
        public override decimal CalculateInterestAmount(int period)
        {
            if (Customer is Individual)
            {
                if (period < 6)
                {
                    throw new ArgumentException("Your time period does not qualify for interest.");
                }
                return (period - 6) * InterestRate;
            }

            if (period < 12)
            {
                return (period) * InterestRate / 2;
            }

            return ((period - 12) * InterestRate + (12 * InterestRate / 2));
        }

        public void AddDeposit(decimal moneyToDeposit)
        {
            Balance += moneyToDeposit;
            Console.WriteLine("You have succesfully deposited this {0} amount.", moneyToDeposit);
        }

        public Mortgage(Customer customer, decimal interestRate, decimal balance)
        {
            Customer = customer;
            InterestRate = interestRate;
            Balance = balance;
        }
    }
}
