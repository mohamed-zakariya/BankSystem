using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BankSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


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
                        Admin f2 = new(this, emp);
                        f2.Show();
                        this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}         