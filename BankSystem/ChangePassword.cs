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
    public partial class ChangePassword : Form
    {
        Customer cust;
        User f3;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(User f3, Customer cust)
        {
            InitializeComponent();
            this.f3 = f3;
            this.cust = cust;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cust.changePassword(textBox1.Text, textBox2.Text))
                label3.Text = "Operation Done";
            else
                label3.Text = "your old Password is not correct";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
