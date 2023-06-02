namespace PharmacyMgtApp
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.empsex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.empsalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empname = new System.Windows.Forms.TextBox();
            this.empid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empphone = new System.Windows.Forms.TextBox();
            this.delEmpBtn = new System.Windows.Forms.Button();
            this.updateEmpBtn = new System.Windows.Forms.Button();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.emppassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // empsex
            // 
            this.empsex.FormattingEnabled = true;
            this.empsex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.empsex.Location = new System.Drawing.Point(252, 243);
            this.empsex.Name = "empsex";
            this.empsex.Size = new System.Drawing.Size(139, 21);
            this.empsex.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(258, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(258, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Salary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // empsalary
            // 
            this.empsalary.Location = new System.Drawing.Point(251, 181);
            this.empsalary.Name = "empsalary";
            this.empsalary.Size = new System.Drawing.Size(131, 20);
            this.empsalary.TabIndex = 21;
            this.empsalary.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(74, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Employee Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // empage
            // 
            this.empage.Location = new System.Drawing.Point(68, 313);
            this.empage.Name = "empage";
            this.empage.Size = new System.Drawing.Size(131, 20);
            this.empage.TabIndex = 19;
            this.empage.TextChanged += new System.EventHandler(this.SellingPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(65, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Employee Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(67, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Employee Name";
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(67, 243);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(131, 20);
            this.empname.TabIndex = 16;
            // 
            // empid
            // 
            this.empid.Location = new System.Drawing.Point(68, 181);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(140, 20);
            this.empid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(258, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Employee Phone";
            // 
            // empphone
            // 
            this.empphone.Location = new System.Drawing.Point(252, 313);
            this.empphone.Name = "empphone";
            this.empphone.Size = new System.Drawing.Size(140, 20);
            this.empphone.TabIndex = 25;
            // 
            // delEmpBtn
            // 
            this.delEmpBtn.BackColor = System.Drawing.Color.Brown;
            this.delEmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.delEmpBtn.ForeColor = System.Drawing.Color.White;
            this.delEmpBtn.Location = new System.Drawing.Point(292, 427);
            this.delEmpBtn.Name = "delEmpBtn";
            this.delEmpBtn.Size = new System.Drawing.Size(92, 34);
            this.delEmpBtn.TabIndex = 30;
            this.delEmpBtn.Text = "DELETE";
            this.delEmpBtn.UseVisualStyleBackColor = false;
            this.delEmpBtn.Click += new System.EventHandler(this.delEmpBtn_Click);
            // 
            // updateEmpBtn
            // 
            this.updateEmpBtn.BackColor = System.Drawing.Color.Brown;
            this.updateEmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updateEmpBtn.ForeColor = System.Drawing.Color.White;
            this.updateEmpBtn.Location = new System.Drawing.Point(190, 427);
            this.updateEmpBtn.Name = "updateEmpBtn";
            this.updateEmpBtn.Size = new System.Drawing.Size(92, 34);
            this.updateEmpBtn.TabIndex = 29;
            this.updateEmpBtn.Text = "UPDATE";
            this.updateEmpBtn.UseVisualStyleBackColor = false;
            this.updateEmpBtn.Click += new System.EventHandler(this.updateEmpBtn_Click);
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.Color.Brown;
            this.addEmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addEmpBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpBtn.Location = new System.Drawing.Point(82, 427);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(92, 34);
            this.addEmpBtn.TabIndex = 28;
            this.addEmpBtn.Text = "ADD";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Brown;
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(202, 480);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 26);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "BACK";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeGridView.Location = new System.Drawing.Point(397, 12);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(560, 486);
            this.employeeGridView.TabIndex = 31;
            this.employeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGridView_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(73, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Employee Password";
            // 
            // emppassword
            // 
            this.emppassword.Location = new System.Drawing.Point(67, 385);
            this.emppassword.Name = "emppassword";
            this.emppassword.Size = new System.Drawing.Size(140, 20);
            this.emppassword.TabIndex = 32;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emppassword);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.delEmpBtn);
            this.Controls.Add(this.updateEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empphone);
            this.Controls.Add(this.empsex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empsalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox empsex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empsalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.TextBox empid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empphone;
        private System.Windows.Forms.Button delEmpBtn;
        private System.Windows.Forms.Button updateEmpBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emppassword;
    }
}