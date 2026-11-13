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
            btnExportCsv = new Button();
            btnRefresh = new Button();
            btnAddData = new Button();
            panelNavTabs = new Panel();
            btnTabRoomBed = new Button();
            panelTabUnderline = new Panel();
            btnTabLabTests = new Button();
            btnTabMedicine = new Button();
            btnTabConsultation = new Button();
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
            panelHeader.Controls.Add(btnExportCsv);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(btnAddData);
            panelHeader.Location = new Point(24, 14);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1339, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblBreadcrumb1
            // 
            lblBreadcrumb1.AutoSize = true;
            lblBreadcrumb1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBreadcrumb1.ForeColor = Color.FromArgb(100, 116, 139);
            lblBreadcrumb1.Location = new Point(0, 2);
            lblBreadcrumb1.Name = "lblBreadcrumb1";
            lblBreadcrumb1.Size = new Size(189, 19);
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
            lblBreadcrumb2.Size = new Size(157, 19);
            lblBreadcrumb2.TabIndex = 1;
            lblBreadcrumb2.Text = "Clinic and Data Setups";
            // 
            // lblActiveBadge
            // 
            lblActiveBadge.BackColor = Color.FromArgb(219, 234, 254);
            lblActiveBadge.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveBadge.ForeColor = Color.FromArgb(37, 99, 235);
            lblActiveBadge.Location = new Point(333, 2);
            lblActiveBadge.Name = "lblActiveBadge";
            lblActiveBadge.Size = new Size(92, 20);
            lblActiveBadge.TabIndex = 2;
            lblActiveBadge.Text = "Active Module";
            lblActiveBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleIcon
            // 
            lblTitleIcon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblTitleIcon.Location = new Point(3, 26);
            lblTitleIcon.Name = "lblTitleIcon";
            lblTitleIcon.Size = new Size(26, 36);
            lblTitleIcon.TabIndex = 3;
            lblTitleIcon.Text = "≋";
            lblTitleIcon.Click += lblTitleIcon_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(34, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 31);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Clinic and Master Data Configuration";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.White;
            btnExportCsv.Cursor = Cursors.Hand;
            btnExportCsv.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCsv.ForeColor = Color.FromArgb(51, 65, 85);
            btnExportCsv.Location = new Point(918, 23);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(115, 39);
            btnExportCsv.TabIndex = 5;
            btnExportCsv.Text = "⭳  Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new Point(1039, 23);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(95, 39);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "⟳  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += this.btnRefresh_Click;
            // 
            // btnAddData
            // 
            btnAddData.BackColor = Color.FromArgb(37, 99, 235);
            btnAddData.Cursor = Cursors.Hand;
            btnAddData.FlatAppearance.BorderSize = 0;
            btnAddData.FlatStyle = FlatStyle.Flat;
            btnAddData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddData.ForeColor = Color.White;
            btnAddData.Location = new Point(1140, 23);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(194, 39);
            btnAddData.TabIndex = 7;
            btnAddData.Text = "+ Add New Bed / Room";
            btnAddData.UseVisualStyleBackColor = false;
            btnAddData.Click += btnAddData_Click;
            // 
            // panelNavTabs
            // 
            panelNavTabs.Controls.Add(btnTabRoomBed);
            panelNavTabs.Controls.Add(panelTabUnderline);
            panelNavTabs.Controls.Add(btnTabLabTests);
            panelNavTabs.Controls.Add(btnTabMedicine);
            panelNavTabs.Controls.Add(btnTabConsultation);
            panelNavTabs.Controls.Add(panelTabsDivider);
            panelNavTabs.Location = new Point(24, 88);
            panelNavTabs.Name = "panelNavTabs";
            panelNavTabs.Size = new Size(1339, 48);
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
            btnTabRoomBed.Size = new Size(246, 38);
            btnTabRoomBed.TabIndex = 0;
            btnTabRoomBed.Text = "🛏  Room & Bed Management  ( 0 )";
            btnTabRoomBed.TextAlign = ContentAlignment.MiddleLeft;
            btnTabRoomBed.UseVisualStyleBackColor = false;
            btnTabRoomBed.Click += btnTabRoomBed_Click;
            // 
            // panelTabUnderline
            // 
            panelTabUnderline.BackColor = Color.FromArgb(37, 99, 235);
            panelTabUnderline.Location = new Point(0, 41);
            panelTabUnderline.Name = "panelTabUnderline";
            panelTabUnderline.Size = new Size(246, 3);
            panelTabUnderline.TabIndex = 1;
            panelTabUnderline.Paint += panelTabUnderline_Paint;
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
            btnTabLabTests.Location = new Point(255, 4);
            btnTabLabTests.Name = "btnTabLabTests";
            btnTabLabTests.Size = new Size(220, 38);
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
            btnTabMedicine.Location = new Point(480, 4);
            btnTabMedicine.Name = "btnTabMedicine";
            btnTabMedicine.Size = new Size(180, 38);
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
            btnTabConsultation.Location = new Point(665, 4);
            btnTabConsultation.Name = "btnTabConsultation";
            btnTabConsultation.Size = new Size(245, 38);
            btnTabConsultation.TabIndex = 4;
            btnTabConsultation.Text = "\U0001f9d1‍⚕️  Consultation Fee Schedules  (0)";
            btnTabConsultation.TextAlign = ContentAlignment.MiddleLeft;
            btnTabConsultation.UseVisualStyleBackColor = false;
            btnTabConsultation.Click += btnTabConsultation_Click;
            // 
            // panelTabsDivider
            // 
            panelTabsDivider.BackColor = Color.FromArgb(226, 232, 240);
            panelTabsDivider.Location = new Point(0, 44);
            panelTabsDivider.Name = "panelTabsDivider";
            panelTabsDivider.Size = new Size(1339, 1);
            panelTabsDivider.TabIndex = 5;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblFooterSecurity);
            panelFooter.Controls.Add(lblFooterAudit);
            panelFooter.Controls.Add(lblFooterDataSet);
            panelFooter.Location = new Point(24, 691);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1339, 29);
            panelFooter.TabIndex = 8;
            // 
            // lblFooterSecurity
            // 
            lblFooterSecurity.AutoSize = true;
            lblFooterSecurity.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterSecurity.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterSecurity.Location = new Point(0, 5);
            lblFooterSecurity.Name = "lblFooterSecurity";
            lblFooterSecurity.Size = new Size(215, 17);
            lblFooterSecurity.TabIndex = 0;
            lblFooterSecurity.Text = "🛡  Role: Full Administrative Access";
            // 
            // lblFooterAudit
            // 
            lblFooterAudit.AutoSize = true;
            lblFooterAudit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterAudit.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterAudit.Location = new Point(210, 5);
            lblFooterAudit.Name = "lblFooterAudit";
            lblFooterAudit.Size = new Size(237, 17);
            lblFooterAudit.TabIndex = 1;
            lblFooterAudit.Text = "•  Audit Stamp: Real-time Ledger Active";
            // 
            // lblFooterDataSet
            // 
            lblFooterDataSet.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterDataSet.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterDataSet.Location = new Point(1060, 5);
            lblFooterDataSet.Name = "lblFooterDataSet";
            lblFooterDataSet.Size = new Size(279, 20);
            lblFooterDataSet.TabIndex = 2;
            lblFooterDataSet.Text = "Data Set: Metro Pedia Central Clinic";
            lblFooterDataSet.TextAlign = ContentAlignment.TopRight;
            // 
            // panelContent
            // 
            panelContent.Location = new Point(24, 142);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1339, 543);
            panelContent.TabIndex = 9;
            panelContent.Paint += panelContent_Paint;
            // 
            // ClinicAndDataSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNavTabs);
            Controls.Add(panelFooter);
            Name = "ClinicAndDataSetup";
            RightToLeft = RightToLeft.No;
            Size = new Size(1387, 731);
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
        private Button btnExportCsv;
        private Button btnRefresh;
        private Button btnAddData;
        private Panel panelNavTabs;
        private Button btnTabRoomBed;
        private Panel panelTabUnderline;
        private Button btnTabLabTests;
        private Button btnTabMedicine;
        private Button btnTabConsultation;
        private Panel panelTabsDivider;
        private Panel panelFooter;
        private Label lblFooterSecurity;
        private Label lblFooterAudit;
        private Label lblFooterDataSet;
        private Panel panelContent;
    }
}
