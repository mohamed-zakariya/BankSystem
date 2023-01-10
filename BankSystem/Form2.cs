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
    public partial class Admin : Form
    {

        private Employee emp;
        Form1 f1;
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Form1 f1, Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            this.f1 = f1;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DeleteUser f11 = new DeleteUser(this, emp);
            f11.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateUser f13 = new UpdateUser(this, emp);
            f13.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ShowUser f12 = new ShowUser(this, emp);
            f12.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateUser f9 = new CreateUser(this, emp);
            f9.Show();
            this.Hide();
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            label1.Text = "Hello MR" + " " + emp.Name;
        }
    }
}
