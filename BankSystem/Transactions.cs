using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Transactions : CurrentAccount
    {

        double fee;
        double debt = 0;
        double assets;

        public Transactions()
        {

        }

        public Transactions(double fee, double assets, double debt, int id, double balance, int password) : base(id, balance, password)
        {
            this.fee = fee;
            this.debt = debt;
            this.assets = assets;
        }



        public void NormalDeposit(int balance1)
        {

            balance += balance1;
            balance -= fee;

        }
        public void VipDeposit(int balance1)
        {
            balance += balance1;

        }
        public void NormalWithdraw(int withdraw)
        {
            if (withdraw <= balance)
            {
                balance -= withdraw;
                balance -= fee;
            }
        }
        public void VipWithdraw(int withdraw)
        {
            if (withdraw <= balance)
            {
                balance -= withdraw;
            }
        }

        public void takeLoan(double loan)
        {
            if (loan < assets && debt == 0)
            {
                debt += loan;
            }
        }
    }
}
