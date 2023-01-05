using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    abstract internal class Person
    {
        private int id_NN;
        private string name;
        private int age;
        private string address;

        public int Id_NN
        {
            get { return id_NN; }
            set { id_NN = value; }
        }
        public int Age
        {
            get { return age; }

            set
            {
                if (value > 18)
                    age = value;
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person()
        {

        }
        public Person(string Name, int Id_NN, int Age, string Address)
        {
            this.Name = Name;
            this.Id_NN = Id_NN;
            this.Age = Age;
            this.Address = Address;
        }
    }
}
