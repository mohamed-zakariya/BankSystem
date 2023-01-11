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
    public partial class Deposit : Form
    {
        User f3;
        Account account;
        Customer cust;
        public Deposit()
        {
            InitializeComponent();
        }
        public Deposit(User f3, Customer cust, Account account)
        {
            InitializeComponent();
            this.f3 = f3;
            this.account = account;
            this.cust = cust;
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            if (cust.Account_lvl == 0)
            {
                Account account = new CurrentAccount(cust);
                label3.Text = account.Balance + "";
            }
            else
            {
                Account account = new SavingAccount(cust);
                label3.Text = account.Balance + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                if (cust.Account_lvl == 0)
                {
                    Account account = new CurrentAccount(cust);
                    double amount = Convert.ToDouble(textBox1.Text);

                    if (account.deposit(amount))
                    {
                        label3.Text = account.Balance.ToString();
                        label4.Text = "Operation Done";
                    }

                    else
                        label4.Text = "Enter valid amount";
                }
                else
                {
                    Account account = new SavingAccount(cust);
                    label3.Text = account.Balance + "";
                    double amount = Convert.ToDouble(textBox1.Text);

                    if (account.deposit(amount))
                    {
                        label3.Text = account.Balance.ToString();
                        label4.Text = "Operation Done";
                    }

                    else
                        label4.Text = "Enter valid amount";
                }
            }
            catch (Exception ex)
            {
                label4.Text = "Enter valid amount";
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
