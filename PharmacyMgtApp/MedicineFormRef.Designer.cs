namespace PharmacyMgtApp
{
    partial class MedicineFormRef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineFormRef));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BuyingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.companycb = new Guna.UI.WinForms.GunaComboBox();
            this.ExpireDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.Quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MedicineName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gunaLabel2.Size = new System.Drawing.Size(209, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Medicine Information";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Lime;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(513, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(428, 429);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuyingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BuyingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BuyingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.BuyingPrice.HintText = "";
            this.BuyingPrice.isPassword = false;
            this.BuyingPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.BuyingPrice.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.BuyingPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.BuyingPrice.LineThickness = 3;
            this.BuyingPrice.Location = new System.Drawing.Point(153, 115);
            this.BuyingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.Size = new System.Drawing.Size(126, 44);
            this.BuyingPrice.TabIndex = 52;
            this.BuyingPrice.Text = "Buying Price";
            this.BuyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Lime;
            this.bunifuCards1.Controls.Add(this.gunaLabel4);
            this.bunifuCards1.Controls.Add(this.companycb);
            this.bunifuCards1.Controls.Add(this.ExpireDate);
            this.bunifuCards1.Controls.Add(this.gunaLabel3);
            this.bunifuCards1.Controls.Add(this.Quantity);
            this.bunifuCards1.Controls.Add(this.BuyingPrice);
            this.bunifuCards1.Controls.Add(this.gunaLabel2);
            this.bunifuCards1.Controls.Add(this.MedicineName);
            this.bunifuCards1.Controls.Add(this.SellingPrice);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(207, 9);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(300, 429);
            this.bunifuCards1.TabIndex = 62;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(12, 271);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(85, 16);
            this.gunaLabel4.TabIndex = 68;
            this.gunaLabel4.Text = "Company Name";
            // 
            // companycb
            // 
            this.companycb.BackColor = System.Drawing.Color.Transparent;
            this.companycb.BaseColor = System.Drawing.Color.White;
            this.companycb.BorderColor = System.Drawing.Color.Silver;
            this.companycb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companycb.FocusedColor = System.Drawing.Color.Empty;
            this.companycb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companycb.ForeColor = System.Drawing.Color.Black;
            this.companycb.FormattingEnabled = true;
            this.companycb.Location = new System.Drawing.Point(15, 290);
            this.companycb.Name = "companycb";
            this.companycb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.companycb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.companycb.Size = new System.Drawing.Size(121, 26);
            this.companycb.TabIndex = 67;
            // 
            // ExpireDate
            // 
            this.ExpireDate.BaseColor = System.Drawing.Color.White;
            this.ExpireDate.BorderColor = System.Drawing.Color.Silver;
            this.ExpireDate.CustomFormat = null;
            this.ExpireDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ExpireDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpireDate.ForeColor = System.Drawing.Color.Black;
            this.ExpireDate.Location = new System.Drawing.Point(15, 206);
            this.ExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.ExpireDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExpireDate.OnPressedColor = System.Drawing.Color.Black;
            this.ExpireDate.Size = new System.Drawing.Size(114, 30);
            this.ExpireDate.TabIndex = 66;
            this.ExpireDate.Text = "Wednesday, June 7, 2023";
            this.ExpireDate.Value = new System.DateTime(2023, 6, 7, 11, 11, 33, 826);
            this.ExpireDate.ValueChanged += new System.EventHandler(this.gunaDateTimePicker1_ValueChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 185);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 16);
            this.gunaLabel3.TabIndex = 58;
            this.gunaLabel3.Text = "Expire Date";
            // 
            // Quantity
            // 
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quantity.HintForeColor = System.Drawing.Color.Empty;
            this.Quantity.HintText = "";
            this.Quantity.isPassword = false;
            this.Quantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.Quantity.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.Quantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Quantity.LineThickness = 3;
            this.Quantity.Location = new System.Drawing.Point(153, 272);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(126, 44);
            this.Quantity.TabIndex = 56;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MedicineName
            // 
            this.MedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicineName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineName.HintForeColor = System.Drawing.Color.Empty;
            this.MedicineName.HintText = "";
            this.MedicineName.isPassword = false;
            this.MedicineName.LineFocusedColor = System.Drawing.Color.Blue;
            this.MedicineName.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.MedicineName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MedicineName.LineThickness = 3;
            this.MedicineName.Location = new System.Drawing.Point(15, 115);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(102, 44);
            this.MedicineName.TabIndex = 5;
            this.MedicineName.Text = "Name";
            this.MedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MedicineName.OnValueChanged += new System.EventHandler(this.MedicineName_OnValueChanged);
            // 
            // SellingPrice
            // 
            this.SellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.SellingPrice.HintText = "";
            this.SellingPrice.isPassword = false;
            this.SellingPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.SellingPrice.LineIdleColor = System.Drawing.Color.LawnGreen;
            this.SellingPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.SellingPrice.LineThickness = 3;
            this.SellingPrice.Location = new System.Drawing.Point(153, 192);
            this.SellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(126, 44);
            this.SellingPrice.TabIndex = 49;
            this.SellingPrice.Text = "Selling Price";
            this.SellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(13, 238);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(173, 42);
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
            this.gunaGradientButton2.Location = new System.Drawing.Point(13, 286);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(175, 42);
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
            this.gunaGradientButton3.Location = new System.Drawing.Point(13, 334);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(175, 42);
            this.gunaGradientButton3.TabIndex = 3;
            this.gunaGradientButton3.Text = "DELETE";
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(31, 17);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(138, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "New Medicine";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Location = new System.Drawing.Point(13, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 55);
            this.panel1.TabIndex = 1;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 453);
            this.flowLayoutPanel1.TabIndex = 60;
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
            this.gunaImageButton2.Size = new System.Drawing.Size(169, 158);
            this.gunaImageButton2.TabIndex = 12;
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
            this.gunaGradientButton4.Location = new System.Drawing.Point(13, 382);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.BurlyWood;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(175, 42);
            this.gunaGradientButton4.TabIndex = 4;
            this.gunaGradientButton4.Text = "BACK";
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(587, 435);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 63;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // MedicineFormRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineFormRef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineFormRef";
            this.Load += new System.EventHandler(this.MedicineFormRef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BuyingPrice;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedicineName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellingPrice;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Quantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private Guna.UI.WinForms.GunaDateTimePicker ExpireDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox companycb;
    }
}