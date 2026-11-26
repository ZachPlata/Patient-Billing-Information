namespace Patient_Info_and_Billing_System.Admin
{
    partial class Access_Logs___Audit_Trail
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(17, 34);
            button1.Name = "button1";
            button1.Size = new Size(216, 49);
            button1.TabIndex = 0;
            button1.Text = "⏩Dashboard Quick Alerts ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(253, 34);
            button2.Name = "button2";
            button2.Size = new Size(211, 49);
            button2.TabIndex = 1;
            button2.Text = "👨🏼‍⚕️Staff User Credentials";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(501, 34);
            button3.Name = "button3";
            button3.Size = new Size(210, 49);
            button3.TabIndex = 2;
            button3.Text = "📋Clinic Data Setups";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(758, 34);
            button4.Name = "button4";
            button4.Size = new Size(203, 49);
            button4.TabIndex = 3;
            button4.Text = "🔓Access Logs Audit Trail";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(17, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1530, 713);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1527, 513);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Timestamp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 230;
            // 
            // Column2
            // 
            Column2.HeaderText = "Staff ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 230;
            // 
            // Column3
            // 
            Column3.HeaderText = "Staff Member";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 230;
            // 
            // Column4
            // 
            Column4.HeaderText = "Patient ID";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 230;
            // 
            // Column5
            // 
            Column5.HeaderText = "Patient Name";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 230;
            // 
            // Column6
            // 
            Column6.HeaderText = "Action Taken";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 230;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(56, 173, 238);
            button6.Font = new Font("Segoe UI", 10.8F);
            button6.Location = new Point(312, 13);
            button6.Name = "button6";
            button6.Size = new Size(203, 36);
            button6.TabIndex = 1;
            button6.Text = "➜]Staff Login / Logout History";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(56, 173, 238);
            button5.Font = new Font("Segoe UI", 10.8F);
            button5.Location = new Point(23, 13);
            button5.Name = "button5";
            button5.Size = new Size(262, 36);
            button5.TabIndex = 0;
            button5.Text = "📝Patient Record Access Logs & Audit";
            button5.UseVisualStyleBackColor = false;
            // 
            // Access_Logs___Audit_Trail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Access_Logs___Audit_Trail";
            Size = new Size(1585, 860);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
