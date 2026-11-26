namespace Patient_Info_and_Billing_System.BillingStaff
{
    partial class uc_PaymentHistory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelGridCard = new Panel();
            dgvPaymentHistory = new DataGridView();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblHistoryTitle = new Label();
            panelDetailCard = new Panel();
            btnClear = new Button();
            txtReceiptNumber = new TextBox();
            lblReceiptNumber = new Label();
            txtPaymentMethod = new TextBox();
            lblPaymentMethod = new Label();
            txtAmountPaid = new TextBox();
            lblAmountPaid = new Label();
            txtDatePaid = new TextBox();
            lblDatePaid = new Label();
            txtPatientName = new TextBox();
            lblPatientName = new Label();
            txtPaymentId = new TextBox();
            lblPaymentId = new Label();
            lblDetailTitle = new Label();
            panelHeader.SuspendLayout();
            panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).BeginInit();
            panelDetailCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(250, 249, 246);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(12, 10);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 58);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(6, 35);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(340, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Search and view completed patient payment transactions.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(4, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment History";
            // 
            // panelGridCard
            // 
            panelGridCard.BackColor = Color.White;
            panelGridCard.BorderStyle = BorderStyle.FixedSingle;
            panelGridCard.Controls.Add(dgvPaymentHistory);
            panelGridCard.Controls.Add(btnRefresh);
            panelGridCard.Controls.Add(btnSearch);
            panelGridCard.Controls.Add(txtSearch);
            panelGridCard.Controls.Add(lblSearch);
            panelGridCard.Controls.Add(lblHistoryTitle);
            panelGridCard.Location = new Point(16, 76);
            panelGridCard.Name = "panelGridCard";
            panelGridCard.Size = new Size(880, 550);
            panelGridCard.TabIndex = 1;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblHistoryTitle.Location = new Point(16, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(192, 21);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "Payment Transactions";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(51, 65, 85);
            lblSearch.Location = new Point(16, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(216, 17);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Payment ID / Name / OR #:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(240, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(406, 25);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(656, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(100, 116, 139);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(760, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvPaymentHistory
            // 
            dgvPaymentHistory.AllowUserToAddRows = false;
            dgvPaymentHistory.AllowUserToDeleteRows = false;
            dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentHistory.BackgroundColor = Color.White;
            dgvPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentHistory.Location = new Point(16, 88);
            dgvPaymentHistory.MultiSelect = false;
            dgvPaymentHistory.Name = "dgvPaymentHistory";
            dgvPaymentHistory.ReadOnly = true;
            dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentHistory.Size = new Size(846, 444);
            dgvPaymentHistory.TabIndex = 5;
            dgvPaymentHistory.CellClick += dgvPaymentHistory_CellClick;
            // 
            // panelDetailCard
            // 
            panelDetailCard.BackColor = Color.White;
            panelDetailCard.BorderStyle = BorderStyle.FixedSingle;
            panelDetailCard.Controls.Add(btnClear);
            panelDetailCard.Controls.Add(txtReceiptNumber);
            panelDetailCard.Controls.Add(lblReceiptNumber);
            panelDetailCard.Controls.Add(txtPaymentMethod);
            panelDetailCard.Controls.Add(lblPaymentMethod);
            panelDetailCard.Controls.Add(txtAmountPaid);
            panelDetailCard.Controls.Add(lblAmountPaid);
            panelDetailCard.Controls.Add(txtDatePaid);
            panelDetailCard.Controls.Add(lblDatePaid);
            panelDetailCard.Controls.Add(txtPatientName);
            panelDetailCard.Controls.Add(lblPatientName);
            panelDetailCard.Controls.Add(txtPaymentId);
            panelDetailCard.Controls.Add(lblPaymentId);
            panelDetailCard.Controls.Add(lblDetailTitle);
            panelDetailCard.Location = new Point(912, 76);
            panelDetailCard.Name = "panelDetailCard";
            panelDetailCard.Size = new Size(456, 550);
            panelDetailCard.TabIndex = 2;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblDetailTitle.Location = new Point(20, 14);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(165, 21);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Transaction Details";
            // 
            // lblPaymentId
            // 
            lblPaymentId.AutoSize = true;
            lblPaymentId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentId.Location = new Point(20, 62);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(83, 17);
            lblPaymentId.TabIndex = 1;
            lblPaymentId.Text = "Payment ID:";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentId.Location = new Point(160, 58);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.ReadOnly = true;
            txtPaymentId.Size = new Size(270, 25);
            txtPaymentId.TabIndex = 2;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(20, 108);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(99, 17);
            lblPatientName.TabIndex = 3;
            lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientName.Location = new Point(160, 104);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new Size(270, 25);
            txtPatientName.TabIndex = 4;
            // 
            // lblDatePaid
            // 
            lblDatePaid.AutoSize = true;
            lblDatePaid.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatePaid.Location = new Point(20, 154);
            lblDatePaid.Name = "lblDatePaid";
            lblDatePaid.Size = new Size(74, 17);
            lblDatePaid.TabIndex = 5;
            lblDatePaid.Text = "Date Paid:";
            // 
            // txtDatePaid
            // 
            txtDatePaid.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatePaid.Location = new Point(160, 150);
            txtDatePaid.Name = "txtDatePaid";
            txtDatePaid.ReadOnly = true;
            txtDatePaid.Size = new Size(270, 25);
            txtDatePaid.TabIndex = 6;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(20, 200);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(95, 17);
            lblAmountPaid.TabIndex = 7;
            lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountPaid.Location = new Point(160, 196);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.ReadOnly = true;
            txtAmountPaid.Size = new Size(270, 25);
            txtAmountPaid.TabIndex = 8;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(20, 246);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(122, 17);
            lblPaymentMethod.TabIndex = 9;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentMethod.Location = new Point(160, 242);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.ReadOnly = true;
            txtPaymentMethod.Size = new Size(270, 25);
            txtPaymentMethod.TabIndex = 10;
            // 
            // lblReceiptNumber
            // 
            lblReceiptNumber.AutoSize = true;
            lblReceiptNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptNumber.Location = new Point(20, 292);
            lblReceiptNumber.Name = "lblReceiptNumber";
            lblReceiptNumber.Size = new Size(118, 17);
            lblReceiptNumber.TabIndex = 11;
            lblReceiptNumber.Text = "Receipt Number:";
            // 
            // txtReceiptNumber
            // 
            txtReceiptNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceiptNumber.Location = new Point(160, 288);
            txtReceiptNumber.Name = "txtReceiptNumber";
            txtReceiptNumber.ReadOnly = true;
            txtReceiptNumber.Size = new Size(270, 25);
            txtReceiptNumber.TabIndex = 12;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(160, 346);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // uc_PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 249, 246);
            Controls.Add(panelDetailCard);
            Controls.Add(panelGridCard);
            Controls.Add(panelHeader);
            Name = "uc_PaymentHistory";
            Size = new Size(1384, 642);
            Load += uc_PaymentHistory_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGridCard.ResumeLayout(false);
            panelGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).EndInit();
            panelDetailCard.ResumeLayout(false);
            panelDetailCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panelGridCard;
        private DataGridView dgvPaymentHistory;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblHistoryTitle;
        private Panel panelDetailCard;
        private Button btnClear;
        private TextBox txtReceiptNumber;
        private Label lblReceiptNumber;
        private TextBox txtPaymentMethod;
        private Label lblPaymentMethod;
        private TextBox txtAmountPaid;
        private Label lblAmountPaid;
        private TextBox txtDatePaid;
        private Label lblDatePaid;
        private TextBox txtPatientName;
        private Label lblPatientName;
        private TextBox txtPaymentId;
        private Label lblPaymentId;
        private Label lblDetailTitle;
    }
}
