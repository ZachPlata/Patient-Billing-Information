namespace Patient_Info_and_Billing_System.Admin
{
    partial class AddMedicineForm
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
            lblMedicineCode = new Label();
            txtMedicineCode = new TextBox();
            lblMedicineName = new Label();
            txtMedicineName = new TextBox();
            lblDosageUnit = new Label();
            txtDosageUnit = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblStockQty = new Label();
            txtStockQty = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMedicineCode
            // 
            lblMedicineCode.AutoSize = true;
            lblMedicineCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicineCode.Location = new Point(24, 24);
            lblMedicineCode.Name = "lblMedicineCode";
            lblMedicineCode.Size = new Size(97, 15);
            lblMedicineCode.TabIndex = 0;
            lblMedicineCode.Text = "Medicine Code:";
            // 
            // txtMedicineCode
            // 
            txtMedicineCode.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedicineCode.Location = new Point(140, 20);
            txtMedicineCode.Name = "txtMedicineCode";
            txtMedicineCode.Size = new Size(210, 24);
            txtMedicineCode.TabIndex = 1;
            // 
            // lblMedicineName
            // 
            lblMedicineName.AutoSize = true;
            lblMedicineName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicineName.Location = new Point(24, 64);
            lblMedicineName.Name = "lblMedicineName";
            lblMedicineName.Size = new Size(100, 15);
            lblMedicineName.TabIndex = 2;
            lblMedicineName.Text = "Medicine Name:";
            // 
            // txtMedicineName
            // 
            txtMedicineName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedicineName.Location = new Point(140, 60);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(210, 24);
            txtMedicineName.TabIndex = 3;
            // 
            // lblDosageUnit
            // 
            lblDosageUnit.AutoSize = true;
            lblDosageUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDosageUnit.Location = new Point(24, 104);
            lblDosageUnit.Name = "lblDosageUnit";
            lblDosageUnit.Size = new Size(82, 15);
            lblDosageUnit.TabIndex = 4;
            lblDosageUnit.Text = "Dosage Unit:";
            // 
            // txtDosageUnit
            // 
            txtDosageUnit.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDosageUnit.Location = new Point(140, 100);
            txtDosageUnit.Name = "txtDosageUnit";
            txtDosageUnit.Size = new Size(210, 24);
            txtDosageUnit.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(24, 144);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(140, 140);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(210, 24);
            txtCategory.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(24, 184);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(67, 15);
            lblUnitPrice.TabIndex = 8;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(140, 180);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(210, 24);
            txtUnitPrice.TabIndex = 9;
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockQty.Location = new Point(24, 224);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(66, 15);
            lblStockQty.TabIndex = 10;
            lblStockQty.Text = "Stock Qty:";
            // 
            // txtStockQty
            // 
            txtStockQty.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQty.Location = new Point(140, 220);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(210, 24);
            txtStockQty.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(24, 264);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(140, 260);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(210, 24);
            cmbStatus.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(270, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 32);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddMedicineForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(376, 366);
            Controls.Add(lblMedicineCode);
            Controls.Add(txtMedicineCode);
            Controls.Add(lblMedicineName);
            Controls.Add(txtMedicineName);
            Controls.Add(lblDosageUnit);
            Controls.Add(txtDosageUnit);
            Controls.Add(lblCategory);
            Controls.Add(txtCategory);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblStockQty);
            Controls.Add(txtStockQty);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddMedicineForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Medicine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMedicineCode;
        private TextBox txtMedicineCode;
        private Label lblMedicineName;
        private TextBox txtMedicineName;
        private Label lblDosageUnit;
        private TextBox txtDosageUnit;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblStockQty;
        private TextBox txtStockQty;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}
