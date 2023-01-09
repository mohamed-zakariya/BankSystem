using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BankSystem
{
    public partial class ShowTransactionscs : Form
    {
        User f3;
        Account account;
        Customer cust;
        public ShowTransactionscs()
        {
            InitializeComponent();
        }
        public ShowTransactionscs(User f3, Customer cust, Account account)
        {
            InitializeComponent();
            this.f3 = f3;
            this.account = account;
            this.cust = cust;
        }

        private void ShowTransactionscs_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[Transaction] where id =" + cust.Id1, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource= dt;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.Show();
        }


    }
}
