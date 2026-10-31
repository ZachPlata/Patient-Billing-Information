namespace Patient_Info_and_Billing_System
{
    partial class uc_PatientUtil
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
            panel1 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            patUtil_Search = new Button();
            PatUtil_PatIdTxtBox = new TextBox();
            panel2 = new Panel();
            label15 = new Label();
            Date = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            LABEL = new Label();
            PatUtil_Notes = new TextBox();
            PatUtil_Date = new DateTimePicker();
            PatUtil_QtTextBox = new TextBox();
            PatUtil_EqIdNoComboBox = new TextBox();
            PatUtil_EqDrgComboBox = new ComboBox();
            PatUtil_EqCatComboBox = new ComboBox();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            label9 = new Label();
            label8 = new Label();
            button2 = new Button();
            RegPat_BtnAdd = new Button();
            RegPat_BtnClr = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(patUtil_Search);
            panel1.Controls.Add(PatUtil_PatIdTxtBox);
            panel1.Location = new Point(18, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1549, 139);
            panel1.TabIndex = 0;
            // 
            // label14
            // 
            label14.AllowDrop = true;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(15, 23, 42);
            label14.Location = new Point(1197, 36);
            label14.Name = "label14";
            label14.Size = new Size(83, 32);
            label14.TabIndex = 28;
            label14.Text = "Status";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(15, 23, 42);
            label13.Location = new Point(1052, 84);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 27;
            label13.Text = "Admitted: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(15, 23, 42);
            label12.Location = new Point(787, 84);
            label12.Name = "label12";
            label12.Size = new Size(121, 17);
            label12.TabIndex = 26;
            label12.Text = "Attending Doctor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(15, 23, 42);
            label11.Location = new Point(654, 84);
            label11.Name = "label11";
            label11.Size = new Size(52, 17);
            label11.TabIndex = 25;
            label11.Text = "Room: ";
            label11.Click += label11_Click;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(654, 36);
            label6.Name = "label6";
            label6.Size = new Size(108, 32);
            label6.TabIndex = 24;
            label6.Text = "Patient: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(15, 23, 42);
            label7.Location = new Point(35, 27);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 23;
            label7.Text = "Patient ID";
            // 
            // patUtil_Search
            // 
            patUtil_Search.Location = new Point(427, 47);
            patUtil_Search.Name = "patUtil_Search";
            patUtil_Search.Size = new Size(145, 48);
            patUtil_Search.TabIndex = 22;
            patUtil_Search.Text = "Search";
            patUtil_Search.UseVisualStyleBackColor = true;
            // 
            // PatUtil_PatIdTxtBox
            // 
            PatUtil_PatIdTxtBox.Location = new Point(30, 47);
            PatUtil_PatIdTxtBox.Multiline = true;
            PatUtil_PatIdTxtBox.Name = "PatUtil_PatIdTxtBox";
            PatUtil_PatIdTxtBox.Size = new Size(365, 48);
            PatUtil_PatIdTxtBox.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(RegPat_BtnClr);
            panel2.Controls.Add(RegPat_BtnAdd);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LABEL);
            panel2.Controls.Add(PatUtil_Notes);
            panel2.Controls.Add(PatUtil_Date);
            panel2.Controls.Add(PatUtil_QtTextBox);
            panel2.Controls.Add(PatUtil_EqIdNoComboBox);
            panel2.Controls.Add(PatUtil_EqDrgComboBox);
            panel2.Controls.Add(PatUtil_EqCatComboBox);
            panel2.Location = new Point(18, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 643);
            panel2.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(15, 23, 42);
            label15.Location = new Point(32, 326);
            label15.Name = "label15";
            label15.Size = new Size(44, 17);
            label15.TabIndex = 28;
            label15.Text = "Notes";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.ForeColor = Color.FromArgb(15, 23, 42);
            Date.Location = new Point(30, 237);
            Date.Name = "Date";
            Date.Size = new Size(49, 17);
            Date.TabIndex = 26;
            Date.Text = "ID NO.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(32, 151);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 25;
            label5.Text = "ID NO.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(391, 151);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 24;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(391, 62);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 23;
            label3.Text = "Equipment/Drug";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(30, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 22;
            label2.Text = "Category";
            // 
            // LABEL
            // 
            LABEL.AllowDrop = true;
            LABEL.AutoSize = true;
            LABEL.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL.ForeColor = Color.FromArgb(15, 23, 42);
            LABEL.Location = new Point(30, 7);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(207, 32);
            LABEL.TabIndex = 21;
            LABEL.Text = "LOG EQUIPMENT";
            // 
            // PatUtil_Notes
            // 
            PatUtil_Notes.Location = new Point(30, 346);
            PatUtil_Notes.Multiline = true;
            PatUtil_Notes.Name = "PatUtil_Notes";
            PatUtil_Notes.Size = new Size(591, 195);
            PatUtil_Notes.TabIndex = 20;
            // 
            // PatUtil_Date
            // 
            PatUtil_Date.Font = new Font("Segoe UI", 11F);
            PatUtil_Date.Format = DateTimePickerFormat.Short;
            PatUtil_Date.Location = new Point(30, 257);
            PatUtil_Date.Name = "PatUtil_Date";
            PatUtil_Date.Size = new Size(300, 27);
            PatUtil_Date.TabIndex = 19;
            // 
            // PatUtil_QtTextBox
            // 
            PatUtil_QtTextBox.Location = new Point(391, 171);
            PatUtil_QtTextBox.Multiline = true;
            PatUtil_QtTextBox.Name = "PatUtil_QtTextBox";
            PatUtil_QtTextBox.Size = new Size(230, 32);
            PatUtil_QtTextBox.TabIndex = 18;
            // 
            // PatUtil_EqIdNoComboBox
            // 
            PatUtil_EqIdNoComboBox.Location = new Point(30, 171);
            PatUtil_EqIdNoComboBox.Multiline = true;
            PatUtil_EqIdNoComboBox.Name = "PatUtil_EqIdNoComboBox";
            PatUtil_EqIdNoComboBox.Size = new Size(300, 32);
            PatUtil_EqIdNoComboBox.TabIndex = 17;
            // 
            // PatUtil_EqDrgComboBox
            // 
            PatUtil_EqDrgComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatUtil_EqDrgComboBox.FormattingEnabled = true;
            PatUtil_EqDrgComboBox.Location = new Point(391, 82);
            PatUtil_EqDrgComboBox.Name = "PatUtil_EqDrgComboBox";
            PatUtil_EqDrgComboBox.Size = new Size(230, 28);
            PatUtil_EqDrgComboBox.TabIndex = 16;
            // 
            // PatUtil_EqCatComboBox
            // 
            PatUtil_EqCatComboBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatUtil_EqCatComboBox.FormattingEnabled = true;
            PatUtil_EqCatComboBox.Location = new Point(30, 82);
            PatUtil_EqCatComboBox.Name = "PatUtil_EqCatComboBox";
            PatUtil_EqCatComboBox.Size = new Size(300, 28);
            PatUtil_EqCatComboBox.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(731, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(836, 431);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(19, 7);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 22;
            label1.Text = "Utilized Equipment and Drugs";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 336);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(button2);
            panel4.Location = new Point(731, 662);
            panel4.Name = "panel4";
            panel4.Size = new Size(836, 181);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(15, 23, 42);
            label9.Location = new Point(3, 115);
            label9.Name = "label9";
            label9.Size = new Size(197, 32);
            label9.TabIndex = 24;
            label9.Text = "Estimated Cost: ";
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(15, 23, 42);
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(123, 32);
            label8.TabIndex = 23;
            label8.Text = "Summary";
            // 
            // button2
            // 
            button2.Location = new Point(607, 107);
            button2.Name = "button2";
            button2.Size = new Size(213, 48);
            button2.TabIndex = 23;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // RegPat_BtnAdd
            // 
            RegPat_BtnAdd.BackColor = Color.FromArgb(16, 185, 129);
            RegPat_BtnAdd.FlatStyle = FlatStyle.Flat;
            RegPat_BtnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegPat_BtnAdd.ForeColor = Color.White;
            RegPat_BtnAdd.Location = new Point(30, 556);
            RegPat_BtnAdd.Margin = new Padding(3, 2, 3, 2);
            RegPat_BtnAdd.Name = "RegPat_BtnAdd";
            RegPat_BtnAdd.Size = new Size(300, 52);
            RegPat_BtnAdd.TabIndex = 29;
            RegPat_BtnAdd.Text = "Register Patient";
            RegPat_BtnAdd.UseVisualStyleBackColor = false;
            // 
            // RegPat_BtnClr
            // 
            RegPat_BtnClr.BackColor = Color.White;
            RegPat_BtnClr.FlatStyle = FlatStyle.Flat;
            RegPat_BtnClr.ForeColor = Color.Black;
            RegPat_BtnClr.Location = new Point(391, 556);
            RegPat_BtnClr.Margin = new Padding(3, 2, 3, 2);
            RegPat_BtnClr.Name = "RegPat_BtnClr";
            RegPat_BtnClr.Size = new Size(229, 53);
            RegPat_BtnClr.TabIndex = 30;
            RegPat_BtnClr.Text = "Clear";
            RegPat_BtnClr.UseVisualStyleBackColor = false;
            // 
            // uc_PatientUtil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(244, 248, 252);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "uc_PatientUtil";
            Size = new Size(1585, 860);
            Load += uc_PatientUtil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox PatUtil_EqDrgComboBox;
        private ComboBox PatUtil_EqCatComboBox;
        private TextBox PatUtil_QtTextBox;
        private TextBox PatUtil_EqIdNoComboBox;
        private DateTimePicker PatUtil_Date;
        private TextBox PatUtil_Notes;
        private DataGridView dataGridView1;
        private TextBox PatUtil_PatIdTxtBox;
        private Button patUtil_Search;
        private Label LABEL;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button button2;
        private Label label9;
        private Label label11;
        private Label Date;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label15;
        private Button RegPat_BtnAdd;
        private Button RegPat_BtnClr;
    }
}
