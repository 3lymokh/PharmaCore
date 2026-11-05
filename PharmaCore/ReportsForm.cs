
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using PharmaCore;

namespace PharmaCore
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            // 1. Total Sales
            decimal totalSales = 0;

            foreach (var sale in AppData.Sales)
            {
                object value = GetPropertyValue(
                    sale, "Total", "TotalAmount", "Amount"
                );

                if (value != null)
                    totalSales += Convert.ToDecimal(value);
            }

            lblTotalSalesValue.Text = "$" + totalSales.ToString("0.00");


            // 2. Expired Medicines
            int expiredCount = AppData.Medicines.Count(m =>
                m.ExpiryDate.Date < DateTime.Today);

            // 3. Low Stock
            int lowStockCount = AppData.Medicines.Count(m =>
                m.Quantity <= 10);

            // Update Cards
            lblExpiredValue.Text = expiredCount.ToString();
            lblLowStockValue.Text = lowStockCount.ToString();


            // 4. Sales Table
            DataTable salesTable = new DataTable();

            salesTable.Columns.Add("ID");
            salesTable.Columns.Add("DATE");
            salesTable.Columns.Add("TOTAL");

            foreach (var sale in AppData.Sales)
            {
                object id = GetPropertyValue(sale, "Id", "SaleId");
                object date = GetPropertyValue(
                    sale, "Date", "SaleDate", "CreatedAt"
                );
                object total = GetPropertyValue(
                    sale, "Total", "TotalAmount", "Amount"
                );

                salesTable.Rows.Add(
                    id ?? "",
                    date ?? "",
                    total ?? ""
                );
            }

            dgvSales.AutoGenerateColumns = false;
            dgvSales.DataSource = salesTable;


            // 5. Expiring Medicines Table
            DataTable expiringTable = new DataTable();

            expiringTable.Columns.Add("NAME");
            expiringTable.Columns.Add("QUANTITY");
            expiringTable.Columns.Add("EXPIRY DATE");
            expiringTable.Columns.Add("STATUS");

            var expiringMedicines = AppData.Medicines
                .Where(m => m.ExpiryDate.Date <= DateTime.Today.AddDays(30))
                .OrderBy(m => m.ExpiryDate);

            foreach (var medicine in expiringMedicines)
            {
                string status = medicine.ExpiryDate.Date < DateTime.Today
                    ? "Expired"
                    : "Expiring Soon";

                expiringTable.Rows.Add(
                    medicine.Name,
                    medicine.Quantity,
                    medicine.ExpiryDate.ToShortDateString(),
                    status
                );
            }

            dgvExpiring.AutoGenerateColumns = false;
            dgvExpiring.DataSource = expiringTable;
        }


        private object GetPropertyValue(object obj, params string[] names)
        {
            if (obj == null)
                return null;

            foreach (string name in names)
            {
                PropertyInfo property = obj.GetType().GetProperty(name);

                if (property != null)
                    return property.GetValue(obj);
            }

            return null;
        }

        private void lblTotalSalesValue_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
