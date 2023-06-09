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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyMgtApp
{
    public partial class LoginForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee_tb1 where Empname = '" + Username.Text + "' and EmpPassword = '" + Password.Text + "'", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            Con.Close();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
