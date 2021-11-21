namespace PosSystem.Forms
{
    partial class FormUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.PanelBtnLoadStockFormWrapper = new System.Windows.Forms.Panel();
            this.btnLoadStockForm = new System.Windows.Forms.Button();
            this.lblMainTopTitle = new System.Windows.Forms.Label();
            this.panelChartTracking = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.dgvImageUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelSearchBy = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelLeftSidebar = new System.Windows.Forms.Panel();
            this.PanelBtnLoadStockFormWrapper.SuspendLayout();
            this.panelChartTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panelMainTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelSearchBy.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelLeftSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBtnLoadStockFormWrapper
            // 
            this.PanelBtnLoadStockFormWrapper.Controls.Add(this.btnLoadStockForm);
            this.PanelBtnLoadStockFormWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelBtnLoadStockFormWrapper.Location = new System.Drawing.Point(564, 0);
            this.PanelBtnLoadStockFormWrapper.Name = "PanelBtnLoadStockFormWrapper";
            this.PanelBtnLoadStockFormWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 20, 40);
            this.PanelBtnLoadStockFormWrapper.Size = new System.Drawing.Size(322, 152);
            this.PanelBtnLoadStockFormWrapper.TabIndex = 2;
            // 
            // btnLoadStockForm
            // 
            this.btnLoadStockForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(114)))), ((int)(((byte)(215)))));
            this.btnLoadStockForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadStockForm.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadStockForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoadStockForm.Location = new System.Drawing.Point(23, 40);
            this.btnLoadStockForm.Name = "btnLoadStockForm";
            this.btnLoadStockForm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLoadStockForm.Size = new System.Drawing.Size(279, 72);
            this.btnLoadStockForm.TabIndex = 2;
            this.btnLoadStockForm.Text = "+ បន្ថែមអ្នកប្រើប្រា​ស់";
            this.btnLoadStockForm.UseVisualStyleBackColor = false;
            this.btnLoadStockForm.MouseHover += new System.EventHandler(this.btnLoadStockForm_MouseHover);
            // 
            // lblMainTopTitle
            // 
            this.lblMainTopTitle.AutoSize = true;
            this.lblMainTopTitle.Font = new System.Drawing.Font("Battambang", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainTopTitle.Location = new System.Drawing.Point(49, 40);
            this.lblMainTopTitle.Name = "lblMainTopTitle";
            this.lblMainTopTitle.Size = new System.Drawing.Size(225, 68);
            this.lblMainTopTitle.TabIndex = 0;
            this.lblMainTopTitle.Text = "អ្នកប្រើប្រា​ស់";
            // 
            // panelChartTracking
            // 
            this.panelChartTracking.Controls.Add(this.dgvUser);
            this.panelChartTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTracking.Location = new System.Drawing.Point(0, 152);
            this.panelChartTracking.Name = "panelChartTracking";
            this.panelChartTracking.Size = new System.Drawing.Size(886, 670);
            this.panelChartTracking.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvImageUser,
            this.Username,
            this.LastName,
            this.FirstName,
            this.Gender,
            this.Role,
            this.dgvBtnDelete,
            this.dgvBtnUpdate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Battambang", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(886, 670);
            this.dgvUser.TabIndex = 0;
            // 
            // dgvImageUser
            // 
            this.dgvImageUser.HeaderText = "រូបភា​ព";
            this.dgvImageUser.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvImageUser.MinimumWidth = 6;
            this.dgvImageUser.Name = "dgvImageUser";
            this.dgvImageUser.ReadOnly = true;
            this.dgvImageUser.Width = 120;
            // 
            // Username
            // 
            this.Username.HeaderText = "គណនេយ្យ";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "នា​មត្រកូល";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "នា​មខ្លួន";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "ភេទ";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // Role
            // 
            this.Role.HeaderText = "តួរនា​ទី";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 125;
            // 
            // dgvBtnDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Battambang", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBtnDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBtnDelete.HeaderText = "ប្រតិបត្តិ";
            this.dgvBtnDelete.MinimumWidth = 6;
            this.dgvBtnDelete.Name = "dgvBtnDelete";
            this.dgvBtnDelete.ReadOnly = true;
            this.dgvBtnDelete.Text = "លុប";
            this.dgvBtnDelete.ToolTipText = "ប្រើប្រាស់សម្រាប់លុបទិន្នន័យ";
            this.dgvBtnDelete.Width = 125;
            // 
            // dgvBtnUpdate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Battambang", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvBtnUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBtnUpdate.HeaderText = "ប្រតិបត្តិ";
            this.dgvBtnUpdate.MinimumWidth = 6;
            this.dgvBtnUpdate.Name = "dgvBtnUpdate";
            this.dgvBtnUpdate.ReadOnly = true;
            this.dgvBtnUpdate.Text = "កែប្រែ";
            this.dgvBtnUpdate.ToolTipText = "ប្រើប្រាស់សម្រាប់កែប្រែទិន្នន័យ";
            this.dgvBtnUpdate.Width = 125;
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.White;
            this.panelMainTitle.Controls.Add(this.PanelBtnLoadStockFormWrapper);
            this.panelMainTitle.Controls.Add(this.lblMainTopTitle);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(886, 152);
            this.panelMainTitle.TabIndex = 0;
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
            this.panelMain.Size = new System.Drawing.Size(886, 822);
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
            this.panelLogout.Location = new System.Drawing.Point(623, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogout.Size = new System.Drawing.Size(261, 134);
            this.panelLogout.TabIndex = 0;
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
            this.panelNavBar.Size = new System.Drawing.Size(886, 136);
            this.panelNavBar.TabIndex = 4;
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
            this.panelSearchBy.Size = new System.Drawing.Size(623, 134);
            this.panelSearchBy.TabIndex = 1;
            this.panelSearchBy.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearchBy_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(451, 46);
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
            this.txtSearchBox.Location = new System.Drawing.Point(289, 46);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(156, 44);
            this.txtSearchBox.TabIndex = 2;
            this.txtSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyUp);
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
            "គណនេយ្យ",
            "នា​​មត្រកូល",
            "នា​​ម​ខ្លួន"});
            this.comboSearchBy.Location = new System.Drawing.Point(141, 49);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.Size = new System.Drawing.Size(142, 39);
            this.comboSearchBy.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBy.ForeColor = System.Drawing.Color.White;
            this.lblSearchBy.Location = new System.Drawing.Point(5, 55);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(130, 31);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "ស្វែងរកតា​មរយៈ";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 439);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(424, 76);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "របា​យកា​រណ៍";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.MouseHover += new System.EventHandler(this.btnReport_MouseHover);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.DarkGreen;
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
            this.btnSale.MouseHover += new System.EventHandler(this.btnSale_MouseHover);
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
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
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
            this.lblLogo.Size = new System.Drawing.Size(293, 67);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ប្រព័ន្ធគ្រប់គ្រងកា​រលក់";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeftSidebar
            // 
            this.panelLeftSidebar.BackColor = System.Drawing.Color.White;
            this.panelLeftSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftSidebar.Controls.Add(this.btnReport);
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
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1312, 958);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelLeftSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.PanelBtnLoadStockFormWrapper.ResumeLayout(false);
            this.panelChartTracking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelNavBar.ResumeLayout(false);
            this.panelSearchBy.ResumeLayout(false);
            this.panelSearchBy.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelLeftSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelBtnLoadStockFormWrapper;
        private Button btnLoadStockForm;
        private Label lblMainTopTitle;
        private Panel panelChartTracking;
        private Panel panelMainTitle;
        private Panel panelMain;
        private Button btnLogout;
        private Panel panelLogout;
        private Panel panelNavBar;
        private Button btnReport;
        private Button btnUser;
        private Button btnSale;
        private Button btnStock;
        private Button btnDashboard;
        private Panel panelLogo;
        private Label lblLogo;
        private Panel panelLeftSidebar;
        private DataGridView dgvUser;
        private DataGridViewImageColumn dgvImageUser;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewButtonColumn dgvBtnDelete;
        private DataGridViewButtonColumn dgvBtnUpdate;
        private Panel panelSearchBy;
        private Label lblSearchBy;
        private ComboBox comboSearchBy;
        private TextBox txtSearchBox;
        private Button btnSearch;
    }
}