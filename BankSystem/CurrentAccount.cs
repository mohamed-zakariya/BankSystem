using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class CurrentAccount : Account
    {
        public CurrentAccount() { }

        public CurrentAccount(Customer cust) : base(cust)
        {

        }

        public override double getBalance()
        {
            return Balance;
        }
    }
}
