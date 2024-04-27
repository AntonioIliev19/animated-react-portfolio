using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CreditAccount : SavingsAccount
    {
        public CreditAccount(string name, decimal balance) : base(name, balance) 
        {

        }

        public override void GetCredit(decimal creditAmount, Customer obj)
        {
            decimal interestRate = (decimal)0.08;

            if (obj.IsBankClient)
            {
                interestRate = (decimal)0.05;
                if (obj.IsPensioner)
                {
                    interestRate = (decimal)0.03;
                }
            }

            decimal totalCreditAmount = creditAmount + creditAmount * interestRate;
            Console.WriteLine($"The credit amount is ${totalCreditAmount} and the person is {obj.FirstName}");

        }
    }
}
