using Org.BouncyCastle.Asn1.Ocsp;
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

namespace PharmacyMgtApp
{
    public partial class CompanyForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");

        public void Populate()
        {
            Con.Open();
            string Myquery = "select * from Company_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            companyGridView.ReadOnly = true;
            companyGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        public CompanyForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.companyGridView.Rows[e.RowIndex];
                cmpId.Text = row.Cells["CompId"].Value.ToString();
                cmpName.Text = row.Cells["CompName"].Value.ToString();
                cmpAddress.Text = row.Cells["CompPhone"].Value.ToString();
                cmpPhone.Text = row.Cells["CompAddress"].Value.ToString();
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (cmpId.Text == "" || cmpName.Text == "" || cmpPhone.Text == "" || cmpAddress.Text == "")
            {
                MessageBox.Show("Wrong Input! Fill all fields required!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tb1 values('" + cmpId.Text + "', '" + cmpName.Text + "', '" + cmpPhone.Text + "' , '" + cmpAddress.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Succesfully added");
                Con.Close();
                Populate();
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Con.Open();

            string MyQuery = "UPDATE Company_tb1 SET CompId = '" + cmpId.Text + "',CompName = '" + cmpName.Text + "',CompPhone = '" + cmpPhone.Text + "',CompAddress = '" + cmpAddress.Text + "' WHERE  CompId = '" + cmpId.Text + "';";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Company Updated Successfully!");

            Con.Close();

            Populate();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (cmpId.Text == "")
            {
                MessageBox.Show("Provide the Company ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from Company_tb1 where CompId = '" + cmpId.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully!");
                Con.Close();
            }
            Populate();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();

        }

        private void cmpAddress_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cmpPhone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmpId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cmpName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
