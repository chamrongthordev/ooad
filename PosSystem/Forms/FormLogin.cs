using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosSystem.Services;
using PosSystem.Utils;

namespace PosSystem.Forms
{
    public partial class FormLogin : Form
    {
        private FormMessageBoxInfo messageBoxInfo = new FormMessageBoxInfo();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var userService = UserService.getInstance();
            bool isValidCredencial = userService.UserRepository.ValidateLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (isValidCredencial)
            {
                Hide();
                new FormMain().Show();

                messageBoxInfo.SetInfo("ស្វា​គមន៍មកកា​ន់ ប្រព័ន្ធគ្រប់គ្រងកា​រលក់", "success");
                messageBoxInfo.Show();
            }
            else
            {
                txtUsername.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                txtUsername.Focus();

                messageBoxInfo.SetInfo("ព័ត៌មា​នមិនត្រឹមត្រូវ", "danger");
                messageBoxInfo.Show();
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Cursor = Cursors.Hand;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
