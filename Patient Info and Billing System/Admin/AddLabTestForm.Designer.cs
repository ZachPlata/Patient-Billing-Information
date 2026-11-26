namespace Patient_Info_and_Billing_System.Admin
{
    partial class AddLabTestForm
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
            lblTestCode = new Label();
            txtTestCode = new TextBox();
            lblTestName = new Label();
            txtTestName = new TextBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblTurnaround = new Label();
            txtTurnaround = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTestCode
            // 
            lblTestCode.AutoSize = true;
            lblTestCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestCode.Location = new Point(24, 24);
            lblTestCode.Name = "lblTestCode";
            lblTestCode.Size = new Size(68, 15);
            lblTestCode.TabIndex = 0;
            lblTestCode.Text = "Test Code:";
            // 
            // txtTestCode
            // 
            txtTestCode.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestCode.Location = new Point(140, 20);
            txtTestCode.Name = "txtTestCode";
            txtTestCode.Size = new Size(210, 24);
            txtTestCode.TabIndex = 1;
            // 
            // lblTestName
            // 
            lblTestName.AutoSize = true;
            lblTestName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestName.Location = new Point(24, 64);
            lblTestName.Name = "lblTestName";
            lblTestName.Size = new Size(72, 15);
            lblTestName.TabIndex = 2;
            lblTestName.Text = "Test Name:";
            // 
            // txtTestName
            // 
            txtTestName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTestName.Location = new Point(140, 60);
            txtTestName.Name = "txtTestName";
            txtTestName.Size = new Size(210, 24);
            txtTestName.TabIndex = 3;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartment.Location = new Point(24, 104);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(80, 15);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Hematology", "Clinical Chemistry", "Serology & Virology", "Clinical Microscopy", "Microbiology" });
            cmbDepartment.Location = new Point(140, 100);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(210, 24);
            cmbDepartment.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(24, 144);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(140, 140);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 24);
            txtPrice.TabIndex = 7;
            // 
            // lblTurnaround
            // 
            lblTurnaround.AutoSize = true;
            lblTurnaround.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurnaround.Location = new Point(24, 184);
            lblTurnaround.Name = "lblTurnaround";
            lblTurnaround.Size = new Size(78, 15);
            lblTurnaround.TabIndex = 8;
            lblTurnaround.Text = "Turnaround:";
            // 
            // txtTurnaround
            // 
            txtTurnaround.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTurnaround.Location = new Point(140, 180);
            txtTurnaround.Name = "txtTurnaround";
            txtTurnaround.Size = new Size(210, 24);
            txtTurnaround.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(24, 224);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(46, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(140, 220);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(210, 24);
            cmbStatus.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 272);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(270, 272);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 32);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddLabTestForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(376, 326);
            Controls.Add(lblTestCode);
            Controls.Add(txtTestCode);
            Controls.Add(lblTestName);
            Controls.Add(txtTestName);
            Controls.Add(lblDepartment);
            Controls.Add(cmbDepartment);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblTurnaround);
            Controls.Add(txtTurnaround);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLabTestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Lab Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTestCode;
        private TextBox txtTestCode;
        private Label lblTestName;
        private TextBox txtTestName;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblTurnaround;
        private TextBox txtTurnaround;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}
