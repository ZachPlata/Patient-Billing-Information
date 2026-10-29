namespace NurseDashBoard
{
    partial class Nurse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlsidebar = new Panel();
            panel3 = new Panel();
            btn_shiftlog = new Button();
            btn_util = new Button();
            btn_ptntrec = new Button();
            btn_ptntreg = new Button();
            btn_nursedash = new Button();
            panel2 = new Panel();
            panelContent = new Panel();
            LABEL = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            timer = new Label();
            panel6 = new Panel();
            date = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlsidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlsidebar
            // 
            pnlsidebar.BackColor = Color.FromArgb(17, 34, 64);
            pnlsidebar.Controls.Add(panel3);
            pnlsidebar.Controls.Add(btn_shiftlog);
            pnlsidebar.Controls.Add(btn_util);
            pnlsidebar.Controls.Add(btn_ptntrec);
            pnlsidebar.Controls.Add(btn_ptntreg);
            pnlsidebar.Controls.Add(btn_nursedash);
            pnlsidebar.Controls.Add(panel2);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 0);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(233, 1041);
            pnlsidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 99, 235);
            panel3.Location = new Point(12, 122);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(46, 35);
            panel3.TabIndex = 9;
            // 
            // btn_shiftlog
            // 
            btn_shiftlog.FlatAppearance.BorderSize = 0;
            btn_shiftlog.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btn_shiftlog.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_shiftlog.FlatStyle = FlatStyle.Flat;
            btn_shiftlog.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_shiftlog.ForeColor = SystemColors.ControlLight;
            btn_shiftlog.ImageAlign = ContentAlignment.BottomCenter;
            btn_shiftlog.Location = new Point(0, 403);
            btn_shiftlog.Name = "btn_shiftlog";
            btn_shiftlog.Size = new Size(266, 40);
            btn_shiftlog.TabIndex = 8;
            btn_shiftlog.Text = "Shift Logs";
            btn_shiftlog.TextAlign = ContentAlignment.MiddleLeft;
            btn_shiftlog.UseVisualStyleBackColor = true;
            btn_shiftlog.Click += btn_shiftlog_Click;
            // 
            // btn_util
            // 
            btn_util.FlatAppearance.BorderSize = 0;
            btn_util.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btn_util.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_util.FlatStyle = FlatStyle.Flat;
            btn_util.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_util.ForeColor = SystemColors.ControlLight;
            btn_util.Location = new Point(0, 449);
            btn_util.Name = "btn_util";
            btn_util.Size = new Size(266, 40);
            btn_util.TabIndex = 5;
            btn_util.Text = "Utilization";
            btn_util.TextAlign = ContentAlignment.MiddleLeft;
            btn_util.UseVisualStyleBackColor = true;
            btn_util.Click += btn_util_Click;
            // 
            // btn_ptntrec
            // 
            btn_ptntrec.FlatAppearance.BorderSize = 0;
            btn_ptntrec.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btn_ptntrec.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_ptntrec.FlatStyle = FlatStyle.Flat;
            btn_ptntrec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ptntrec.ForeColor = SystemColors.Control;
            btn_ptntrec.Location = new Point(0, 357);
            btn_ptntrec.Name = "btn_ptntrec";
            btn_ptntrec.Size = new Size(266, 40);
            btn_ptntrec.TabIndex = 3;
            btn_ptntrec.Text = "Patient Records";
            btn_ptntrec.TextAlign = ContentAlignment.MiddleLeft;
            btn_ptntrec.UseVisualStyleBackColor = true;
            btn_ptntrec.Click += btn_ptntrec_Click;
            // 
            // btn_ptntreg
            // 
            btn_ptntreg.FlatAppearance.BorderSize = 0;
            btn_ptntreg.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btn_ptntreg.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_ptntreg.FlatStyle = FlatStyle.Flat;
            btn_ptntreg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ptntreg.ForeColor = SystemColors.Control;
            btn_ptntreg.Location = new Point(0, 303);
            btn_ptntreg.Name = "btn_ptntreg";
            btn_ptntreg.Size = new Size(266, 40);
            btn_ptntreg.TabIndex = 2;
            btn_ptntreg.Text = "Patient Registration";
            btn_ptntreg.TextAlign = ContentAlignment.MiddleLeft;
            btn_ptntreg.UseVisualStyleBackColor = true;
            btn_ptntreg.Click += btn_ptntreg_Click;
            // 
            // btn_nursedash
            // 
            btn_nursedash.FlatAppearance.BorderSize = 0;
            btn_nursedash.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btn_nursedash.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btn_nursedash.FlatStyle = FlatStyle.Flat;
            btn_nursedash.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nursedash.ForeColor = SystemColors.Control;
            btn_nursedash.Location = new Point(0, 249);
            btn_nursedash.Name = "btn_nursedash";
            btn_nursedash.Size = new Size(266, 40);
            btn_nursedash.TabIndex = 1;
            btn_nursedash.Text = "Dashboard";
            btn_nursedash.TextAlign = ContentAlignment.MiddleLeft;
            btn_nursedash.UseMnemonic = false;
            btn_nursedash.UseVisualStyleBackColor = true;
            btn_nursedash.Click += btn_nursedash_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 25, 47);
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 57);
            panel2.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(257, 112);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1626, 917);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint_2;
            // 
            // LABEL
            // 
            LABEL.AllowDrop = true;
            LABEL.AutoSize = true;
            LABEL.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL.ForeColor = Color.FromArgb(15, 23, 42);
            LABEL.Location = new Point(72, 31);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(311, 32);
            LABEL.TabIndex = 0;
            LABEL.Text = "NURSE CLINICAL STATION";
            LABEL.Click += LABEL_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 249, 246);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(timer);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LABEL);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(233, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1671, 94);
            panel1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 34, 64);
            panel7.Location = new Point(1459, 56);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(22, 17);
            panel7.TabIndex = 15;
            // 
            // timer
            // 
            timer.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer.Location = new Point(1486, 56);
            timer.Name = "timer";
            timer.Size = new Size(149, 17);
            timer.TabIndex = 13;
            timer.Text = "Time";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 34, 64);
            panel6.Location = new Point(1219, 56);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(22, 17);
            panel6.TabIndex = 14;
            // 
            // date
            // 
            date.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.Location = new Point(1246, 56);
            date.Name = "date";
            date.Size = new Size(207, 17);
            date.TabIndex = 12;
            date.Text = "Date";
            date.Click += date_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(319, 17);
            label2.TabIndex = 3;
            label2.Text = "Health / Clinical Diagnosis / Medical Prescriptions";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Nurse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(panelContent);
            Controls.Add(pnlsidebar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Nurse";
            Text = "Nurse";
            pnlsidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlsidebar;
        private Button button4;
        private Button btn_ptntrec;
        private Button btn_ptntreg;
        private Button btn_nursedash;
        private Panel panel2;
        private Button btn_util;
        private Panel panelContent;
        private Label LABEL;
        private Panel panel1;
        private Label label2;
        private Button shft_log;
        private Button btn_shftlog;
        private Button btn_4;
        private Button button1;
        private Button btn_shiftlog;
        private Panel panel7;
        private Label timer;
        private Panel panel6;
        private Label date;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}
