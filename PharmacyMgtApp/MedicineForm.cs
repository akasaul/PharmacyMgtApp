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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyMgtApp
{

    public partial class MedicineForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");
        
        public void Populate()
        {
            Con.Open();
            string Myquery = "select * from Medicine_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            var ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
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

        public void fillComboBox()
        {
            string sql = "select CompName from Company_tb1";
            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CompName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                companycb.ValueMember = "CompName";
                companycb.DataSource = dt;

                Con.Close();
            }
            catch { }
        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            Populate();
            fillComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            MedicineName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BuyingPrice.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SellingPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); 
            */
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                MedicineName.Text = row.Cells["MedName"].Value.ToString();
                BuyingPrice.Text = row.Cells["Bprice"].Value.ToString();
                SellingPrice.Text = row.Cells["Sprice"].Value.ToString();
                Quantity.Text = row.Cells["MedQty"].Value.ToString();
                companycb.SelectedItem = row.Cells["Company"].Value.ToString();
            }
        }

        /* private void textBox1_TextChanged_1(object sender, EventArgs e)
         {
             Con.Open();
             SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "', "+ BuyingPrice.Text +", "+SellingPrice.Text+", "+Quantity.Text+", '"+ExpireDate.Text+"', '"+companycb+"' )", Con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Medicine Successfully Added");
             Con.Close();
         } */

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MedicineName.Text == "" || SellingPrice.Text == "" || BuyingPrice.Text == "" || Quantity.Text == "" || companycb.SelectedItem == null)
            {
                MessageBox.Show("Missing Data. Fill All the Forms Please");
            } else {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "', " + BuyingPrice.Text + ", " + SellingPrice.Text + ", " + Quantity.Text + ", '" + ExpireDate.Text + "', '" + companycb.SelectedItem.ToString() + "' )", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");
                Con.Close();
                Populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "UPDATE Medicine_tb1 SET Bprice = " + BuyingPrice.Text + ",Sprice = " + SellingPrice.Text + ",MedQty = " + Quantity.Text + ",ExpDate = '" + ExpireDate.Text + "',Company = '" + companycb.SelectedItem.ToString() + "' WHERE  MedName = '" + MedicineName.Text + "';";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Medicine Update Successfully!");
            
            Con.Close();

            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MedicineName.Text == "")
            {
                MessageBox.Show("Wrong Options For the Medicine to be deleted");
            } else
            {   
                Con.Open();
                string myQuery = "delete from Medicine_tb1 where MedName = '" + MedicineName.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
                Con.Close();
            }

            Populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void companycb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
