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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(50, 92);
            label1.Name = "label1";
            label1.Size = new Size(369, 41);
            label1.TabIndex = 0;
            label1.Text = "Metro Pedia Care System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 51);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 1;
            label2.Text = "Email/Username";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(38, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 38);
            textBox1.TabIndex = 2;
            textBox1.Text = "example@gmail.com";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(38, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 38);
            textBox2.TabIndex = 3;
            textBox2.Text = "Enter password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(50, 61);
            label4.Name = "label4";
            label4.Size = new Size(144, 31);
            label4.TabIndex = 5;
            label4.Text = "Welcome To";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 185, 129);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(163, 287);
            button1.Name = "button1";
            button1.Size = new Size(122, 41);
            button1.TabIndex = 6;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 381);
            panel1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Sign In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel1;
    }
}