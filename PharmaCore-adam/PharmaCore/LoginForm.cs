using System;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "admin" && password == AppData.DemoPassword)
            {
                lblError.Visible = false;
                Hide();
                using (DashboardForm dashboard = new DashboardForm(username))
                {
                    dashboard.ShowDialog();
                }
                txtPassword.Clear();
                Show();
                txtPassword.Focus();
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
