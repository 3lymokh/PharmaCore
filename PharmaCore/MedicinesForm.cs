using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class MedicinesForm : Form
    {
        public MedicinesForm()
        {
            InitializeComponent();
            dgvMedicines.ReadOnly = true;
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.MultiSelect = false;
            dgvMedicines.CellFormatting += dgvMedicines_CellFormatting;
            LoadMedicineData();
        }

        private void LoadMedicineData()
        {
            string query = txtSearchMedicine.Text.Trim().ToLowerInvariant();
            var rows = AppData.Medicines.Where(m =>
                m.Name.ToLowerInvariant().Contains(query) ||
                m.Category.ToLowerInvariant().Contains(query) ||
                m.BatchNumber.ToLowerInvariant().Contains(query)).ToList();

            dgvMedicines.DataSource = null;
            dgvMedicines.DataSource = rows;
            ApplyGridStyle();
        }

        private void ApplyGridStyle()
        {
            dgvMedicines.BackgroundColor = Color.White;
            dgvMedicines.BorderStyle = BorderStyle.None;
            dgvMedicines.RowHeadersVisible = false;
            dgvMedicines.EnableHeadersVisualStyles = false;
            dgvMedicines.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvMedicines.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMedicines.ColumnHeadersHeight = 36;
            dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicines.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);

            if (dgvMedicines.Columns.Contains("Id"))
                dgvMedicines.Columns["Id"].Visible = false;
            if (dgvMedicines.Columns.Contains("BatchNumber"))
                dgvMedicines.Columns["BatchNumber"].HeaderText = "Batch Number";
            if (dgvMedicines.Columns.Contains("UnitPrice"))
            {
                dgvMedicines.Columns["UnitPrice"].HeaderText = "Unit Price";
                dgvMedicines.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            }
            if (dgvMedicines.Columns.Contains("ExpiryDate"))
            {
                dgvMedicines.Columns["ExpiryDate"].HeaderText = "Expiry Date";
                dgvMedicines.Columns["ExpiryDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void dgvMedicines_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvMedicines.Columns[e.ColumnIndex].Name != "Status") return;

            string status = Convert.ToString(e.Value);
            if (status == "In Stock")
                e.CellStyle.ForeColor = Color.FromArgb(22, 128, 61);
            else if (status == "Expiring Soon")
                e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9);
            else
                e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
        }

        private Medicine SelectedMedicine()
        {
            if (dgvMedicines.CurrentRow == null) return null;
            return dgvMedicines.CurrentRow.DataBoundItem as Medicine;
        }

        private void btnSearchMedicine_Click(object sender, EventArgs e) { LoadMedicineData(); }
        private void txtSearchMedicine_TextChanged(object sender, EventArgs e) { LoadMedicineData(); }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            using (AddMedicineForm form = new AddMedicineForm())
                if (form.ShowDialog() == DialogResult.OK) LoadMedicineData();
        }

        private void btnEditMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = SelectedMedicine();
            if (medicine == null)
            {
                MessageBox.Show("Select a medicine first.");
                return;
            }
            using (AddMedicineForm form = new AddMedicineForm(medicine))
                if (form.ShowDialog() == DialogResult.OK) LoadMedicineData();
        }

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            Medicine medicine = SelectedMedicine();
            if (medicine == null)
            {
                MessageBox.Show("Select a medicine first.");
                return;
            }
            DialogResult answer = MessageBox.Show("Delete " + medicine.Name + "?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                AppData.Medicines.Remove(medicine);
                LoadMedicineData();
            }
        }

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void lbladmin_Click(object sender, EventArgs e)
        {

        }
    }
}
