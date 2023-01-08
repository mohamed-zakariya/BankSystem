using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public abstract class Account
    {
        
        protected double balance;
        private int account_lvl2;
        private Customer cust;

        public Customer Cust
        {
            get { return cust; }
            set { cust = value; }
        }
        public int Account_lvl2
        {
            get { return account_lvl2; }
            set { account_lvl2 = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(Customer cust)
        {
            this.cust = cust;
            account_lvl2 = cust.Account_lvl;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from [dbo].[Table] where id = @Id", con);

                cmd.Parameters.AddWithValue("@Id", cust.Id1);
               
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.balance = Convert.ToDouble(dr.GetValue(6));
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        public abstract double getBalance();

        public abstract bool withdraw(double amount);

        public abstract bool deposit(double amount); 

        public abstract bool transfer(double amount, string username);
        
    }
}
