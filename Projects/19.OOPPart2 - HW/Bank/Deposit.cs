using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit : Account, IDeposit, IDraw
    {
        public override decimal CalculateInterestAmount(int period)
        {
            if (Balance < 1000 && Balance > 0)
            {
                Console.WriteLine("Your deposit account balance does not meet the requirments for an interest (>1000)");
                return 0;
            }

            return period * InterestRate * Balance; //your interest over the money
        }

        public void AddDeposit(decimal moneyToDeposit)
        {
            Balance += moneyToDeposit;
            Console.WriteLine("You have succesfully deposited this {0} amount.", moneyToDeposit);
        }

        public void Draw(decimal moneyToDraw)
        {
            if(Balance - moneyToDraw < 0)
            {
                Console.WriteLine("Your balance will become negative.");
            }

            Balance -= moneyToDraw;
            Console.WriteLine("You have succesfully withdrawn this {0} amount.", moneyToDraw);
        }

        public Deposit(Customer customer, decimal interestRate, decimal balance)
        {
            Customer = customer;
            InterestRate = interestRate;
            Balance = balance;
        }
    }
}
