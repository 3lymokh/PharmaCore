using System;
using System.Linq;
using System.Windows.Forms;
namespace PharmaCore
{
    public partial class SuppliersForm : Form
    {
        public SuppliersForm(string username)
        {
            InitializeComponent();
            lblAdmin.Text = username;
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = AppData.Suppliers.ToList();
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Enter a supplier name.");
                txtSupplierName.Focus();
                return;
            }
            AppData.Suppliers.Add(new Supplier
            {
                Id = AppData.NextSupplierId(),
                Name = txtSupplierName.Text.Trim(),
                Company = txtCompany.Text.Trim(),
                Phone = txtSupplierPhone.Text.Trim()
            });
            txtSupplierName.Clear();
            txtCompany.Clear();
            txtSupplierPhone.Clear();
            LoadSuppliers();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null) return;
            Supplier supplier = dgvSuppliers.CurrentRow.DataBoundItem as Supplier;
            if (supplier != null)
            {
                AppData.Suppliers.Remove(supplier);
                LoadSuppliers();
            }
        }
    }
}