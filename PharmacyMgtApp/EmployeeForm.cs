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
    public partial class EmployeeForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");
        public EmployeeForm()
        {
            InitializeComponent();
        }


        public void Populate()
        {
            Con.Open();
            string Myquery = "select * from Employee_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            employeeGridView.ReadOnly = true;
            employeeGridView.DataSource = ds.Tables[0];
            
            Con.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (empid.Text == "" || empname.Text == "" || empsalary.Text == "" || empphone.Text == "" || empsex.SelectedItem == null || empage.Text == "" || emppassword.Text == "")
            {
                MessageBox.Show("Wrong Input Fill all fields required!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee_tb1 values('" + empid.Text + "', '" + empname.Text + "', '" + empsalary.Text + "' , " + empage.Text + ", '" + empphone.Text + "' , '" + emppassword.Text + "', '" + empsex.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employees Succesfully added");
                Con.Close();
                Populate();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void empid_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.employeeGridView.Rows[e.RowIndex];
                empid.Text = row.Cells["EmpId"].Value.ToString();
                empname.Text = row.Cells["Empname"].Value.ToString();
                empsalary.Text = row.Cells["Empsalary"].Value.ToString();
                empage.Text = row.Cells["EmpAge"].Value.ToString();
                empphone.Text = row.Cells["EmpPhone"].Value.ToString();
                emppassword.Text = row.Cells["EmpPassword"].Value.ToString();
                empsex.SelectedItem = row.Cells["EmpSex"].Value.ToString();
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Con.Open();

            string MyQuery = "UPDATE Employee_tb1 SET EmpId = '" + empid.Text + "',Empname = '" + empname.Text + "',Empsalary = '" + empsalary.Text + "',EmpAge = '" + empage.Text + "',EmpPhone = '" + empphone.Text + "',EmpPassword = '" + emppassword.Text + "',EmpSex = '" + empsex.Text + "' WHERE  EmpId = '" + empid.Text + "';";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Employee Updated Successfully!");

            Con.Close();

            Populate();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (empid.Text == "")
            {
                MessageBox.Show("Provide the Employee ID");
            }
            else
            {
                Con.Open();
                string myQuery = "delete from Employee_tb1 where EmpId = '" + empid.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully!");
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

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empname_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
