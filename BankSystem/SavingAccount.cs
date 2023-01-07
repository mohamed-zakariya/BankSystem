using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class SavingAccount : Account
    {

        public float annualInterest = 0.4f;



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
