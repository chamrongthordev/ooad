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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.panelChartTracking = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
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
            this.panelMain.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelLeftSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChartTracking
            // 
            this.panelChartTracking.Controls.Add(this.panelView);
            this.panelChartTracking.Controls.Add(this.panelSearch);
            this.panelChartTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTracking.Location = new System.Drawing.Point(0, 0);
            this.panelChartTracking.Name = "panelChartTracking";
            this.panelChartTracking.Size = new System.Drawing.Size(1319, 822);
            this.panelChartTracking.TabIndex = 1;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelView.Location = new System.Drawing.Point(0, 76);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(567, 746);
            this.panelView.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Gray;
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1319, 76);
            this.panelSearch.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelMain.Controls.Add(this.panelChartTracking);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(426, 136);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1319, 822);
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
            this.panelLogout.Location = new System.Drawing.Point(1056, 0);
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
            this.panelNavBar.Size = new System.Drawing.Size(1319, 136);
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
            this.ClientSize = new System.Drawing.Size(1745, 958);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelLeftSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelChartTracking.ResumeLayout(false);
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
    }
}