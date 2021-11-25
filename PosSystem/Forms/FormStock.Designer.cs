namespace PosSystem.Forms
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.lblMainTopTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelChartTracking = new System.Windows.Forms.Panel();
            this.panelDataManagement = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.dgvImageProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelManipulator = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductBarcode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelSearchBy = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.panelLeftSidebar = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelMainTitle.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelChartTracking.SuspendLayout();
            this.panelDataManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panelManipulator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.panelSearchBy.SuspendLayout();
            this.panelLeftSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.White;
            this.panelMainTitle.Controls.Add(this.lblMainTopTitle);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(1319, 152);
            this.panelMainTitle.TabIndex = 0;
            // 
            // lblMainTopTitle
            // 
            this.lblMainTopTitle.AutoSize = true;
            this.lblMainTopTitle.Font = new System.Drawing.Font("Battambang", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainTopTitle.Location = new System.Drawing.Point(49, 40);
            this.lblMainTopTitle.Name = "lblMainTopTitle";
            this.lblMainTopTitle.Size = new System.Drawing.Size(339, 77);
            this.lblMainTopTitle.TabIndex = 0;
            this.lblMainTopTitle.Text = "ផលិតផលក្នុងស្តុក";
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
            this.panelLogout.Location = new System.Drawing.Point(1056, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogout.Size = new System.Drawing.Size(261, 134);
            this.panelLogout.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelMain.Controls.Add(this.panelChartTracking);
            this.panelMain.Controls.Add(this.panelMainTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(426, 136);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1319, 822);
            this.panelMain.TabIndex = 8;
            // 
            // panelChartTracking
            // 
            this.panelChartTracking.Controls.Add(this.panelDataManagement);
            this.panelChartTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTracking.Location = new System.Drawing.Point(0, 152);
            this.panelChartTracking.Name = "panelChartTracking";
            this.panelChartTracking.Size = new System.Drawing.Size(1319, 670);
            this.panelChartTracking.TabIndex = 1;
            // 
            // panelDataManagement
            // 
            this.panelDataManagement.BackColor = System.Drawing.Color.Silver;
            this.panelDataManagement.Controls.Add(this.dgvUser);
            this.panelDataManagement.Controls.Add(this.panelManipulator);
            this.panelDataManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataManagement.Location = new System.Drawing.Point(0, 0);
            this.panelDataManagement.Name = "panelDataManagement";
            this.panelDataManagement.Size = new System.Drawing.Size(1319, 670);
            this.panelDataManagement.TabIndex = 0;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvImageProduct,
            this.dgvProductName,
            this.dgvProductBarcode,
            this.dgvProductPrice,
            this.dgvProductQuantity});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUser.Location = new System.Drawing.Point(515, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(804, 670);
            this.dgvUser.TabIndex = 10;
            // 
            // dgvImageProduct
            // 
            this.dgvImageProduct.HeaderText = "រូបភា​ព";
            this.dgvImageProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvImageProduct.MinimumWidth = 6;
            this.dgvImageProduct.Name = "dgvImageProduct";
            this.dgvImageProduct.ReadOnly = true;
            this.dgvImageProduct.Width = 120;
            // 
            // dgvProductName
            // 
            this.dgvProductName.HeaderText = "ឈ្មោះផលិតផល";
            this.dgvProductName.MinimumWidth = 6;
            this.dgvProductName.Name = "dgvProductName";
            this.dgvProductName.ReadOnly = true;
            this.dgvProductName.Width = 125;
            // 
            // dgvProductBarcode
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductBarcode.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductBarcode.HeaderText = "លេខ Barcode";
            this.dgvProductBarcode.MinimumWidth = 6;
            this.dgvProductBarcode.Name = "dgvProductBarcode";
            this.dgvProductBarcode.ReadOnly = true;
            this.dgvProductBarcode.Width = 225;
            // 
            // dgvProductPrice
            // 
            this.dgvProductPrice.HeaderText = "តម្លៃ";
            this.dgvProductPrice.MinimumWidth = 6;
            this.dgvProductPrice.Name = "dgvProductPrice";
            this.dgvProductPrice.ReadOnly = true;
            this.dgvProductPrice.Width = 125;
            // 
            // dgvProductQuantity
            // 
            this.dgvProductQuantity.HeaderText = "ចំនួនផលិតផល";
            this.dgvProductQuantity.MinimumWidth = 6;
            this.dgvProductQuantity.Name = "dgvProductQuantity";
            this.dgvProductQuantity.ReadOnly = true;
            this.dgvProductQuantity.Width = 125;
            // 
            // panelManipulator
            // 
            this.panelManipulator.AutoScroll = true;
            this.panelManipulator.BackColor = System.Drawing.Color.DimGray;
            this.panelManipulator.Controls.Add(this.btnClear);
            this.panelManipulator.Controls.Add(this.txtProductQuantity);
            this.panelManipulator.Controls.Add(this.lblProductQuantity);
            this.panelManipulator.Controls.Add(this.btnAdd);
            this.panelManipulator.Controls.Add(this.btnUpdate);
            this.panelManipulator.Controls.Add(this.btnDelete);
            this.panelManipulator.Controls.Add(this.pictureBoxProfile);
            this.panelManipulator.Controls.Add(this.txtProductPrice);
            this.panelManipulator.Controls.Add(this.txtProductBarcode);
            this.panelManipulator.Controls.Add(this.txtProductName);
            this.panelManipulator.Controls.Add(this.lblPrice);
            this.panelManipulator.Controls.Add(this.lblProductBarcode);
            this.panelManipulator.Controls.Add(this.lblProductName);
            this.panelManipulator.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManipulator.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelManipulator.Location = new System.Drawing.Point(0, 0);
            this.panelManipulator.Name = "panelManipulator";
            this.panelManipulator.Size = new System.Drawing.Size(515, 670);
            this.panelManipulator.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(36, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 53);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "ជម្រះ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductQuantity.Location = new System.Drawing.Point(181, 160);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '*';
            this.txtProductQuantity.Size = new System.Drawing.Size(179, 38);
            this.txtProductQuantity.TabIndex = 15;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductQuantity.Location = new System.Drawing.Point(22, 158);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(120, 31);
            this.lblProductQuantity.TabIndex = 14;
            this.lblProductQuantity.Text = "ចំនួនផលិតផល";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(114)))), ((int)(((byte)(215)))));
            this.btnAdd.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(36, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(261, 62);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "បញ្ចូល";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(303, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 53);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "កែប្រែ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(303, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 53);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(181, 218);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(203, 125);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductPrice.Location = new System.Drawing.Point(181, 116);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(179, 38);
            this.txtProductPrice.TabIndex = 5;
            // 
            // txtProductBarcode
            // 
            this.txtProductBarcode.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductBarcode.Location = new System.Drawing.Point(181, 72);
            this.txtProductBarcode.Name = "txtProductBarcode";
            this.txtProductBarcode.Size = new System.Drawing.Size(179, 38);
            this.txtProductBarcode.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductName.Location = new System.Drawing.Point(181, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(179, 38);
            this.txtProductName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(22, 114);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 31);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "តម្លៃ";
            // 
            // lblProductBarcode
            // 
            this.lblProductBarcode.AutoSize = true;
            this.lblProductBarcode.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductBarcode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductBarcode.Location = new System.Drawing.Point(22, 72);
            this.lblProductBarcode.Name = "lblProductBarcode";
            this.lblProductBarcode.Size = new System.Drawing.Size(128, 31);
            this.lblProductBarcode.TabIndex = 1;
            this.lblProductBarcode.Text = "លេខ Barcode";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.Location = new System.Drawing.Point(22, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(127, 31);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ឈ្មោះផលិតផល";
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.panelNavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavBar.Controls.Add(this.panelSearchBy);
            this.panelNavBar.Controls.Add(this.panelLogout);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(426, 0);
            this.panelNavBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(1319, 136);
            this.panelNavBar.TabIndex = 7;
            // 
            // panelSearchBy
            // 
            this.panelSearchBy.Controls.Add(this.btnSearch);
            this.panelSearchBy.Controls.Add(this.txtSearchBox);
            this.panelSearchBy.Controls.Add(this.comboSearchBy);
            this.panelSearchBy.Controls.Add(this.lblSearchBy);
            this.panelSearchBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchBy.Location = new System.Drawing.Point(0, 0);
            this.panelSearchBy.Name = "panelSearchBy";
            this.panelSearchBy.Size = new System.Drawing.Size(1056, 134);
            this.panelSearchBy.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(527, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchBox.Location = new System.Drawing.Point(365, 44);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(156, 44);
            this.txtSearchBox.TabIndex = 2;
            // 
            // comboSearchBy
            // 
            this.comboSearchBy.AutoCompleteCustomSource.AddRange(new string[] {
            "Username",
            "First Name",
            "Last Name"});
            this.comboSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchBy.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboSearchBy.FormattingEnabled = true;
            this.comboSearchBy.Items.AddRange(new object[] {
            "ឈ្មោះផលិតផល",
            "Barcode"});
            this.comboSearchBy.Location = new System.Drawing.Point(217, 47);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.Size = new System.Drawing.Size(142, 44);
            this.comboSearchBy.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBy.ForeColor = System.Drawing.Color.White;
            this.lblSearchBy.Location = new System.Drawing.Point(5, 55);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(149, 36);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "ស្វែងរកតា​មរយៈ";
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
            this.panelLeftSidebar.TabIndex = 6;
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
            this.btnSale.MouseHover += new System.EventHandler(this.btnSale_MouseHover);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkGreen;
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
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
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
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 958);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelLeftSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            this.panelLogout.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelChartTracking.ResumeLayout(false);
            this.panelDataManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panelManipulator.ResumeLayout(false);
            this.panelManipulator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.panelSearchBy.ResumeLayout(false);
            this.panelSearchBy.PerformLayout();
            this.panelLeftSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMainTitle;
        private Label lblMainTopTitle;
        private Button btnLogout;
        private Panel panelLogout;
        private Panel panelMain;
        private Panel panelChartTracking;
        private Panel panelDataManagement;
        private DataGridView dgvUser;
        private Panel panelManipulator;
        private Button btnClear;
        private TextBox txtProductQuantity;
        private Label lblProductQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBoxProfile;
        private TextBox txtProductPrice;
        private TextBox txtProductBarcode;
        private TextBox txtProductName;
        private Label lblPrice;
        private Label lblProductBarcode;
        private Label lblProductName;
        private Panel panelNavBar;
        private Panel panelSearchBy;
        private Button btnSearch;
        private TextBox txtSearchBox;
        private ComboBox comboSearchBy;
        private Label lblSearchBy;
        private Panel panelLeftSidebar;
        private Button btnUser;
        private Button btnSale;
        private Button btnStock;
        private Button btnDashboard;
        private Panel panelLogo;
        private Label lblLogo;
        private DataGridViewImageColumn dgvImageProduct;
        private DataGridViewTextBoxColumn dgvProductName;
        private DataGridViewTextBoxColumn dgvProductBarcode;
        private DataGridViewTextBoxColumn dgvProductPrice;
        private DataGridViewTextBoxColumn dgvProductQuantity;
    }
}