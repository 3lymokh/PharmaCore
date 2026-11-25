using PharmaCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PharmaCore
{

    public partial class ReportsForm : Form
    {
        private SalesBarChart salesChart;

        int salesChartVal = 0;
        int expiredChartVal = 0;
        int lowStockChartVal = 0;
        int expiringSoonChartVal = 0;

        public ReportsForm()
        {
            InitializeComponent();

            LoadReports();
        }
        private void AddStatIconToCard(Control card, StatIconType iconType)
        {
            if (card == null) return;

            foreach (Control c in card.Controls)
            {
                if (c is StatIconBox existing)
                {
                    existing.IconType = iconType;
                    return;
                }
            }

            int iconSize = Math.Max(36, Math.Min(52, card.Height - 36));
            int leftMargin = 14;
            int topMargin = (card.Height - iconSize) / 2;

            var iconBox = new StatIconBox
            {
                IconType = iconType,
                BackColor = card.BackColor,
                Size = new Size(iconSize, iconSize),
                Location = new Point(leftMargin, topMargin),
                Anchor = AnchorStyles.Left
            };

            // زحزح النصوص (Labels) لليمين عشان متدخلش فوق الأيقونة
            int shiftX = iconSize + 12;
            foreach (Control ctrl in card.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.Left += shiftX;
                }
            }

            card.Controls.Add(iconBox);
            iconBox.BringToFront();
        }
        private void SetupStatCardsIcons()
        {
            AddStatIconToCard(pnlTotalSales, StatIconType.Sales);
            AddStatIconToCard(pnlExpired, StatIconType.Expired);
            AddStatIconToCard(pnlLowStock, StatIconType.LowStock);
            AddStatIconToCard(pnlExpiringSoon, StatIconType.ExpiringSoon);
        }
        private void UpdateSalesBarChart()
        {
            if (salesChart == null && pnlStockChart != null && pnlStockChart.Parent != null)
            {
                salesChart = new SalesBarChart
                {
                    Location = pnlStockChart.Location,
                    Size = pnlStockChart.Size,
                    Anchor = pnlStockChart.Anchor,
                    Title = "Sales - Last 7 Days"
                };

                pnlStockChart.Parent.Controls.Add(salesChart);
                salesChart.BringToFront();
                pnlStockChart.Visible = false;
            }

            if (salesChart == null) return;

            string[] labels = new string[7];
            decimal[] values = new decimal[7];

            for (int i = 0; i < 7; i++)
            {
                DateTime day = DateTime.Today.AddDays(-(6 - i));
                labels[i] = day.ToString("ddd");

                decimal dayTotal = 0;
                foreach (var sale in AppData.Sales)
                {
                    object dateObj = GetPropertyValue(sale, "Date", "SaleDate", "CreatedAt");
                    object totalObj = GetPropertyValue(sale, "Total", "TotalAmount", "Amount");

                    if (dateObj != null && totalObj != null &&
                        DateTime.TryParse(dateObj.ToString(), out DateTime saleDate) &&
                        saleDate.Date == day.Date)
                    {
                        dayTotal += Convert.ToDecimal(totalObj);
                    }
                }

                values[i] = dayTotal;
            }

            salesChart.SetData(labels, values);
        }
        private void LoadReports()
        {
            SetupStatCardsIcons();
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

            int expiredCount = AppData.Medicines.Count(m =>
                m.ExpiryDate.Date < DateTime.Today);

            int lowStockCount = AppData.Medicines.Count(m =>
                m.Quantity <= 10);

            int expiringSoonCount = AppData.Medicines.Count(m =>
                m.ExpiryDate.Date >= DateTime.Today &&
                m.ExpiryDate.Date <= DateTime.Today.AddDays(30));

            lblExpiredValue.Text = expiredCount.ToString();
            lblLowStockValue.Text = lowStockCount.ToString();

            if (this.Controls.Find("lblExpiringSoonValue", true).FirstOrDefault() is Label soonLbl)
            {
                soonLbl.Text = expiringSoonCount.ToString();
            }

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

            salesChartVal = (int)Math.Round(totalSales);
            expiredChartVal = expiredCount;
            lowStockChartVal = lowStockCount;
            expiringSoonChartVal = expiringSoonCount;

            UpdateSalesBarChart();
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

        private void pnlStockChart_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            string[] labels = { "Sales", "Exp", "Low", "Soon" };
            int[] values = { salesChartVal, expiredChartVal, lowStockChartVal, expiringSoonChartVal };
            Color[] colors =
            {
                Color.FromArgb(22, 163, 74),
                Color.FromArgb(185, 28, 28),
                Color.FromArgb(234, 88, 12),
                Color.FromArgb(220, 38, 38)
            };

            int leftMargin = 36;
            int rightMargin = 14;
            int topMargin = 48;
            int bottomMargin = 36;

            int chartWidth = Math.Max(60, panel.Width - leftMargin - rightMargin);
            int chartHeight = Math.Max(80, panel.Height - topMargin - bottomMargin);
            int baseY = topMargin + chartHeight;
            int maxVal = Math.Max(1, values.Max());

            using (Font titleFont = new Font("Segoe UI", 11, FontStyle.Bold))
            using (Font labelFont = new Font("Segoe UI", 8, FontStyle.Regular))
            using (Font valFont = new Font("Segoe UI", 8.5f, FontStyle.Bold))
            using (Brush titleBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            using (Brush textBrush = new SolidBrush(Color.FromArgb(51, 65, 85)))
            using (Pen axisPen = new Pen(Color.FromArgb(148, 163, 184), 1.5f))
            using (Pen gridPen = new Pen(Color.FromArgb(241, 245, 249), 1f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                g.DrawString("Overview Chart", titleFont, titleBrush, 14, 12);

                for (int i = 0; i <= 3; i++)
                {
                    float ratio = i / 3f;
                    int y = baseY - (int)(ratio * (chartHeight - 18));
                    int gridVal = (int)Math.Round(ratio * maxVal);

                    if (i > 0)
                        g.DrawLine(gridPen, leftMargin, y, leftMargin + chartWidth, y);

                    g.DrawString(gridVal.ToString(), labelFont, textBrush, 6, y - 7);
                }

                g.DrawLine(axisPen, leftMargin, topMargin, leftMargin, baseY);
                g.DrawLine(axisPen, leftMargin, baseY, leftMargin + chartWidth, baseY);

                int slotWidth = chartWidth / values.Length;
                int barWidth = Math.Min(28, Math.Max(14, slotWidth / 2));

                for (int i = 0; i < values.Length; i++)
                {
                    float hRatio = (float)values[i] / maxVal;
                    int barHeight = values[i] == 0 ? 2 : Math.Max(4, (int)(hRatio * (chartHeight - 22)));
                    int x = leftMargin + i * slotWidth + (slotWidth - barWidth) / 2;
                    int y = baseY - barHeight;

                    using (SolidBrush barBrush = new SolidBrush(colors[i]))
                    {
                        g.FillRectangle(barBrush, x, y, barWidth, barHeight);
                    }

                    string valText = values[i].ToString();
                    SizeF valSize = g.MeasureString(valText, valFont);
                    g.DrawString(valText, valFont, textBrush, x + (barWidth - valSize.Width) / 2, y - valSize.Height - 2);

                    SizeF lblSize = g.MeasureString(labels[i], labelFont);
                    g.DrawString(labels[i], labelFont, textBrush, x + (barWidth - lblSize.Width) / 2, baseY + 6);
                }
            }
        }
    }
}