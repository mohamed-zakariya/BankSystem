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
        public SavingAccount(int id, double balance, int password, float annualInterest) : base(id, balance, password)
        {

            this.annualInterest = annualInterest;
        }

        public double MonthlyInterest(double balance)
        {
            return balance += balance * (double)annualInterest / 12;
        }
        public decimal AnnualInterest(decimal balance)
        {
            return balance += balance * (decimal)annualInterest;
        }
    }
}
