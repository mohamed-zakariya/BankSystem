using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class CurrentAccount : Account
    {
        private float fee = 0.01f;
        public CurrentAccount() { }

        public CurrentAccount(Customer cust) : base(cust)
        {

        }

        public override double getBalance()
        {
            return Balance;
        }

        public override bool withdraw(double amount)
        {   
          
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if (amount > this.Balance || amount < 0)
                    throw new Exception();
                this.Balance -= amount;
               
                SqlCommand cmd = new SqlCommand("update [dbo].[Table] set balance = @newbalance where id = " + this.Cust.Id1, con);

                cmd.Parameters.AddWithValue("@newbalance", this.Balance);
              

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                con.Close();
                cmd = new SqlCommand("INSERT INTO [dbo].[Transaction](id, operation, balance, amount,date) VALUES ( " + this.Cust.Id1 + ", @operation, @balance,@amount,@date)" , con);
                
                cmd.Parameters.AddWithValue("@operation", "Withdraw");
                cmd.Parameters.AddWithValue("@balance", this.Balance);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());

                con.Open();
                dr = cmd.ExecuteReader();

                return true;

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
        public override bool deposit(double amount)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {

                if (amount < 0)
                {
                    throw new Exception();
                }
                this.Balance += amount;

                SqlCommand cmd = new SqlCommand("update [dbo].[Table] set balance = @newbalance where id =" + this.Cust.Id1, con);

                cmd.Parameters.AddWithValue("@newbalance", this.Balance);



                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                con.Close();
                cmd = new SqlCommand("INSERT INTO [dbo].[Transaction](id, operation, balance, amount,date) VALUES ( " + this.Cust.Id1 + ", @operation, @balance,@amount,@date)", con);

                cmd.Parameters.AddWithValue("@operation", "Deposit");
                cmd.Parameters.AddWithValue("@balance", this.Balance);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());

                con.Open();
                dr = cmd.ExecuteReader();
                return true;

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

        double balance3;
        public override bool transfer(double amount, string username)
        {
            bool flag = false;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                if(this.Balance < 0 || this.Balance < amount)
                    throw new Exception();
                
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from [dbo].[Table]", con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd[1].ToString() == username && rd[7].ToString()== "0")
                    {
                        balance3 = Convert.ToDouble(rd[6]);
                        flag = true;
                        break;
                    }
                }
               con.Close();
                if (flag)
                {

                    con.Open();
                    cmd = new SqlCommand("update [dbo].[Table] set balance = @balance where username = @username", con);

                    this.Balance -= this.Balance*fee;
                    balance3 += amount;
                    
                    cmd.Parameters.AddWithValue("@balance", balance3);
                    cmd.Parameters.AddWithValue("@username", username);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SqlCommand("update [dbo].[Table] set balance = @newbalance where username = @username", con);

                    this.Balance -= amount;
                    
                    cmd.Parameters.AddWithValue("@newbalance", this.Balance);
                    cmd.Parameters.AddWithValue("@username", this.Cust.Username);

                    cmd.ExecuteNonQuery();
                    con.Close();


                    
                    cmd = new SqlCommand("INSERT INTO [dbo].[Transaction](id, operation, balance, amount,date) VALUES ( " + this.Cust.Id1 + ", @operation, @balance,@amount,@date)", con);

                    cmd.Parameters.AddWithValue("@operation", "Transfer");
                    cmd.Parameters.AddWithValue("@balance", this.Balance);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    return true;

                }
                else
                {
                    return false;
                }

                flag = false;

            }
            catch(Exception ex)
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
