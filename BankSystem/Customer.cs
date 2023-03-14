using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Customer : Person
    {

        int id1;

        int account_lvl;//cuurent account  or saving account 

        public int Account_lvl
        {
            get { return account_lvl; }
            set { account_lvl = value; }
        }
        public int Id1
        {
            get { return id1; }
            set
            {
                if (value >= 0)
                {
                    id1 = value;
                }
            }
        }
        public Customer()
        {

        }
        public Customer(int Id_NN, string Name, string username, string password, int Age, string Address, int sec_lvl, int account_lvl, string Phonenum, string Mail) : base(Id_NN, Name, username, password, Age, Address, sec_lvl, Phonenum, Mail)
        {
            Id1 = Id_NN;
            this.account_lvl = account_lvl;
        }

        public bool changePassword(string oldPassword, string newPassword)
        {
            bool flag = false;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (oldPassword == "" || oldPassword == newPassword || newPassword == "")
                    throw new Exception();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where id = " + this.Id1, con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd[2].ToString() == oldPassword)
                    {
                        //MessageBox.Show(rd[2].ToString() + " " + oldPassword);
                        flag = true;
                        break;
                    }
                }
                con.Close();
                if (flag)
                {
                    //MessageBox.Show(newPassword + " " + this.Username);
                    cmd = new SqlCommand("update [dbo].[Table] set password = @password where id = " + this.Id1, con);

                    cmd.Parameters.AddWithValue("@password", newPassword);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return false;
        }




    }
}
