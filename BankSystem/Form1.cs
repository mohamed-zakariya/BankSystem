using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int id;
        private string username;
        private string password;
        private string name;
        private int age;
        private string address;
        private double balance;
        private int sec_lvl;





        private void Login_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Enter the Username");
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                Person p = new();

                p = p.loginCheck(textBox2.Text, textBox1.Text);
                if(p != null )
                {
                   if(p is Customer)
                    {   
                        Customer cust  = (Customer)p;
                        User f3 = new(this, cust);
                        f3.Show();
                        this.Hide();
                            
                    }
                   else if (p is Employee) {
                        Employee emp = (Employee)p;
                        Admin f2 = new(emp);
                    }
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
                
            }
            
        }

        private void Signin_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}         