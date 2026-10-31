namespace NurseDashBoard
{
    partial class uc_RegistrationPatients
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
            panel2 = new Panel();
            label12 = new Label();
            textBox11 = new TextBox();
            panel3 = new Panel();
            RegPat_BtnClr = new Button();
            RegPat_BtnAdd = new Button();
            label7 = new Label();
            label6 = new Label();
            PatReg_ConRelTxtBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            PatReg_GenderCbox = new ComboBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            PatReg_Date = new DateTimePicker();
            PatReg_ConNoTxtBox = new TextBox();
            PatReg_ConPerTxtBox = new TextBox();
            PatReg_HomeAdTxtBox = new TextBox();
            PatReg_NameTxtBox = new TextBox();
            panel4 = new Panel();
            PatReg_BloodTypeComboBox = new ComboBox();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            PatReg_BodyTemTxtBox = new TextBox();
            PatReg_BPTextBox = new TextBox();
            label10 = new Label();
            PatReg_BPTxtBox = new TextBox();
            label11 = new Label();
            PatReg_KgTxtBox = new TextBox();
            LABEL = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            PatReg_HeightTxtBox = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 248, 252);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1585, 802);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(14, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1568, 741);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(15, 23, 42);
            label12.Location = new Point(1142, 512);
            label12.Name = "label12";
            label12.Size = new Size(245, 17);
            label12.TabIndex = 24;
            label12.Text = "Known Medical Conditions / Allergies:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1142, 533);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(365, 187);
            textBox11.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(RegPat_BtnClr);
            panel3.Controls.Add(RegPat_BtnAdd);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(PatReg_ConRelTxtBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(PatReg_GenderCbox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(PatReg_Date);
            panel3.Controls.Add(PatReg_ConNoTxtBox);
            panel3.Controls.Add(PatReg_ConPerTxtBox);
            panel3.Controls.Add(PatReg_HomeAdTxtBox);
            panel3.Controls.Add(PatReg_NameTxtBox);
            panel3.Location = new Point(16, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(1085, 676);
            panel3.TabIndex = 0;
            // 
            // RegPat_BtnClr
            // 
            RegPat_BtnClr.BackColor = Color.White;
            RegPat_BtnClr.FlatStyle = FlatStyle.Flat;
            RegPat_BtnClr.ForeColor = Color.Black;
            RegPat_BtnClr.Location = new Point(549, 468);
            RegPat_BtnClr.Margin = new Padding(3, 2, 3, 2);
            RegPat_BtnClr.Name = "RegPat_BtnClr";
            RegPat_BtnClr.Size = new Size(216, 31);
            RegPat_BtnClr.TabIndex = 22;
            RegPat_BtnClr.Text = "Clear";
            RegPat_BtnClr.UseVisualStyleBackColor = false;
            // 
            // RegPat_BtnAdd
            // 
            RegPat_BtnAdd.BackColor = Color.FromArgb(16, 185, 129);
            RegPat_BtnAdd.FlatStyle = FlatStyle.Flat;
            RegPat_BtnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegPat_BtnAdd.ForeColor = Color.White;
            RegPat_BtnAdd.Location = new Point(270, 468);
            RegPat_BtnAdd.Margin = new Padding(3, 2, 3, 2);
            RegPat_BtnAdd.Name = "RegPat_BtnAdd";
            RegPat_BtnAdd.Size = new Size(262, 31);
            RegPat_BtnAdd.TabIndex = 21;
            RegPat_BtnAdd.Text = "Register Patient";
            RegPat_BtnAdd.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(15, 23, 42);
            label7.Location = new Point(870, 25);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 20;
            label7.Text = "DATE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 23, 42);
            label6.Location = new Point(269, 363);
            label6.Name = "label6";
            label6.Size = new Size(301, 17);
            label6.TabIndex = 19;
            label6.Text = "EMERGENCY CONTACT PERSON RELATIONSHIP:";
            // 
            // PatReg_ConRelTxtBox
            // 
            PatReg_ConRelTxtBox.Location = new Point(269, 383);
            PatReg_ConRelTxtBox.Multiline = true;
            PatReg_ConRelTxtBox.Name = "PatReg_ConRelTxtBox";
            PatReg_ConRelTxtBox.Size = new Size(300, 32);
            PatReg_ConRelTxtBox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(15, 23, 42);
            label5.Location = new Point(270, 185);
            label5.Name = "label5";
            label5.Size = new Size(126, 17);
            label5.TabIndex = 17;
            label5.Text = "CONTACT PERSON:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(270, 270);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 16;
            label4.Text = "CONTACT NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(270, 96);
            label3.Name = "label3";
            label3.Size = new Size(184, 17);
            label3.TabIndex = 15;
            label3.Text = "COMPLETE HOME ADDRESS:";
            // 
            // PatReg_GenderCbox
            // 
            PatReg_GenderCbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatReg_GenderCbox.FormattingEnabled = true;
            PatReg_GenderCbox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            PatReg_GenderCbox.Location = new Point(612, 45);
            PatReg_GenderCbox.Name = "PatReg_GenderCbox";
            PatReg_GenderCbox.Size = new Size(186, 28);
            PatReg_GenderCbox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 23, 42);
            label2.Location = new Point(612, 25);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 13;
            label2.Text = "SEX:";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(15, 23, 42);
            flowLayoutPanel1.ForeColor = Color.FromArgb(15, 23, 42);
            flowLayoutPanel1.Location = new Point(30, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(215, 141);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(270, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 10;
            label1.Text = "PATIENT NAME:";
            label1.Click += label1_Click;
            // 
            // PatReg_Date
            // 
            PatReg_Date.Font = new Font("Segoe UI", 11F);
            PatReg_Date.Format = DateTimePickerFormat.Short;
            PatReg_Date.Location = new Point(870, 46);
            PatReg_Date.Name = "PatReg_Date";
            PatReg_Date.Size = new Size(200, 27);
            PatReg_Date.TabIndex = 9;
            // 
            // PatReg_ConNoTxtBox
            // 
            PatReg_ConNoTxtBox.Location = new Point(270, 290);
            PatReg_ConNoTxtBox.Multiline = true;
            PatReg_ConNoTxtBox.Name = "PatReg_ConNoTxtBox";
            PatReg_ConNoTxtBox.Size = new Size(796, 32);
            PatReg_ConNoTxtBox.TabIndex = 6;
            // 
            // PatReg_ConPerTxtBox
            // 
            PatReg_ConPerTxtBox.Location = new Point(270, 205);
            PatReg_ConPerTxtBox.Multiline = true;
            PatReg_ConPerTxtBox.Name = "PatReg_ConPerTxtBox";
            PatReg_ConPerTxtBox.Size = new Size(796, 32);
            PatReg_ConPerTxtBox.TabIndex = 4;
            // 
            // PatReg_HomeAdTxtBox
            // 
            PatReg_HomeAdTxtBox.Location = new Point(270, 115);
            PatReg_HomeAdTxtBox.Multiline = true;
            PatReg_HomeAdTxtBox.Name = "PatReg_HomeAdTxtBox";
            PatReg_HomeAdTxtBox.Size = new Size(796, 32);
            PatReg_HomeAdTxtBox.TabIndex = 3;
            // 
            // PatReg_NameTxtBox
            // 
            PatReg_NameTxtBox.Location = new Point(270, 45);
            PatReg_NameTxtBox.Multiline = true;
            PatReg_NameTxtBox.Name = "PatReg_NameTxtBox";
            PatReg_NameTxtBox.Size = new Size(300, 32);
            PatReg_NameTxtBox.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(PatReg_HeightTxtBox);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(PatReg_BloodTypeComboBox);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(PatReg_BodyTemTxtBox);
            panel4.Controls.Add(PatReg_BPTextBox);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(PatReg_BPTxtBox);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(PatReg_KgTxtBox);
            panel4.Location = new Point(1142, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 439);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // PatReg_BloodTypeComboBox
            // 
            PatReg_BloodTypeComboBox.AllowDrop = true;
            PatReg_BloodTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A−", "B+", "B−", "AB+", "AB−", "O+", "O−" });
            PatReg_BloodTypeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatReg_BloodTypeComboBox.FormattingEnabled = true;
            PatReg_BloodTypeComboBox.Items.AddRange(new object[] { "A+", "A−", "B+", "B−", "AB+", "AB−", "O+", "O−" });
            PatReg_BloodTypeComboBox.Location = new Point(74, 384);
            PatReg_BloodTypeComboBox.Name = "PatReg_BloodTypeComboBox";
            PatReg_BloodTypeComboBox.Size = new Size(202, 29);
            PatReg_BloodTypeComboBox.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(15, 23, 42);
            label13.Location = new Point(76, 361);
            label13.Name = "label13";
            label13.Size = new Size(77, 17);
            label13.TabIndex = 33;
            label13.Text = "Blood Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(15, 23, 42);
            label8.Location = new Point(74, 16);
            label8.Name = "label8";
            label8.Size = new Size(156, 17);
            label8.TabIndex = 22;
            label8.Text = "Blood pressure (mmHg)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(15, 23, 42);
            label9.Location = new Point(76, 85);
            label9.Name = "label9";
            label9.Size = new Size(114, 17);
            label9.TabIndex = 30;
            label9.Text = "Pulse Rate (BPM)";
            // 
            // PatReg_BodyTemTxtBox
            // 
            PatReg_BodyTemTxtBox.Location = new Point(74, 173);
            PatReg_BodyTemTxtBox.Multiline = true;
            PatReg_BodyTemTxtBox.Name = "PatReg_BodyTemTxtBox";
            PatReg_BodyTemTxtBox.Size = new Size(200, 32);
            PatReg_BodyTemTxtBox.TabIndex = 29;
            // 
            // PatReg_BPTextBox
            // 
            PatReg_BPTextBox.Location = new Point(74, 105);
            PatReg_BPTextBox.Multiline = true;
            PatReg_BPTextBox.Name = "PatReg_BPTextBox";
            PatReg_BPTextBox.Size = new Size(202, 32);
            PatReg_BPTextBox.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(15, 23, 42);
            label10.Location = new Point(74, 153);
            label10.Name = "label10";
            label10.Size = new Size(148, 17);
            label10.TabIndex = 31;
            label10.Text = "Body Temperature (°C)";
            // 
            // PatReg_BPTxtBox
            // 
            PatReg_BPTxtBox.Location = new Point(74, 36);
            PatReg_BPTxtBox.Multiline = true;
            PatReg_BPTxtBox.Name = "PatReg_BPTxtBox";
            PatReg_BPTxtBox.Size = new Size(202, 32);
            PatReg_BPTxtBox.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(15, 23, 42);
            label11.Location = new Point(74, 294);
            label11.Name = "label11";
            label11.Size = new Size(118, 17);
            label11.TabIndex = 32;
            label11.Text = "Body Weight (Kg)";
            // 
            // PatReg_KgTxtBox
            // 
            PatReg_KgTxtBox.Location = new Point(74, 315);
            PatReg_KgTxtBox.Multiline = true;
            PatReg_KgTxtBox.Name = "PatReg_KgTxtBox";
            PatReg_KgTxtBox.Size = new Size(202, 32);
            PatReg_KgTxtBox.TabIndex = 24;
            // 
            // LABEL
            // 
            LABEL.AllowDrop = true;
            LABEL.AutoSize = true;
            LABEL.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABEL.ForeColor = Color.FromArgb(15, 23, 42);
            LABEL.Location = new Point(0, 0);
            LABEL.Name = "LABEL";
            LABEL.Size = new Size(365, 32);
            LABEL.TabIndex = 1;
            LABEL.Text = "PATIENT REGISTRATION FORM";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(15, 23, 42);
            label14.Location = new Point(614, 363);
            label14.Name = "label14";
            label14.Size = new Size(88, 17);
            label14.TabIndex = 23;
            label14.Text = "COMPLAINT:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(615, 383);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 32);
            textBox1.TabIndex = 24;
            // 
            // PatReg_HeightTxtBox
            // 
            PatReg_HeightTxtBox.AutoSize = true;
            PatReg_HeightTxtBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PatReg_HeightTxtBox.ForeColor = Color.FromArgb(15, 23, 42);
            PatReg_HeightTxtBox.Location = new Point(76, 220);
            PatReg_HeightTxtBox.Name = "PatReg_HeightTxtBox";
            PatReg_HeightTxtBox.Size = new Size(117, 17);
            PatReg_HeightTxtBox.TabIndex = 35;
            PatReg_HeightTxtBox.Text = "Body Height (cm)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 241);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 32);
            textBox2.TabIndex = 34;
            // 
            // uc_RegistrationPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LABEL);
            Controls.Add(panel1);
            Name = "uc_RegistrationPatients";
            Size = new Size(1585, 860);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LABEL;
        private Panel panel4;
        private Panel panel3;
        private TextBox PatReg_NameTxtBox;
        private TextBox PatReg_ConPerTxtBox;
        private TextBox PatReg_HomeAdTxtBox;
        private TextBox PatReg_ConNoTxtBox;
        private DateTimePicker PatReg_Date;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox PatReg_GenderCbox;
        private Label label6;
        private TextBox PatReg_ConRelTxtBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox PatReg_KgTxtBox;
        private TextBox PatReg_BPTextBox;
        private TextBox PatReg_BPTxtBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox PatReg_BodyTemTxtBox;
        private TextBox textBox11;
        private ComboBox PatReg_BloodTypeComboBox;
        private Label label13;
        private Label label12;
        private Label label7;
        private Button RegPat_BtnAdd;
        private Button RegPat_BtnClr;
        private TextBox textBox1;
        private Label label14;
        private Label PatReg_HeightTxtBox;
        private TextBox textBox2;
    }
}
