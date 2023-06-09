namespace PharmacyMgtApp
{
    partial class CompanyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.companyGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmpPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmpAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cmpId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmpName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(30, 42);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(212, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Company Information";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // companyGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.companyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.companyGridView.BackgroundColor = System.Drawing.Color.White;
            this.companyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.DoubleBuffered = true;
            this.companyGridView.EnableHeadersVisualStyles = false;
            this.companyGridView.HeaderBgColor = System.Drawing.Color.Lime;
            this.companyGridView.HeaderForeColor = System.Drawing.Color.White;
            this.companyGridView.Location = new System.Drawing.Point(499, 12);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.companyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.companyGridView.Size = new System.Drawing.Size(436, 429);
            this.companyGridView.TabIndex = 58;
            this.companyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGridView_CellContentClick);
            // 
            // cmpPhone
            // 
            this.cmpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmpPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmpPhone.HintForeColor = System.Drawing.Color.Empty;
            this.cmpPhone.HintText = "";
            this.cmpPhone.isPassword = false;
            this.cmpPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpPhone.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.cmpPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpPhone.LineThickness = 3;
            this.cmpPhone.Location = new System.Drawing.Point(145, 227);
            this.cmpPhone.Margin = new System.Windows.Forms.Padding(4);
            this.cmpPhone.Name = "cmpPhone";
            this.cmpPhone.Size = new System.Drawing.Size(126, 44);
            this.cmpPhone.TabIndex = 54;
            this.cmpPhone.Text = "Phone";
            this.cmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpPhone.OnValueChanged += new System.EventHandler(this.cmpPhone_OnValueChanged);
            // 
            // cmpAddress
            // 
            this.cmpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmpAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmpAddress.HintForeColor = System.Drawing.Color.Empty;
            this.cmpAddress.HintText = "";
            this.cmpAddress.isPassword = false;
            this.cmpAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpAddress.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.cmpAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpAddress.LineThickness = 3;
            this.cmpAddress.Location = new System.Drawing.Point(145, 115);
            this.cmpAddress.Margin = new System.Windows.Forms.Padding(4);
            this.cmpAddress.Name = "cmpAddress";
            this.cmpAddress.Size = new System.Drawing.Size(126, 44);
            this.cmpAddress.TabIndex = 52;
            this.cmpAddress.Text = "Address";
            this.cmpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpAddress.OnValueChanged += new System.EventHandler(this.cmpAddress_OnValueChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Lime;
            this.bunifuCards1.Controls.Add(this.cmpPhone);
            this.bunifuCards1.Controls.Add(this.cmpAddress);
            this.bunifuCards1.Controls.Add(this.gunaLabel2);
            this.bunifuCards1.Controls.Add(this.cmpId);
            this.bunifuCards1.Controls.Add(this.cmpName);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(208, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(285, 429);
            this.bunifuCards1.TabIndex = 59;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // cmpId
            // 
            this.cmpId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmpId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmpId.HintForeColor = System.Drawing.Color.Empty;
            this.cmpId.HintText = "";
            this.cmpId.isPassword = false;
            this.cmpId.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpId.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.cmpId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpId.LineThickness = 3;
            this.cmpId.Location = new System.Drawing.Point(15, 115);
            this.cmpId.Margin = new System.Windows.Forms.Padding(4);
            this.cmpId.Name = "cmpId";
            this.cmpId.Size = new System.Drawing.Size(102, 44);
            this.cmpId.TabIndex = 5;
            this.cmpId.Text = "ID";
            this.cmpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpId.OnValueChanged += new System.EventHandler(this.cmpId_OnValueChanged);
            // 
            // cmpName
            // 
            this.cmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmpName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmpName.HintForeColor = System.Drawing.Color.Empty;
            this.cmpName.HintText = "";
            this.cmpName.isPassword = false;
            this.cmpName.LineFocusedColor = System.Drawing.Color.Blue;
            this.cmpName.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.cmpName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cmpName.LineThickness = 3;
            this.cmpName.Location = new System.Drawing.Point(15, 227);
            this.cmpName.Margin = new System.Windows.Forms.Padding(4);
            this.cmpName.Name = "cmpName";
            this.cmpName.Size = new System.Drawing.Size(102, 44);
            this.cmpName.TabIndex = 49;
            this.cmpName.Text = "Name";
            this.cmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmpName.OnValueChanged += new System.EventHandler(this.cmpName_OnValueChanged);
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton3.Image")));
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton3.Location = new System.Drawing.Point(13, 344);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(177, 42);
            this.gunaGradientButton3.TabIndex = 3;
            this.gunaGradientButton3.Text = "DELETE";
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton1.Location = new System.Drawing.Point(13, 248);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(175, 42);
            this.gunaGradientButton1.TabIndex = 0;
            this.gunaGradientButton1.Text = "ADD";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton2.Image")));
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton2.Location = new System.Drawing.Point(13, 296);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(177, 42);
            this.gunaGradientButton2.TabIndex = 2;
            this.gunaGradientButton2.Text = "UPDATE";
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(48, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Company";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(13, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 55);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Chartreuse;
            this.flowLayoutPanel1.Controls.Add(this.gunaImageButton2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton1);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton2);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton3);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 453);
            this.flowLayoutPanel1.TabIndex = 57;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.BackgroundImage")));
            this.gunaImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = null;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(13, 13);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(175, 168);
            this.gunaImageButton2.TabIndex = 12;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton4.Image")));
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton4.Location = new System.Drawing.Point(13, 392);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(177, 42);
            this.gunaGradientButton4.TabIndex = 4;
            this.gunaGradientButton4.Text = "BACK";
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 453);
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid companyGridView;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpAddress;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cmpName;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
    }
}