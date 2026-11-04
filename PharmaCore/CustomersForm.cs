using PharmaCare;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class CustomersForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = AppData.Customers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Enter a customer name.");
                txtCustomerName.Focus();
                return;
            }

            AppData.Customers.Add(new Customer
            {
                Id = AppData.NextCustomerId(),
                Name = txtCustomerName.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            });

            txtCustomerName.Clear();
            txtPhone.Clear();
            LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            Customer customer = dgvCustomers.CurrentRow.DataBoundItem as Customer;
            if (customer != null)
            {
                AppData.Customers.Remove(customer);
                LoadCustomers();
            }
        }

        private void cardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CustomersForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}