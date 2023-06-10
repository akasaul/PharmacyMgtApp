namespace PharmacyMgtApp
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.empid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emppassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empsalary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empsex = new Guna.UI.WinForms.GunaComboBox();
            this.empphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.employeeGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Chartreuse;
            this.flowLayoutPanel1.Controls.Add(this.gunaImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton1);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton2);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton3);
            this.flowLayoutPanel1.Controls.Add(this.gunaGradientButton4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 453);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(13, 13);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(168, 143);
            this.gunaImageButton1.TabIndex = 1;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(13, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 55);
            this.panel1.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(38, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(102, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Employee";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(13, 223);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(168, 42);
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
            this.gunaGradientButton2.Location = new System.Drawing.Point(13, 271);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(170, 42);
            this.gunaGradientButton2.TabIndex = 2;
            this.gunaGradientButton2.Text = "UPDATE";
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
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
            this.gunaGradientButton3.Location = new System.Drawing.Point(13, 319);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(170, 42);
            this.gunaGradientButton3.TabIndex = 3;
            this.gunaGradientButton3.Text = "DELETE";
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
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
            this.gunaGradientButton4.Location = new System.Drawing.Point(13, 367);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(170, 42);
            this.gunaGradientButton4.TabIndex = 4;
            this.gunaGradientButton4.Text = "BACK";
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // empid
            // 
            this.empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empid.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empid.HintText = "ID";
            this.empid.isPassword = false;
            this.empid.LineFocusedColor = System.Drawing.Color.Blue;
            this.empid.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.empid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empid.LineThickness = 3;
            this.empid.Location = new System.Drawing.Point(15, 69);
            this.empid.Margin = new System.Windows.Forms.Padding(4);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(102, 44);
            this.empid.TabIndex = 5;
            this.empid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empid.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // empname
            // 
            this.empname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empname.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empname.HintText = "Name";
            this.empname.isPassword = false;
            this.empname.LineFocusedColor = System.Drawing.Color.Blue;
            this.empname.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.empname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empname.LineThickness = 3;
            this.empname.Location = new System.Drawing.Point(15, 153);
            this.empname.Margin = new System.Windows.Forms.Padding(4);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(102, 44);
            this.empname.TabIndex = 49;
            this.empname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empname.OnValueChanged += new System.EventHandler(this.empname_OnValueChanged);
            // 
            // empage
            // 
            this.empage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empage.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empage.HintText = "Age";
            this.empage.isPassword = false;
            this.empage.LineFocusedColor = System.Drawing.Color.Blue;
            this.empage.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.empage.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empage.LineThickness = 3;
            this.empage.Location = new System.Drawing.Point(15, 249);
            this.empage.Margin = new System.Windows.Forms.Padding(4);
            this.empage.Name = "empage";
            this.empage.Size = new System.Drawing.Size(102, 44);
            this.empage.TabIndex = 50;
            this.empage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empage.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // emppassword
            // 
            this.emppassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emppassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emppassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emppassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emppassword.HintText = "Password";
            this.emppassword.isPassword = true;
            this.emppassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.emppassword.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.emppassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emppassword.LineThickness = 3;
            this.emppassword.Location = new System.Drawing.Point(94, 344);
            this.emppassword.Margin = new System.Windows.Forms.Padding(4);
            this.emppassword.Name = "emppassword";
            this.emppassword.Size = new System.Drawing.Size(110, 44);
            this.emppassword.TabIndex = 51;
            this.emppassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emppassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // empsalary
            // 
            this.empsalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empsalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empsalary.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empsalary.HintText = "Salary";
            this.empsalary.isPassword = false;
            this.empsalary.LineFocusedColor = System.Drawing.Color.Blue;
            this.empsalary.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.empsalary.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empsalary.LineThickness = 3;
            this.empsalary.Location = new System.Drawing.Point(145, 69);
            this.empsalary.Margin = new System.Windows.Forms.Padding(4);
            this.empsalary.Name = "empsalary";
            this.empsalary.Size = new System.Drawing.Size(126, 44);
            this.empsalary.TabIndex = 52;
            this.empsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // empsex
            // 
            this.empsex.BackColor = System.Drawing.Color.Transparent;
            this.empsex.BaseColor = System.Drawing.Color.White;
            this.empsex.BorderColor = System.Drawing.Color.Silver;
            this.empsex.DisplayMember = "Sex";
            this.empsex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.empsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empsex.FocusedColor = System.Drawing.Color.Empty;
            this.empsex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.empsex.ForeColor = System.Drawing.Color.Black;
            this.empsex.FormattingEnabled = true;
            this.empsex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.empsex.Location = new System.Drawing.Point(142, 171);
            this.empsex.Name = "empsex";
            this.empsex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empsex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.empsex.Size = new System.Drawing.Size(126, 26);
            this.empsex.TabIndex = 53;
            this.empsex.Tag = "Sex";
            // 
            // empphone
            // 
            this.empphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empphone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empphone.HintText = "Phone";
            this.empphone.isPassword = false;
            this.empphone.LineFocusedColor = System.Drawing.Color.Blue;
            this.empphone.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.empphone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.empphone.LineThickness = 3;
            this.empphone.Location = new System.Drawing.Point(145, 251);
            this.empphone.Margin = new System.Windows.Forms.Padding(4);
            this.empphone.Name = "empphone";
            this.empphone.Size = new System.Drawing.Size(126, 44);
            this.empphone.TabIndex = 54;
            this.empphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // employeeGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.DoubleBuffered = true;
            this.employeeGridView.EnableHeadersVisualStyles = false;
            this.employeeGridView.HeaderBgColor = System.Drawing.Color.Lime;
            this.employeeGridView.HeaderForeColor = System.Drawing.Color.White;
            this.employeeGridView.Location = new System.Drawing.Point(493, 12);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeGridView.Size = new System.Drawing.Size(436, 429);
            this.employeeGridView.TabIndex = 55;
            this.employeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Lime;
            this.bunifuCards1.Controls.Add(this.emppassword);
            this.bunifuCards1.Controls.Add(this.empphone);
            this.bunifuCards1.Controls.Add(this.empsex);
            this.bunifuCards1.Controls.Add(this.empsalary);
            this.bunifuCards1.Controls.Add(this.gunaLabel2);
            this.bunifuCards1.Controls.Add(this.empid);
            this.bunifuCards1.Controls.Add(this.empage);
            this.bunifuCards1.Controls.Add(this.empname);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(202, 12);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(285, 429);
            this.bunifuCards1.TabIndex = 56;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 15);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(215, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Employee Information";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 453);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emppassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empsalary;
        private Guna.UI.WinForms.GunaComboBox empsex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empphone;
        private Bunifu.Framework.UI.BunifuCustomDataGrid employeeGridView;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}