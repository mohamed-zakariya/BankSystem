using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public abstract class Account
    {
        
        protected double balance;

        private Customer cust;
       
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
        
    }
}
