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
            pnlTotalClinicPatients = new Panel();
            panel3 = new Panel();
            label11 = new Label();
            label7 = new Label();
            label3 = new Label();
            pnlAdmittedPatients = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label2 = new Label();
            pnlBedOccupancyRate = new Panel();
            panel4 = new Panel();
            label12 = new Label();
            label8 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            pnlAvailableBeds.SuspendLayout();
            pnlTotalClinicPatients.SuspendLayout();
            pnlAdmittedPatients.SuspendLayout();
            pnlBedOccupancyRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlAvailableBeds.Location = new Point(28, 35);
            pnlAvailableBeds.Name = "pnlAvailableBeds";
            pnlAvailableBeds.Size = new Size(230, 103);
            pnlAvailableBeds.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Location = new Point(3, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 10);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(3, 43);
            label10.Name = "label10";
            label10.Size = new Size(67, 32);
            label10.TabIndex = 3;
            label10.Text = "1 / 8";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 77);
            label5.Name = "label5";
            label5.Size = new Size(153, 13);
            label5.TabIndex = 1;
            label5.Text = "Ready for patient admission";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "TOTAL AVAILABLE BEDS";
            // 
            // pnlTotalClinicPatients
            // 
            pnlTotalClinicPatients.BackColor = SystemColors.ControlLightLight;
            pnlTotalClinicPatients.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalClinicPatients.Controls.Add(panel3);
            pnlTotalClinicPatients.Controls.Add(label11);
            pnlTotalClinicPatients.Controls.Add(label7);
            pnlTotalClinicPatients.Controls.Add(label3);
            pnlTotalClinicPatients.Location = new Point(500, 35);
            pnlTotalClinicPatients.Name = "pnlTotalClinicPatients";
            pnlTotalClinicPatients.Size = new Size(230, 103);
            pnlTotalClinicPatients.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 24, 39);
            panel3.Location = new Point(3, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 10);
            panel3.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(-1, 43);
            label11.Name = "label11";
            label11.Size = new Size(28, 32);
            label11.TabIndex = 5;
            label11.Text = "4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(3, 77);
            label7.Name = "label7";
            label7.Size = new Size(139, 13);
            label7.TabIndex = 3;
            label7.Text = "Active profiles on records";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 2;
            label3.Text = "TOTAL CLINIC PATIENTS";
            label3.Click += label3_Click;
            // 
            // pnlAdmittedPatients
            // 
            pnlAdmittedPatients.BackColor = SystemColors.ControlLightLight;
            pnlAdmittedPatients.BorderStyle = BorderStyle.FixedSingle;
            pnlAdmittedPatients.Controls.Add(panel2);
            pnlAdmittedPatients.Controls.Add(label9);
            pnlAdmittedPatients.Controls.Add(label6);
            pnlAdmittedPatients.Controls.Add(label2);
            pnlAdmittedPatients.Location = new Point(264, 35);
            pnlAdmittedPatients.Name = "pnlAdmittedPatients";
            pnlAdmittedPatients.Size = new Size(230, 103);
            pnlAdmittedPatients.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 96, 232);
            panel2.Location = new Point(3, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 10);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 43);
            label9.Name = "label9";
            label9.Size = new Size(28, 32);
            label9.TabIndex = 4;
            label9.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 77);
            label6.Name = "label6";
            label6.Size = new Size(185, 13);
            label6.TabIndex = 2;
            label6.Text = "Currently occupying hospital beds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 1;
            label2.Text = "ADMITTED PATIENTS";
            label2.Click += label2_Click;
            // 
            // pnlBedOccupancyRate
            // 
            pnlBedOccupancyRate.BackColor = SystemColors.ControlLightLight;
            pnlBedOccupancyRate.BorderStyle = BorderStyle.FixedSingle;
            pnlBedOccupancyRate.Controls.Add(panel4);
            pnlBedOccupancyRate.Controls.Add(label12);
            pnlBedOccupancyRate.Controls.Add(label8);
            pnlBedOccupancyRate.Controls.Add(label4);
            pnlBedOccupancyRate.Location = new Point(736, 35);
            pnlBedOccupancyRate.Name = "pnlBedOccupancyRate";
            pnlBedOccupancyRate.Size = new Size(230, 103);
            pnlBedOccupancyRate.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(239, 165, 28);
            panel4.Location = new Point(3, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 10);
            panel4.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(-1, 43);
            label12.Name = "label12";
            label12.Size = new Size(28, 32);
            label12.TabIndex = 6;
            label12.Text = "4";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(3, 77);
            label8.Name = "label8";
            label8.Size = new Size(125, 13);
            label8.TabIndex = 4;
            label8.Text = "Current capacity status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 3;
            label4.Text = "BED OCCUPANCY RATE";
            label4.Click += label4_Click;
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
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(17, 24, 39);
            label13.Location = new Point(74, 180);
            label13.Name = "label13";
            label13.Size = new Size(158, 15);
            label13.TabIndex = 5;
            label13.Text = "HOSPITAL ROOOM STATUS";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 25);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // uc_dashboard
            // 
            AccessibleName = "Dashboard";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBedOccupancyRate);
            Controls.Add(pnlTotalClinicPatients);
            Controls.Add(pnlAdmittedPatients);
            Controls.Add(pnlAvailableBeds);
            Name = "uc_dashboard";
            Size = new Size(1585, 860);
            pnlAvailableBeds.ResumeLayout(false);
            pnlAvailableBeds.PerformLayout();
            pnlTotalClinicPatients.ResumeLayout(false);
            pnlTotalClinicPatients.PerformLayout();
            pnlAdmittedPatients.ResumeLayout(false);
            pnlAdmittedPatients.PerformLayout();
            pnlBedOccupancyRate.ResumeLayout(false);
            pnlBedOccupancyRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Panel pnlAvailableBeds;
        private Panel pnlTotalClinicPatients;
        private Panel pnlAdmittedPatients;
        private Panel pnlBedOccupancyRate;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Label label13;
        private PictureBox pictureBox1;
    }
}
