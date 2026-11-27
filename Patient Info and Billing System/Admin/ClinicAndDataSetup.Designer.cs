namespace Patient_Info_and_Billing_System.Admin
{
    partial class ClinicAndDataSetup
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
            btnTabRoomBed = new Button();
            panelTabUnderline = new Panel();
            btnTabLabTests = new Button();
            btnTabMedicine = new Button();
            btnTabConsultation = new Button();
            btnTabSpecialties = new Button();
            panelTabsDivider = new Panel();
            panelFooter = new Panel();
            lblFooterSecurity = new Label();
            lblFooterAudit = new Label();
            lblFooterDataSet = new Label();
            panelContent = new Panel();
            panelHeader.SuspendLayout();
            panelNavTabs.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblBreadcrumb1);
            panelHeader.Controls.Add(lblBreadcrumb2);
            panelHeader.Controls.Add(lblActiveBadge);
            panelHeader.Controls.Add(lblTitleIcon);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(24, 10);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1537, 58);
            panelHeader.TabIndex = 0;
            // 
            // lblBreadcrumb1
            // 
            lblBreadcrumb1.AutoSize = true;
            lblBreadcrumb1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreadcrumb1.ForeColor = Color.FromArgb(100, 116, 139);
            lblBreadcrumb1.Location = new Point(0, 4);
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
            lblBreadcrumb2.Location = new Point(210, 4);
            lblBreadcrumb2.Name = "lblBreadcrumb2";
            lblBreadcrumb2.Size = new Size(129, 15);
            lblBreadcrumb2.TabIndex = 1;
            lblBreadcrumb2.Text = "Clinic and Data Setups";
            lblBreadcrumb2.Click += lblBreadcrumb2_Click;
            // 
            // lblActiveBadge
            // 
            lblActiveBadge.BackColor = Color.FromArgb(219, 234, 254);
            lblActiveBadge.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveBadge.ForeColor = Color.FromArgb(37, 99, 235);
            lblActiveBadge.Location = new Point(380, 3);
            lblActiveBadge.Name = "lblActiveBadge";
            lblActiveBadge.Size = new Size(92, 18);
            lblActiveBadge.TabIndex = 2;
            lblActiveBadge.Text = "Active Module";
            lblActiveBadge.TextAlign = ContentAlignment.MiddleCenter;
            lblActiveBadge.Click += lblActiveBadge_Click;
            // 
            // lblTitleIcon
            // 
            lblTitleIcon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitleIcon.Location = new Point(3, 25);
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
            lblTitle.Location = new Point(34, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(365, 28);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Clinic and Master Data Configuration";
            // 
            // panelNavTabs
            // 
            panelNavTabs.Controls.Add(btnTabRoomBed);
            panelNavTabs.Controls.Add(panelTabUnderline);
            panelNavTabs.Controls.Add(btnTabLabTests);
            panelNavTabs.Controls.Add(btnTabMedicine);
            panelNavTabs.Controls.Add(btnTabConsultation);
            panelNavTabs.Controls.Add(btnTabSpecialties);
            panelNavTabs.Controls.Add(panelTabsDivider);
            panelNavTabs.Location = new Point(24, 72);
            panelNavTabs.Name = "panelNavTabs";
            panelNavTabs.Size = new Size(1537, 44);
            panelNavTabs.TabIndex = 1;
            // 
            // btnTabRoomBed
            // 
            btnTabRoomBed.BackColor = Color.Transparent;
            btnTabRoomBed.Cursor = Cursors.Hand;
            btnTabRoomBed.FlatAppearance.BorderSize = 0;
            btnTabRoomBed.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabRoomBed.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabRoomBed.FlatStyle = FlatStyle.Flat;
            btnTabRoomBed.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabRoomBed.ForeColor = Color.FromArgb(37, 99, 235);
            btnTabRoomBed.Location = new Point(3, 3);
            btnTabRoomBed.Name = "btnTabRoomBed";
            btnTabRoomBed.Size = new Size(256, 36);
            btnTabRoomBed.TabIndex = 0;
            btnTabRoomBed.Text = "🛏  Room && Bed Management  (0)";
            btnTabRoomBed.TextAlign = ContentAlignment.MiddleLeft;
            btnTabRoomBed.UseVisualStyleBackColor = false;
            btnTabRoomBed.Click += btnTabRoomBed_Click;
            // 
            // panelTabUnderline
            // 
            panelTabUnderline.BackColor = Color.FromArgb(37, 99, 235);
            panelTabUnderline.Location = new Point(0, 38);
            panelTabUnderline.Name = "panelTabUnderline";
            panelTabUnderline.Size = new Size(256, 3);
            panelTabUnderline.TabIndex = 1;
            // 
            // btnTabLabTests
            // 
            btnTabLabTests.BackColor = Color.Transparent;
            btnTabLabTests.Cursor = Cursors.Hand;
            btnTabLabTests.FlatAppearance.BorderSize = 0;
            btnTabLabTests.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabLabTests.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabLabTests.FlatStyle = FlatStyle.Flat;
            btnTabLabTests.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabLabTests.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabLabTests.Location = new Point(268, 4);
            btnTabLabTests.Name = "btnTabLabTests";
            btnTabLabTests.Size = new Size(235, 36);
            btnTabLabTests.TabIndex = 2;
            btnTabLabTests.Text = "\U0001f9ea  Laboratory Tests Catalog  (0)";
            btnTabLabTests.TextAlign = ContentAlignment.MiddleLeft;
            btnTabLabTests.UseVisualStyleBackColor = false;
            btnTabLabTests.Click += btnTabLabTests_Click;
            // 
            // btnTabMedicine
            // 
            btnTabMedicine.BackColor = Color.Transparent;
            btnTabMedicine.Cursor = Cursors.Hand;
            btnTabMedicine.FlatAppearance.BorderSize = 0;
            btnTabMedicine.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabMedicine.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabMedicine.FlatStyle = FlatStyle.Flat;
            btnTabMedicine.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabMedicine.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabMedicine.Location = new Point(512, 4);
            btnTabMedicine.Name = "btnTabMedicine";
            btnTabMedicine.Size = new Size(195, 36);
            btnTabMedicine.TabIndex = 3;
            btnTabMedicine.Text = "💊  Medicine Catalog  (0)";
            btnTabMedicine.TextAlign = ContentAlignment.MiddleLeft;
            btnTabMedicine.UseVisualStyleBackColor = false;
            btnTabMedicine.Click += btnTabMedicine_Click;
            // 
            // btnTabConsultation
            // 
            btnTabConsultation.BackColor = Color.Transparent;
            btnTabConsultation.Cursor = Cursors.Hand;
            btnTabConsultation.FlatAppearance.BorderSize = 0;
            btnTabConsultation.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabConsultation.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabConsultation.FlatStyle = FlatStyle.Flat;
            btnTabConsultation.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabConsultation.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabConsultation.Location = new Point(716, 4);
            btnTabConsultation.Name = "btnTabConsultation";
            btnTabConsultation.Size = new Size(265, 36);
            btnTabConsultation.TabIndex = 4;
            btnTabConsultation.Text = "\U0001f9d1‍⚕️  Consultation Fee Schedules  (0)";
            btnTabConsultation.TextAlign = ContentAlignment.MiddleLeft;
            btnTabConsultation.UseVisualStyleBackColor = false;
            btnTabConsultation.Click += btnTabConsultation_Click;
            // 
            // btnTabSpecialties
            // 
            btnTabSpecialties.BackColor = Color.Transparent;
            btnTabSpecialties.Cursor = Cursors.Hand;
            btnTabSpecialties.FlatAppearance.BorderSize = 0;
            btnTabSpecialties.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTabSpecialties.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTabSpecialties.FlatStyle = FlatStyle.Flat;
            btnTabSpecialties.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTabSpecialties.ForeColor = Color.FromArgb(100, 116, 139);
            btnTabSpecialties.Location = new Point(990, 4);
            btnTabSpecialties.Name = "btnTabSpecialties";
            btnTabSpecialties.Size = new Size(230, 36);
            btnTabSpecialties.TabIndex = 5;
            btnTabSpecialties.Text = "\U0001fa7a  Doctor Specialties  (0)";
            btnTabSpecialties.TextAlign = ContentAlignment.MiddleLeft;
            btnTabSpecialties.UseVisualStyleBackColor = false;
            btnTabSpecialties.Click += btnTabSpecialties_Click;
            // 
            // panelTabsDivider
            // 
            panelTabsDivider.BackColor = Color.FromArgb(226, 232, 240);
            panelTabsDivider.Location = new Point(0, 41);
            panelTabsDivider.Name = "panelTabsDivider";
            panelTabsDivider.Size = new Size(1537, 1);
            panelTabsDivider.TabIndex = 6;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblFooterSecurity);
            panelFooter.Controls.Add(lblFooterAudit);
            panelFooter.Controls.Add(lblFooterDataSet);
            panelFooter.Location = new Point(24, 686);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1537, 26);
            panelFooter.TabIndex = 8;
            // 
            // lblFooterSecurity
            // 
            lblFooterSecurity.AutoSize = true;
            lblFooterSecurity.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterSecurity.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterSecurity.Location = new Point(0, 4);
            lblFooterSecurity.Name = "lblFooterSecurity";
            lblFooterSecurity.Size = new Size(185, 13);
            lblFooterSecurity.TabIndex = 0;
            lblFooterSecurity.Text = "🛡  Role: Full Administrative Access";
            // 
            // lblFooterAudit
            // 
            lblFooterAudit.AutoSize = true;
            lblFooterAudit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterAudit.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterAudit.Location = new Point(235, 4);
            lblFooterAudit.Name = "lblFooterAudit";
            lblFooterAudit.Size = new Size(205, 13);
            lblFooterAudit.TabIndex = 1;
            lblFooterAudit.Text = "•  Audit Stamp: Real-time Ledger Active";
            // 
            // lblFooterDataSet
            // 
            lblFooterDataSet.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterDataSet.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterDataSet.Location = new Point(1258, 4);
            lblFooterDataSet.Name = "lblFooterDataSet";
            lblFooterDataSet.Size = new Size(279, 18);
            lblFooterDataSet.TabIndex = 2;
            lblFooterDataSet.Text = "Data Set: Metro Pedia Central Clinic";
            lblFooterDataSet.TextAlign = ContentAlignment.TopRight;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(24, 122);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1537, 558);
            panelContent.TabIndex = 9;
            // 
            // ClinicAndDataSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNavTabs);
            Controls.Add(panelFooter);
            Name = "ClinicAndDataSetup";
            RightToLeft = RightToLeft.No;
            Size = new Size(1585, 720);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavTabs.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
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
        private Button btnTabRoomBed;
        private Panel panelTabUnderline;
        private Button btnTabLabTests;
        private Button btnTabMedicine;
        private Button btnTabConsultation;
        private Button btnTabSpecialties;
        private Panel panelTabsDivider;
        private Panel panelFooter;
        private Label lblFooterSecurity;
        private Label lblFooterAudit;
        private Label lblFooterDataSet;
        private Panel panelContent;
    }
}
