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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor = Cursors.Hand;
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.Cursor = Cursors.Hand;
        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnStock.Cursor = Cursors.Hand;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUser.Cursor = Cursors.Hand;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMain().Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Hide();
            new FormStock().Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Hide();
            new FormUser().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Hide();
            new FormSale().Show();
        }
    }
}
