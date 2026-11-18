namespace Patient_Info_and_Billing_System.Admin
{
    partial class AddFeeScheduleForm
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
            lblPhysician = new Label();
            cmbDoctor = new ComboBox();
            lblStandardFee = new Label();
            txtStandardFee = new TextBox();
            lblFollowUpFee = new Label();
            txtFollowUpFee = new TextBox();
            lblScheduleDays = new Label();
            txtScheduleDays = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPhysician
            // 
            lblPhysician.AutoSize = true;
            lblPhysician.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhysician.Location = new Point(24, 24);
            lblPhysician.Name = "lblPhysician";
            lblPhysician.Size = new Size(65, 15);
            lblPhysician.TabIndex = 0;
            lblPhysician.Text = "Physician:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(140, 20);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(210, 24);
            cmbDoctor.TabIndex = 1;
            // 
            // lblStandardFee
            // 
            lblStandardFee.AutoSize = true;
            lblStandardFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStandardFee.Location = new Point(24, 64);
            lblStandardFee.Name = "lblStandardFee";
            lblStandardFee.Size = new Size(88, 15);
            lblStandardFee.TabIndex = 2;
            lblStandardFee.Text = "Standard Fee:";
            // 
            // txtStandardFee
            // 
            txtStandardFee.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStandardFee.Location = new Point(140, 60);
            txtStandardFee.Name = "txtStandardFee";
            txtStandardFee.Size = new Size(210, 24);
            txtStandardFee.TabIndex = 3;
            // 
            // lblFollowUpFee
            // 
            lblFollowUpFee.AutoSize = true;
            lblFollowUpFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFollowUpFee.Location = new Point(24, 104);
            lblFollowUpFee.Name = "lblFollowUpFee";
            lblFollowUpFee.Size = new Size(92, 15);
            lblFollowUpFee.TabIndex = 4;
            lblFollowUpFee.Text = "Follow-Up Fee:";
            // 
            // txtFollowUpFee
            // 
            txtFollowUpFee.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFollowUpFee.Location = new Point(140, 100);
            txtFollowUpFee.Name = "txtFollowUpFee";
            txtFollowUpFee.Size = new Size(210, 24);
            txtFollowUpFee.TabIndex = 5;
            // 
            // lblScheduleDays
            // 
            lblScheduleDays.AutoSize = true;
            lblScheduleDays.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScheduleDays.Location = new Point(24, 144);
            lblScheduleDays.Name = "lblScheduleDays";
            lblScheduleDays.Size = new Size(93, 15);
            lblScheduleDays.TabIndex = 6;
            lblScheduleDays.Text = "Schedule Days:";
            // 
            // txtScheduleDays
            // 
            txtScheduleDays.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScheduleDays.Location = new Point(140, 140);
            txtScheduleDays.Name = "txtScheduleDays";
            txtScheduleDays.Size = new Size(210, 24);
            txtScheduleDays.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(270, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 32);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddFeeScheduleForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(376, 246);
            Controls.Add(lblPhysician);
            Controls.Add(cmbDoctor);
            Controls.Add(lblStandardFee);
            Controls.Add(txtStandardFee);
            Controls.Add(lblFollowUpFee);
            Controls.Add(txtFollowUpFee);
            Controls.Add(lblScheduleDays);
            Controls.Add(txtScheduleDays);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFeeScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Fee Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhysician;
        private ComboBox cmbDoctor;
        private Label lblStandardFee;
        private TextBox txtStandardFee;
        private Label lblFollowUpFee;
        private TextBox txtFollowUpFee;
        private Label lblScheduleDays;
        private TextBox txtScheduleDays;
        private Button btnSave;
        private Button btnCancel;
    }
}
