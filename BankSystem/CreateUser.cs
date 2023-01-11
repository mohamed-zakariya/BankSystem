using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class CreateUser : Form
    {
        private Employee emp;
        private Admin f2;

        bool flag = false;
        int account_lvl;
        public CreateUser()
        {
            InitializeComponent();
        }
        public CreateUser(Admin f2, Employee emp)
        {
            InitializeComponent();
            this.f2 = f2;
            this.emp = emp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            if (textBox1.Text == "")
            {
                label2.Text = "enter user's username";
                flag = true;
            }
            if (textBox2.Text == "")
            {
                label3.Text = "enter user's password";
                flag = true;
            }
            if (textBox3.Text == "")
            {
                label4.Text = "enter user's name";
                flag = true;
            }
            if (textBox4.Text == "")
            {
                label5.Text = "enter user's age";
                flag = true;
            }
            if (textBox5.Text == "")
            {
                label6.Text = "enter user's adress";
                flag = true;
            }
            if (textBox6.Text == "")
            {
                label7.Text = "enter user's balance";
                flag = true;
            }
            if (textBox8.Text == "")
            {
                label10.Text = "enter user's phone number";
                flag = true;
            }
            if (textBox7.Text == "")
            {
                label11.Text = "enter user's mail";
                flag = true;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                label8.Text = "enter user's account type";
                flag = true;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                label8.Text = "enter user's account type";
                flag = true;
            }
            if (comboBox1.Text == "Current Account")
            {
                account_lvl = 0;
            }
            if (comboBox1.Text == "Saving Account")
            {
                account_lvl = 1;
            }
            if (!flag)

            {
                if (emp.createUser(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToDouble(textBox6.Text), account_lvl, textBox8.Text, textBox7.Text))
                {
                    label9.Text = "Sucessfully created";
                }
                else
                {
                    label9.Text = "The User is already exists";
                }
            }
            flag = false;
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {

            f2.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
