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

    public partial class MedicineForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void populate()
        {
            Con.Open();

            Con.Close();
        }


        public MedicineForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "', "+ BuyingPrice.Text +", "+SellingPrice.Text+", "+Quantity.Text+", '"+ExpireDate.Text+"', '"+companycb+"' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Successfully Added");
            Con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "', " + BuyingPrice.Text + ", " + SellingPrice.Text + ", " + Quantity.Text + ", '" + ExpireDate.Text + "', '" + companycb + "' )", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Successfully Added");
            Con.Close();
        }
    }
}
