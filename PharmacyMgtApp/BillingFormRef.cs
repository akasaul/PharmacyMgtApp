using Microsoft.VisualBasic;
using Org.BouncyCastle.Utilities.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyMgtApp
{
    public partial class BillingFormRef : Form
    {
        private bool isAdmin;

        public BillingFormRef(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Njayzzy\\Documents\\PhramacyApp.mdf;Integrated Security=True;Connect Timeout=30");
        
        void populateComboBox()
        {
            string sql = "select * from Medicine_tb1";
            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                comboBox1.ValueMember = "MedName";
                comboBox1.DataSource = dt;

                Con.Close();
            }
            catch { }
        }

        int x, unitp;


        public void fetchQty()
        {
            Con.Open();
            string query = "select * from Medicine_tb1 where MedName = '" + comboBox1.SelectedValue.ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["MedQty"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                Stocklbl.Text = "Avalable Stock: " + dr["MedQty"].ToString();

                Stocklbl.Visible = true;
                stockRange.MaximumRange = Convert.ToInt32(dr["MedQty"]);
            }

            Con.Close();
        }

        public void updateMedicine()
        {
            Con.Open();

            if(BillGridView.Rows == null)
            {
                return;
            }

            foreach (DataGridViewRow row in BillGridView.Rows)
            {
                string query = "SELECT COUNT(*) FROM Medicine_tb1 WHERE MedName = '" + MedName + "';";
                SqlCommand command = new SqlCommand(query, Con);

                object result = command.ExecuteScalar();
                int prevQty = Convert.ToInt32(result);

                int newQty = prevQty - Convert.ToInt32(row.Cells["MedQty"].Value);
                string MyQuery = "UPDATE Medicine_tb1 SET MedQty = '" + newQty + "' WHERE  MedName = '" + comboBox1.SelectedValue.ToString() + "';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
            }

            //BillGridView.Rows.Clear();
           // totalAmount.Text = "";

            Con.Close();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void companyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        int GridTotal = 0;
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

            if(billingQty.Text == "")
            {
                MessageBox.Show("Quantity Can't be Empty");
                return;
            }
            int n = 0, total = Convert.ToInt32(billingQty.Text) * x;

            if(billingQty.Text == "")
            {
                MessageBox.Show("Quantity Should not be Empty!");
            }

            if (Convert.ToInt32(billingQty.Text) > x)
            {
                MessageBox.Show("Not Enough Stocks, Please Check!");
            }
            else
            {
                bool isFound = false;

                if(BillGridView.Rows != null)
                {

                    foreach (DataGridViewRow row in BillGridView.Rows)
                    {

                        // Check if cells in the table exist and not null

                        if (row.Cells["MedName"] != null && row.Cells["MedQty"] != null && row.Cells != null && row != null)
                        {
                            if (row.Cells["MedName"].Value == comboBox1.SelectedValue)
                            {
                                isFound = true;
                                row.Cells["MedQty"].Value = Convert.ToInt32(billingQty.Text) + Convert.ToInt32(row.Cells["MedQty"].Value);
                                //billingQty.Text = 
                                if(Convert.ToInt32(row.Cells["MedQty"].Value) <= stockRange.MaximumRange)
                                {
                                    stockRange.RangeMax = Convert.ToInt32(row.Cells["MedQty"].Value);
                                } else
                                {
                                    MessageBox.Show("Not Enough Stocks");
                                    return;
                                }
                                return;
                            }
                        }
                    
                    }

                }

                if(isFound)
                {
                    return;
                }

                var index = BillGridView.Rows.Add();
                BillGridView.Rows[index].Cells["MedName"].Value = comboBox1.SelectedValue.ToString();
                BillGridView.Rows[index].Cells["MedQty"].Value = Convert.ToInt32(billingQty.Text);
                BillGridView.Rows[index].Cells["Unitprice"].Value = unitp;
                BillGridView.Rows[index].Cells["TotalPrice"].Value = unitp * Convert.ToInt32(billingQty.Text);

                GridTotal = GridTotal + total;
                totalAmount.Text = "$ " + GridTotal;

            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billingQty_OnValueChanged(object sender, EventArgs e)
        {
            if (billingQty.Text != "")
            {
                int val;
                try
                {
                    val = int.Parse(billingQty.Text);

                    stockRange.RangeMax = val;

                } catch(Exception err) { }
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stocklbl_Click(object sender, EventArgs e)
        {

        }

        Bitmap bitmap;

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            //UPDATE your_table_name
            //SET quantity = quantity - 1
            //WHERE MedName = 'givenName';

            //updateMedicine();

            if(BillGridView.Rows == null || BillGridView.Rows.Count == 0)
            {
                MessageBox.Show("You Have Selected No Medicines");
                return;
            }

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            BillGridView.Rows.Clear();
            Stocklbl.Text = "Available Stock: ";
            billingQty.Text = "";
            totalAmount.Text = "0"; 
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        private void stockRange_RangeChanged(object sender, EventArgs e)
        {

        }

        private void totalAmount_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            if(this.isAdmin)
            {   
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            } else
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void BillingFormRef_Load(object sender, EventArgs e)
        {
            populateComboBox();
            fetchQty();
        }
    }
}
