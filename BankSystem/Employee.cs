using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public  class Employee : Person
    {
        
        double salary;
       
        public double Salary
        {
            get
            {
                return salary;
            }
            set { if (value > 0) salary = value; }
        }
        public Employee()
        {

        }
        public Employee(int id, string Name, string username, string password, int Age, string Address, int sec_lvl) : base( id,  Name,  username,  password,  Age,  Address,  sec_lvl)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from [dbo].[Table] where username = @username and password = @password", con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.salary = Convert.ToDouble(dr.GetValue(6));
                    
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


    
        
    }
}
