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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            txtHideUser = new TextBox();
            txtHideType = new TextBox();
            txtHidePw = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(44, 69);
            label1.Name = "label1";
            label1.Size = new Size(298, 32);
            label1.TabIndex = 0;
            label1.Text = "Metro Pedia Care System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 38);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Email/Username";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(33, 62);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(323, 32);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(33, 146);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 122);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(44, 46);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "Welcome To";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 185, 129);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(143, 215);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(107, 31);
            button1.TabIndex = 6;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(10, 120);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 286);
            panel1.TabIndex = 7;
            // 
            // txtHideUser
            // 
            txtHideUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHideUser.ForeColor = Color.Gray;
            txtHideUser.Location = new Point(566, 46);
            txtHideUser.Margin = new Padding(3, 2, 3, 2);
            txtHideUser.Name = "txtHideUser";
            txtHideUser.Size = new Size(149, 32);
            txtHideUser.TabIndex = 7;
            // 
            // txtHideType
            // 
            txtHideType.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHideType.ForeColor = Color.Gray;
            txtHideType.Location = new Point(566, 120);
            txtHideType.Margin = new Padding(3, 2, 3, 2);
            txtHideType.Name = "txtHideType";
            txtHideType.Size = new Size(149, 32);
            txtHideType.TabIndex = 8;
            // 
            // txtHidePw
            // 
            txtHidePw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHidePw.ForeColor = Color.Gray;
            txtHidePw.Location = new Point(566, 84);
            txtHidePw.Margin = new Padding(3, 2, 3, 2);
            txtHidePw.Name = "txtHidePw";
            txtHidePw.Size = new Size(149, 32);
            txtHidePw.TabIndex = 9;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 415);
            Controls.Add(txtHidePw);
            Controls.Add(txtHideType);
            Controls.Add(txtHideUser);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignIn";
            Text = "Sign In";
            Load += SignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel1;
        private TextBox txtHideUser;
        private TextBox txtHideType;
        private TextBox txtHidePw;
    }
}