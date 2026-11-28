namespace Patient_Info_and_Billing_System.Admin
{
    partial class DoctorManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            rbtnInactive = new RadioButton();
            rbtnActive = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            textPNum = new TextBox();
            label6 = new Label();
            textEmail = new TextBox();
            label5 = new Label();
            textSpecialty = new TextBox();
            label3 = new Label();
            txt_Password = new TextBox();
            label2 = new Label();
            txt_Username = new TextBox();
            label1 = new Label();
            txt_Fullname = new TextBox();
            doctorTable = new DataGridView();
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            label8 = new Label();
            label4 = new Label();
            cmbBoxFilter = new ComboBox();
            searchText = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorTable).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(248, 250, 252);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textPNum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textSpecialty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Fullname);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(17, 34, 64);
            groupBox1.Location = new Point(20, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(465, 617);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤Doctor Credentials Entry";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(234, 537);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(214, 29);
            button4.TabIndex = 18;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnInactive);
            groupBox2.Controls.Add(rbtnActive);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(14, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 53);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Status";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbtnInactive
            // 
            rbtnInactive.AutoSize = true;
            rbtnInactive.Location = new Point(105, 22);
            rbtnInactive.Name = "rbtnInactive";
            rbtnInactive.RightToLeft = RightToLeft.No;
            rbtnInactive.Size = new Size(70, 19);
            rbtnInactive.TabIndex = 1;
            rbtnInactive.TabStop = true;
            rbtnInactive.Text = "Inactive";
            rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            rbtnActive.AutoSize = true;
            rbtnActive.Location = new Point(26, 22);
            rbtnActive.Name = "rbtnActive";
            rbtnActive.Size = new Size(61, 19);
            rbtnActive.TabIndex = 0;
            rbtnActive.TabStop = true;
            rbtnActive.Text = "Active";
            rbtnActive.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(37, 99, 235);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 493);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(204, 29);
            button3.TabIndex = 16;
            button3.Text = "Edit ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 539);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(205, 25);
            button2.TabIndex = 15;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 34, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(234, 493);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(214, 29);
            button1.TabIndex = 14;
            button1.Text = "New ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 262);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 13;
            label7.Text = "Phone Number:";
            // 
            // textPNum
            // 
            textPNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPNum.Location = new Point(15, 280);
            textPNum.Margin = new Padding(3, 2, 3, 2);
            textPNum.Name = "textPNum";
            textPNum.Size = new Size(434, 23);
            textPNum.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 213);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 11;
            label6.Text = "Email Address:";
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textEmail.Location = new Point(15, 232);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(434, 23);
            textEmail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 314);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Specialty";
            // 
            // textSpecialty
            // 
            textSpecialty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSpecialty.Location = new Point(15, 331);
            textSpecialty.Margin = new Padding(3, 2, 3, 2);
            textSpecialty.Name = "textSpecialty";
            textSpecialty.Size = new Size(434, 23);
            textSpecialty.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(14, 178);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(434, 23);
            txt_Password.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 106);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Username.Location = new Point(14, 124);
            txt_Username.Margin = new Padding(3, 2, 3, 2);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(434, 23);
            txt_Username.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 52);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Staff Full Name:";
            // 
            // txt_Fullname
            // 
            txt_Fullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Fullname.Location = new Point(14, 73);
            txt_Fullname.Margin = new Padding(3, 2, 3, 2);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(434, 23);
            txt_Fullname.TabIndex = 0;
            txt_Fullname.TextChanged += txt_Fullname_TextChanged;
            // 
            // doctorTable
            // 
            doctorTable.AllowUserToResizeColumns = false;
            doctorTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctorTable.BackgroundColor = Color.White;
            doctorTable.BorderStyle = BorderStyle.None;
            doctorTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            doctorTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            doctorTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            doctorTable.ColumnHeadersHeight = 42;
            doctorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            doctorTable.DefaultCellStyle = dataGridViewCellStyle2;
            doctorTable.EnableHeadersVisualStyles = false;
            doctorTable.GridColor = Color.FromArgb(235, 238, 242);
            doctorTable.Location = new Point(511, 119);
            doctorTable.Margin = new Padding(3, 2, 3, 2);
            doctorTable.MultiSelect = false;
            doctorTable.Name = "doctorTable";
            doctorTable.ReadOnly = true;
            doctorTable.RowHeadersVisible = false;
            doctorTable.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 52, 64);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 242, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 52, 64);
            doctorTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            doctorTable.RowTemplate.Height = 38;
            doctorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorTable.Size = new Size(1010, 514);
            doctorTable.TabIndex = 2;
            doctorTable.CellClick += doctorTable_CellClick;
            doctorTable.CellContentClick += doctorTable_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(248, 250, 252);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cmbBoxFilter);
            groupBox3.Controls.Add(searchText);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(511, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1010, 82);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = " ⌕ Search && Filter Directory";
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(861, 36);
            button6.Name = "button6";
            button6.Size = new Size(143, 23);
            button6.TabIndex = 5;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(37, 99, 235);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(575, 37);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(656, 19);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 3;
            label8.Text = "Account Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "Search: ";
            // 
            // cmbBoxFilter
            // 
            cmbBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxFilter.FormattingEnabled = true;
            cmbBoxFilter.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            cmbBoxFilter.Location = new Point(656, 37);
            cmbBoxFilter.Name = "cmbBoxFilter";
            cmbBoxFilter.Size = new Size(199, 23);
            cmbBoxFilter.TabIndex = 1;
            cmbBoxFilter.SelectedIndexChanged += cmbBoxFilter_SelectedIndexChanged;
            // 
            // searchText
            // 
            searchText.Location = new Point(20, 38);
            searchText.Name = "searchText";
            searchText.Size = new Size(549, 23);
            searchText.TabIndex = 0;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // DoctorManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(groupBox3);
            Controls.Add(doctorTable);
            Controls.Add(groupBox1);
            Name = "DoctorManage";
            Size = new Size(1546, 653);
            Load += DoctorManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorTable).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private TextBox textPNum;
        private Label label6;
        private TextBox textEmail;
        private Label label5;
        private TextBox textSpecialty;
        private Label label3;
        private TextBox txt_Password;
        private Label label2;
        private TextBox txt_Username;
        private Label label1;
        private TextBox txt_Fullname;
        private DataGridView doctorTable;
        private GroupBox groupBox2;
        private RadioButton rbtnInactive;
        private RadioButton rbtnActive;
        private Button button4;
        private GroupBox groupBox3;
        private ComboBox cmbBoxFilter;
        private TextBox searchText;
        private Button button5;
        private Label label8;
        private Label label4;
        private Button button6;
        private ErrorProvider errorProvider1;
    }
}
