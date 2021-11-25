using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem.Forms
{
    public partial class FormStock : Form
    {
        string fileSavePath = @"Image\no-image.png";
        public FormStock()
        {
            InitializeComponent();
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.Cursor = Cursors.Hand;
        }

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            btnSale.Cursor = Cursors.Hand;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMain().Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Hide();
            new FormUser().Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor = Cursors.Hand;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin().Show();
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Cursor = Cursors.Hand;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.Cursor = Cursors.Hand;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.Cursor = Cursors.Hand;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductBarcode.Text = "";
            txtProductPrice.Text = "";
            txtProductQuantity.Text = "";
            pictureBoxProfile.Image = Image.FromFile(fileSavePath);
        }
    }
}
