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

namespace PosSystem.Forms
{
    public partial class FormLogin : Form
    {
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
                MessageBox.Show("You're login successfully.");
                
                Hide();
                new FormMain().Show();
            }
            else
            {
                MessageBox.Show("Invalid Credencial!");
                txtUsername.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                txtUsername.Focus();
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
