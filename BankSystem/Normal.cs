using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Normal : Customer
    {
        public Normal()
        {

        }
        public Normal(string Name, int Id_NN, int Age, string Address, CurrentAccount accountc) : base(Name, Id_NN, Age, Address, accountc)
        {

        }
    }
}
