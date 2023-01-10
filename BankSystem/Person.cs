using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Person
    {
        private int id;
        private string username;
        private string password;
        private string name;
        private int age;
        private string address;
        private int sec_lvl;
        private string phonenum;
        private string mail;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Age
        {
            get { return age; }

            set
            {
                if (value > 18)
                    age = value;
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Sec_lvl
        {
            get { return sec_lvl; }
            set { sec_lvl = value; }
        }
        public string Phonenum
        {
            get { return phonenum; }
            set { phonenum = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public Person()
        {

        }
        public Person(int Id_NN, string Name, string username, string password, int Age, string Address, int sec_lvl, string Phonenum, string Mail)
        {
            this.username = username;
            this.password = password;
            this.sec_lvl = sec_lvl;
            this.Name = Name;
            this.id = Id_NN;
            this.Age = Age;
            this.Address = Address;
            this.Mail = Mail;
            this.Phonenum = Phonenum;
        }

        public Person? loginCheck(string username, string password)
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
                    this.id = Convert.ToInt32(dr.GetValue(0));
                    this.username = dr.GetValue(1) + "";
                    this.password = dr.GetValue(2) + "";
                    this.name = dr.GetValue(3) + "";
                    this.age = Convert.ToInt32(dr.GetValue(4));
                    this.address = dr.GetValue(5) + "";
                    this.sec_lvl = Convert.ToInt32(dr.GetValue(7));

                    if (this.sec_lvl == 0)
                    {
                        return new Customer(this.id, this.name, this.username, this.password, this.age, this.address, this.sec_lvl, Convert.ToInt32(dr.GetValue(8)), this.phonenum, this.mail);
                    }
                    else
                    {
                        return new Employee(this.id, this.name, this.username, this.password, this.age, this.address, this.sec_lvl, this.phonenum, this.mail);
                    }
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
            return null;
        }



    }

}
