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

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser f9 = new CreateUser(this, emp);
            f9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
