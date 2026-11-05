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
            this.pnlTotalSalesCard = new System.Windows.Forms.Panel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExpiredValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.pnlTotalSalesCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSalesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).BeginInit();
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
            this.lblPageTitle.Size = new System.Drawing.Size(139, 46);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Reports";
            // 
            // pnlTotalSalesCard
            // 
            this.pnlTotalSalesCard.BackColor = System.Drawing.Color.White;
            this.pnlTotalSalesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSalesCard.Controls.Add(this.lblTotalSalesValue);
            this.pnlTotalSalesCard.Controls.Add(this.lblTotalSalesTitle);
            this.pnlTotalSalesCard.Location = new System.Drawing.Point(44, 143);
            this.pnlTotalSalesCard.Name = "pnlTotalSalesCard";
            this.pnlTotalSalesCard.Size = new System.Drawing.Size(223, 93);
            this.pnlTotalSalesCard.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblExpiredValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(318, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 93);
            this.panel1.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLowStockValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(592, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 93);
            this.panel2.TabIndex = 7;
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
            this.pnlSalesCard.Location = new System.Drawing.Point(44, 271);
            this.pnlSalesCard.Name = "pnlSalesCard";
            this.pnlSalesCard.Size = new System.Drawing.Size(497, 268);
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
            this.colSaleID.HeaderText = "ID";
            this.colSaleID.MinimumWidth = 6;
            this.colSaleID.Name = "colSaleID";
            this.colSaleID.ReadOnly = true;
            // 
            // colSaleDate
            // 
            this.colSaleDate.HeaderText = "DATE";
            this.colSaleDate.MinimumWidth = 6;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            // 
            // colSaleTotal
            // 
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
            this.panel3.Location = new System.Drawing.Point(592, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 268);
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
            this.dgvExpiring.Location = new System.Drawing.Point(27, 62);
            this.dgvExpiring.Name = "dgvExpiring";
            this.dgvExpiring.ReadOnly = true;
            this.dgvExpiring.RowHeadersVisible = false;
            this.dgvExpiring.RowHeadersWidth = 51;
            this.dgvExpiring.RowTemplate.Height = 24;
            this.dgvExpiring.Size = new System.Drawing.Size(456, 165);
            this.dgvExpiring.TabIndex = 2;
            // 
            // colMedicineName
            // 
            this.colMedicineName.HeaderText = "NAME";
            this.colMedicineName.MinimumWidth = 6;
            this.colMedicineName.Name = "colMedicineName";
            this.colMedicineName.ReadOnly = true;
            // 
            // colMedicineQuantity
            // 
            this.colMedicineQuantity.HeaderText = "QUANTITY";
            this.colMedicineQuantity.MinimumWidth = 6;
            this.colMedicineQuantity.Name = "colMedicineQuantity";
            this.colMedicineQuantity.ReadOnly = true;
            // 
            // colExpiryDate
            // 
            this.colExpiryDate.HeaderText = "EXPIR DATE";
            this.colExpiryDate.MinimumWidth = 6;
            this.colExpiryDate.Name = "colExpiryDate";
            this.colExpiryDate.ReadOnly = true;
            // 
            // colMedicineStatus
            // 
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
            this.panel4.Location = new System.Drawing.Point(44, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 10);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(318, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 10);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(592, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 10);
            this.panel6.TabIndex = 11;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1398, 657);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSalesCard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTotalSalesCard);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblPageSubtitle);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlTotalSalesCard.ResumeLayout(false);
            this.pnlTotalSalesCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSalesCard.ResumeLayout(false);
            this.pnlSalesCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTotalSalesCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
    }
}