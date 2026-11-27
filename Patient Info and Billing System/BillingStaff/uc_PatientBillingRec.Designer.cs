namespace Patient_Info_and_Billing_System
{
    partial class uc_PatientBillingRec
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            panelBadge = new Panel();
            lblBadge = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelDetailsCard = new Panel();
            btnClearSelection = new Button();
            btnShowAll = new Button();
            txtEquipmentUsed = new TextBox();
            lblEquipmentUsed = new Label();
            txtBillings = new TextBox();
            lblBillings = new Label();
            lstVisitHistory = new ListBox();
            lblVisitHistory = new Label();
            txtPatientName = new TextBox();
            lblPatientName = new Label();
            lblDetailsHeader = new Label();
            panelTableCard = new Panel();
            lblFooterRight = new Label();
            lblFooterLeft = new Label();
            btnClearSearch = new Button();
            btnReload = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblRecordCount = new Label();
            lblTableTitle = new Label();
            PatBillRec_DGV = new DataGridView();
            panelHeader.SuspendLayout();
            panelBadge.SuspendLayout();
            panelDetailsCard.SuspendLayout();
            panelTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatBillRec_DGV).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Transparent;
            panelHeader.Controls.Add(panelBadge);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(20, 15);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1545, 70);
            panelHeader.TabIndex = 0;
            // 
            // panelBadge
            // 
            panelBadge.BackColor = Color.White;
            panelBadge.BorderStyle = BorderStyle.FixedSingle;
            panelBadge.Controls.Add(lblBadge);
            panelBadge.Location = new Point(1385, 18);
            panelBadge.Name = "panelBadge";
            panelBadge.Size = new Size(160, 34);
            panelBadge.TabIndex = 2;
            // 
            // lblBadge
            // 
            lblBadge.AutoSize = true;
            lblBadge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBadge.ForeColor = Color.FromArgb(16, 185, 129);
            lblBadge.Location = new Point(14, 7);
            lblBadge.Name = "lblBadge";
            lblBadge.Size = new Size(114, 17);
            lblBadge.TabIndex = 0;
            lblBadge.Text = "● Billing & History";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(2, 42);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(511, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select a patient to view their visit history, billing records, and utilized equipment/items.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(3, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Records & Billing Log";
            // 
            // panelDetailsCard
            // 
            panelDetailsCard.BackColor = Color.White;
            panelDetailsCard.BorderStyle = BorderStyle.FixedSingle;
            panelDetailsCard.Controls.Add(btnClearSelection);
            panelDetailsCard.Controls.Add(btnShowAll);
            panelDetailsCard.Controls.Add(txtEquipmentUsed);
            panelDetailsCard.Controls.Add(lblEquipmentUsed);
            panelDetailsCard.Controls.Add(txtBillings);
            panelDetailsCard.Controls.Add(lblBillings);
            panelDetailsCard.Controls.Add(lstVisitHistory);
            panelDetailsCard.Controls.Add(lblVisitHistory);
            panelDetailsCard.Controls.Add(txtPatientName);
            panelDetailsCard.Controls.Add(lblPatientName);
            panelDetailsCard.Controls.Add(lblDetailsHeader);
            panelDetailsCard.Location = new Point(20, 95);
            panelDetailsCard.Name = "panelDetailsCard";
            panelDetailsCard.Size = new Size(380, 745);
            panelDetailsCard.TabIndex = 1;
            // 
            // btnClearSelection
            // 
            btnClearSelection.BackColor = Color.FromArgb(248, 250, 252);
            btnClearSelection.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClearSelection.FlatStyle = FlatStyle.Flat;
            btnClearSelection.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSelection.ForeColor = Color.FromArgb(71, 85, 105);
            btnClearSelection.Location = new Point(18, 687);
            btnClearSelection.Name = "btnClearSelection";
            btnClearSelection.Size = new Size(342, 38);
            btnClearSelection.TabIndex = 10;
            btnClearSelection.Text = "↺ Clear Selection";
            btnClearSelection.UseVisualStyleBackColor = false;
            btnClearSelection.Click += btnClearSelection_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(37, 99, 235);
            btnShowAll.FlatAppearance.BorderSize = 0;
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(18, 641);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(342, 38);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All Billings & Equipment";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // txtEquipmentUsed
            // 
            txtEquipmentUsed.BackColor = Color.FromArgb(248, 250, 252);
            txtEquipmentUsed.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentUsed.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEquipmentUsed.ForeColor = Color.FromArgb(15, 23, 42);
            txtEquipmentUsed.Location = new Point(18, 465);
            txtEquipmentUsed.Multiline = true;
            txtEquipmentUsed.Name = "txtEquipmentUsed";
            txtEquipmentUsed.PlaceholderText = "Equipment & drugs used will appear here...";
            txtEquipmentUsed.ReadOnly = true;
            txtEquipmentUsed.ScrollBars = ScrollBars.Vertical;
            txtEquipmentUsed.Size = new Size(342, 160);
            txtEquipmentUsed.TabIndex = 8;
            // 
            // lblEquipmentUsed
            // 
            lblEquipmentUsed.AutoSize = true;
            lblEquipmentUsed.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipmentUsed.ForeColor = Color.FromArgb(71, 85, 105);
            lblEquipmentUsed.Location = new Point(18, 445);
            lblEquipmentUsed.Name = "lblEquipmentUsed";
            lblEquipmentUsed.Size = new Size(190, 17);
            lblEquipmentUsed.TabIndex = 7;
            lblEquipmentUsed.Text = "Equipment & Drugs Used (Util)";
            // 
            // txtBillings
            // 
            txtBillings.BackColor = Color.FromArgb(248, 250, 252);
            txtBillings.BorderStyle = BorderStyle.FixedSingle;
            txtBillings.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillings.ForeColor = Color.FromArgb(15, 23, 42);
            txtBillings.Location = new Point(18, 290);
            txtBillings.Multiline = true;
            txtBillings.Name = "txtBillings";
            txtBillings.PlaceholderText = "Billing records will appear here...";
            txtBillings.ReadOnly = true;
            txtBillings.ScrollBars = ScrollBars.Vertical;
            txtBillings.Size = new Size(342, 140);
            txtBillings.TabIndex = 6;
            // 
            // lblBillings
            // 
            lblBillings.AutoSize = true;
            lblBillings.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillings.ForeColor = Color.FromArgb(71, 85, 105);
            lblBillings.Location = new Point(18, 270);
            lblBillings.Name = "lblBillings";
            lblBillings.Size = new Size(100, 17);
            lblBillings.TabIndex = 5;
            lblBillings.Text = "Billing Records";
            // 
            // lstVisitHistory
            // 
            lstVisitHistory.BackColor = Color.FromArgb(248, 250, 252);
            lstVisitHistory.BorderStyle = BorderStyle.FixedSingle;
            lstVisitHistory.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstVisitHistory.ForeColor = Color.FromArgb(15, 23, 42);
            lstVisitHistory.FormattingEnabled = true;
            lstVisitHistory.Location = new Point(18, 130);
            lstVisitHistory.Name = "lstVisitHistory";
            lstVisitHistory.Size = new Size(342, 121);
            lstVisitHistory.TabIndex = 4;
            lstVisitHistory.SelectedIndexChanged += lstVisitHistory_SelectedIndexChanged;
            // 
            // lblVisitHistory
            // 
            lblVisitHistory.AutoSize = true;
            lblVisitHistory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitHistory.ForeColor = Color.FromArgb(71, 85, 105);
            lblVisitHistory.Location = new Point(18, 110);
            lblVisitHistory.Name = "lblVisitHistory";
            lblVisitHistory.Size = new Size(217, 17);
            lblVisitHistory.TabIndex = 3;
            lblVisitHistory.Text = "Visit History (Click a date for bill)";
            // 
            // txtPatientName
            // 
            txtPatientName.BackColor = Color.FromArgb(248, 250, 252);
            txtPatientName.BorderStyle = BorderStyle.FixedSingle;
            txtPatientName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientName.ForeColor = Color.FromArgb(15, 23, 42);
            txtPatientName.Location = new Point(18, 72);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.PlaceholderText = "Select a patient from the table";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new Size(342, 24);
            txtPatientName.TabIndex = 2;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientName.ForeColor = Color.FromArgb(71, 85, 105);
            lblPatientName.Location = new Point(18, 52);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(92, 17);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Patient Name";
            // 
            // lblDetailsHeader
            // 
            lblDetailsHeader.AutoSize = true;
            lblDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailsHeader.ForeColor = Color.FromArgb(37, 99, 235);
            lblDetailsHeader.Location = new Point(16, 16);
            lblDetailsHeader.Name = "lblDetailsHeader";
            lblDetailsHeader.Size = new Size(122, 21);
            lblDetailsHeader.TabIndex = 0;
            lblDetailsHeader.Text = "Patient Details";
            // 
            // panelTableCard
            // 
            panelTableCard.BackColor = Color.White;
            panelTableCard.BorderStyle = BorderStyle.FixedSingle;
            panelTableCard.Controls.Add(lblFooterRight);
            panelTableCard.Controls.Add(lblFooterLeft);
            panelTableCard.Controls.Add(btnClearSearch);
            panelTableCard.Controls.Add(btnReload);
            panelTableCard.Controls.Add(btnSearch);
            panelTableCard.Controls.Add(txtSearch);
            panelTableCard.Controls.Add(lblRecordCount);
            panelTableCard.Controls.Add(lblTableTitle);
            panelTableCard.Controls.Add(PatBillRec_DGV);
            panelTableCard.Location = new Point(416, 95);
            panelTableCard.Name = "panelTableCard";
            panelTableCard.Size = new Size(1149, 745);
            panelTableCard.TabIndex = 2;
            // 
            // lblFooterRight
            // 
            lblFooterRight.AutoSize = true;
            lblFooterRight.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFooterRight.ForeColor = Color.FromArgb(37, 99, 235);
            lblFooterRight.Location = new Point(925, 710);
            lblFooterRight.Name = "lblFooterRight";
            lblFooterRight.Size = new Size(171, 15);
            lblFooterRight.TabIndex = 8;
            lblFooterRight.Text = "Visits, Billings & Equipment Used";
            // 
            // lblFooterLeft
            // 
            lblFooterLeft.AutoSize = true;
            lblFooterLeft.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterLeft.ForeColor = Color.FromArgb(100, 116, 139);
            lblFooterLeft.Location = new Point(18, 710);
            lblFooterLeft.Name = "lblFooterLeft";
            lblFooterLeft.Size = new Size(422, 15);
            lblFooterLeft.TabIndex = 7;
            lblFooterLeft.Text = "Click a patient row, then click any visit date on the left to view that day's billing";
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.FromArgb(248, 250, 252);
            btnClearSearch.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = Color.FromArgb(71, 85, 105);
            btnClearSearch.Location = new Point(1095, 14);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(34, 30);
            btnClearSearch.TabIndex = 6;
            btnClearSearch.Text = "✕";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(248, 250, 252);
            btnReload.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.FromArgb(15, 23, 42);
            btnReload.Location = new Point(1014, 14);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 30);
            btnReload.TabIndex = 5;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(16, 185, 129);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(923, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(248, 250, 252);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(15, 23, 42);
            txtSearch.Location = new Point(685, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search patient ID or name...";
            txtSearch.Size = new Size(230, 25);
            txtSearch.TabIndex = 3;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblRecordCount.Location = new Point(195, 19);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(70, 17);
            lblRecordCount.TabIndex = 2;
            lblRecordCount.Text = "0 patient(s)";
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableTitle.ForeColor = Color.FromArgb(37, 99, 235);
            lblTableTitle.Location = new Point(16, 16);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(174, 21);
            lblTableTitle.TabIndex = 1;
            lblTableTitle.Text = "Patient Records Table";
            // 
            // PatBillRec_DGV
            // 
            PatBillRec_DGV.AllowUserToAddRows = false;
            PatBillRec_DGV.AllowUserToDeleteRows = false;
            PatBillRec_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatBillRec_DGV.BackgroundColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(17, 34, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(17, 34, 64);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PatBillRec_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PatBillRec_DGV.ColumnHeadersHeight = 36;
            PatBillRec_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            PatBillRec_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            PatBillRec_DGV.EnableHeadersVisualStyles = false;
            PatBillRec_DGV.GridColor = Color.FromArgb(226, 232, 240);
            PatBillRec_DGV.Location = new Point(18, 58);
            PatBillRec_DGV.MultiSelect = false;
            PatBillRec_DGV.Name = "PatBillRec_DGV";
            PatBillRec_DGV.ReadOnly = true;
            PatBillRec_DGV.RowHeadersVisible = false;
            PatBillRec_DGV.RowTemplate.Height = 32;
            PatBillRec_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatBillRec_DGV.Size = new Size(1111, 635);
            PatBillRec_DGV.TabIndex = 0;
            PatBillRec_DGV.CellClick += PatBillRec_DGV_CellClick;
            // 
            // uc_PatientBillingRec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            Controls.Add(panelTableCard);
            Controls.Add(panelDetailsCard);
            Controls.Add(panelHeader);
            Name = "uc_PatientBillingRec";
            Size = new Size(1585, 860);
            Load += uc_PatientBillingRec_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBadge.ResumeLayout(false);
            panelBadge.PerformLayout();
            panelDetailsCard.ResumeLayout(false);
            panelDetailsCard.PerformLayout();
            panelTableCard.ResumeLayout(false);
            panelTableCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatBillRec_DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelBadge;
        private Label lblBadge;
        private Panel panelDetailsCard;
        private Label lblDetailsHeader;
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Label lblVisitHistory;
        private ListBox lstVisitHistory;
        private Label lblBillings;
        private TextBox txtBillings;
        private Label lblEquipmentUsed;
        private TextBox txtEquipmentUsed;
        private Button btnShowAll;
        private Button btnClearSelection;
        private Panel panelTableCard;
        private Label lblTableTitle;
        private Label lblRecordCount;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnReload;
        private Button btnClearSearch;
        private DataGridView PatBillRec_DGV;
        private Label lblFooterLeft;
        private Label lblFooterRight;
    }
}
