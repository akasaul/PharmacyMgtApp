namespace PharmacyMgtApp
{
    partial class Company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delCmpBtn = new System.Windows.Forms.Button();
            this.updateCmpBtn = new System.Windows.Forms.Button();
            this.addCmpBtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmpPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmpName = new System.Windows.Forms.TextBox();
            this.cmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.companyGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delCmpBtn
            // 
            this.delCmpBtn.BackColor = System.Drawing.Color.Brown;
            this.delCmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.delCmpBtn.ForeColor = System.Drawing.Color.White;
            this.delCmpBtn.Location = new System.Drawing.Point(291, 355);
            this.delCmpBtn.Name = "delCmpBtn";
            this.delCmpBtn.Size = new System.Drawing.Size(92, 34);
            this.delCmpBtn.TabIndex = 50;
            this.delCmpBtn.Text = "DELETE";
            this.delCmpBtn.UseVisualStyleBackColor = false;
            this.delCmpBtn.Click += new System.EventHandler(this.delCmpBtn_Click);
            // 
            // updateCmpBtn
            // 
            this.updateCmpBtn.BackColor = System.Drawing.Color.Brown;
            this.updateCmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updateCmpBtn.ForeColor = System.Drawing.Color.White;
            this.updateCmpBtn.Location = new System.Drawing.Point(185, 355);
            this.updateCmpBtn.Name = "updateCmpBtn";
            this.updateCmpBtn.Size = new System.Drawing.Size(92, 34);
            this.updateCmpBtn.TabIndex = 49;
            this.updateCmpBtn.Text = "UPDATE";
            this.updateCmpBtn.UseVisualStyleBackColor = false;
            this.updateCmpBtn.Click += new System.EventHandler(this.updateCmpBtn_Click);
            // 
            // addCmpBtn
            // 
            this.addCmpBtn.BackColor = System.Drawing.Color.Brown;
            this.addCmpBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addCmpBtn.ForeColor = System.Drawing.Color.White;
            this.addCmpBtn.Location = new System.Drawing.Point(62, 355);
            this.addCmpBtn.Name = "addCmpBtn";
            this.addCmpBtn.Size = new System.Drawing.Size(92, 34);
            this.addCmpBtn.TabIndex = 48;
            this.addCmpBtn.Text = "ADD";
            this.addCmpBtn.UseVisualStyleBackColor = false;
            this.addCmpBtn.Click += new System.EventHandler(this.addCmpBtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Brown;
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(185, 423);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 26);
            this.textBox4.TabIndex = 47;
            this.textBox4.Text = "BACK";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(250, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Phone Number";
            // 
            // cmpPhone
            // 
            this.cmpPhone.Location = new System.Drawing.Point(243, 156);
            this.cmpPhone.Name = "cmpPhone";
            this.cmpPhone.Size = new System.Drawing.Size(131, 20);
            this.cmpPhone.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(258, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Company Address";
            // 
            // cmpAddress
            // 
            this.cmpAddress.Location = new System.Drawing.Point(252, 253);
            this.cmpAddress.Name = "cmpAddress";
            this.cmpAddress.Size = new System.Drawing.Size(131, 20);
            this.cmpAddress.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(57, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Company Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(62, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Company Name";
            // 
            // cmpName
            // 
            this.cmpName.Location = new System.Drawing.Point(62, 253);
            this.cmpName.Name = "cmpName";
            this.cmpName.Size = new System.Drawing.Size(131, 20);
            this.cmpName.TabIndex = 36;
            // 
            // cmpId
            // 
            this.cmpId.Location = new System.Drawing.Point(60, 156);
            this.cmpId.Name = "cmpId";
            this.cmpId.Size = new System.Drawing.Size(140, 20);
            this.cmpId.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 44);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manufacturer";
            // 
            // companyGridView
            // 
            this.companyGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.companyGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.companyGridView.Location = new System.Drawing.Point(422, 12);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.Size = new System.Drawing.Size(535, 486);
            this.companyGridView.TabIndex = 53;
            this.companyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGridView_CellContentClick);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.delCmpBtn);
            this.Controls.Add(this.updateCmpBtn);
            this.Controls.Add(this.addCmpBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmpPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmpAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmpName);
            this.Controls.Add(this.cmpId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delCmpBtn;
        private System.Windows.Forms.Button updateCmpBtn;
        private System.Windows.Forms.Button addCmpBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmpPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmpName;
        private System.Windows.Forms.TextBox cmpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView companyGridView;
    }
}