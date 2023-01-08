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
    public partial class Transfer : Form
    {
        User f3;
        Account account;
        Customer cust;
        public Transfer()
        {
            InitializeComponent();
        }
        public Transfer(User f3, Customer cust, Account account) 
        {
            InitializeComponent();
            this.f3 = f3;
            this.account = account;
            this.cust = cust;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "";
                if (cust.Account_lvl == 0)
                {
                    Account account = new CurrentAccount(cust);
                    double amount = Convert.ToDouble(textBox2.Text);

                    if (account.transfer(amount, textBox1.Text))
                    {
                        label4.Text = account.Balance.ToString();
                        label5.Text = "Operation Done";
                    }

                    else
                        label5.Text = "Enter Valid Data";
                }
                else
                {
                    Account account = new SavingAccount(cust);
                    label4.Text = account.Balance + "";
                    double amount = Convert.ToDouble(textBox2.Text);

                    if (account.transfer(amount, textBox1.Text))
                    {
                        label4.Text = account.Balance.ToString();
                        label5.Text = "Operation Done";
                    }

                    else
                        label5.Text = "Enter Valid Data";
                }
            }
            catch (Exception ex)
            {
                label5.Text = "Enter Valid Data";
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            if (cust.Account_lvl == 0)
            {
                Account account = new CurrentAccount(cust);
                label4.Text = account.Balance + "";
            }
            else
            {
                Account account = new SavingAccount(cust);
                label4.Text = account.Balance + "";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.Show();
        }
    }
}
