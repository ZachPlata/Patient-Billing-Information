namespace Patient_Info_and_Billing_System.Doctor
{
    partial class PatientForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            searchBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            textBox10 = new TextBox();
            label17 = new Label();
            label16 = new Label();
            textBox9 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label14 = new Label();
            textBox7 = new TextBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label15 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label11 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            panel2 = new Panel();
            label19 = new Label();
            dataGridView2 = new DataGridView();
            label18 = new Label();
            label20 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            label21 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label22 = new Label();
            button5 = new Button();
            PatientIDColumn = new DataGridViewTextBoxColumn();
            PatientNameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            ContactNumberColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            DoctorColumn = new DataGridViewTextBoxColumn();
            DiagnosisColumn = new DataGridViewTextBoxColumn();
            FollowUpColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 34, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Patient Records";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PatientIDColumn, PatientNameColumn, AgeColumn, ContactNumberColumn });
            dataGridView1.Location = new Point(13, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(443, 764);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Patient Name / ID";
            textBox1.Size = new Size(334, 31);
            textBox1.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(37, 99, 235);
            searchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(353, 35);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(103, 36);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 34, 64);
            label2.Location = new Point(10, 6);
            label2.Name = "label2";
            label2.Size = new Size(298, 25);
            label2.TabIndex = 0;
            label2.Text = "Patient Profile and Demographics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 34, 64);
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 1;
            label3.Text = "Full Name:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(21, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 30);
            textBox2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(333, 204);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(292, 30);
            maskedTextBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(17, 34, 64);
            label4.Location = new Point(333, 178);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 4;
            label4.Text = "Address:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(21, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 30);
            textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(333, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 31);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(17, 34, 64);
            label5.Location = new Point(333, 45);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 7;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(17, 34, 64);
            label6.Location = new Point(21, 178);
            label6.Name = "label6";
            label6.Size = new Size(143, 23);
            label6.TabIndex = 8;
            label6.Text = "Contact Number:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(21, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(398, 30);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(17, 34, 64);
            label7.Location = new Point(21, 246);
            label7.Name = "label7";
            label7.Size = new Size(164, 23);
            label7.TabIndex = 10;
            label7.Text = "Emergency Contact:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(474, 7);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(151, 30);
            textBox5.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(17, 34, 64);
            label8.Location = new Point(378, 8);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 12;
            label8.Text = "Patient ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(473, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 809);
            panel1.TabIndex = 4;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(21, 341);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(393, 30);
            textBox10.TabIndex = 38;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(23, 315);
            label17.Name = "label17";
            label17.Size = new Size(168, 23);
            label17.TabIndex = 37;
            label17.Text = "Emergency Number:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(333, 111);
            label16.Name = "label16";
            label16.Size = new Size(39, 20);
            label16.TabIndex = 36;
            label16.Text = "Age:";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(333, 133);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(86, 30);
            textBox9.TabIndex = 35;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(365, 756);
            button4.Name = "button4";
            button4.Size = new Size(121, 39);
            button4.TabIndex = 34;
            button4.Text = "Deactivate";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(258, 756);
            button3.Name = "button3";
            button3.Size = new Size(101, 39);
            button3.TabIndex = 33;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(141, 756);
            button2.Name = "button2";
            button2.Size = new Size(111, 39);
            button2.TabIndex = 32;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 756);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 31;
            button1.Text = "Add patient";
            button1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(23, 108);
            label14.Name = "label14";
            label14.Size = new Size(78, 23);
            label14.TabIndex = 30;
            label14.Text = "Birthday:";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(21, 133);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(278, 30);
            textBox7.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(17, 34, 64);
            label10.Location = new Point(454, 47);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 28;
            label10.Text = "Status:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBox3.Location = new Point(454, 73);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 31);
            comboBox3.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(454, 274);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(17, 34, 64);
            label15.Location = new Point(10, 392);
            label15.Name = "label15";
            label15.Size = new Size(186, 25);
            label15.TabIndex = 25;
            label15.Text = "Medical Information";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(333, 468);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(292, 27);
            textBox8.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(17, 34, 64);
            label13.Location = new Point(333, 442);
            label13.Name = "label13";
            label13.Size = new Size(135, 23);
            label13.TabIndex = 20;
            label13.Text = "Medical History:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(17, 34, 64);
            label12.Location = new Point(23, 513);
            label12.Name = "label12";
            label12.Size = new Size(170, 23);
            label12.TabIndex = 19;
            label12.Text = "Current Medications:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox2.Location = new Point(21, 539);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(292, 30);
            maskedTextBox2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(17, 34, 64);
            label11.Location = new Point(454, 248);
            label11.Name = "label11";
            label11.Size = new Size(99, 23);
            label11.TabIndex = 16;
            label11.Text = "Blood Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(21, 439);
            label9.Name = "label9";
            label9.Size = new Size(143, 23);
            label9.TabIndex = 14;
            label9.Text = "Allergies (ALERT):";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(23, 465);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(292, 30);
            textBox6.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(maskedTextBox3);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(1120, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 811);
            panel2.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(17, 34, 64);
            label19.Location = new Point(18, 582);
            label19.Name = "label19";
            label19.Size = new Size(152, 25);
            label19.TabIndex = 2;
            label19.Text = "Billing Summary";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { DateColumn, DoctorColumn, DiagnosisColumn, FollowUpColumn });
            dataGridView2.Location = new Point(15, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(420, 498);
            dataGridView2.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(17, 34, 64);
            label18.Location = new Point(15, 8);
            label18.Name = "label18";
            label18.Size = new Size(117, 25);
            label18.TabIndex = 0;
            label18.Text = "Visit History";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(15, 622);
            label20.Name = "label20";
            label20.Size = new Size(92, 23);
            label20.TabIndex = 3;
            label20.Text = "Total billed";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(15, 648);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(149, 27);
            textBox11.TabIndex = 4;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(201, 648);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(211, 27);
            textBox12.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(201, 622);
            label21.Name = "label21";
            label21.Size = new Size(84, 23);
            label21.TabIndex = 6;
            label21.Text = "Total paid";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(15, 704);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(149, 27);
            maskedTextBox3.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(15, 678);
            label22.Name = "label22";
            label22.Size = new Size(69, 23);
            label22.TabIndex = 8;
            label22.Text = "Balance";
            label22.Click += label22_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(37, 99, 235);
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(18, 758);
            button5.Name = "button5";
            button5.Size = new Size(146, 39);
            button5.TabIndex = 9;
            button5.Text = "New Checkup";
            button5.UseVisualStyleBackColor = false;
            // 
            // PatientIDColumn
            // 
            PatientIDColumn.HeaderText = "Patient ID";
            PatientIDColumn.MinimumWidth = 6;
            PatientIDColumn.Name = "PatientIDColumn";
            PatientIDColumn.ReadOnly = true;
            PatientIDColumn.Width = 60;
            // 
            // PatientNameColumn
            // 
            PatientNameColumn.HeaderText = "Name";
            PatientNameColumn.MinimumWidth = 6;
            PatientNameColumn.Name = "PatientNameColumn";
            PatientNameColumn.ReadOnly = true;
            PatientNameColumn.Width = 150;
            // 
            // AgeColumn
            // 
            AgeColumn.HeaderText = "Age";
            AgeColumn.MinimumWidth = 6;
            AgeColumn.Name = "AgeColumn";
            AgeColumn.ReadOnly = true;
            AgeColumn.Width = 50;
            // 
            // ContactNumberColumn
            // 
            ContactNumberColumn.HeaderText = "Contact No.";
            ContactNumberColumn.MinimumWidth = 6;
            ContactNumberColumn.Name = "ContactNumberColumn";
            ContactNumberColumn.ReadOnly = true;
            ContactNumberColumn.Width = 135;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 6;
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.Width = 125;
            // 
            // DoctorColumn
            // 
            DoctorColumn.HeaderText = "Doctor";
            DoctorColumn.MinimumWidth = 6;
            DoctorColumn.Name = "DoctorColumn";
            DoctorColumn.ReadOnly = true;
            DoctorColumn.Width = 125;
            // 
            // DiagnosisColumn
            // 
            DiagnosisColumn.HeaderText = "Diagnosis";
            DiagnosisColumn.MinimumWidth = 6;
            DiagnosisColumn.Name = "DiagnosisColumn";
            DiagnosisColumn.ReadOnly = true;
            DiagnosisColumn.Width = 125;
            // 
            // FollowUpColumn
            // 
            FollowUpColumn.HeaderText = "Follow-up";
            FollowUpColumn.MinimumWidth = 6;
            FollowUpColumn.Name = "FollowUpColumn";
            FollowUpColumn.ReadOnly = true;
            FollowUpColumn.Width = 125;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "PatientForm";
            Size = new Size(1585, 860);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button searchBtn;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private TextBox textBox6;
        private Label label11;
        private MaskedTextBox maskedTextBox2;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private Label label15;
        private ComboBox comboBox2;
        private TextBox textBox7;
        private Label label10;
        private ComboBox comboBox3;
        private Label label14;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox10;
        private Label label17;
        private Label label16;
        private TextBox textBox9;
        private Panel panel2;
        private Label label18;
        private DataGridView dataGridView2;
        private Label label19;
        private Label label21;
        private TextBox textBox12;
        private TextBox textBox11;
        private Label label20;
        private Label label22;
        private MaskedTextBox maskedTextBox3;
        private Button button5;
        private DataGridViewTextBoxColumn PatientIDColumn;
        private DataGridViewTextBoxColumn PatientNameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn ContactNumberColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn DoctorColumn;
        private DataGridViewTextBoxColumn DiagnosisColumn;
        private DataGridViewTextBoxColumn FollowUpColumn;
    }
}
