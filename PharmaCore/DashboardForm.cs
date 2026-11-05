using PharmaCore;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PharmaCore
{
    public partial class DashboardForm : Form
    {
        private readonly string loggedInUser;
        private Form activeChild;

        public DashboardForm() : this("admin")
        {
        }

        public DashboardForm(string username)
        {
            InitializeComponent();
            MakeRoundedButton(pnlAdmin, 20);

            loggedInUser = username;

            // Connect Inventory Status Event
            dgvInventory.CellFormatting += dgvInventory_CellFormatting;

            // Welcome Information
            lblGreeting.Text = "Welcome, " + loggedInUser;
            lblDate.Text = DateTime.Now.ToString("dddd, yyyy/MM/dd");

            // Default Active Button
            SetActiveButton(btnOverview);

            // Load Dashboard Data
            LoadInventoryStatus();
            ShowOverview();
        }

        // Set Active Sidebar Button

        private void SetActiveButton(Button activeButton)
        {
            Button[] buttons =
            {
        btnOverview,
        btnMedicines,
        btnSales,
        btnCustomers,
        btnSuppliers,
        btnReports,
        btnSettings
    };

            foreach (Button btn in buttons)
            {
                btn.BackColor = pnlSidebar.BackColor;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }

            // Only the clicked button changes color
            activeButton.BackColor = Color.FromArgb(35, 35, 105);
            activeButton.ForeColor = Color.White;
        }


        // Update Dashboard Statistics
        private void RefreshOverview()
        {
            lblTotalMedicinesValue.Text =
                AppData.Medicines.Count.ToString();

            lblLowStockValue.Text =
                AppData.Medicines.Count(m => m.Quantity <= 10).ToString();

            lblExpiringSoonValue.Text =
                AppData.Medicines.Count(m =>
                    m.ExpiryDate.Date >= DateTime.Today &&
                    m.ExpiryDate.Date <= DateTime.Today.AddDays(30)
                ).ToString();

            decimal todayTotal = AppData.Sales
                .Where(s => s.Date.Date == DateTime.Today)
                .Sum(s => s.Total);

            lblTodaySalesValue.Text = todayTotal.ToString("C");
        }

        // Show Dashboard Overview
        private void ShowOverview()
        {
            if (activeChild != null)
            {
                activeChild.Close();
                activeChild.Dispose();
                activeChild = null;
            }

            pnlChildHost.Controls.Clear();
            pnlChildHost.Visible = false;
            pnlOverview.Visible = true;

            LoadInventoryStatus();
            RefreshOverview();
        }

        // Open Other Forms Inside Dashboard
        private void OpenChildForm(Form child)
        {
            if (activeChild != null)
            {
                activeChild.Close();
                activeChild.Dispose();
            }

            pnlOverview.Visible = false;
            pnlChildHost.Controls.Clear();

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            pnlChildHost.Controls.Add(child);
            pnlChildHost.Visible = true;

            activeChild = child;
            child.Show();
        }

        // Load Inventory Data
        private void LoadInventoryStatus()
        {
            var rows = AppData.Medicines
                .Select(m => new
                {
                    Medicine = m.Name,

                    Status = m.Quantity == 0
                        ? "Out of Stock"
                        : m.Quantity <= 10
                            ? "Low Stock"
                            : "In Stock"
                })
                .ToList();

            dgvInventory.DataSource = null;
            dgvInventory.DataSource = rows;

            dgvInventory.ReadOnly = true;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.ColumnHeadersVisible = false;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;

            dgvInventory.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvInventory.GridColor =
                Color.FromArgb(229, 231, 235);

            dgvInventory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvInventory.RowTemplate.Height = 40;

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                row.Height = 40;
            }

            dgvInventory.DefaultCellStyle.SelectionBackColor =
                Color.White;

            dgvInventory.DefaultCellStyle.SelectionForeColor =
                Color.Black;
        }

        // Change Inventory Status Colors
        private void dgvInventory_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvInventory.Columns[e.ColumnIndex].Name != "Status")
                return;

            string status = Convert.ToString(e.Value);

            if (status == "In Stock")
            {
                e.CellStyle.ForeColor =
                    Color.FromArgb(22, 128, 61);

                e.CellStyle.BackColor =
                    Color.FromArgb(236, 253, 243);
            }
            else if (status == "Low Stock")
            {
                e.CellStyle.ForeColor = Color.DarkRed;

                e.CellStyle.BackColor =Color.MistyRose;
            }
            else
            {
                e.CellStyle.ForeColor = Color.Red;

                e.CellStyle.BackColor =
                    Color.FromArgb(254, 242, 242);
            }
        }

        // Sidebar Buttons
        private void btnOverview_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnOverview);
            ShowOverview();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnMedicines);
            OpenChildForm(new MedicinesForm());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSales);
            OpenChildForm(new SalesForm());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnCustomers);
            OpenChildForm(new CustomersForm());
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSuppliers);
            OpenChildForm(new SuppliersForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);
            OpenChildForm(new ReportsForm());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSettings);
            OpenChildForm(new SettingsForm());
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvInventory_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
        private void MakeRoundedButton(Panel panel,int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

       
    }
}

