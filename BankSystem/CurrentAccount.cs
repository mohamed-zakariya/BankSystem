using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CurrentAccount : Account
    {
        public CurrentAccount() { }

        public CurrentAccount(int id, double balance, int password) : base(id, balance, password)
        {

        }

        public void displayBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
