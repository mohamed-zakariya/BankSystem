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
                
            }
            finally
            {
                con.Close();
            }   
        }

        public bool createUser(string username, string password, string name, int age, string address, double balance, int account_lvl)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where username = @username", con);
                cmd.Parameters.AddWithValue("@username", username);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[1].ToString() == username)
                    {
                        return false;
                        break;
                    }
                }
                con.Close();
                
                cmd = new SqlCommand("INSERT INTO [dbo].[Table] (username, password, name, age, address, balance, sec_lvl, account_lvl) VALUES (@username, @password, @name, @age, @address, @balance, @sec_lvl, @account_lvl)", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@sec_lvl", 0);
                cmd.Parameters.AddWithValue("@account_lvl", account_lvl);
                
                con.Open();
                rd = cmd.ExecuteReader();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
            finally { con.Close(); }
            return false;

        }





    }
}
