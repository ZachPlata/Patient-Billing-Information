namespace NurseDashBoard
{
    partial class uc_dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAvailableBeds = new Panel();
            panel1 = new Panel();
            label10 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            pnlAdmittedPatients = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            pnlBedOccupancyRate = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label13 = new Label();
            colorDialog1 = new ColorDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label7 = new Label();
            label11 = new Label();
            pnlAvailableBeds.SuspendLayout();
            panel6.SuspendLayout();
            pnlAdmittedPatients.SuspendLayout();
            pnlBedOccupancyRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAvailableBeds
            // 
            pnlAvailableBeds.BackColor = SystemColors.ControlLightLight;
            pnlAvailableBeds.BorderStyle = BorderStyle.FixedSingle;
            pnlAvailableBeds.Controls.Add(panel1);
            pnlAvailableBeds.Controls.Add(label10);
            pnlAvailableBeds.Controls.Add(label5);
            pnlAvailableBeds.Controls.Add(label1);
            pnlAvailableBeds.Location = new Point(3, 3);
            pnlAvailableBeds.Margin = new Padding(3, 3, 90, 3);
            pnlAvailableBeds.Name = "pnlAvailableBeds";
            pnlAvailableBeds.Size = new Size(230, 140);
            pnlAvailableBeds.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Location = new Point(-4, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 10);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(3, 74);
            label10.Name = "label10";
            label10.Size = new Size(88, 45);
            label10.TabIndex = 3;
            label10.Text = "1 / 8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(1, 119);
            label5.Name = "label5";
            label5.Size = new Size(182, 17);
            label5.TabIndex = 1;
            label5.Text = "Ready for patient admission";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 35);
            label1.Name = "label1";
            label1.Size = new Size(213, 21);
            label1.TabIndex = 0;
            label1.Text = "🛏️ TOTAL AVAILABLE BEDS";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label16);
            panel6.Location = new Point(972, 3);
            panel6.Margin = new Padding(3, 3, 90, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 140);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(17, 24, 39);
            panel7.Location = new Point(-1, 59);
            panel7.Name = "panel7";
            panel7.Size = new Size(215, 10);
            panel7.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(3, 74);
            label14.Name = "label14";
            label14.Size = new Size(38, 45);
            label14.TabIndex = 5;
            label14.Text = "4";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(3, 119);
            label15.Name = "label15";
            label15.Size = new Size(166, 17);
            label15.TabIndex = 3;
            label15.Text = "Active profiles on records";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(-1, 35);
            label16.Name = "label16";
            label16.Size = new Size(215, 21);
            label16.TabIndex = 2;
            label16.Text = "👤 TOTAL CLINIC PATIENTS";
            // 
            // pnlAdmittedPatients
            // 
            pnlAdmittedPatients.BackColor = SystemColors.ControlLightLight;
            pnlAdmittedPatients.BorderStyle = BorderStyle.FixedSingle;
            pnlAdmittedPatients.Controls.Add(panel2);
            pnlAdmittedPatients.Controls.Add(label9);
            pnlAdmittedPatients.Controls.Add(label6);
            pnlAdmittedPatients.Controls.Add(label2);
            pnlAdmittedPatients.Location = new Point(649, 3);
            pnlAdmittedPatients.Margin = new Padding(3, 3, 90, 3);
            pnlAdmittedPatients.Name = "pnlAdmittedPatients";
            pnlAdmittedPatients.Size = new Size(230, 140);
            pnlAdmittedPatients.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 96, 232);
            panel2.Location = new Point(-1, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 10);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 74);
            label9.Name = "label9";
            label9.Size = new Size(38, 45);
            label9.TabIndex = 4;
            label9.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 119);
            label6.Name = "label6";
            label6.Size = new Size(219, 17);
            label6.TabIndex = 2;
            label6.Text = "Currently occupying hospital beds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 1;
            label2.Text = "👤 ADMITTED PATIENTS";
            label2.Click += label2_Click;
            // 
            // pnlBedOccupancyRate
            // 
            pnlBedOccupancyRate.BackColor = SystemColors.ControlLightLight;
            pnlBedOccupancyRate.BorderStyle = BorderStyle.FixedSingle;
            pnlBedOccupancyRate.Controls.Add(label4);
            pnlBedOccupancyRate.Controls.Add(panel4);
            pnlBedOccupancyRate.Controls.Add(label12);
            pnlBedOccupancyRate.Controls.Add(label8);
            pnlBedOccupancyRate.Location = new Point(326, 3);
            pnlBedOccupancyRate.Margin = new Padding(3, 3, 90, 3);
            pnlBedOccupancyRate.Name = "pnlBedOccupancyRate";
            pnlBedOccupancyRate.Size = new Size(230, 140);
            pnlBedOccupancyRate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(-1, 35);
            label4.Name = "label4";
            label4.Size = new Size(211, 21);
            label4.TabIndex = 8;
            label4.Text = "🛏️ BED OCCUPANCY RATE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(239, 165, 28);
            panel4.Location = new Point(-1, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 10);
            panel4.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(3, 77);
            label12.Name = "label12";
            label12.Size = new Size(38, 45);
            label12.TabIndex = 6;
            label12.Text = "4";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(3, 119);
            label8.Name = "label8";
            label8.Size = new Size(149, 17);
            label8.TabIndex = 4;
            label8.Text = "Current capacity status";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1529, 637);
            dataGridView1.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(17, 24, 39);
            label13.Location = new Point(28, 177);
            label13.Name = "label13";
            label13.Size = new Size(238, 21);
            label13.TabIndex = 5;
            label13.Text = "⚕️ HOSPITAL ROOOM STATUS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pnlAvailableBeds);
            flowLayoutPanel1.Controls.Add(pnlBedOccupancyRate);
            flowLayoutPanel1.Controls.Add(pnlAdmittedPatients);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(28, 31);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1529, 143);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(1295, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 140);
            panel3.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(17, 24, 39);
            panel5.Location = new Point(-1, 59);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 10);
            panel5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(38, 45);
            label3.TabIndex = 5;
            label3.Text = "4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(3, 119);
            label7.Name = "label7";
            label7.Size = new Size(166, 17);
            label7.TabIndex = 3;
            label7.Text = "Active profiles on records";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(-1, 35);
            label11.Name = "label11";
            label11.Size = new Size(196, 21);
            label11.TabIndex = 2;
            label11.Text = "👤 AVAILABLE DOCTORS";
            // 
            // uc_dashboard
            // 
            AccessibleName = "Dashboard";
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label13);
            Controls.Add(dataGridView1);
            Name = "uc_dashboard";
            Size = new Size(1585, 860);
            Load += uc_dashboard_Load;
            pnlAvailableBeds.ResumeLayout(false);
            pnlAvailableBeds.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlAdmittedPatients.ResumeLayout(false);
            pnlAdmittedPatients.PerformLayout();
            pnlBedOccupancyRate.ResumeLayout(false);
            pnlBedOccupancyRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Panel pnlAvailableBeds;
        private Panel pnlAdmittedPatients;
        private Panel pnlBedOccupancyRate;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label12;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label label13;
        private ColorDialog colorDialog1;
        private Panel panel6;
        private Panel panel7;
        private Label label14;
        private Label label15;
        private Label label16;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel5;
        private Label label3;
        private Label label7;
        private Label label11;
        private Label label4;
    }
}
