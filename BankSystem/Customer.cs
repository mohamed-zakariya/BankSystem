using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    abstract internal class Customer : Person
    {
        public CurrentAccount accountc;


        public Customer()
        {

        }
        public Customer(string Name, int Id_NN, int Age, string Address, CurrentAccount accountc) : base(Name, Id_NN, Age, Address)
        {
            this.accountc = accountc;
        }

        //public abstract void Cash_withdrawal(CurrentAccount accountc);



    }
}
