namespace PharmaCore{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblPharmacyManagement = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pnlCardLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlExpiringSoon = new System.Windows.Forms.Panel();
            this.pnlCardExpiringSoon = new System.Windows.Forms.Panel();
            this.lblExpiringSoon = new System.Windows.Forms.Label();
            this.lblExpiringSoonValue = new System.Windows.Forms.Label();
            this.pnlTodaySales = new System.Windows.Forms.Panel();
            this.pnlCardTodaySales = new System.Windows.Forms.Panel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.lblTodaySalesValue = new System.Windows.Forms.Label();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlInventoryDivider = new System.Windows.Forms.Panel();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.pnlTotalMedicines = new System.Windows.Forms.Panel();
            this.pnlCardTotalMedicines = new System.Windows.Forms.Panel();
            this.lblTotalMedicines = new System.Windows.Forms.Label();
            this.lblTotalMedicinesValue = new System.Windows.Forms.Label();
            this.pnlChildHost = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlExpiringSoon.SuspendLayout();
            this.pnlTodaySales.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlTotalMedicines.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.pnlHeader);
            this.pnlSidebar.Controls.Add(this.btnOverview);
            this.pnlSidebar.Controls.Add(this.btnMedicines);
            this.pnlSidebar.Controls.Add(this.btnSales);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnSuppliers);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 802);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(220, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(42, 28);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(158, 29);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "PharamaCore";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblRole.Location = new System.Drawing.Point(22, 57);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(178, 15);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Pharmacy Managment System ";
            // 
            // btnOverview
            // 
            this.btnOverview.AutoSize = true;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOverview.Location = new System.Drawing.Point(25, 173);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(88, 30);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.AutoSize = true;
            this.btnMedicines.FlatAppearance.BorderSize = 0;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicines.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMedicines.Location = new System.Drawing.Point(25, 248);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(95, 30);
            this.btnMedicines.TabIndex = 1;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicines.UseVisualStyleBackColor = true;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = true;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSales.Location = new System.Drawing.Point(25, 315);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 30);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.AutoSize = true;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCustomers.Location = new System.Drawing.Point(25, 378);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(101, 30);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSuppliers.Location = new System.Drawing.Point(25, 443);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(89, 30);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = true;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReports.Location = new System.Drawing.Point(25, 508);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(78, 30);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSettings.Location = new System.Drawing.Point(25, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 30);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(0, 772);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pnlOverview);
            this.pnlMainContent.Controls.Add(this.pnlChildHost);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(220, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1461, 802);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlOverview.Controls.Add(this.pnlAdmin);
            this.pnlOverview.Controls.Add(this.lblOverview);
            this.pnlOverview.Controls.Add(this.lblPharmacyManagement);
            this.pnlOverview.Controls.Add(this.lblDate);
            this.pnlOverview.Controls.Add(this.lblGreeting);
            this.pnlOverview.Controls.Add(this.pnlLowStock);
            this.pnlOverview.Controls.Add(this.pnlExpiringSoon);
            this.pnlOverview.Controls.Add(this.pnlTodaySales);
            this.pnlOverview.Controls.Add(this.pnlInventory);
            this.pnlOverview.Controls.Add(this.pnlTotalMedicines);
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(0, 0);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1461, 802);
            this.pnlOverview.TabIndex = 0;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdmin.BackColor = System.Drawing.Color.White;
            this.pnlAdmin.Controls.Add(this.lblAdmin);
            this.pnlAdmin.Location = new System.Drawing.Point(1348, 6);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(90, 40);
            this.pnlAdmin.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Location = new System.Drawing.Point(0, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(90, 40);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.BackColor = System.Drawing.Color.AliceBlue;
            this.lblOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.ForeColor = System.Drawing.Color.Navy;
            this.lblOverview.Location = new System.Drawing.Point(70, 57);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(167, 39);
            this.lblOverview.TabIndex = 1;
            this.lblOverview.Text = "Overview";
            // 
            // lblPharmacyManagement
            // 
            this.lblPharmacyManagement.AutoSize = true;
            this.lblPharmacyManagement.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPharmacyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPharmacyManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacyManagement.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPharmacyManagement.Location = new System.Drawing.Point(66, 21);
            this.lblPharmacyManagement.Name = "lblPharmacyManagement";
            this.lblPharmacyManagement.Size = new System.Drawing.Size(239, 25);
            this.lblPharmacyManagement.TabIndex = 0;
            this.lblPharmacyManagement.Text = "Pharmacy Management";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(296, 118);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.AliceBlue;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGreeting.Location = new System.Drawing.Point(77, 118);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(84, 22);
            this.lblGreeting.TabIndex = 3;
            this.lblGreeting.Text = "Welcome";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLowStock.Controls.Add(this.pnlCardLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(394, 173);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(315, 120);
            this.pnlLowStock.TabIndex = 13;
            // 
            // pnlCardLowStock
            // 
            this.pnlCardLowStock.BackColor = System.Drawing.Color.Firebrick;
            this.pnlCardLowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardLowStock.Location = new System.Drawing.Point(0, 0);
            this.pnlCardLowStock.Name = "pnlCardLowStock";
            this.pnlCardLowStock.Size = new System.Drawing.Size(313, 3);
            this.pnlCardLowStock.TabIndex = 14;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLowStockValue.Location = new System.Drawing.Point(21, 60);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(28, 29);
            this.lblLowStockValue.TabIndex = 4;
            this.lblLowStockValue.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLowStock.Location = new System.Drawing.Point(20, 15);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(87, 20);
            this.lblLowStock.TabIndex = 9;
            this.lblLowStock.Text = "Low Stock";
            // 
            // pnlExpiringSoon
            // 
            this.pnlExpiringSoon.BackColor = System.Drawing.Color.White;
            this.pnlExpiringSoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpiringSoon.Controls.Add(this.pnlCardExpiringSoon);
            this.pnlExpiringSoon.Controls.Add(this.lblExpiringSoon);
            this.pnlExpiringSoon.Controls.Add(this.lblExpiringSoonValue);
            this.pnlExpiringSoon.Location = new System.Drawing.Point(740, 174);
            this.pnlExpiringSoon.Name = "pnlExpiringSoon";
            this.pnlExpiringSoon.Size = new System.Drawing.Size(320, 120);
            this.pnlExpiringSoon.TabIndex = 0;
            // 
            // pnlCardExpiringSoon
            // 
            this.pnlCardExpiringSoon.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlCardExpiringSoon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardExpiringSoon.Location = new System.Drawing.Point(0, 0);
            this.pnlCardExpiringSoon.Name = "pnlCardExpiringSoon";
            this.pnlCardExpiringSoon.Size = new System.Drawing.Size(318, 3);
            this.pnlCardExpiringSoon.TabIndex = 14;
            // 
            // lblExpiringSoon
            // 
            this.lblExpiringSoon.AutoSize = true;
            this.lblExpiringSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiringSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExpiringSoon.Location = new System.Drawing.Point(15, 16);
            this.lblExpiringSoon.Name = "lblExpiringSoon";
            this.lblExpiringSoon.Size = new System.Drawing.Size(112, 20);
            this.lblExpiringSoon.TabIndex = 10;
            this.lblExpiringSoon.Text = "Expiring Soon";
            // 
            // lblExpiringSoonValue
            // 
            this.lblExpiringSoonValue.AutoSize = true;
            this.lblExpiringSoonValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiringSoonValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblExpiringSoonValue.Location = new System.Drawing.Point(30, 61);
            this.lblExpiringSoonValue.Name = "lblExpiringSoonValue";
            this.lblExpiringSoonValue.Size = new System.Drawing.Size(28, 29);
            this.lblExpiringSoonValue.TabIndex = 7;
            this.lblExpiringSoonValue.Text = "0";
            // 
            // pnlTodaySales
            // 
            this.pnlTodaySales.BackColor = System.Drawing.Color.White;
            this.pnlTodaySales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodaySales.Controls.Add(this.pnlCardTodaySales);
            this.pnlTodaySales.Controls.Add(this.lblTodaySales);
            this.pnlTodaySales.Controls.Add(this.lblTodaySalesValue);
            this.pnlTodaySales.Location = new System.Drawing.Point(1105, 173);
            this.pnlTodaySales.Name = "pnlTodaySales";
            this.pnlTodaySales.Size = new System.Drawing.Size(307, 120);
            this.pnlTodaySales.TabIndex = 0;
            // 
            // pnlCardTodaySales
            // 
            this.pnlCardTodaySales.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlCardTodaySales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardTodaySales.Location = new System.Drawing.Point(0, 0);
            this.pnlCardTodaySales.Name = "pnlCardTodaySales";
            this.pnlCardTodaySales.Size = new System.Drawing.Size(305, 3);
            this.pnlCardTodaySales.TabIndex = 14;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTodaySales.Location = new System.Drawing.Point(3, 13);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(101, 20);
            this.lblTodaySales.TabIndex = 11;
            this.lblTodaySales.Text = "Today Sales";
            // 
            // lblTodaySalesValue
            // 
            this.lblTodaySalesValue.AutoSize = true;
            this.lblTodaySalesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTodaySalesValue.Location = new System.Drawing.Point(34, 61);
            this.lblTodaySalesValue.Name = "lblTodaySalesValue";
            this.lblTodaySalesValue.Size = new System.Drawing.Size(28, 29);
            this.lblTodaySalesValue.TabIndex = 6;
            this.lblTodaySalesValue.Text = "0";
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.White;
            this.pnlInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventory.Controls.Add(this.dgvInventory);
            this.pnlInventory.Controls.Add(this.pnlInventoryDivider);
            this.pnlInventory.Controls.Add(this.lblInventoryTitle);
            this.pnlInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlInventory.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlInventory.Location = new System.Drawing.Point(59, 326);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(1353, 431);
            this.pnlInventory.TabIndex = 4;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.Location = new System.Drawing.Point(35, 85);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(1281, 326);
            this.dgvInventory.TabIndex = 5;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // pnlInventoryDivider
            // 
            this.pnlInventoryDivider.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlInventoryDivider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlInventoryDivider.Location = new System.Drawing.Point(21, 63);
            this.pnlInventoryDivider.Name = "pnlInventoryDivider";
            this.pnlInventoryDivider.Size = new System.Drawing.Size(590, 2);
            this.pnlInventoryDivider.TabIndex = 4;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblInventoryTitle.Location = new System.Drawing.Point(47, 19);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(236, 31);
            this.lblInventoryTitle.TabIndex = 4;
            this.lblInventoryTitle.Text = "Inventory Status ";
            // 
            // pnlTotalMedicines
            // 
            this.pnlTotalMedicines.BackColor = System.Drawing.Color.White;
            this.pnlTotalMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalMedicines.Controls.Add(this.pnlCardTotalMedicines);
            this.pnlTotalMedicines.Controls.Add(this.lblTotalMedicines);
            this.pnlTotalMedicines.Controls.Add(this.lblTotalMedicinesValue);
            this.pnlTotalMedicines.Location = new System.Drawing.Point(59, 173);
            this.pnlTotalMedicines.Name = "pnlTotalMedicines";
            this.pnlTotalMedicines.Size = new System.Drawing.Size(296, 120);
            this.pnlTotalMedicines.TabIndex = 12;
            // 
            // pnlCardTotalMedicines
            // 
            this.pnlCardTotalMedicines.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCardTotalMedicines.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardTotalMedicines.Location = new System.Drawing.Point(0, 0);
            this.pnlCardTotalMedicines.Name = "pnlCardTotalMedicines";
            this.pnlCardTotalMedicines.Size = new System.Drawing.Size(294, 3);
            this.pnlCardTotalMedicines.TabIndex = 9;
            // 
            // lblTotalMedicines
            // 
            this.lblTotalMedicines.AutoSize = true;
            this.lblTotalMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalMedicines.Location = new System.Drawing.Point(9, 13);
            this.lblTotalMedicines.Name = "lblTotalMedicines";
            this.lblTotalMedicines.Size = new System.Drawing.Size(127, 20);
            this.lblTotalMedicines.TabIndex = 8;
            this.lblTotalMedicines.Text = "Total Medicines";
            // 
            // lblTotalMedicinesValue
            // 
            this.lblTotalMedicinesValue.AutoSize = true;
            this.lblTotalMedicinesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMedicinesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalMedicinesValue.Location = new System.Drawing.Point(21, 60);
            this.lblTotalMedicinesValue.Name = "lblTotalMedicinesValue";
            this.lblTotalMedicinesValue.Size = new System.Drawing.Size(28, 29);
            this.lblTotalMedicinesValue.TabIndex = 5;
            this.lblTotalMedicinesValue.Text = "0";
            // 
            // pnlChildHost
            // 
            this.pnlChildHost.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlChildHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChildHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildHost.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChildHost.ForeColor = System.Drawing.Color.DimGray;
            this.pnlChildHost.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHost.Name = "pnlChildHost";
            this.pnlChildHost.Size = new System.Drawing.Size(1461, 802);
            this.pnlChildHost.TabIndex = 0;
            this.pnlChildHost.Visible = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 802);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharamaCore Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.pnlAdmin.ResumeLayout(false);
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlExpiringSoon.ResumeLayout(false);
            this.pnlExpiringSoon.PerformLayout();
            this.pnlTodaySales.ResumeLayout(false);
            this.pnlTodaySales.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlTotalMedicines.ResumeLayout(false);
            this.pnlTotalMedicines.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlChildHost;
        private System.Windows.Forms.Label lblTotalMedicinesValue;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Label lblPharmacyManagement;
        private System.Windows.Forms.Label lblExpiringSoonValue;
        private System.Windows.Forms.Label lblTodaySalesValue;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Label lblExpiringSoon;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTotalMedicines;
        private System.Windows.Forms.Panel pnlTotalMedicines;
        private System.Windows.Forms.Panel pnlTodaySales;
        private System.Windows.Forms.Panel pnlExpiringSoon;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlCardLowStock;
        private System.Windows.Forms.Panel pnlCardTotalMedicines;
        private System.Windows.Forms.Panel pnlCardTodaySales;
        private System.Windows.Forms.Panel pnlCardExpiringSoon;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Panel pnlInventoryDivider;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblAdmin;
    }
}
