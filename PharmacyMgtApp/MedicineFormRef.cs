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
    public partial class MedicineFormRef : Form
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

        public MedicineFormRef()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if(MedicineName.Text == "" || SellingPrice.Text == "" || BuyingPrice.Text == "" || Quantity.Text == "" || companycb.SelectedItem == null)
            {
                MessageBox.Show("Missing Data. Fill All the Forms Please");
            } else {
                Con.Open();


                // logic
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Medicine_tb1 where MedName = '" + MedicineName.Text + "'", Con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Medicine Already Exists!");
                    Con.Close();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "', " + BuyingPrice.Text + ", " + SellingPrice.Text + ", " + Quantity.Text + ", '" + ExpireDate.Text + "', '" + companycb.SelectedValue.ToString() + "' )", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Successfully Added");
                    Con.Close();
                    Populate();
                }
                // logic
            }
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

        private void MedicineFormRef_Load(object sender, EventArgs e)
        {
            Populate();
            fillComboBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void MedicineName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Medicine_tb1 where MedName = '" + MedicineName.Text + "'", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                if(BuyingPrice.Text == "" || SellingPrice.Text == "" || MedicineName.Text == "" || Quantity.Text == "" || ExpireDate.Text == "" || companycb.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Please Fill out All Fields");
                    return;
                }

                string MyQuery = "UPDATE Medicine_tb1 SET Bprice = " + BuyingPrice.Text + ",Sprice = " + SellingPrice.Text + ",MedQty = " + Quantity.Text + ",ExpDate = '" + ExpireDate.Text + "',Company = '" + companycb.SelectedItem.ToString() + "' WHERE  MedName = '" + MedicineName.Text + "';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine Update Successfully!");
            }

            else
            {
                MessageBox.Show("Medicine Not Found");
                Con.Close();
                return;
            }

            Con.Close();

            Populate();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (MedicineName.Text == "")
            {
                MessageBox.Show("Wrong Options For the Medicine to be deleted");
            }
            else
            {
                Con.Open();

                // logic

                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Medicine_tb1 where MedName = '" + MedicineName.Text + "'", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    string myQuery = "delete from Medicine_tb1 where MedName = '" + MedicineName.Text + "';";
                    SqlCommand cmd = new SqlCommand(myQuery, Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Deleted Successfully");
                }

                else
                {
                    MessageBox.Show("Medicine Not Found");
                    Con.Close();
                    return;
                }
               
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

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
