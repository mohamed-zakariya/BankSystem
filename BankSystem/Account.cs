using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    abstract internal class Account
    {
        protected int id;
        int password;
        protected double balance;

        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public Account()
        {

        }
        public Account(int id, double balance, int password)
        {
            this.id = id;
            Password = password;
            this.balance = balance;

        }
    }
}
