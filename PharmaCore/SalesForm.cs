using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCore
{
    public partial class SalesForm : Form
    {
        private readonly List<CartRow> cart = new List<CartRow>();

        private class CartRow
        {
            public int MedicineId { get; set; }
            public string MedicineName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal LineTotal { get { return Quantity * UnitPrice; } }
        }

        public SalesForm()
        {
            InitializeComponent();
            nudQty.Minimum = 1;
            nudQty.Maximum = 9999;
            dgvCart.ReadOnly = true;
            dgvCart.AllowUserToAddRows = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadMedicines();
            RefreshCart();
        }

        private void LoadMedicines()
        {
            cmbMedicines.DataSource = null;
            cmbMedicines.DataSource = AppData.Medicines
                .Where(m => m.Quantity > 0 && m.ExpiryDate.Date >= DateTime.Today).ToList();
            cmbMedicines.DisplayMember = "Name";
            cmbMedicines.ValueMember = "Id";
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart.ToList();
            lblTotal.Text = cart.Sum(r => r.LineTotal).ToString("C");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Medicine medicine = cmbMedicines.SelectedItem as Medicine;
            int quantity = Decimal.ToInt32(nudQty.Value);

            if (medicine == null)
            {
                MessageBox.Show("No medicines are available for sale.");
                return;
            }

            CartRow existing = cart.FirstOrDefault(r => r.MedicineId == medicine.Id);
            int alreadyInCart = existing == null ? 0 : existing.Quantity;

            if (quantity + alreadyInCart > medicine.Quantity)
            {
                MessageBox.Show("Requested quantity exceeds available stock.");
                return;
            }

            if (existing == null)
                cart.Add(new CartRow
                {
                    MedicineId = medicine.Id,
                    MedicineName = medicine.Name,
                    Quantity = quantity,
                    UnitPrice = medicine.UnitPrice
                });
            else
                existing.Quantity += quantity;

            RefreshCart();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null) return;
            CartRow row = dgvCart.CurrentRow.DataBoundItem as CartRow;
            if (row != null) cart.Remove(row);
            RefreshCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("The cart is empty.");
                return;
            }

            foreach (CartRow row in cart)
            {
                Medicine current = AppData.Medicines.FirstOrDefault(m => m.Id == row.MedicineId);
                if (current == null || current.Quantity < row.Quantity ||
                    current.ExpiryDate.Date < DateTime.Today)
                {
                    MessageBox.Show("Stock or expiry changed. Refresh the cart and try again.");
                    LoadMedicines();
                    return;
                }
            }

            List<SaleItem> items = new List<SaleItem>();
            foreach (CartRow row in cart)
            {
                Medicine current = AppData.Medicines.First(m => m.Id == row.MedicineId);
                current.Quantity -= row.Quantity;
                items.Add(new SaleItem
                {
                    MedicineId = row.MedicineId,
                    MedicineName = row.MedicineName,
                    Quantity = row.Quantity,
                    UnitPrice = row.UnitPrice
                });
            }

            Sale sale = new Sale { Id = AppData.NextSaleId(), Date = DateTime.Now, Items = items };
            AppData.Sales.Add(sale);

            MessageBox.Show("Sale " + sale.Id + " recorded. Total: " + sale.Total.ToString("C"));
            cart.Clear();
            LoadMedicines();
            RefreshCart();
        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
        }

        private void lblMedicine_Click(object sender, EventArgs e)
        {

        }
    }
}
