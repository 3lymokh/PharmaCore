namespace PharmaCore
{
    partial class MedicinesForm
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
            this.txtSearchMedicine = new System.Windows.Forms.TextBox();
            this.btnSearchMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnEditMedicine = new System.Windows.Forms.Button();
            this.btnDeleteMedicine = new System.Windows.Forms.Button();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Location = new System.Drawing.Point(41, 141);
            this.txtSearchMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMedicine.Multiline = true;
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.Size = new System.Drawing.Size(490, 44);
            this.txtSearchMedicine.TabIndex = 0;
            this.txtSearchMedicine.TextChanged += new System.EventHandler(this.txtSearchMedicine_TextChanged);
            // 
            // btnSearchMedicine
            // 
            this.btnSearchMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(186)))));
            this.btnSearchMedicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchMedicine.Location = new System.Drawing.Point(565, 141);
            this.btnSearchMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMedicine.Name = "btnSearchMedicine";
            this.btnSearchMedicine.Size = new System.Drawing.Size(86, 44);
            this.btnSearchMedicine.TabIndex = 1;
            this.btnSearchMedicine.Text = "Search";
            this.btnSearchMedicine.UseVisualStyleBackColor = false;
            this.btnSearchMedicine.Click += new System.EventHandler(this.btnSearchMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(186)))));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMedicine.Location = new System.Drawing.Point(687, 141);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(86, 44);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.Text = "ADD";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnEditMedicine
            // 
            this.btnEditMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(186)))));
            this.btnEditMedicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditMedicine.Location = new System.Drawing.Point(804, 141);
            this.btnEditMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditMedicine.Name = "btnEditMedicine";
            this.btnEditMedicine.Size = new System.Drawing.Size(86, 44);
            this.btnEditMedicine.TabIndex = 3;
            this.btnEditMedicine.Text = "Edit";
            this.btnEditMedicine.UseVisualStyleBackColor = false;
            this.btnEditMedicine.Click += new System.EventHandler(this.btnEditMedicine_Click);
            // 
            // btnDeleteMedicine
            // 
            this.btnDeleteMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteMedicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteMedicine.Location = new System.Drawing.Point(934, 141);
            this.btnDeleteMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteMedicine.Name = "btnDeleteMedicine";
            this.btnDeleteMedicine.Size = new System.Drawing.Size(86, 44);
            this.btnDeleteMedicine.TabIndex = 4;
            this.btnDeleteMedicine.Text = "Delete";
            this.btnDeleteMedicine.UseVisualStyleBackColor = false;
            this.btnDeleteMedicine.Click += new System.EventHandler(this.btnDeleteMedicine_Click);
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(41, 219);
            this.dgvMedicines.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersWidth = 51;
            this.dgvMedicines.RowTemplate.Height = 24;
            this.dgvMedicines.Size = new System.Drawing.Size(770, 287);
            this.dgvMedicines.TabIndex = 5;
            this.dgvMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pharmacy Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Medicines";
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1093, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.btnDeleteMedicine);
            this.Controls.Add(this.btnEditMedicine);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnSearchMedicine);
            this.Controls.Add(this.txtSearchMedicine);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MedicinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicinesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchMedicine;
        private System.Windows.Forms.Button btnSearchMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnEditMedicine;
        private System.Windows.Forms.Button btnDeleteMedicine;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
