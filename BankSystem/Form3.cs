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

        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,int nTop, int nRight,int nBottom , int nWidthEllipse, int nHeightEllipse
        );
        
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
            deposite.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, deposite.Width,
           deposite.Height, 50, 50));
            loan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, loan.Width,
           loan.Height, 50, 50));
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
    }
}
