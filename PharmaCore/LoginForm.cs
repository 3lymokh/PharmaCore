using System;
using System.Windows.Forms;
using PharmaCare;

namespace PharmaCore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(txtUsername.Text.Trim(), "admin", StringComparison.OrdinalIgnoreCase)
                || txtPassword.Text != AppData.DemoPassword)
            {
                MessageBox.Show("Incorrect username or password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            txtPassword.Clear();
            chkShowPassword.Checked = false;
            Hide();

            using (DashboardForm dashboard = new DashboardForm())
            {
                dashboard.ShowDialog();
            }

            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
