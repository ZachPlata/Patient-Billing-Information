namespace Patient_Info_and_Billing_System.LogIn
{
    partial class SignIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            txtHideUser = new TextBox();
            txtHideType = new TextBox();
            txtHidePw = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Dock = DockStyle.Fill;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(46, 0);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(369, 22);
            txtUser.TabIndex = 1;
            txtUser.WordWrap = false;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(46, 0);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(369, 22);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 34, 64);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(230, 227);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 0;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtHideUser
            // 
            txtHideUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHideUser.ForeColor = Color.Gray;
            txtHideUser.Location = new Point(750, 385);
            txtHideUser.Margin = new Padding(3, 2, 3, 2);
            txtHideUser.Name = "txtHideUser";
            txtHideUser.Size = new Size(149, 32);
            txtHideUser.TabIndex = 7;
            txtHideUser.Visible = false;
            // 
            // txtHideType
            // 
            txtHideType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHideType.ForeColor = Color.Gray;
            txtHideType.Location = new Point(750, 457);
            txtHideType.Margin = new Padding(3, 2, 3, 2);
            txtHideType.Name = "txtHideType";
            txtHideType.Size = new Size(149, 32);
            txtHideType.TabIndex = 8;
            txtHideType.Visible = false;
            // 
            // txtHidePw
            // 
            txtHidePw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHidePw.ForeColor = Color.Gray;
            txtHidePw.Location = new Point(750, 421);
            txtHidePw.Margin = new Padding(3, 2, 3, 2);
            txtHidePw.Name = "txtHidePw";
            txtHidePw.Size = new Size(149, 32);
            txtHidePw.TabIndex = 9;
            txtHidePw.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 34, 64);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 108);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 61);
            label4.Name = "label4";
            label4.Size = new Size(192, 21);
            label4.TabIndex = 8;
            label4.Text = "Sign in to Your Workspace";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(40, 24);
            label3.Name = "label3";
            label3.Size = new Size(377, 37);
            label3.TabIndex = 5;
            label3.Text = "MetroCare Hospital  System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(250, 249, 246);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(17, 34, 64);
            groupBox1.Location = new Point(40, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 298);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "ACCOUNT CREDENTIALS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(31, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(417, 27);
            panel3.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(31, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 28);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(342, 227);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 145);
            label2.Name = "label2";
            label2.Size = new Size(67, 13);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 56);
            label1.Name = "label1";
            label1.Size = new Size(123, 13);
            label1.TabIndex = 4;
            label1.Text = "EMAIL OR USERNAME";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(250, 249, 246);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(17, 34, 64);
            groupBox2.Location = new Point(42, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 75);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "SELECT ACCESS ROLE";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 34, 64);
            button5.Location = new Point(340, 19);
            button5.Name = "button5";
            button5.Size = new Size(131, 36);
            button5.TabIndex = 2;
            button5.Text = "NURSE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 34, 64);
            button4.Location = new Point(180, 19);
            button4.Name = "button4";
            button4.Size = new Size(131, 36);
            button4.TabIndex = 1;
            button4.Text = "DOCTOR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 34, 64);
            button3.Location = new Point(21, 22);
            button3.Name = "button3";
            button3.Size = new Size(131, 36);
            button3.TabIndex = 0;
            button3.Text = "ADMIN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 562);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(txtHidePw);
            Controls.Add(txtHideUser);
            Controls.Add(txtHideType);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MetroCare Hospital System - Sign In";
            Load += SignIn_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button1;
        private TextBox txtHideUser;
        private TextBox txtHideType;
        private TextBox txtHidePw;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private ErrorProvider errorProvider1;
    }
}