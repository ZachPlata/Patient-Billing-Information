namespace Patient_Info_and_Billing_System.BillingStaff
{
    partial class BillingStaffForm
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
            Header = new Panel();
            panel7 = new Panel();
            timer = new Label();
            panel6 = new Panel();
            date = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            SideNavBar = new Panel();
            button1 = new Button();
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
            panelContent = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            payment_id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            Header.SuspendLayout();
            SideNavBar.SuspendLayout();
            panel1.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
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
            Header.TabIndex = 2;
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
            date.Click += date_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(10, 56);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 9;
            label7.Text = "Balance / ";
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
            label6.Size = new Size(284, 32);
            label6.TabIndex = 6;
            label6.Text = "BILLING STAFF STATION";
            // 
            // SideNavBar
            // 
            SideNavBar.BackColor = Color.FromArgb(17, 34, 64);
            SideNavBar.Controls.Add(button1);
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
            SideNavBar.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(37, 99, 235);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 379);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(233, 30);
            button1.TabIndex = 7;
            button1.Text = "Payment History";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            btnHlthCheckup.Text = "Payment Form";
            btnHlthCheckup.TextAlign = ContentAlignment.MiddleLeft;
            btnHlthCheckup.UseVisualStyleBackColor = true;
            btnHlthCheckup.Click += btnHlthCheckup_Click;
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
            btnPatientRecord.Text = "Patient Billing Records";
            btnPatientRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientRecord.UseVisualStyleBackColor = true;
            btnPatientRecord.Click += btnPatientRecord_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(250, 249, 246);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(panel8);
            panelContent.Location = new Point(257, 112);
            panelContent.Margin = new Padding(3, 2, 3, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1387, 645);
            panelContent.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(755, 74);
            button3.Name = "button3";
            button3.Size = new Size(217, 34);
            button3.TabIndex = 7;
            button3.Text = "Settle / Pay Selected Bill";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All status" });
            comboBox1.Location = new Point(573, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(459, 77);
            label8.Name = "label8";
            label8.Size = new Size(118, 28);
            label8.TabIndex = 5;
            label8.Text = "Status Filter:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(28, 74);
            label9.Name = "label9";
            label9.Size = new Size(166, 28);
            label9.TabIndex = 4;
            label9.Text = "Search(ID/ Name)";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(195, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 31);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(195, 132);
            button2.Name = "button2";
            button2.Size = new Size(143, 36);
            button2.TabIndex = 2;
            button2.Text = "Payment History";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(15, 33, 62);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(28, 132);
            button4.Name = "button4";
            button4.Size = new Size(143, 36);
            button4.TabIndex = 1;
            button4.Text = "View patient bills";
            button4.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(22, 17);
            label10.Name = "label10";
            label10.Size = new Size(306, 38);
            label10.TabIndex = 0;
            label10.Text = "Recent Transaction Bills";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { payment_id, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(0, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1582, 644);
            dataGridView1.TabIndex = 3;
            // 
            // payment_id
            // 
            payment_id.HeaderText = "Payment ID";
            payment_id.MinimumWidth = 6;
            payment_id.Name = "payment_id";
            payment_id.Width = 210;
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 210;
            // 
            // Column2
            // 
            Column2.HeaderText = "Patient Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 210;
            // 
            // Column3
            // 
            Column3.HeaderText = "Payment Details";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 210;
            // 
            // Column4
            // 
            Column4.HeaderText = "Amount";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 210;
            // 
            // Column5
            // 
            Column5.HeaderText = "Payment Methods";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 210;
            // 
            // Column6
            // 
            Column6.HeaderText = "Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 210;
            // 
            // Column7
            // 
            Column7.HeaderText = "Time";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 210;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(10, 22, 40);
            panel8.Controls.Add(button3);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(panel2);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(button4);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1582, 381);
            panel8.TabIndex = 2;
            // 
            // BillingStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(panelContent);
            Controls.Add(Header);
            Controls.Add(SideNavBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BillingStaffForm";
            Text = "BillingStaff";
            WindowState = FormWindowState.Maximized;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            SideNavBar.ResumeLayout(false);
            SideNavBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel panel7;
        private Label timer;
        private Panel panel6;
        private Label date;
        private Label label7;
        private Panel panel5;
        private Label label6;
        private Panel SideNavBar;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnDrDashboard;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Button btnHlthCheckup;
        private Button btnPatientRecord;
        private Button button1;
        private Panel panelContent;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn payment_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel8;
        private Button button3;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Button button2;
        private Button button4;
        private Label label10;
    }
}