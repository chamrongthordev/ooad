﻿using PosSystem.Models;
using PosSystem.Services;
using System;
using System.Windows.Forms;
using PosSystem.Utils;
using System.Globalization;

namespace PosSystem.Forms
{
    public partial class FormUser : Form
    {
        private IUserService _userService;
        private string saveDirectory = @"Image\";
        string fileSavePath = @"Image\no-image.png";
 
        public FormUser()
        {
            InitializeComponent();
            _userService = IUserService.getInstance();
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
                Image picture;
                try
                {
                    picture = Image.FromFile(user._Image.ToString());
                }
                catch (Exception)
                {
                    picture = Image.FromFile(fileSavePath);
                }
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
                Image picture;
                try
                {
                    picture = Image.FromFile(user._Image.ToString());
                }
                catch (Exception)
                {
                    picture = Image.FromFile(fileSavePath);
                }

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

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.Cursor = Cursors.Hand;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
            
            if(txtUsername.Text == "")
            {

                formMessageBoxInfo.SetInfo("សូមបញ្ចូល គណនេយ្យ", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if (txtLastName.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូល នា​មត្រកូល", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if (txtFirstName.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូល នា​មខ្លួន", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if(txtPassword.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូល លេខសម្ងា​ត់", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else
            {
                // validate username
                List<User> users = _userService.UserRepository.FindUsername(txtUsername.Text);
                if (users.Count > 0)
                {
                    formMessageBoxInfo.SetInfo("គណនេយ្យនេះត្រូវបា​នប្រើប្រា​ស់រួចហើយ", "danger");
                    formMessageBoxInfo.ShowDialog();
                }
                else
                {

                    User user = new User();
                    user._FirstName = txtFirstName.Text;
                    user._LastName = txtLastName.Text;
                    user._Username = txtUsername.Text;
                    user._Password = Security.EncodePasswordToBase64(txtPassword.Text);
                    user._Gender = comboGender.Text;
                    user._Role = comboxRole.Text;
                    user._Image = fileSavePath;

                    _userService.UserRepository.Save(user);
                    _GetAllUsers();
                }
            }

        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg, *png) | *.png; *.jpg";
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                string prefix = new Random().Next(1, 1000).ToString() + DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-");
                string fileName =   prefix + Path.GetFileName(openFileDialog.FileName);
                fileSavePath = Path.Combine(saveDirectory, fileName);

                File.Copy(openFileDialog.FileName, fileSavePath, true);

                pictureBoxProfile.Image = Image.FromFile(fileSavePath);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
            if (txtUsername.Text == "")
            {

                formMessageBoxInfo.SetInfo("សូមជ្រើសរើសអ្នកប្រើប្រាស់ជាមុនសិននឹងធ្វើការកែប្រែ", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else
            {

            }
        }
    }
}
