namespace Patient_Info_and_Billing_System.Admin
{
    partial class AdminManage
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
            groupBox3 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            label8 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            searchText = new TextBox();
            userTable = new DataGridView();
            groupBox1 = new GroupBox();
            button4 = new Button();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            txt_Password = new TextBox();
            label2 = new Label();
            txt_Username = new TextBox();
            label1 = new Label();
            txt_Fullname = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(248, 250, 252);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(searchText);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(514, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1010, 82);
            groupBox3.TabIndex = 9;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ACTIVE", "INACTIVE", "LOCKED" });
            comboBox1.Location = new Point(656, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchText
            // 
            searchText.Location = new Point(20, 38);
            searchText.Name = "searchText";
            searchText.Size = new Size(549, 23);
            searchText.TabIndex = 0;
            // 
            // userTable
            // 
            userTable.AllowUserToResizeColumns = false;
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userTable.BackgroundColor = Color.White;
            userTable.BorderStyle = BorderStyle.None;
            userTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            userTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userTable.ColumnHeadersHeight = 42;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(13, 27, 48);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userTable.DefaultCellStyle = dataGridViewCellStyle2;
            userTable.EnableHeadersVisualStyles = false;
            userTable.GridColor = Color.FromArgb(235, 238, 242);
            userTable.Location = new Point(514, 121);
            userTable.Margin = new Padding(3, 2, 3, 2);
            userTable.Name = "userTable";
            userTable.RowHeadersVisible = false;
            userTable.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 52, 64);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 242, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 52, 64);
            userTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            userTable.RowTemplate.Height = 38;
            userTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userTable.Size = new Size(1010, 514);
            userTable.TabIndex = 8;
            userTable.CellClick += userTable_CellClick;
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
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_Fullname);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(17, 34, 64);
            groupBox1.Location = new Point(23, 18);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(465, 617);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "👤Admin Credentials Entry";
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
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 53);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account Status";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(190, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Locked";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(105, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.RightToLeft = RightToLeft.No;
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Inactive";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Active";
            radioButton1.UseVisualStyleBackColor = true;
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
            label7.Location = new Point(15, 260);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 13;
            label7.Text = "Phone Number:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(15, 280);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(434, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 211);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 11;
            label6.Text = "Email Address:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(15, 232);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(434, 23);
            textBox5.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 158);
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
            label2.Location = new Point(14, 104);
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
            label1.Location = new Point(14, 50);
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
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(userTable);
            Controls.Add(groupBox1);
            Name = "AdminManage";
            Size = new Size(1546, 653);
            Load += AdminManage_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button button6;
        private Button button5;
        private Label label8;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox searchText;
        private DataGridView userTable;
        private GroupBox groupBox1;
        private Button button4;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label3;
        private TextBox txt_Password;
        private Label label2;
        private TextBox txt_Username;
        private Label label1;
        private TextBox txt_Fullname;
        private ErrorProvider errorProvider1;
    }
}
