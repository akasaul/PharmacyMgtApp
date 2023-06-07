﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMgtApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        MedicineFormRef medForm = new MedicineFormRef();
        EmployeeForm employees = new EmployeeForm();     
        CompanyForm company = new CompanyForm();   
        BillingFormRef billingForm = new BillingFormRef();        
        private void button1_Click_1(object sender, EventArgs e)
        {
            medForm.Show();     
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employees.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            billingForm.Hide();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            company.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login(); 
            lg.Show();
            this.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            company.Show();
            this.Hide();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            billingForm.Show();
            this.Hide();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            employees.Show();
            this.Hide();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            medForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
