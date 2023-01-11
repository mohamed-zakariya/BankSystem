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
    public partial class UpdateUser : Form
    {
        private Employee emp;
        private Admin f2;

        bool flag = false;
        public int account_lvl;
        public UpdateUser()
        {
            InitializeComponent();
        }

        public UpdateUser(Admin f2, Employee emp)
        {
            InitializeComponent();
            this.f2 = f2;
            this.emp = emp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            if (textBox1.Text == "")
            {
                label3.Text = "enter user's username";
                flag = true;
            }

            if (textBox5.Text == "")
            {
                label4.Text = "enter user's adress";
                flag = true;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                label5.Text = "enter user's account type";
                flag = true;
            }
            if (textBox2.Text == "")
            {
                label7.Text = "enter user's phone number";
                flag = true;
            }
            if (textBox3.Text == "")
            {
                label8.Text = "enter user's mail";
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
                emp.updateUser(textBox1.Text, textBox5.Text, account_lvl, textBox2.Text, textBox3.Text);

                label6.Text = "Sucessfully  updated ";


            }
            flag = false;
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

