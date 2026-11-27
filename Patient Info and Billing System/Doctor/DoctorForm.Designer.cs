namespace Patient_Info_and_Billing_System.Doctor
{
    partial class DoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SideNavBar = new Panel();
            label8 = new Label();
            label9 = new Label();
            userLabel = new Label();
            panel2 = new Panel();
            btnDrDashboard = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnHlthCheckup = new Button();
            btnPatientRecord = new Button();
            Header = new Panel();
            panel7 = new Panel();
            timer = new Label();
            panel6 = new Panel();
            date = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelContent = new Panel();
            SideNavBar.SuspendLayout();
            panel1.SuspendLayout();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // SideNavBar
            // 
            SideNavBar.BackColor = Color.FromArgb(17, 34, 64);
            SideNavBar.Controls.Add(label8);
            SideNavBar.Controls.Add(label9);
            SideNavBar.Controls.Add(userLabel);
            SideNavBar.Controls.Add(panel2);
            SideNavBar.Controls.Add(btnDrDashboard);
            SideNavBar.Controls.Add(label1);
            SideNavBar.Controls.Add(panel1);
            SideNavBar.Controls.Add(btnHlthCheckup);
            SideNavBar.Controls.Add(btnPatientRecord);
            SideNavBar.Dock = DockStyle.Left;
            SideNavBar.Location = new Point(0, 0);
            SideNavBar.Name = "SideNavBar";
            SideNavBar.Size = new Size(266, 1033);
            SideNavBar.TabIndex = 0;
            SideNavBar.Paint += SideNavBar_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(81, 53);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 12;
            label8.Text = "Specialization";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(16, 185, 129);
            label9.Location = new Point(85, 80);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 11;
            label9.Text = "STATUS";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(85, 31);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(97, 20);
            userLabel.TabIndex = 9;
            userLabel.Text = "User's Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 99, 235);
            panel2.Location = new Point(14, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 64);
            panel2.TabIndex = 10;
            // 
            // btnDrDashboard
            // 
            btnDrDashboard.FlatAppearance.BorderSize = 0;
            btnDrDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            btnDrDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnDrDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnDrDashboard.FlatStyle = FlatStyle.Flat;
            btnDrDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrDashboard.ForeColor = Color.White;
            btnDrDashboard.Location = new Point(0, 257);
            btnDrDashboard.Name = "btnDrDashboard";
            btnDrDashboard.Size = new Size(266, 40);
            btnDrDashboard.TabIndex = 0;
            btnDrDashboard.Text = "Dashboard";
            btnDrDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDrDashboard.UseVisualStyleBackColor = true;
            btnDrDashboard.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(3, 221);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 4;
            label1.Text = "Clinical Workspaces";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 25, 47);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 76);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 34, 64);
            panel4.Location = new Point(14, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(53, 47);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(72, 40);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 6;
            label5.Text = "ERP SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 12);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 5;
            label4.Text = "METRO CARE";
            label4.Click += label4_Click;
            // 
            // btnHlthCheckup
            // 
            btnHlthCheckup.FlatAppearance.BorderSize = 0;
            btnHlthCheckup.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            btnHlthCheckup.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnHlthCheckup.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnHlthCheckup.FlatStyle = FlatStyle.Flat;
            btnHlthCheckup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHlthCheckup.ForeColor = Color.White;
            btnHlthCheckup.Location = new Point(0, 349);
            btnHlthCheckup.Name = "btnHlthCheckup";
            btnHlthCheckup.Size = new Size(266, 40);
            btnHlthCheckup.TabIndex = 2;
            btnHlthCheckup.Text = "Health Checkup";
            btnHlthCheckup.TextAlign = ContentAlignment.MiddleLeft;
            btnHlthCheckup.UseVisualStyleBackColor = true;
            btnHlthCheckup.Click += button3_Click;
            // 
            // btnPatientRecord
            // 
            btnPatientRecord.FlatAppearance.BorderSize = 0;
            btnPatientRecord.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            btnPatientRecord.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnPatientRecord.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnPatientRecord.FlatStyle = FlatStyle.Flat;
            btnPatientRecord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatientRecord.ForeColor = Color.White;
            btnPatientRecord.Location = new Point(0, 304);
            btnPatientRecord.Name = "btnPatientRecord";
            btnPatientRecord.Size = new Size(266, 40);
            btnPatientRecord.TabIndex = 1;
            btnPatientRecord.Text = "Patient Records";
            btnPatientRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientRecord.UseVisualStyleBackColor = true;
            btnPatientRecord.Click += button2_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(250, 249, 246);
            Header.Controls.Add(panel7);
            Header.Controls.Add(timer);
            Header.Controls.Add(panel6);
            Header.Controls.Add(date);
            Header.Controls.Add(label7);
            Header.Controls.Add(panel5);
            Header.Controls.Add(label6);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(266, 0);
            Header.Name = "Header";
            Header.Size = new Size(1636, 125);
            Header.TabIndex = 1;
            Header.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 34, 64);
            panel7.Location = new Point(1666, 75);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 23);
            panel7.TabIndex = 11;
            // 
            // timer
            // 
            timer.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer.Location = new Point(1697, 75);
            timer.Name = "timer";
            timer.Size = new Size(170, 23);
            timer.TabIndex = 3;
            timer.Text = "Time";
            timer.Click += label8_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 34, 64);
            panel6.Location = new Point(1392, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(25, 23);
            panel6.TabIndex = 10;
            // 
            // date
            // 
            date.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(1423, 75);
            date.Name = "date";
            date.Size = new Size(237, 23);
            date.TabIndex = 2;
            date.Text = "Date";
            date.Click += timer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(11, 75);
            label7.Name = "label7";
            label7.Size = new Size(496, 23);
            label7.TabIndex = 9;
            label7.Text = "Health Check Up / Clinical Diagnosis / Medical Presicriptions";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(17, 34, 64);
            panel5.Location = new Point(14, 31);
            panel5.Name = "panel5";
            panel5.Size = new Size(53, 41);
            panel5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(72, 31);
            label6.Name = "label6";
            label6.Size = new Size(418, 41);
            label6.TabIndex = 6;
            label6.Text = "DOCTOR CLINICAL STATION";
            label6.Click += label6_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(250, 249, 246);
            panelContent.Location = new Point(294, 149);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1585, 860);
            panelContent.TabIndex = 2;
            panelContent.Paint += panel8_Paint;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelContent);
            Controls.Add(Header);
            Controls.Add(SideNavBar);
            Name = "DoctorForm";
            Text = "  ";
            WindowState = FormWindowState.Maximized;
            Load += Doctor_Load;
            SideNavBar.ResumeLayout(false);
            SideNavBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SideNavBar;
        private Panel Header;
        private Button btnPatientRecord;
        private Button btnDrDashboard;
        private Button btnHlthCheckup;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Label label7;
        private Label date;
        private System.Windows.Forms.Timer timer1;
        private Panel panel6;
        private Label timer;
        private Panel panel7;
        private Panel panelContent;
        private Label label8;
        private Label label9;
        public Label userLabel;
        private Panel panel2;
    }
}