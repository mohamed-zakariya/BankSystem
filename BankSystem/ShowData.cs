using System;
using System.CodeDom;
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
    public partial class ShowData : Form
    {
        Employee emp;
        Customer cust;
        Account account;
        Admin f2;
        public ShowData()
        {
            InitializeComponent();
        }

        public ShowData(Admin f2, Employee emp)
        {
            InitializeComponent();
            this.f2 = f2;
            this.emp = emp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";
            label7.Text = "";
            label10.Text = "";
            label11.Text = "";
            label14.Text = "";
            label15.Text = "";

            cust = emp.showData(textBox1.Text);
            
           
            if(cust != null)
            {
                if (cust.Account_lvl == 0)
                {
                    account = new CurrentAccount(cust);
                }
                if (cust.Account_lvl == 1)
                {
                    account = new SavingAccount(cust);
                }

                label3.Text = cust.Name;
                label4.Text = cust.Age.ToString();
                label6.Text = cust.Address;
                label7.Text = (account.getBalance()).ToString();
                label10.Text = (cust.Account_lvl == 0)? "Current Account" : "Saving Account";
                label11.Text = cust.Phonenum.ToString();
                label14.Text = cust.Mail;

            }
            else
            {
                label15.Text = "User not found";
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
