namespace PosSystem.Forms
{
    partial class FormSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.panelChartTracking = new System.Windows.Forms.Panel();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtAmountPrice = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDiscountPrice = new System.Windows.Forms.TextBox();
            this.comboDiscountBy = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panelCart = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelLeftSidebar = new System.Windows.Forms.Panel();
            this.panelChartTracking.SuspendLayout();
            this.panelCheckout.SuspendLayout();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelLeftSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChartTracking
            // 
            this.panelChartTracking.Controls.Add(this.panelCheckout);
            this.panelChartTracking.Controls.Add(this.panelCart);
            this.panelChartTracking.Controls.Add(this.panelView);
            this.panelChartTracking.Controls.Add(this.panelSearch);
            this.panelChartTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTracking.Location = new System.Drawing.Point(0, 0);
            this.panelChartTracking.Name = "panelChartTracking";
            this.panelChartTracking.Size = new System.Drawing.Size(1371, 822);
            this.panelChartTracking.TabIndex = 1;
            // 
            // panelCheckout
            // 
            this.panelCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCheckout.Controls.Add(this.btnCheckout);
            this.panelCheckout.Controls.Add(this.txtAmountPrice);
            this.panelCheckout.Controls.Add(this.lblAmount);
            this.panelCheckout.Controls.Add(this.txtDiscountPrice);
            this.panelCheckout.Controls.Add(this.comboDiscountBy);
            this.panelCheckout.Controls.Add(this.txtTotalPrice);
            this.panelCheckout.Controls.Add(this.lblDiscountAmount);
            this.panelCheckout.Controls.Add(this.lblDiscount);
            this.panelCheckout.Controls.Add(this.lblTotalPrice);
            this.panelCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCheckout.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelCheckout.Location = new System.Drawing.Point(487, 419);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(884, 403);
            this.panelCheckout.TabIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Black;
            this.btnCheckout.Font = new System.Drawing.Font("Kh Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.Location = new System.Drawing.Point(222, 250);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(282, 86);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "គិតថ្លៃ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.MouseHover += new System.EventHandler(this.btnCheckout_MouseHover);
            // 
            // txtAmountPrice
            // 
            this.txtAmountPrice.Enabled = false;
            this.txtAmountPrice.Location = new System.Drawing.Point(222, 188);
            this.txtAmountPrice.Name = "txtAmountPrice";
            this.txtAmountPrice.Size = new System.Drawing.Size(282, 45);
            this.txtAmountPrice.TabIndex = 7;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(11, 197);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(186, 36);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "ថ្លៃផលិតផលទាំងអស់";
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.Location = new System.Drawing.Point(222, 137);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.Size = new System.Drawing.Size(282, 45);
            this.txtDiscountPrice.TabIndex = 5;
            // 
            // comboDiscountBy
            // 
            this.comboDiscountBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDiscountBy.FormattingEnabled = true;
            this.comboDiscountBy.Items.AddRange(new object[] {
            "ភាគរយ",
            "តម្លៃថេរ"});
            this.comboDiscountBy.Location = new System.Drawing.Point(222, 87);
            this.comboDiscountBy.Name = "comboDiscountBy";
            this.comboDiscountBy.Size = new System.Drawing.Size(282, 44);
            this.comboDiscountBy.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(222, 36);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(282, 45);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscountAmount.Location = new System.Drawing.Point(104, 146);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(93, 36);
            this.lblDiscountAmount.TabIndex = 2;
            this.lblDiscountAmount.Text = "បញ្ចុះតម្លៃ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscount.Location = new System.Drawing.Point(34, 95);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(163, 36);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "បញ្ចុះតម្លៃតាមរយៈ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPrice.Location = new System.Drawing.Point(108, 39);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(89, 36);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "តម្លៃពេញ";
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCart.Controls.Add(this.dgvCart);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCart.Location = new System.Drawing.Point(487, 119);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(884, 300);
            this.panelCart.TabIndex = 2;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductName,
            this.dgvProductBarcode,
            this.dgvProductQuantity,
            this.dgvProductPrice});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCart.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCart.RowTemplate.Height = 29;
            this.dgvCart.Size = new System.Drawing.Size(884, 300);
            this.dgvCart.TabIndex = 0;
            // 
            // dgvProductName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kh Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvProductName.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductName.HeaderText = "ឈ្មោះផលិតផល";
            this.dgvProductName.MinimumWidth = 6;
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            this.dgvProductName.Width = 200;
            // 
            // dgvProductBarcode
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvProductBarcode.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductBarcode.HeaderText = "លេខ barcode";
            this.dgvProductBarcode.MinimumWidth = 6;
            this.dgvProductBarcode.Name = "dgvProductBarcode";
            this.dgvProductBarcode.ReadOnly = true;
            this.dgvProductBarcode.Width = 200;
            // 
            // dgvProductQuantity
            // 
            this.dgvProductQuantity.HeaderText = "ចំនួនផលិតផល";
            this.dgvProductQuantity.MinimumWidth = 6;
            this.dgvProductQuantity.Name = "dgvProductQuantity";
            this.dgvProductQuantity.ReadOnly = true;
            this.dgvProductQuantity.Width = 200;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.HeaderText = "តម្លៃ";
            this.dgvProductPrice.MinimumWidth = 6;
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            this.dgvProductPrice.Width = 200;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.Silver;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelView.Location = new System.Drawing.Point(0, 119);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(487, 703);
            this.panelView.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Gray;
            this.panelSearch.Controls.Add(this.txtSearchTerm);
            this.panelSearch.Controls.Add(this.lblSearchBy);
            this.panelSearch.Controls.Add(this.comboSearchBy);
            this.panelSearch.Controls.Add(this.lblSearchProduct);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1371, 119);
            this.panelSearch.TabIndex = 0;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTerm.Location = new System.Drawing.Point(757, 31);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(380, 45);
            this.txtSearchTerm.TabIndex = 3;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchBy.Location = new System.Drawing.Point(70, 35);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(172, 41);
            this.lblSearchBy.TabIndex = 2;
            this.lblSearchBy.Text = "ស្វែងរកតាមរយៈ";
            // 
            // comboSearchBy
            // 
            this.comboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchBy.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboSearchBy.FormattingEnabled = true;
            this.comboSearchBy.Items.AddRange(new object[] {
            "ឈ្មោះផលិតផល",
            "លេខ Barcode"});
            this.comboSearchBy.Location = new System.Drawing.Point(257, 32);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.Size = new System.Drawing.Size(293, 44);
            this.comboSearchBy.TabIndex = 1;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchProduct.Location = new System.Drawing.Point(556, 35);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(186, 41);
            this.lblSearchProduct.TabIndex = 0;
            this.lblSearchProduct.Text = "ស្វែងរកផលិតផល";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelMain.Controls.Add(this.panelChartTracking);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(426, 136);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1371, 822);
            this.panelMain.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(253, 124);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "ចា​កចេញ";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.Color.Transparent;
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogout.Location = new System.Drawing.Point(1108, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogout.Size = new System.Drawing.Size(261, 134);
            this.panelLogout.TabIndex = 0;
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.panelNavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavBar.Controls.Add(this.panelLogout);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(426, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(1371, 136);
            this.panelNavBar.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Black;
            this.lblLogo.Font = new System.Drawing.Font("Battambang", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(52, 35);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblLogo.Size = new System.Drawing.Size(331, 74);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ប្រព័ន្ធគ្រប់គ្រងកា​រលក់";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 363);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(424, 76);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "អ្នកប្រើប្រា​ស់";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseHover += new System.EventHandler(this.btnUser_MouseHover);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 287);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSale.Size = new System.Drawing.Size(424, 76);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = " កា​រលក់";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 211);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(424, 76);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "ស្តុក";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 135);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(424, 76);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "ផ្ទាំ ងគ្រប់គ្រងទិន្នន័យ";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseHover += new System.EventHandler(this.btnDashboard_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(424, 135);
            this.panelLogo.TabIndex = 0;
            // 
            // panelLeftSidebar
            // 
            this.panelLeftSidebar.BackColor = System.Drawing.Color.White;
            this.panelLeftSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftSidebar.Controls.Add(this.btnUser);
            this.panelLeftSidebar.Controls.Add(this.btnSale);
            this.panelLeftSidebar.Controls.Add(this.btnStock);
            this.panelLeftSidebar.Controls.Add(this.btnDashboard);
            this.panelLeftSidebar.Controls.Add(this.panelLogo);
            this.panelLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeftSidebar.Name = "panelLeftSidebar";
            this.panelLeftSidebar.Size = new System.Drawing.Size(426, 958);
            this.panelLeftSidebar.TabIndex = 3;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 958);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelLeftSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.panelChartTracking.ResumeLayout(false);
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.panelCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelLeftSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelChartTracking;
        private Panel panelMain;
        private Button btnLogout;
        private Panel panelLogout;
        private Panel panelNavBar;
        private Label lblLogo;
        private Button btnUser;
        private Button btnSale;
        private Button btnStock;
        private Button btnDashboard;
        private Panel panelLogo;
        private Panel panelLeftSidebar;
        private Panel panelSearch;
        private Panel panelView;
        private Panel panelCart;
        private Panel panelCheckout;
        private Label lblSearchProduct;
        private Label lblSearchBy;
        private ComboBox comboSearchBy;
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn dgvProductName;
        private DataGridViewTextBoxColumn dgvProductBarcode;
        private DataGridViewTextBoxColumn dgvProductQuantity;
        private DataGridViewTextBoxColumn dgvProductPrice;
        private Label lblTotalPrice;
        private Label lblDiscount;
        private Label lblDiscountAmount;
        private TextBox txtTotalPrice;
        private TextBox txtDiscountPrice;
        private ComboBox comboDiscountBy;
        private TextBox txtAmountPrice;
        private Label lblAmount;
        private Button btnCheckout;
        private TextBox txtSearchTerm;
    }
}