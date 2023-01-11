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
    public partial class DeleteUser : Form
    {
        private Employee emp;
        private Admin f2;

        bool flag = false;

        public DeleteUser()
        {
            InitializeComponent();
        }
        public DeleteUser(Admin f2, Employee emp)
        {
            InitializeComponent();
            this.f2 = f2;
            this.emp = emp;
        }
       

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "";


            if (textBox1.Text == "")
            {
                label2.Text = "enter user's username";
                flag = true;
            }

            if (!flag)

            {
                emp.deleteUser(textBox1.Text);

                label2.Text = "Sucessfully Deleted the user ";


            }
            flag = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
