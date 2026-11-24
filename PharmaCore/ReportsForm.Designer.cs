namespace PharmaCore
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlTotalSales = new System.Windows.Forms.Panel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.pnlExpired = new System.Windows.Forms.Panel();
            this.lblExpiredValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSalesCard = new System.Windows.Forms.Panel();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvExpiring = new System.Windows.Forms.DataGridView();
            this.colMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedicineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedicineStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlExpiringCard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlStockChart = new System.Windows.Forms.Panel();
            this.pnlExpiringSoon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlTotalSales.SuspendLayout();
            this.pnlExpired.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlSalesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).BeginInit();
            this.pnlExpiringSoon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.AutoSize = true;
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPageSubtitle.Location = new System.Drawing.Point(41, 29);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(177, 17);
            this.lblPageSubtitle.TabIndex = 3;
            this.lblPageSubtitle.Text = "\tPHARMACY MANAGEMENT";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPageTitle.Location = new System.Drawing.Point(35, 56);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(137, 45);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Reports";
            // 
            // pnlTotalSales
            // 
            this.pnlTotalSales.BackColor = System.Drawing.Color.White;
            this.pnlTotalSales.Controls.Add(this.lblTotalSalesValue);
            this.pnlTotalSales.Controls.Add(this.lblTotalSalesTitle);
            this.pnlTotalSales.Controls.Add(this.panel4);
            this.pnlTotalSales.Location = new System.Drawing.Point(44, 143);
            this.pnlTotalSales.Name = "pnlTotalSales";
            this.pnlTotalSales.Size = new System.Drawing.Size(296, 98);
            this.pnlTotalSales.TabIndex = 5;
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesValue.Location = new System.Drawing.Point(11, 37);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.Size = new System.Drawing.Size(94, 41);
            this.lblTotalSalesValue.TabIndex = 1;
            this.lblTotalSalesValue.Text = "$0.00";
            this.lblTotalSalesValue.Click += new System.EventHandler(this.lblTotalSalesValue_Click);
            // 
            // lblTotalSalesTitle
            // 
            this.lblTotalSalesTitle.AutoSize = true;
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(15, 14);
            this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            this.lblTotalSalesTitle.Size = new System.Drawing.Size(76, 16);
            this.lblTotalSalesTitle.TabIndex = 0;
            this.lblTotalSalesTitle.Text = "Total Sales";
            // 
            // pnlExpired
            // 
            this.pnlExpired.BackColor = System.Drawing.Color.White;
            this.pnlExpired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpired.Controls.Add(this.lblExpiredValue);
            this.pnlExpired.Controls.Add(this.label1);
            this.pnlExpired.Location = new System.Drawing.Point(394, 143);
            this.pnlExpired.Name = "pnlExpired";
            this.pnlExpired.Size = new System.Drawing.Size(296, 98);
            this.pnlExpired.TabIndex = 6;
            // 
            // lblExpiredValue
            // 
            this.lblExpiredValue.AutoSize = true;
            this.lblExpiredValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredValue.Location = new System.Drawing.Point(10, 37);
            this.lblExpiredValue.Name = "lblExpiredValue";
            this.lblExpiredValue.Size = new System.Drawing.Size(35, 41);
            this.lblExpiredValue.TabIndex = 2;
            this.lblExpiredValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expired";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.label3);
            this.pnlLowStock.Location = new System.Drawing.Point(739, 145);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(296, 96);
            this.pnlLowStock.TabIndex = 7;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockValue.Location = new System.Drawing.Point(10, 37);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(35, 41);
            this.lblLowStockValue.TabIndex = 3;
            this.lblLowStockValue.Text = "1";
            this.lblLowStockValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low Stock";
            // 
            // pnlSalesCard
            // 
            this.pnlSalesCard.BackColor = System.Drawing.Color.White;
            this.pnlSalesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesCard.Controls.Add(this.dgvSales);
            this.pnlSalesCard.Controls.Add(this.lblSalesTitle);
            this.pnlSalesCard.Location = new System.Drawing.Point(43, 637);
            this.pnlSalesCard.Name = "pnlSalesCard";
            this.pnlSalesCard.Size = new System.Drawing.Size(1335, 204);
            this.pnlSalesCard.TabIndex = 8;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleID,
            this.colSaleDate,
            this.colSaleTotal});
            this.dgvSales.Location = new System.Drawing.Point(18, 62);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(456, 165);
            this.dgvSales.TabIndex = 2;
            // 
            // colSaleID
            // 
            this.colSaleID.DataPropertyName = "ID";
            this.colSaleID.HeaderText = "ID";
            this.colSaleID.MinimumWidth = 6;
            this.colSaleID.Name = "colSaleID";
            this.colSaleID.ReadOnly = true;
            // 
            // colSaleDate
            // 
            this.colSaleDate.DataPropertyName = "DATE";
            this.colSaleDate.HeaderText = "DATE";
            this.colSaleDate.MinimumWidth = 6;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            // 
            // colSaleTotal
            // 
            this.colSaleTotal.DataPropertyName = "TOTAL";
            this.colSaleTotal.HeaderText = "TOTAL";
            this.colSaleTotal.MinimumWidth = 6;
            this.colSaleTotal.Name = "colSaleTotal";
            this.colSaleTotal.ReadOnly = true;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSalesTitle.Location = new System.Drawing.Point(22, 21);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(58, 28);
            this.lblSalesTitle.TabIndex = 1;
            this.lblSalesTitle.Text = "Sales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvExpiring);
            this.panel3.Controls.Add(this.pnlExpiringCard);
            this.panel3.Location = new System.Drawing.Point(730, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 330);
            this.panel3.TabIndex = 9;
            // 
            // dgvExpiring
            // 
            this.dgvExpiring.AllowUserToAddRows = false;
            this.dgvExpiring.AllowUserToDeleteRows = false;
            this.dgvExpiring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpiring.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpiring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpiring.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiring.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedicineName,
            this.colMedicineQuantity,
            this.colExpiryDate,
            this.colMedicineStatus});
            this.dgvExpiring.Location = new System.Drawing.Point(27, 74);
            this.dgvExpiring.Name = "dgvExpiring";
            this.dgvExpiring.ReadOnly = true;
            this.dgvExpiring.RowHeadersVisible = false;
            this.dgvExpiring.RowHeadersWidth = 51;
            this.dgvExpiring.RowTemplate.Height = 24;
            this.dgvExpiring.Size = new System.Drawing.Size(616, 232);
            this.dgvExpiring.TabIndex = 2;
            // 
            // colMedicineName
            // 
            this.colMedicineName.DataPropertyName = "NAME";
            this.colMedicineName.HeaderText = "NAME";
            this.colMedicineName.MinimumWidth = 6;
            this.colMedicineName.Name = "colMedicineName";
            this.colMedicineName.ReadOnly = true;
            // 
            // colMedicineQuantity
            // 
            this.colMedicineQuantity.DataPropertyName = "QUANTITY";
            this.colMedicineQuantity.HeaderText = "QUANTITY";
            this.colMedicineQuantity.MinimumWidth = 6;
            this.colMedicineQuantity.Name = "colMedicineQuantity";
            this.colMedicineQuantity.ReadOnly = true;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.DataPropertyName = "EXPIRY DATE";
            this.colExpiryDate.HeaderText = "EXPIRY DATE";
            this.colExpiryDate.MinimumWidth = 6;
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.ReadOnly = true;
            // 
            // colMedicineStatus
            // 
            this.colMedicineStatus.DataPropertyName = "STATUS";
            this.colMedicineStatus.HeaderText = "STATUS";
            this.colMedicineStatus.MinimumWidth = 6;
            this.colMedicineStatus.Name = "colMedicineStatus";
            this.colMedicineStatus.ReadOnly = true;
            // 
            // pnlExpiringCard
            // 
            this.pnlExpiringCard.AutoSize = true;
            this.pnlExpiringCard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlExpiringCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlExpiringCard.Location = new System.Drawing.Point(22, 21);
            this.pnlExpiringCard.Name = "pnlExpiringCard";
            this.pnlExpiringCard.Size = new System.Drawing.Size(183, 28);
            this.pnlExpiringCard.TabIndex = 1;
            this.pnlExpiringCard.Text = "Expiring Medicines";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 3);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(395, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 3);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(740, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 3);
            this.panel6.TabIndex = 11;
            // 
            // pnlStockChart
            // 
            this.pnlStockChart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlStockChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlStockChart.Location = new System.Drawing.Point(43, 279);
            this.pnlStockChart.Name = "pnlStockChart";
            this.pnlStockChart.Size = new System.Drawing.Size(647, 330);
            this.pnlStockChart.TabIndex = 12;
            this.pnlStockChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStockChart_Paint);
            // 
            // pnlExpiringSoon
            // 
            this.pnlExpiringSoon.BackColor = System.Drawing.Color.White;
            this.pnlExpiringSoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpiringSoon.Controls.Add(this.label2);
            this.pnlExpiringSoon.Controls.Add(this.label4);
            this.pnlExpiringSoon.Location = new System.Drawing.Point(1081, 143);
            this.pnlExpiringSoon.Name = "pnlExpiringSoon";
            this.pnlExpiringSoon.Size = new System.Drawing.Size(296, 98);
            this.pnlExpiringSoon.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expiring Soon";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.OrangeRed;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(1082, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 3);
            this.panel8.TabIndex = 12;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1723, 853);
            this.Controls.Add(this.pnlSalesCard);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlLowStock);
            this.Controls.Add(this.pnlExpiringSoon);
            this.Controls.Add(this.pnlStockChart);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlExpired);
            this.Controls.Add(this.pnlTotalSales);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblPageSubtitle);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlTotalSales.ResumeLayout(false);
            this.pnlTotalSales.PerformLayout();
            this.pnlExpired.ResumeLayout(false);
            this.pnlExpired.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlSalesCard.ResumeLayout(false);
            this.pnlSalesCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).EndInit();
            this.pnlExpiringSoon.ResumeLayout(false);
            this.pnlExpiringSoon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTotalSales;
        private System.Windows.Forms.Panel pnlExpired;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpiredValue;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSalesCard;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvExpiring;
        private System.Windows.Forms.Label pnlExpiringCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlStockChart;
        private System.Windows.Forms.Panel pnlExpiringSoon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
    }
}
