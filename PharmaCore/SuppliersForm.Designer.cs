namespace PharmaCore
{
    partial class SuppliersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSupplier = new System.Windows.Forms.Button();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDeleteSupplier);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvSuppliers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveSupplier);
            this.panel1.Controls.Add(this.txtSupplierPhone);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.txtSupplierName);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(37, 223);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 249);
            this.panel1.TabIndex = 0;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(797, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            //
            // btnDeleteSupplier
            //
            this.btnDeleteSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.White;
            this.btnDeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(1167, 162);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(75, 54);
            this.btnDeleteSupplier.TabIndex = 5;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(412, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            //
            // dgvSuppliers
            //
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(29, 162);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersWidth = 51;
            this.dgvSuppliers.RowTemplate.Height = 24;
            this.dgvSuppliers.Size = new System.Drawing.Size(1122, 54);
            this.dgvSuppliers.TabIndex = 4;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(125)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            //
            // btnSaveSupplier
            //
            this.btnSaveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.btnSaveSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSupplier.FlatAppearance.BorderSize = 0;
            this.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSaveSupplier.Location = new System.Drawing.Point(1167, 39);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(75, 38);
            this.btnSaveSupplier.TabIndex = 3;
            this.btnSaveSupplier.Text = "Save";
            this.btnSaveSupplier.UseVisualStyleBackColor = false;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            //
            // txtSupplierPhone
            //
            this.txtSupplierPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.txtSupplierPhone.Location = new System.Drawing.Point(801, 39);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(350, 38);
            this.txtSupplierPhone.TabIndex = 2;
            //
            // txtCompany
            //
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.txtCompany.Location = new System.Drawing.Point(416, 39);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(364, 38);
            this.txtCompany.TabIndex = 1;
            //
            // txtSupplierName
            //
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.txtSupplierName.Location = new System.Drawing.Point(29, 39);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(371, 38);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(53, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "PHARMACY MANAGEMENT";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(59, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 41);
            this.label5.TabIndex = 2;
            this.label5.Text = "Suppliers";
            //
            // SuppliersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1515, 1044);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 800);
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnSaveSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}