namespace PharmaCore
{
    partial class SalesForm
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
            this.lblMedicine = new System.Windows.Forms.Label();
            this.cmbMedicines = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblWordTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();


            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(76, 58);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(70, 19);
            this.lblMedicine.TabIndex = 0;
            this.lblMedicine.Text = "Medicine";


            this.cmbMedicines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicines.FormattingEnabled = true;
            this.cmbMedicines.Location = new System.Drawing.Point(80, 81);
            this.cmbMedicines.Name = "cmbMedicines";
            this.cmbMedicines.Size = new System.Drawing.Size(303, 24);
            this.cmbMedicines.TabIndex = 1;


            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(414, 60);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 19);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";


            this.nudQty.Location = new System.Drawing.Point(417, 83);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(120, 22);
            this.nudQty.TabIndex = 3;


            this.btnAddToCart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddToCart.Location = new System.Drawing.Point(553, 70);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(98, 44);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);


            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(678, 70);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(95, 44);
            this.btnRemoveFromCart.TabIndex = 5;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);


            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(80, 133);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(693, 210);
            this.dgvCart.TabIndex = 6;


            this.lblWordTotal.AutoSize = true;
            this.lblWordTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordTotal.Location = new System.Drawing.Point(77, 400);
            this.lblWordTotal.Name = "lblWordTotal";
            this.lblWordTotal.Size = new System.Drawing.Size(51, 19);
            this.lblWordTotal.TabIndex = 7;
            this.lblWordTotal.Text = "Total :";


            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(135, 400);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";


            this.btnCheckout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCheckout.Location = new System.Drawing.Point(678, 392);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(95, 37);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblWordTotal);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbMedicines);
            this.Controls.Add(this.lblMedicine);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ComboBox cmbMedicines;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblWordTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;
    }
}
