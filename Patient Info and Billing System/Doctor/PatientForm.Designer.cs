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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            patrecordDataGridView = new DataGridView();
            PatientIDColumn = new DataGridViewTextBoxColumn();
            PatientNameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            ContactNumberColumn = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            searchBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            fullnameTxtbox = new TextBox();
            addressTxtbox = new MaskedTextBox();
            label4 = new Label();
            contactnoTxtbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            emrgncycontactpersonTxtbox = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            emrgncycontactnoTxtbox = new TextBox();
            label17 = new Label();
            label16 = new Label();
            ageTxtbox = new TextBox();
            deactivateBtn = new Button();
            clearBtn = new Button();
            updateBtn = new Button();
            adpatientBtn = new Button();
            label14 = new Label();
            birthdayTxtbox = new TextBox();
            label10 = new Label();
            statusCmbBox = new ComboBox();
            bloodtypeCmbbox = new ComboBox();
            label15 = new Label();
            medhistoryTxtbox = new TextBox();
            label13 = new Label();
            label12 = new Label();
            currentmedTxtbox = new MaskedTextBox();
            label11 = new Label();
            label9 = new Label();
            allergiesTxtbox = new TextBox();
            panel2 = new Panel();
            button5 = new Button();
            label22 = new Label();
            balanceTxtbox = new MaskedTextBox();
            label21 = new Label();
            totalpaidTxtbox = new TextBox();
            totalbillTxtbox = new TextBox();
            label20 = new Label();
            label19 = new Label();
            visithistoryDataGridView = new DataGridView();
            DateColumn = new DataGridViewTextBoxColumn();
            DoctorColumn = new DataGridViewTextBoxColumn();
            DiagnosisColumn = new DataGridViewTextBoxColumn();
            FollowUpColumn = new DataGridViewTextBoxColumn();
            label18 = new Label();
            errorProvider1 = new ErrorProvider(components);
            genderCmbBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)patrecordDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)visithistoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // patrecordDataGridView
            // 
            patrecordDataGridView.AllowUserToAddRows = false;
            patrecordDataGridView.AllowUserToDeleteRows = false;
            patrecordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patrecordDataGridView.Columns.AddRange(new DataGridViewColumn[] { PatientIDColumn, PatientNameColumn, AgeColumn, ContactNumberColumn });
            patrecordDataGridView.Location = new Point(13, 77);
            patrecordDataGridView.Name = "patrecordDataGridView";
            patrecordDataGridView.ReadOnly = true;
            patrecordDataGridView.RowHeadersWidth = 51;
            patrecordDataGridView.Size = new Size(443, 764);
            patrecordDataGridView.TabIndex = 1;
            patrecordDataGridView.CellClick += patrecordDataGridView_CellClick;
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
            searchBtn.Click += searchBtn_Click;
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
            // fullnameTxtbox
            // 
            fullnameTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullnameTxtbox.Location = new Point(21, 74);
            fullnameTxtbox.Name = "fullnameTxtbox";
            fullnameTxtbox.Size = new Size(280, 30);
            fullnameTxtbox.TabIndex = 2;
            // 
            // addressTxtbox
            // 
            addressTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxtbox.Location = new Point(333, 204);
            addressTxtbox.Name = "addressTxtbox";
            addressTxtbox.Size = new Size(292, 30);
            addressTxtbox.TabIndex = 3;
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
            // contactnoTxtbox
            // 
            contactnoTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactnoTxtbox.Location = new Point(21, 204);
            contactnoTxtbox.Name = "contactnoTxtbox";
            contactnoTxtbox.Size = new Size(280, 30);
            contactnoTxtbox.TabIndex = 5;
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
            // emrgncycontactpersonTxtbox
            // 
            emrgncycontactpersonTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emrgncycontactpersonTxtbox.Location = new Point(21, 272);
            emrgncycontactpersonTxtbox.Multiline = true;
            emrgncycontactpersonTxtbox.Name = "emrgncycontactpersonTxtbox";
            emrgncycontactpersonTxtbox.Size = new Size(393, 27);
            emrgncycontactpersonTxtbox.TabIndex = 9;
            emrgncycontactpersonTxtbox.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(17, 34, 64);
            label7.Location = new Point(21, 246);
            label7.Name = "label7";
            label7.Size = new Size(319, 23);
            label7.TabIndex = 10;
            label7.Text = "Emergency Contact Person Relationship:";
            label7.Click += label7_Click;
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
            panel1.Controls.Add(emrgncycontactnoTxtbox);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(ageTxtbox);
            panel1.Controls.Add(deactivateBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(adpatientBtn);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(birthdayTxtbox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(statusCmbBox);
            panel1.Controls.Add(bloodtypeCmbbox);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(medhistoryTxtbox);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(currentmedTxtbox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(allergiesTxtbox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(emrgncycontactpersonTxtbox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(genderCmbBox);
            panel1.Controls.Add(contactnoTxtbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addressTxtbox);
            panel1.Controls.Add(fullnameTxtbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(473, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 809);
            panel1.TabIndex = 4;
            // 
            // emrgncycontactnoTxtbox
            // 
            emrgncycontactnoTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emrgncycontactnoTxtbox.Location = new Point(21, 341);
            emrgncycontactnoTxtbox.Name = "emrgncycontactnoTxtbox";
            emrgncycontactnoTxtbox.Size = new Size(393, 30);
            emrgncycontactnoTxtbox.TabIndex = 38;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(23, 315);
            label17.Name = "label17";
            label17.Size = new Size(233, 23);
            label17.TabIndex = 37;
            label17.Text = "Emergency Contact Number:";
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
            // ageTxtbox
            // 
            ageTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageTxtbox.Location = new Point(333, 133);
            ageTxtbox.Name = "ageTxtbox";
            ageTxtbox.ReadOnly = true;
            ageTxtbox.Size = new Size(86, 30);
            ageTxtbox.TabIndex = 35;
            // 
            // deactivateBtn
            // 
            deactivateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deactivateBtn.Location = new Point(365, 756);
            deactivateBtn.Name = "deactivateBtn";
            deactivateBtn.Size = new Size(121, 39);
            deactivateBtn.TabIndex = 34;
            deactivateBtn.Text = "Deactivate";
            deactivateBtn.UseVisualStyleBackColor = true;
            deactivateBtn.Click += deactivateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(258, 756);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(101, 39);
            clearBtn.TabIndex = 33;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += button3_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(141, 756);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(111, 39);
            updateBtn.TabIndex = 32;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // adpatientBtn
            // 
            adpatientBtn.BackColor = Color.FromArgb(37, 99, 235);
            adpatientBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adpatientBtn.ForeColor = Color.White;
            adpatientBtn.Location = new Point(10, 756);
            adpatientBtn.Name = "adpatientBtn";
            adpatientBtn.Size = new Size(125, 39);
            adpatientBtn.TabIndex = 31;
            adpatientBtn.Text = "Add patient";
            adpatientBtn.UseVisualStyleBackColor = false;
            adpatientBtn.Click += adpatientBtn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(21, 108);
            label14.Name = "label14";
            label14.Size = new Size(78, 23);
            label14.TabIndex = 30;
            label14.Text = "Birthday:";
            // 
            // birthdayTxtbox
            // 
            birthdayTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayTxtbox.Location = new Point(21, 133);
            birthdayTxtbox.Name = "birthdayTxtbox";
            birthdayTxtbox.PlaceholderText = "yyyy-MM-dd";
            birthdayTxtbox.Size = new Size(278, 30);
            birthdayTxtbox.TabIndex = 29;
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
            // statusCmbBox
            // 
            statusCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCmbBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusCmbBox.FormattingEnabled = true;
            statusCmbBox.Items.AddRange(new object[] { "Outpatient", "Admitted", "Discharged" });
            statusCmbBox.Location = new Point(454, 73);
            statusCmbBox.Name = "statusCmbBox";
            statusCmbBox.Size = new Size(151, 31);
            statusCmbBox.TabIndex = 27;
            // 
            // bloodtypeCmbbox
            // 
            bloodtypeCmbbox.DropDownStyle = ComboBoxStyle.DropDownList;
            bloodtypeCmbbox.FormattingEnabled = true;
            bloodtypeCmbbox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bloodtypeCmbbox.Location = new Point(454, 274);
            bloodtypeCmbbox.Name = "bloodtypeCmbbox";
            bloodtypeCmbbox.Size = new Size(151, 28);
            bloodtypeCmbbox.TabIndex = 26;
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
            // medhistoryTxtbox
            // 
            medhistoryTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medhistoryTxtbox.Location = new Point(333, 468);
            medhistoryTxtbox.Multiline = true;
            medhistoryTxtbox.Name = "medhistoryTxtbox";
            medhistoryTxtbox.Size = new Size(292, 27);
            medhistoryTxtbox.TabIndex = 21;
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
            // currentmedTxtbox
            // 
            currentmedTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentmedTxtbox.Location = new Point(21, 539);
            currentmedTxtbox.Name = "currentmedTxtbox";
            currentmedTxtbox.Size = new Size(292, 30);
            currentmedTxtbox.TabIndex = 18;
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
            // allergiesTxtbox
            // 
            allergiesTxtbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allergiesTxtbox.Location = new Point(23, 465);
            allergiesTxtbox.Name = "allergiesTxtbox";
            allergiesTxtbox.Size = new Size(292, 30);
            allergiesTxtbox.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(balanceTxtbox);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(totalpaidTxtbox);
            panel2.Controls.Add(totalbillTxtbox);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(visithistoryDataGridView);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(1120, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 811);
            panel2.TabIndex = 5;
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
            button5.Click += button5_Click;
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
            // balanceTxtbox
            // 
            balanceTxtbox.Location = new Point(15, 704);
            balanceTxtbox.Name = "balanceTxtbox";
            balanceTxtbox.ReadOnly = true;
            balanceTxtbox.Size = new Size(149, 27);
            balanceTxtbox.TabIndex = 7;
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
            // totalpaidTxtbox
            // 
            totalpaidTxtbox.Location = new Point(201, 648);
            totalpaidTxtbox.Name = "totalpaidTxtbox";
            totalpaidTxtbox.ReadOnly = true;
            totalpaidTxtbox.Size = new Size(211, 27);
            totalpaidTxtbox.TabIndex = 5;
            // 
            // totalbillTxtbox
            // 
            totalbillTxtbox.Location = new Point(15, 648);
            totalbillTxtbox.Name = "totalbillTxtbox";
            totalbillTxtbox.ReadOnly = true;
            totalbillTxtbox.Size = new Size(149, 27);
            totalbillTxtbox.TabIndex = 4;
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
            // visithistoryDataGridView
            // 
            visithistoryDataGridView.AllowUserToAddRows = false;
            visithistoryDataGridView.AllowUserToDeleteRows = false;
            visithistoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visithistoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { DateColumn, DoctorColumn, DiagnosisColumn, FollowUpColumn });
            visithistoryDataGridView.Location = new Point(15, 36);
            visithistoryDataGridView.Name = "visithistoryDataGridView";
            visithistoryDataGridView.ReadOnly = true;
            visithistoryDataGridView.RowHeadersWidth = 51;
            visithistoryDataGridView.Size = new Size(420, 498);
            visithistoryDataGridView.TabIndex = 1;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // genderCmbBox
            // 
            genderCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCmbBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderCmbBox.FormattingEnabled = true;
            genderCmbBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderCmbBox.Location = new Point(333, 73);
            genderCmbBox.Name = "genderCmbBox";
            genderCmbBox.Size = new Size(86, 31);
            genderCmbBox.TabIndex = 6;
            genderCmbBox.SelectedIndexChanged += genderCmbBox_SelectedIndexChanged_1;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            Controls.Add(patrecordDataGridView);
            Controls.Add(label1);
            Name = "PatientForm";
            Size = new Size(1585, 860);
            ((System.ComponentModel.ISupportInitialize)patrecordDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)visithistoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView patrecordDataGridView;
        private TextBox textBox1;
        private Button searchBtn;
        private Label label2;
        private Label label3;
        private TextBox fullnameTxtbox;
        private MaskedTextBox addressTxtbox;
        private Label label4;
        private TextBox contactnoTxtbox;
        private Label label5;
        private Label label6;
        private TextBox emrgncycontactpersonTxtbox;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private TextBox allergiesTxtbox;
        private Label label11;
        private MaskedTextBox currentmedTxtbox;
        private Label label12;
        private TextBox medhistoryTxtbox;
        private Label label13;
        private Label label15;
        private ComboBox bloodtypeCmbbox;
        private TextBox birthdayTxtbox;
        private Label label10;
        private ComboBox statusCmbBox;
        private Label label14;
        private Button adpatientBtn;
        private Button deactivateBtn;
        private Button clearBtn;
        private Button updateBtn;
        private TextBox emrgncycontactnoTxtbox;
        private Label label17;
        private Label label16;
        private TextBox ageTxtbox;
        private Panel panel2;
        private Label label18;
        private DataGridView visithistoryDataGridView;
        private Label label19;
        private Label label21;
        private TextBox totalpaidTxtbox;
        private TextBox totalbillTxtbox;
        private Label label20;
        private Label label22;
        private MaskedTextBox balanceTxtbox;
        private Button button5;
        private DataGridViewTextBoxColumn PatientIDColumn;
        private DataGridViewTextBoxColumn PatientNameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private DataGridViewTextBoxColumn ContactNumberColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn DoctorColumn;
        private DataGridViewTextBoxColumn DiagnosisColumn;
        private DataGridViewTextBoxColumn FollowUpColumn;
        private ErrorProvider errorProvider1;
        private ComboBox genderCmbBox;
    }
}
