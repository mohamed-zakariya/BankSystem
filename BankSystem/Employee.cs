using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public class Employee : Person
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

        public Employee(int id, string Name, string username, string password, int Age, string Address, int sec_lvl, string Phonenum, string Mail) : base(id, Name, username, password, Age, Address, sec_lvl, Phonenum, Mail)
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

        public bool createUser(string username, string password, string name, int age, string address, double balance, int account_lvl, string phonenum, string mail)
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

                cmd = new SqlCommand("INSERT INTO [dbo].[Table] (username, password, name, age, address, balance, sec_lvl, account_lvl, phonenum, mail) VALUES (@username, @password, @name, @age, @address, @balance, @sec_lvl, @account_lvl,@phonenum,@mail)", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@sec_lvl", 0);
                cmd.Parameters.AddWithValue("@account_lvl", account_lvl);
                cmd.Parameters.AddWithValue("@phonenum", phonenum);
                cmd.Parameters.AddWithValue("@mail", mail);

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

        //update

        public void updateUser(string username, string address, int account_lvl, string phonenum, string mail)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Update [Table] set address=@address,account_lvl=@account_lvl,phonenum=@phonenum,mail=@mail where username=@username", con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@account_lvl", account_lvl);
            cmd.Parameters.AddWithValue("@phonenum", phonenum);
            cmd.Parameters.AddWithValue("@mail", mail);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("succfuly updated with new data");

        }


        //delte


        public void deleteUser(string username)
        {


            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete [Table] where  username=@username", con);

            //cmd.Parameters.AddWithValue("@Id",Id);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("succfuly deleted the account");

        }



        //show Data

        public Customer? showData(string username)
        {
            bool flag = false;
            int account_lvl = 0;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                if (username == null)
                    throw new Exception();

                SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where username = @username and sec_lvl = 0", con);
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[1].ToString() == username)
                    {
                        Id = Convert.ToInt32(dr.GetValue(0));
                        Username = dr.GetValue(1) + "";
                        Password = dr.GetValue(2) + "";
                        Name = dr.GetValue(3) + "";
                        Age = Convert.ToInt32(dr.GetValue(4));
                        Address = dr.GetValue(5) + "";
                        Sec_lvl = Convert.ToInt32(dr.GetValue(7));
                        account_lvl = Convert.ToInt32(dr.GetValue(8));
                        Phonenum = dr.GetValue(9) + "";
                        Mail = dr.GetValue(10) + "";

                        flag = true;
                    }
                }
                if (flag)
                {
                    return new Customer(Id, Name, Username, Password, Age, Address, Sec_lvl, account_lvl, Phonenum, Mail);
                }
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return null;
        }



    }
}
