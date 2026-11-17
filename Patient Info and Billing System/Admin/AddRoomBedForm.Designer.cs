namespace Patient_Info_and_Billing_System.Admin
{
    partial class AddRoomBedForm
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
            lblBedId = new Label();
            txtBedId = new TextBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblBedNumber = new Label();
            txtBedNumber = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblDailyRate = new Label();
            txtDailyRate = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBedId
            // 
            lblBedId.AutoSize = true;
            lblBedId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBedId.Location = new Point(24, 24);
            lblBedId.Name = "lblBedId";
            lblBedId.Size = new Size(49, 15);
            lblBedId.TabIndex = 0;
            lblBedId.Text = "Bed ID:";
            // 
            // txtBedId
            // 
            txtBedId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBedId.Location = new Point(140, 20);
            txtBedId.Name = "txtBedId";
            txtBedId.Size = new Size(210, 24);
            txtBedId.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(24, 64);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(56, 15);
            lblRoomNumber.TabIndex = 2;
            lblRoomNumber.Text = "Room #:";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(140, 60);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(210, 24);
            txtRoomNumber.TabIndex = 3;
            // 
            // lblBedNumber
            // 
            lblBedNumber.AutoSize = true;
            lblBedNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBedNumber.Location = new Point(24, 104);
            lblBedNumber.Name = "lblBedNumber";
            lblBedNumber.Size = new Size(44, 15);
            lblBedNumber.TabIndex = 4;
            lblBedNumber.Text = "Bed #:";
            // 
            // txtBedNumber
            // 
            txtBedNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBedNumber.Location = new Point(140, 100);
            txtBedNumber.Name = "txtBedNumber";
            txtBedNumber.Size = new Size(210, 24);
            txtBedNumber.TabIndex = 5;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.Location = new Point(24, 144);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(76, 15);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Room Type:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Ward", "Semi-Private", "Private", "ICU" });
            cmbRoomType.Location = new Point(140, 140);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(210, 24);
            cmbRoomType.TabIndex = 7;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailyRate.Location = new Point(24, 184);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(71, 15);
            lblDailyRate.TabIndex = 8;
            lblDailyRate.Text = "Daily Rate:";
            // 
            // txtDailyRate
            // 
            txtDailyRate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailyRate.Location = new Point(140, 180);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(210, 24);
            txtDailyRate.TabIndex = 9;
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
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied" });
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
            // AddRoomBedForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(376, 326);
            Controls.Add(lblBedId);
            Controls.Add(txtBedId);
            Controls.Add(lblRoomNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblBedNumber);
            Controls.Add(txtBedNumber);
            Controls.Add(lblRoomType);
            Controls.Add(cmbRoomType);
            Controls.Add(lblDailyRate);
            Controls.Add(txtDailyRate);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddRoomBedForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Bed / Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBedId;
        private TextBox txtBedId;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblBedNumber;
        private TextBox txtBedNumber;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblDailyRate;
        private TextBox txtDailyRate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}
