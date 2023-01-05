using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Employee : Person
    {
        int id;
        int salary;
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set { if (value > 0) salary = value; }
        }
        public Employee()
        {

        }
        public Employee(string Name, int Id_NN, int Age, string Address, int salary, int id) : base(Name, Id_NN, Age, Address)
        {
            Salary = salary;
            Id = id;

        }
    }
}
