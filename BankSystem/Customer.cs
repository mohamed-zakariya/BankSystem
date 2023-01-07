using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
     public class Customer : Person
    {
        
        int id1;


        public int Id1
        {
            get { return id1; }
            set
            {
                if (value > 0)
                {
                    id1 = value;
                }
            }
        }
        public Customer()
        {

        }
        public Customer(int Id_NN, string Name, string username, string password, int Age, string Address, int sec_lvl) : base( Id_NN,  Name,  username,  password,  Age,  Address,  sec_lvl)
        {
           Id = Id_NN;
        }

        //public abstract void Cash_withdrawal(CurrentAccount accountc);



    }
}
