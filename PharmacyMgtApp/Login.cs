using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyMgtApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm  = new HomeForm();
            /*if(Username.Text == "Admin" && Password.Text == "admin")
            {
                homeForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Wrong Username or password");
            } */
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee_tb1 where Empname = '" + Username.Text + "' and EmpPassword = '" + Password.Text + "'", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                homeForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            Con.Close();
        }
    }
}
