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

        private void btnLoadStockForm_MouseHover(object sender, EventArgs e)
        {
            btnLoadStockForm.Cursor = Cursors.Hand;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            comboSearchBy.SelectedIndex = 0;
            _GetAllUsers();
        }

        private void panelSearchBy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Cursor = Cursors.Hand;
        }

        //Get all users
        private void _GetAllUsers()
        {
            List<User> users = _userService.UserRepository.GetUsers();
            foreach (User user in users)
            {
                Image picture = Image.FromFile(user._Image.ToString());
                string username = user._Username.ToString();
                string lastName = user._LastName.ToString();
                string firstName = user._FirstName.ToString();
                string gender = user._Gender.ToString();
                string role = user._Role.ToLower();
                string btnDelete = "លុប";
                string btnUpdate = "កែប្រែ";

                dgvUser.Rows.Add(picture, username, lastName, firstName, gender, role, btnDelete, btnUpdate);
            }
        }
    }
}
