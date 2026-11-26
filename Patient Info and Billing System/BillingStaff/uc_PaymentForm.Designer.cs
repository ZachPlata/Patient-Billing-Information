namespace Patient_Info_and_Billing_System.BillingStaff
{
    partial class uc_PaymentForm
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            panelGridCard = new Panel();
            lblBillsTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvBills = new DataGridView();
            panelFormCard = new Panel();
            lblFormTitle = new Label();
            lblPaymentId = new Label();
            txtPaymentId = new TextBox();
            lblBillId = new Label();
            txtBillId = new TextBox();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblAmountDue = new Label();
            txtAmountDue = new TextBox();
            lblAmountPaid = new Label();
            txtAmountPaid = new TextBox();
            lblRemainingBalance = new Label();
            txtRemainingBalance = new TextBox();
            grpPaymentMethod = new GroupBox();
            radCash = new RadioButton();
            radGcash = new RadioButton();
            radCreditCard = new RadioButton();
            lblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            lblReceiptNumber = new Label();
            txtReceiptNumber = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            panelFormCard.SuspendLayout();
            grpPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(4, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payment Form";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(6, 35);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(344, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select an unpaid or partial billing record to process a payment.";
            // 
            // panelGridCard
            // 
            panelGridCard.BackColor = Color.White;
            panelGridCard.BorderStyle = BorderStyle.FixedSingle;
            panelGridCard.Controls.Add(dgvBills);
            panelGridCard.Controls.Add(btnRefresh);
            panelGridCard.Controls.Add(btnSearch);
            panelGridCard.Controls.Add(txtSearch);
            panelGridCard.Controls.Add(lblSearch);
            panelGridCard.Controls.Add(lblBillsTitle);
            panelGridCard.Location = new Point(16, 76);
            panelGridCard.Name = "panelGridCard";
            panelGridCard.Size = new Size(810, 550);
            panelGridCard.TabIndex = 1;
            // 
            // lblBillsTitle
            // 
            lblBillsTitle.AutoSize = true;
            lblBillsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblBillsTitle.Location = new Point(16, 14);
            lblBillsTitle.Name = "lblBillsTitle";
            lblBillsTitle.Size = new Size(202, 21);
            lblBillsTitle.TabIndex = 0;
            lblBillsTitle.Text = "Pending Patient Balances";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(51, 65, 85);
            lblSearch.Location = new Point(16, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(141, 17);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Patient / Bill ID:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(168, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(410, 25);
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
            btnSearch.Location = new Point(588, 46);
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
            btnRefresh.Location = new Point(692, 46);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(16, 88);
            dgvBills.MultiSelect = false;
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(774, 444);
            dgvBills.TabIndex = 5;
            dgvBills.CellClick += dgvBills_CellClick;
            // 
            // panelFormCard
            // 
            panelFormCard.BackColor = Color.White;
            panelFormCard.BorderStyle = BorderStyle.FixedSingle;
            panelFormCard.Controls.Add(btnClear);
            panelFormCard.Controls.Add(btnSave);
            panelFormCard.Controls.Add(txtReceiptNumber);
            panelFormCard.Controls.Add(lblReceiptNumber);
            panelFormCard.Controls.Add(dtpPaymentDate);
            panelFormCard.Controls.Add(lblPaymentDate);
            panelFormCard.Controls.Add(grpPaymentMethod);
            panelFormCard.Controls.Add(txtRemainingBalance);
            panelFormCard.Controls.Add(lblRemainingBalance);
            panelFormCard.Controls.Add(txtAmountPaid);
            panelFormCard.Controls.Add(lblAmountPaid);
            panelFormCard.Controls.Add(txtAmountDue);
            panelFormCard.Controls.Add(lblAmountDue);
            panelFormCard.Controls.Add(txtPatientName);
            panelFormCard.Controls.Add(lblPatientName);
            panelFormCard.Controls.Add(txtBillId);
            panelFormCard.Controls.Add(lblBillId);
            panelFormCard.Controls.Add(txtPaymentId);
            panelFormCard.Controls.Add(lblPaymentId);
            panelFormCard.Controls.Add(lblFormTitle);
            panelFormCard.Location = new Point(842, 76);
            panelFormCard.Name = "panelFormCard";
            panelFormCard.Size = new Size(526, 550);
            panelFormCard.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblFormTitle.Location = new Point(20, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(142, 21);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Payment Details";
            // 
            // lblPaymentId
            // 
            lblPaymentId.AutoSize = true;
            lblPaymentId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentId.Location = new Point(20, 54);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(83, 17);
            lblPaymentId.TabIndex = 1;
            lblPaymentId.Text = "Payment ID:";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentId.Location = new Point(195, 50);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.ReadOnly = true;
            txtPaymentId.Size = new Size(298, 25);
            txtPaymentId.TabIndex = 2;
            // 
            // lblBillId
            // 
            lblBillId.AutoSize = true;
            lblBillId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillId.Location = new Point(20, 90);
            lblBillId.Name = "lblBillId";
            lblBillId.Size = new Size(49, 17);
            lblBillId.TabIndex = 3;
            lblBillId.Text = "Bill ID:";
            // 
            // txtBillId
            // 
            txtBillId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillId.Location = new Point(195, 86);
            txtBillId.Name = "txtBillId";
            txtBillId.ReadOnly = true;
            txtBillId.Size = new Size(298, 25);
            txtBillId.TabIndex = 4;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(20, 126);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(99, 17);
            lblPatientName.TabIndex = 5;
            lblPatientName.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientName.Location = new Point(195, 122);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new Size(298, 25);
            txtPatientName.TabIndex = 6;
            // 
            // lblAmountDue
            // 
            lblAmountDue.AutoSize = true;
            lblAmountDue.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountDue.Location = new Point(20, 162);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(92, 17);
            lblAmountDue.TabIndex = 7;
            lblAmountDue.Text = "Amount Due:";
            // 
            // txtAmountDue
            // 
            txtAmountDue.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountDue.Location = new Point(195, 158);
            txtAmountDue.Name = "txtAmountDue";
            txtAmountDue.ReadOnly = true;
            txtAmountDue.Size = new Size(298, 25);
            txtAmountDue.TabIndex = 8;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(20, 198);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(95, 17);
            lblAmountPaid.TabIndex = 9;
            lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountPaid.Location = new Point(195, 194);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(298, 25);
            txtAmountPaid.TabIndex = 10;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingBalance.Location = new Point(20, 234);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(134, 17);
            lblRemainingBalance.TabIndex = 11;
            lblRemainingBalance.Text = "Remaining Balance:";
            // 
            // txtRemainingBalance
            // 
            txtRemainingBalance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemainingBalance.Location = new Point(195, 230);
            txtRemainingBalance.Name = "txtRemainingBalance";
            txtRemainingBalance.ReadOnly = true;
            txtRemainingBalance.Size = new Size(298, 25);
            txtRemainingBalance.TabIndex = 12;
            // 
            // grpPaymentMethod
            // 
            grpPaymentMethod.Controls.Add(radCreditCard);
            grpPaymentMethod.Controls.Add(radGcash);
            grpPaymentMethod.Controls.Add(radCash);
            grpPaymentMethod.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPaymentMethod.Location = new Point(20, 270);
            grpPaymentMethod.Name = "grpPaymentMethod";
            grpPaymentMethod.Size = new Size(473, 108);
            grpPaymentMethod.TabIndex = 13;
            grpPaymentMethod.TabStop = false;
            grpPaymentMethod.Text = "Payment Method";
            // 
            // radCash
            // 
            radCash.AutoSize = true;
            radCash.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radCash.Location = new Point(22, 32);
            radCash.Name = "radCash";
            radCash.Size = new Size(57, 23);
            radCash.TabIndex = 0;
            radCash.TabStop = true;
            radCash.Text = "Cash";
            radCash.UseVisualStyleBackColor = true;
            // 
            // radGcash
            // 
            radGcash.AutoSize = true;
            radGcash.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radGcash.Location = new Point(168, 32);
            radGcash.Name = "radGcash";
            radGcash.Size = new Size(67, 23);
            radGcash.TabIndex = 1;
            radGcash.TabStop = true;
            radGcash.Text = "GCash";
            radGcash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            radCreditCard.AutoSize = true;
            radCreditCard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radCreditCard.Location = new Point(315, 32);
            radCreditCard.Name = "radCreditCard";
            radCreditCard.Size = new Size(94, 23);
            radCreditCard.TabIndex = 2;
            radCreditCard.TabStop = true;
            radCreditCard.Text = "Credit card";
            radCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentDate.Location = new Point(20, 396);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(100, 17);
            lblPaymentDate.TabIndex = 14;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(195, 392);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(298, 25);
            dtpPaymentDate.TabIndex = 15;
            // 
            // lblReceiptNumber
            // 
            lblReceiptNumber.AutoSize = true;
            lblReceiptNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptNumber.Location = new Point(20, 434);
            lblReceiptNumber.Name = "lblReceiptNumber";
            lblReceiptNumber.Size = new Size(165, 17);
            lblReceiptNumber.TabIndex = 16;
            lblReceiptNumber.Text = "Official Receipt Number:";
            // 
            // txtReceiptNumber
            // 
            txtReceiptNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceiptNumber.Location = new Point(195, 430);
            txtReceiptNumber.Name = "txtReceiptNumber";
            txtReceiptNumber.Size = new Size(298, 25);
            txtReceiptNumber.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(16, 185, 129);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(195, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save Payment";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(353, 482);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // uc_PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 249, 246);
            Controls.Add(panelFormCard);
            Controls.Add(panelGridCard);
            Controls.Add(panelHeader);
            Name = "uc_PaymentForm";
            Size = new Size(1384, 642);
            Load += uc_PaymentForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGridCard.ResumeLayout(false);
            panelGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            panelFormCard.ResumeLayout(false);
            panelFormCard.PerformLayout();
            grpPaymentMethod.ResumeLayout(false);
            grpPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelGridCard;
        private Label lblBillsTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvBills;
        private Panel panelFormCard;
        private Label lblFormTitle;
        private Label lblPaymentId;
        private TextBox txtPaymentId;
        private Label lblBillId;
        private TextBox txtBillId;
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Label lblAmountDue;
        private TextBox txtAmountDue;
        private Label lblAmountPaid;
        private TextBox txtAmountPaid;
        private Label lblRemainingBalance;
        private TextBox txtRemainingBalance;
        private GroupBox grpPaymentMethod;
        private RadioButton radCash;
        private RadioButton radGcash;
        private RadioButton radCreditCard;
        private Label lblPaymentDate;
        private DateTimePicker dtpPaymentDate;
        private Label lblReceiptNumber;
        private TextBox txtReceiptNumber;
        private Button btnSave;
        private Button btnClear;
        private ErrorProvider errorProvider1;
    }
}
