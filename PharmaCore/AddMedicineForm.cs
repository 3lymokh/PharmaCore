using System;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class AddMedicineForm : Form
    {
        private readonly Medicine editingMedicine;

        public AddMedicineForm() : this(null) { }

        public AddMedicineForm(Medicine medicine)
        {
            InitializeComponent();
            editingMedicine = medicine;

            cmbCategory.Items.AddRange(new object[]
                { "Analgesics", "Antibiotics", "Vitamins", "General" });
            cmbSupplier.Items.AddRange(new object[]
                { "PharmaCorp", "MedLife", "HealthPlus", "Other" });

            if (editingMedicine != null) LoadExistingMedicine();
        }

        private void LoadExistingMedicine()
        {
            txtMedicineName.Text = editingMedicine.Name;
            cmbCategory.Text = editingMedicine.Category;
            txtBatchNumber.Text = editingMedicine.BatchNumber;
            nudQuantity.Value = Math.Max(nudQuantity.Minimum,
                Math.Min(nudQuantity.Maximum, editingMedicine.Quantity));
            nudUnitPrice.Value = Math.Max(nudUnitPrice.Minimum,
                Math.Min(nudUnitPrice.Maximum, editingMedicine.UnitPrice));
            dtpExpiryDate.Value = editingMedicine.ExpiryDate;
            cmbSupplier.Text = editingMedicine.Supplier;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("Enter a medicine name.", "Missing information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineName.Focus();
                return;
            }

            Medicine target = editingMedicine ?? new Medicine
            {
                Id = AppData.NextMedicineId()
            };

            target.Name = txtMedicineName.Text.Trim();
            target.Category = cmbCategory.Text.Trim().Length == 0 ? "General" : cmbCategory.Text;
            target.BatchNumber = txtBatchNumber.Text.Trim();
            target.Quantity = Decimal.ToInt32(nudQuantity.Value);
            target.UnitPrice = nudUnitPrice.Value;
            target.ExpiryDate = dtpExpiryDate.Value.Date;
            target.Supplier = cmbSupplier.Text.Trim();

            if (editingMedicine == null) AppData.Medicines.Add(target);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}