namespace Patient_Info_and_Billing_System.Admin
{
    partial class AdminUserManagement
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
            panelHeader = new Panel();
            lblBreadcrumb1 = new Label();
            lblBreadcrumb2 = new Label();
            lblActiveBadge = new Label();
            lblTitleIcon = new Label();
            lblTitle = new Label();
            panelNavTabs = new Panel();
            btnTabDoctor = new Button();
            panelTabUnderline = new Panel();
            btnTabNurse = new Button();
            btnTabAdmin = new Button();
            panelTabsDivider = new Panel();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            panelNavTabs.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(248, 250, 252);
            panelHeader.Controls.Add(lblBreadcrumb1);
            panelHeader.Controls.Add(lblBreadcrumb2);
            panelHeader.Controls.Add(lblActiveBadge);
            panelHeader.Controls.Add(lblTitleIcon);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(21, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1543, 62);
            panelHeader.TabIndex = 13;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblBreadcrumb1
            // 
            lblBreadcrumb1.AutoSize = true;
            lblBreadcrumb1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreadcrumb1.ForeColor = Color.FromArgb(100, 116, 139);
            lblBreadcrumb1.Location = new Point(0, 2);
            lblBreadcrumb1.Name = "lblBreadcrumb1";
            lblBreadcrumb1.Size = new Size(163, 15);
            lblBreadcrumb1.TabIndex = 0;
            lblBreadcrumb1.Text = "Administrative Workspaces   ›";
            // 
            // lblBreadcrumb2
            // 
            lblBreadcrumb2.AutoSize = true;
            lblBreadcrumb2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBreadcrumb2.ForeColor = Color.FromArgb(37, 99, 235);
            lblBreadcrumb2.Location = new Point(170, 2);
            lblBreadcrumb2.Name = "lblBreadcrumb2";
            lblBreadcrumb2.Size = new Size(110, 15);
            lblBreadcrumb2.TabIndex = 1;
            lblBreadcrumb2.Text = "User Management";
            // 
            // lblActiveBadge
            // 
            lblActiveBadge.BackColor = Color.FromArgb(219, 234, 254);
            lblActiveBadge.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveBadge.ForeColor = Color.FromArgb(37, 99, 235);
            lblActiveBadge.Location = new Point(333, 2);
            lblActiveBadge.Name = "lblActiveBadge";
            lblActiveBadge.Size = new Size(92, 18);
            lblActiveBadge.TabIndex = 2;
            lblActiveBadge.Text = "Active Module";
            lblActiveBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleIcon
            // 
            lblTitleIcon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitleIcon.Location = new Point(3, 23);
            lblTitleIcon.Name = "lblTitleIcon";
            lblTitleIcon.Size = new Size(26, 32);
            lblTitleIcon.TabIndex = 3;
            lblTitleIcon.Text = "≋";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(25, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Clinic User Management";
            // 
            // panelNavTabs
            // 
            panelNavTabs.BackColor = Color.FromArgb(248, 250, 252);
            panelNavTabs.Controls.Add(btnTabDoctor);
            panelNavTabs.Controls.Add(panelTabUnderline);
            panelNavTabs.Controls.Add(btnTabNurse);
            panelNavTabs.Controls.Add(btnTabAdmin);
            panelNavTabs.Controls.Add(panelTabsDivider);
            panelNavTabs.Location = new Point(18, 82);
            panelNavTabs.Name = "panelNavTabs";
            panelNavTabs.Size = new Size(1546, 42);
            panelNavTabs.TabIndex = 14;
            // 
            // btnTabDoctor
            // 
            btnTabDoctor.BackColor = Color.Transparent;
            btnTabDoctor.Cursor = Cursors.Hand;
            btnTabDoctor.FlatAppearance.BorderSize = 0;
            btnTabDoctor.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabDoctor.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabDoctor.FlatStyle = FlatStyle.Flat;
            btnTabDoctor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabDoctor.ForeColor = Color.FromArgb(37, 99, 235);
            btnTabDoctor.Location = new Point(3, 3);
            btnTabDoctor.Name = "btnTabDoctor";
            btnTabDoctor.Size = new Size(246, 34);
            btnTabDoctor.TabIndex = 0;
            btnTabDoctor.Text = "\U0001fa7aDoctor (0)";
            btnTabDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnTabDoctor.UseVisualStyleBackColor = false;
            btnTabDoctor.Click += btnTabRoomBed_Click;
            // 
            // panelTabUnderline
            // 
            panelTabUnderline.BackColor = Color.FromArgb(37, 99, 235);
            panelTabUnderline.Location = new Point(0, 36);
            panelTabUnderline.Name = "panelTabUnderline";
            panelTabUnderline.Size = new Size(246, 3);
            panelTabUnderline.TabIndex = 1;
            // 
            // btnTabNurse
            // 
            btnTabNurse.BackColor = Color.Transparent;
            btnTabNurse.Cursor = Cursors.Hand;
            btnTabNurse.FlatAppearance.BorderSize = 0;
            btnTabNurse.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabNurse.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabNurse.FlatStyle = FlatStyle.Flat;
            btnTabNurse.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabNurse.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabNurse.Location = new Point(255, 4);
            btnTabNurse.Name = "btnTabNurse";
            btnTabNurse.Size = new Size(220, 34);
            btnTabNurse.TabIndex = 2;
            btnTabNurse.Text = "💉Nurse (0)";
            btnTabNurse.TextAlign = ContentAlignment.MiddleLeft;
            btnTabNurse.UseVisualStyleBackColor = false;
            btnTabNurse.Click += btnTabNurse_Click;
            // 
            // btnTabAdmin
            // 
            btnTabAdmin.BackColor = Color.Transparent;
            btnTabAdmin.Cursor = Cursors.Hand;
            btnTabAdmin.FlatAppearance.BorderSize = 0;
            btnTabAdmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabAdmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabAdmin.FlatStyle = FlatStyle.Flat;
            btnTabAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabAdmin.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabAdmin.Location = new Point(480, 4);
            btnTabAdmin.Name = "btnTabAdmin";
            btnTabAdmin.Size = new Size(180, 34);
            btnTabAdmin.TabIndex = 3;
            btnTabAdmin.Text = "🛡️ Admin (0)";
            btnTabAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnTabAdmin.UseVisualStyleBackColor = false;
            btnTabAdmin.Click += btnTabAdmin_Click;
            // 
            // panelTabsDivider
            // 
            panelTabsDivider.BackColor = Color.FromArgb(226, 232, 240);
            panelTabsDivider.Location = new Point(0, 39);
            panelTabsDivider.Name = "panelTabsDivider";
            panelTabsDivider.Size = new Size(1339, 1);
            panelTabsDivider.TabIndex = 5;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 250, 252);
            panelContent.Location = new Point(18, 141);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1546, 653);
            panelContent.TabIndex = 15;
            // 
            // AdminUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContent);
            Controls.Add(panelNavTabs);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminUserManagement";
            Size = new Size(1585, 860);
            Load += AdminUserManagement_Load_1;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label lblBreadcrumb1;
        private Label lblBreadcrumb2;
        private Label lblActiveBadge;
        private Label lblTitleIcon;
        private Label lblTitle;
        private Panel panelNavTabs;
        private Button btnTabDoctor;
        private Panel panelTabUnderline;
        private Button btnTabNurse;
        private Button btnTabAdmin;
        private Panel panelTabsDivider;
        private Panel panelContent;
    }
}
