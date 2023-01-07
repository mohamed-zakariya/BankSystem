using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class User : Form
    {
        private Customer cust;
        public User()
        {
            InitializeComponent();
        }
        public User(Customer cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        private void User_Load(object sender, EventArgs e)
        {
            label1.Text +=   " " + cust.Name;

        }
    }
}
