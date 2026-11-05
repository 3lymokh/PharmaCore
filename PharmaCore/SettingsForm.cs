using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void lblMedicines_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != AppData.DemoPassword)
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                txtNewPassword.Text.Length < 4)
            {
                MessageBox.Show("Choose a password with at least 4 characters.");
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password confirmation does not match.");
                return;
            }

            AppData.DemoPassword = txtNewPassword.Text;

            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            MessageBox.Show("Password changed for this session only.");
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
