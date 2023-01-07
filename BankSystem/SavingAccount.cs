using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SavingAccount : Account
    {

        public float annualInterest;



        public SavingAccount()
        {

        }
        public SavingAccount(Customer cust) : base(cust)
        {

            
        }

        public override double getBalance()
        {
            return balance += balance * (double)annualInterest / 12;
        }
       
    }
}
