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
    public partial class Withdraw : Form
    {
        User f3;
        Account account;
        Customer cust;
        public Withdraw()
        {
            InitializeComponent();
        }

        public Withdraw(User f3, Customer cust, Account account)
        {
            InitializeComponent();
            this.f3 = f3;
            this.account = account;
            this.cust = cust;
        }

        private void Form4_Load(object sender, EventArgs e)
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
                label5.Text = "";
                if (cust.Account_lvl == 0)
                {
                    Account account = new CurrentAccount(cust);
                    double amount = Convert.ToDouble(textBox1.Text);

                    if (account.withdraw(amount))
                    {
                        label3.Text = account.Balance.ToString();
                        label5.Text = "Operation Done";
                    }

                    else
                        label5.Text = "Enter valid amount";
                }
                else
                {
                    Account account = new SavingAccount(cust);
                    label3.Text = account.Balance + "";
                    double amount = Convert.ToDouble(textBox1.Text);

                    if (account.withdraw(amount))
                    {
                        label3.Text = account.Balance.ToString();
                        label5.Text = "Operation Done";
                    }

                    else
                        label5.Text = "Enter valid amount";
                }
            }catch(Exception ex)
            {
                label5.Text = "Enter valid amount";
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
