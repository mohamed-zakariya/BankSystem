using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace BankSystem
{
    public partial class ShowUser : Form
    {
        private Employee emp;
        private Admin f2;

        bool flag = false;


        public ShowUser()
        {
            InitializeComponent();
        }

        public ShowUser(Admin f2, Employee emp)
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

        private void button1_Click(object sender, EventArgs e)
        {
            flag = false;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Table] where username = @username", con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);


            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[1].ToString() == textBox1.Text)
                {
                    flag = true;
                }
            }
            con.Close();
            if(flag)
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else
            {
                MessageBox.Show("username not found");
            }

            
        }
    }
}
