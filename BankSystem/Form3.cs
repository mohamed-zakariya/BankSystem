using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class User : Form
    {
        private Customer cust;
        Account account;
        Form1 f1;
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,int nTop, int nRight,int nBottom , int nWidthEllipse, int nHeightEllipse
        );
        
        public User()
        {
            InitializeComponent();
        }
        public User(Form1 f1,Customer cust)
        {
            InitializeComponent();
            this.cust = cust;
            this.f1 = f1;
            
        }

        private void User_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text +=  ", " +cust.Name;
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            checkBalance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, checkBalance.Width,
             checkBalance.Height, 50, 50));
            transfer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, transfer.Width,
             transfer.Height, 50, 50));
            withdraw.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, withdraw.Width,
           withdraw.Height, 50, 50));
            deposit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deposit.Width,
           deposit.Height, 50, 50));
            ShowTransactions.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ShowTransactions.Width,
           ShowTransactions.Height, 50, 50));
            ChangePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ChangePassword.Width,
            ChangePassword.Height, 50, 50));
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            if(cust.Account_lvl == 0)
            {
                Account account = new CurrentAccount(cust);
                MessageBox.Show(Convert.ToString(account.getBalance()));
            }
            else
            {
                Account account = new SavingAccount(cust);
                MessageBox.Show(Convert.ToString(account.getBalance()));
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw f4 = new Withdraw(this, cust, account);
            f4.Show();
            this.Hide();
        }

        private void deposite_Click(object sender, EventArgs e)
        {
            Deposit f5 = new Deposit(this, cust, account);
            f5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            Transfer f6 = new Transfer(this, cust, account);
            f6.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword f7 = new ChangePassword(this, cust);
            f7.Show();
            this.Hide();
        }

        private void ShowTransactions_Click(object sender, EventArgs e)
        {
            ShowTransactionscs f8 = new ShowTransactionscs(this, cust, account);
            f8.Show();
            this.Hide();
        }
    }
}
