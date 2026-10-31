namespace Patient_Info_and_Billing_System.Doctor
{
    partial class Doctor
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
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
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
            SideNavBar.Controls.Add(label3);
            SideNavBar.Controls.Add(label2);
            SideNavBar.Controls.Add(panel3);
            SideNavBar.Controls.Add(btnDrDashboard);
            SideNavBar.Controls.Add(label1);
            SideNavBar.Controls.Add(panel1);
            SideNavBar.Controls.Add(btnHlthCheckup);
            SideNavBar.Controls.Add(btnPatientRecord);
            SideNavBar.Location = new Point(0, 0);
            SideNavBar.Margin = new Padding(3, 2, 3, 2);
            SideNavBar.Name = "SideNavBar";
            SideNavBar.Size = new Size(233, 881);
            SideNavBar.TabIndex = 0;
            SideNavBar.Paint += SideNavBar_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(16, 185, 129);
            label3.Location = new Point(74, 140);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "STATUS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "User's Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 99, 235);
            panel3.Location = new Point(12, 122);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(46, 35);
            panel3.TabIndex = 5;
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
            btnDrDashboard.Location = new Point(0, 275);
            btnDrDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDrDashboard.Name = "btnDrDashboard";
            btnDrDashboard.Size = new Size(233, 30);
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
            label1.Location = new Point(3, 248);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
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
            panel1.Location = new Point(0, 179);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 57);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 34, 64);
            panel4.Location = new Point(12, 12);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(46, 35);
            panel4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(63, 30);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 6;
            label5.Text = "ERP SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 9);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 5;
            label4.Text = "METRO PEDIA";
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
            btnHlthCheckup.Location = new Point(0, 344);
            btnHlthCheckup.Margin = new Padding(3, 2, 3, 2);
            btnHlthCheckup.Name = "btnHlthCheckup";
            btnHlthCheckup.Size = new Size(233, 30);
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
            btnPatientRecord.Location = new Point(0, 310);
            btnPatientRecord.Margin = new Padding(3, 2, 3, 2);
            btnPatientRecord.Name = "btnPatientRecord";
            btnPatientRecord.Size = new Size(233, 30);
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
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(3, 2, 3, 2);
            Header.Name = "Header";
            Header.Size = new Size(1664, 94);
            Header.TabIndex = 1;
            Header.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 34, 64);
            panel7.Location = new Point(1458, 56);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(22, 17);
            panel7.TabIndex = 11;
            // 
            // timer
            // 
            timer.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer.Location = new Point(1485, 56);
            timer.Name = "timer";
            timer.Size = new Size(149, 17);
            timer.TabIndex = 3;
            timer.Text = "Time";
            timer.Click += label8_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 34, 64);
            panel6.Location = new Point(1218, 56);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(22, 17);
            panel6.TabIndex = 10;
            // 
            // date
            // 
            date.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(1245, 56);
            date.Name = "date";
            date.Size = new Size(207, 17);
            date.TabIndex = 2;
            date.Text = "Date";
            date.Click += timer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(10, 56);
            label7.Name = "label7";
            label7.Size = new Size(412, 19);
            label7.TabIndex = 9;
            label7.Text = "Health Check Up / Clinical Diagnosis / Medical Presicriptions";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(17, 34, 64);
            panel5.Location = new Point(12, 23);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(46, 31);
            panel5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(63, 23);
            label6.Name = "label6";
            label6.Size = new Size(331, 32);
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
            panelContent.Location = new Point(257, 112);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1387, 645);
            panelContent.TabIndex = 2;
            panelContent.Paint += panel8_Paint;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(panelContent);
            Controls.Add(Header);
            Controls.Add(SideNavBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Doctor";
            Text = "Metro Pedia Clinical Center - Management System";
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
        private Label label2;
        private Panel panel3;
        private Label label3;
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
    }
}