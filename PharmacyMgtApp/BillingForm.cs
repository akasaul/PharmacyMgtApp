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
using System.Diagnostics;

namespace PharmacyMgtApp
{
    public partial class BillingForm : Form
    {
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
            } catch {}
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

            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["MedQty"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                Stocklbl.Text = "Avalable Stock: " +  dr["MedQty"].ToString();
                Stocklbl.Visible = true;
            }

            Con.Close();
        }
        
        public BillingForm()
        {
            InitializeComponent();
        }
        public void updateMedicine()
        {
            Con.Open();
            
            int newQty = x - Convert.ToInt32(billingQty.Text);
            string MyQuery = "UPDATE Medicine_tb1 SET MedQty = " + newQty + "' WHERE  MedName = '" + comboBox1.SelectedValue.ToString()+ "';";
            SqlCommand cmd = new SqlCommand(MyQuery, Con);
            cmd.ExecuteNonQuery();

            Con.Close();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            populateComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        int GridTotal = 0;
        private void addBillBtn_Click(object sender, EventArgs e)
        {
            int n = 0, total = Convert.ToInt32(billingQty.Text) * x;
            //DataGridViewRow newRow = new DataGridViewRow();


            //BillGridView.Rows[index].Cells["Column1"].Value = "Column1";
            //BillGridView.Rows[index].Cells["Column2"].Value = 5.6;

            //DataGridViewRow newRow = (DataGridViewRow)BillGridView.Rows[0].Clone();

            if(billingQty.Text == "" || Convert.ToInt32(billingQty.Text) > x)
            {
                MessageBox.Show("Not Enough Stocks, Please Check!");
            } else
            {
                var index = BillGridView.Rows.Add();
                BillGridView.Rows[index].Cells["MedId"].Value = n + 1;
                BillGridView.Rows[index].Cells["Medname"].Value = comboBox1.SelectedValue.ToString();
                BillGridView.Rows[index].Cells["MedQty"].Value = billingQty.Text;
                BillGridView.Rows[index].Cells["Unitprice"].Value = unitp;
                BillGridView.Rows[index].Cells["TotalPrice"].Value = unitp * Convert.ToInt32(billingQty.Text);
            
                GridTotal = GridTotal + total;
                totalAmount.Text = "Rs" + GridTotal;

            }


        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap =  new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
