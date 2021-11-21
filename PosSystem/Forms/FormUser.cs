using PosSystem.Models;
using PosSystem.Services;
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
    public partial class FormUser : Form
    {
        private UserService _userService;
        public FormUser()
        {
            InitializeComponent();
            _userService = UserService.getInstance();
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.Cursor = Cursors.Hand;
        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnStock.Cursor = Cursors.Hand;
        }

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            btnSale.Cursor = Cursors.Hand;
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            btnReport.Cursor = Cursors.Hand;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin().Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.BackColor = Color.ForestGreen;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            comboSearchBy.SelectedIndex = 0;
            comboGender.SelectedIndex = 0;
            comboxRole.SelectedIndex = 0;
            _GetAllUsers();
        }

        private void panelSearchBy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Cursor = Cursors.Hand;
        }

        // Get all users
        private void _GetAllUsers()
        {
            dgvUser.Rows.Clear();
            List<User> users = _userService.UserRepository.GetUsers();
            foreach (User user in users)
            {
                Image picture = Image.FromFile(user._Image.ToString());
                string username = user._Username.ToString();
                string lastName = user._LastName.ToString();
                string firstName = user._FirstName.ToString();
                string gender = user._Gender.ToString();
                string role = user._Role.ToLower();

                dgvUser.Rows.Add(picture, username, lastName, firstName, gender, role);
            }
        }

        // filter by Users
        private void _FilterUserLogins()
        {
            List<User> users = _userService.UserRepository.FilterUsers("[User_Username]", txtSearchBox.Text);
            dgvUser.Rows.Clear();
            foreach (User user in users)
            {
                Image picture = Image.FromFile(user._Image.ToString());
                string username = user._Username.ToString();
                string lastName = user._LastName.ToString();
                string firstName = user._FirstName.ToString();
                string gender = user._Gender.ToString();
                string role = user._Role.ToLower();

                dgvUser.Rows.Add(picture, username, lastName, firstName, gender, role);
            }
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            _FilterUserLogins();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image File(*.jpg, *png) | *.png; *.jpg";
                DialogResult result = openFileDialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    int row = e.RowIndex;
                    dgvUser.Rows[row].Cells[0].Value = image;
                }
            }
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg, *png) | *.png; *.jpg";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBoxProfile.Image = image;
            }
        }
    }
}
