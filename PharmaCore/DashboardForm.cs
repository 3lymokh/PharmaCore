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
        private  string adminUsername;
        private Form activeChild;

        public DashboardForm() : this("admin")
        {
        }
        private void AttachNavIconToButton(Button btn, NavIconType iconType)
        {
            if (btn == null) return;

            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(44, btn.Padding.Top, btn.Padding.Right, btn.Padding.Bottom);

            btn.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int iconSize = 22;
                float cx = 14 + iconSize / 2f;
                float cy = btn.Height / 2f;
                float floatS = iconSize;
                Color col = btn.ForeColor.IsEmpty ? Color.White : btn.ForeColor;

                using (var pen = new Pen(col, Math.Max(1.8f, floatS * 0.08f))
                {
                    StartCap = LineCap.Round,
                    EndCap = LineCap.Round,
                    LineJoin = LineJoin.Round
                })
                using (var brush = new SolidBrush(col))
                {
                    switch (iconType)
                    {
                        case NavIconType.Overview:
                            float hw = floatS * 0.34f;
                            float top = cy - floatS * 0.34f;
                            float mid = cy - floatS * 0.06f;
                            float bot = cy + floatS * 0.30f;
                            g.DrawLine(pen, cx, top, cx - hw - floatS * 0.05f, mid);
                            g.DrawLine(pen, cx, top, cx + hw + floatS * 0.05f, mid);
                            g.DrawLine(pen, cx - hw, mid - floatS * 0.02f, cx - hw, bot);
                            g.DrawLine(pen, cx + hw, mid - floatS * 0.02f, cx + hw, bot);
                            g.DrawLine(pen, cx - hw, bot, cx + hw, bot);
                            break;

                        case NavIconType.Medicines:
                            var state = g.Save();
                            g.TranslateTransform(cx, cy);
                            g.RotateTransform(-45f);
                            float cw = floatS * 0.56f;
                            float ch = floatS * 0.26f;
                            g.DrawRectangle(pen, -cw / 2f, -ch / 2f, cw, ch);
                            g.DrawLine(pen, 0f, -ch / 2f, 0f, ch / 2f);
                            g.FillRectangle(brush, -cw / 2f, -ch / 2f, cw / 2f, ch);
                            g.Restore(state);
                            break;

                        case NavIconType.Sales:
                            float rw = floatS * 0.58f;
                            float rh = floatS * 0.52f;
                            float rx = cx - rw / 2f;
                            float ry = cy - rh / 2f;
                            g.DrawRectangle(pen, rx, ry, rw, rh);
                            g.DrawLine(pen, rx + floatS * 0.12f, ry + rh * 0.38f, rx + rw - floatS * 0.12f, ry + rh * 0.38f);
                            g.DrawLine(pen, rx + floatS * 0.12f, ry + rh * 0.65f, rx + rw * 0.65f, ry + rh * 0.65f);
                            break;

                        case NavIconType.Customers:
                            float r1 = floatS * 0.12f;
                            g.DrawEllipse(pen, cx - floatS * 0.14f - r1, cy - floatS * 0.24f - r1, r1 * 2f, r1 * 2f);
                            g.DrawArc(pen, cx - floatS * 0.34f, cy - floatS * 0.02f, floatS * 0.40f, floatS * 0.34f, 180f, 180f);
                            float r2 = floatS * 0.095f;
                            g.DrawEllipse(pen, cx + floatS * 0.16f - r2, cy - floatS * 0.18f - r2, r2 * 2f, r2 * 2f);
                            g.DrawArc(pen, cx + floatS * 0.03f, cy + floatS * 0.03f, floatS * 0.30f, floatS * 0.26f, 200f, 140f);
                            break;

                        case NavIconType.Suppliers:
                            float baseLine = cy + floatS * 0.30f;
                            g.DrawLine(pen, cx - floatS * 0.32f, baseLine, cx + floatS * 0.32f, baseLine);
                            g.DrawRectangle(pen, cx - floatS * 0.24f, cy - floatS * 0.26f, floatS * 0.22f, floatS * 0.56f);
                            g.DrawRectangle(pen, cx - floatS * 0.02f, cy - floatS * 0.04f, floatS * 0.24f, floatS * 0.34f);
                            break;

                        case NavIconType.Reports:
                            g.DrawRectangle(pen, cx - floatS * 0.30f, cy - floatS * 0.28f, floatS * 0.22f, floatS * 0.22f);
                            g.DrawRectangle(pen, cx - floatS * 0.30f, cy + floatS * 0.04f, floatS * 0.22f, floatS * 0.24f);
                            g.DrawLine(pen, cx + floatS * 0.02f, cy - floatS * 0.22f, cx + floatS * 0.30f, cy - floatS * 0.22f);
                            g.DrawLine(pen, cx + floatS * 0.02f, cy - floatS * 0.08f, cx + floatS * 0.24f, cy - floatS * 0.08f);
                            g.DrawLine(pen, cx + floatS * 0.02f, cy + floatS * 0.10f, cx + floatS * 0.30f, cy + floatS * 0.10f);
                            g.DrawLine(pen, cx + floatS * 0.02f, cy + floatS * 0.24f, cx + floatS * 0.22f, cy + floatS * 0.24f);
                            break;

                        case NavIconType.Settings:
                            float outerR = floatS * 0.25f;
                            float innerR = floatS * 0.10f;
                            g.DrawEllipse(pen, cx - outerR, cy - outerR, outerR * 2f, outerR * 2f);
                            g.DrawEllipse(pen, cx - innerR, cy - innerR, innerR * 2f, innerR * 2f);
                            for (int i = 0; i < 6; i++)
                            {
                                double ang = i * Math.PI / 3.0;
                                float x1 = cx + (float)Math.Cos(ang) * (outerR - floatS * 0.02f);
                                float y1 = cy + (float)Math.Sin(ang) * (outerR - floatS * 0.02f);
                                float x2 = cx + (float)Math.Cos(ang) * (outerR + floatS * 0.10f);
                                float y2 = cy + (float)Math.Sin(ang) * (outerR + floatS * 0.10f);
                                g.DrawLine(pen, x1, y1, x2, y2);
                            }
                            break;
                    }
                }
            };
        }
        public DashboardForm(string username)
        {
            InitializeComponent();
            adminUsername = username;
            pnlOverview.AutoScroll = true;
            pnlOverview.AutoScrollMinSize = pnlOverview.ClientSize;
            MakeRoundedButton(pnlAdmin, 20);

            loggedInUser = username;

            // Connect Inventory Status Event
            dgvInventory.CellFormatting += dgvInventory_CellFormatting;

            // Welcome Information
            lblGreeting.Text = "Welcome, " + loggedInUser;
            lblDate.Text = DateTime.Now.ToString("dddd, yyyy/MM/dd");
            SetupSidebarIcons();
            // Default Active Button
            SetActiveButton(btnOverview);

            // Load Dashboard Data
            LoadInventoryStatus();
            ShowOverview();
        }
        private void SetupSidebarIcons()
        {
            AttachNavIconToButton(btnOverview, NavIconType.Overview);
            AttachNavIconToButton(btnMedicines, NavIconType.Medicines);
            AttachNavIconToButton(btnSales, NavIconType.Sales);
            AttachNavIconToButton(btnCustomers, NavIconType.Customers);
            AttachNavIconToButton(btnSuppliers, NavIconType.Suppliers);
            AttachNavIconToButton(btnReports, NavIconType.Reports);
            AttachNavIconToButton(btnSettings, NavIconType.Settings);
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
            child.AutoScroll = true;
            child.AutoScrollMinSize = child.ClientSize;
            child.MinimumSize = Size.Empty;
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
            OpenChildForm(new MedicinesForm(adminUsername));
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSales);
            OpenChildForm(new SalesForm(adminUsername));
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnCustomers);
            OpenChildForm(new CustomersForm(adminUsername));
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSuppliers);
            OpenChildForm(new SuppliersForm(adminUsername));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);
            OpenChildForm(new ReportsForm(adminUsername));
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

