using System;
using System.Windows.Forms;
using PharamaCore;

namespace PharmaCore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            int selectionStart = txtPassword.SelectionStart;
            int selectionLength = txtPassword.SelectionLength;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnShowPassword.Text = txtPassword.UseSystemPasswordChar ? "Show" : "Hide";
            txtPassword.Focus();
            txtPassword.Select(selectionStart, selectionLength);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnShowPassword.Enabled = txtPassword.TextLength > 0;
            if (!btnShowPassword.Enabled)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPassword.Text = "Show";
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "admin" && password == AppData.DemoPassword)
            {
                lblError.Visible = false;
                Hide();
                using (DashboardForm dashboard = new DashboardForm())
                {
                    dashboard.ShowDialog();
                }
                Close();
                return;
            }

            lblError.Text = "Invalid username or password.";
            lblError.Visible = true;
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact the project administrator to reset the password.",
                "Password recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
