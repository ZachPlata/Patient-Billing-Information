namespace Patient_Info_and_Billing_System.Admin
{
    partial class RnBManagement
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
            cardTotalBeds = new Panel();
            lblTitleTotalBeds = new Label();
            lblValTotalBeds = new Label();
            pnlIconTotalBeds = new Panel();
            lblIconBed = new Label();
            cardAvailableBeds = new Panel();
            lblTitleAvailBeds = new Label();
            lblValAvailBeds = new Label();
            pnlIconAvailBeds = new Panel();
            lblIconDoor = new Label();
            cardOccupiedBeds = new Panel();
            lblTitleOccupiedBeds = new Label();
            lblValOccupiedBeds = new Label();
            pnlIconOccupiedBeds = new Panel();
            lblIconOccupied = new Label();
            cardAvgRate = new Panel();
            lblTitleAvgRate = new Label();
            lblValAvgRate = new Label();
            pnlIconAvgRate = new Panel();
            lblIconPeso = new Label();
            groupBoxForm = new GroupBox();
            lblBedId = new Label();
            txtBedId = new TextBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblBedNumber = new Label();
            txtBedNumber = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblDailyRate = new Label();
            txtDailyRate = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblShowingEntries = new Label();
            dgvRooms = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            cardTotalBeds.SuspendLayout();
            pnlIconTotalBeds.SuspendLayout();
            cardAvailableBeds.SuspendLayout();
            pnlIconAvailBeds.SuspendLayout();
            cardOccupiedBeds.SuspendLayout();
            pnlIconOccupiedBeds.SuspendLayout();
            cardAvgRate.SuspendLayout();
            pnlIconAvgRate.SuspendLayout();
            groupBoxForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cardTotalBeds
            // 
            cardTotalBeds.BackColor = Color.White;
            cardTotalBeds.BorderStyle = BorderStyle.FixedSingle;
            cardTotalBeds.Controls.Add(lblTitleTotalBeds);
            cardTotalBeds.Controls.Add(lblValTotalBeds);
            cardTotalBeds.Controls.Add(pnlIconTotalBeds);
            cardTotalBeds.Location = new Point(0, 8);
            cardTotalBeds.Name = "cardTotalBeds";
            cardTotalBeds.Size = new Size(372, 76);
            cardTotalBeds.TabIndex = 0;
            // 
            // lblTitleTotalBeds
            // 
            lblTitleTotalBeds.AutoSize = true;
            lblTitleTotalBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleTotalBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleTotalBeds.Location = new Point(14, 12);
            lblTitleTotalBeds.Name = "lblTitleTotalBeds";
            lblTitleTotalBeds.Size = new Size(124, 12);
            lblTitleTotalBeds.TabIndex = 0;
            lblTitleTotalBeds.Text = "TOTAL REGISTERED BEDS";
            // 
            // lblValTotalBeds
            // 
            lblValTotalBeds.AutoSize = true;
            lblValTotalBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValTotalBeds.ForeColor = Color.FromArgb(15, 23, 42);
            lblValTotalBeds.Location = new Point(14, 30);
            lblValTotalBeds.Name = "lblValTotalBeds";
            lblValTotalBeds.Size = new Size(28, 32);
            lblValTotalBeds.TabIndex = 1;
            lblValTotalBeds.Text = "0";
            // 
            // pnlIconTotalBeds
            // 
            pnlIconTotalBeds.BackColor = Color.FromArgb(239, 246, 255);
            pnlIconTotalBeds.Controls.Add(lblIconBed);
            pnlIconTotalBeds.Location = new Point(314, 16);
            pnlIconTotalBeds.Name = "pnlIconTotalBeds";
            pnlIconTotalBeds.Size = new Size(42, 42);
            pnlIconTotalBeds.TabIndex = 2;
            // 
            // lblIconBed
            // 
            lblIconBed.Dock = DockStyle.Fill;
            lblIconBed.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIconBed.ForeColor = Color.FromArgb(37, 99, 235);
            lblIconBed.Location = new Point(0, 0);
            lblIconBed.Name = "lblIconBed";
            lblIconBed.Size = new Size(42, 42);
            lblIconBed.TabIndex = 0;
            lblIconBed.Text = "🛏";
            lblIconBed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardAvailableBeds
            // 
            cardAvailableBeds.BackColor = Color.White;
            cardAvailableBeds.BorderStyle = BorderStyle.FixedSingle;
            cardAvailableBeds.Controls.Add(lblTitleAvailBeds);
            cardAvailableBeds.Controls.Add(lblValAvailBeds);
            cardAvailableBeds.Controls.Add(pnlIconAvailBeds);
            cardAvailableBeds.Location = new Point(388, 8);
            cardAvailableBeds.Name = "cardAvailableBeds";
            cardAvailableBeds.Size = new Size(372, 76);
            cardAvailableBeds.TabIndex = 1;
            // 
            // lblTitleAvailBeds
            // 
            lblTitleAvailBeds.AutoSize = true;
            lblTitleAvailBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAvailBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleAvailBeds.Location = new Point(14, 12);
            lblTitleAvailBeds.Name = "lblTitleAvailBeds";
            lblTitleAvailBeds.Size = new Size(82, 12);
            lblTitleAvailBeds.TabIndex = 0;
            lblTitleAvailBeds.Text = "AVAILABLE BEDS";
            // 
            // lblValAvailBeds
            // 
            lblValAvailBeds.AutoSize = true;
            lblValAvailBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAvailBeds.ForeColor = Color.FromArgb(16, 185, 129);
            lblValAvailBeds.Location = new Point(14, 30);
            lblValAvailBeds.Name = "lblValAvailBeds";
            lblValAvailBeds.Size = new Size(28, 32);
            lblValAvailBeds.TabIndex = 1;
            lblValAvailBeds.Text = "0";
            // 
            // pnlIconAvailBeds
            // 
            pnlIconAvailBeds.BackColor = Color.FromArgb(236, 253, 245);
            pnlIconAvailBeds.Controls.Add(lblIconDoor);
            pnlIconAvailBeds.Location = new Point(314, 16);
            pnlIconAvailBeds.Name = "pnlIconAvailBeds";
            pnlIconAvailBeds.Size = new Size(42, 42);
            pnlIconAvailBeds.TabIndex = 2;
            // 
            // lblIconDoor
            // 
            lblIconDoor.Dock = DockStyle.Fill;
            lblIconDoor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIconDoor.ForeColor = Color.FromArgb(16, 185, 129);
            lblIconDoor.Location = new Point(0, 0);
            lblIconDoor.Name = "lblIconDoor";
            lblIconDoor.Size = new Size(42, 42);
            lblIconDoor.TabIndex = 0;
            lblIconDoor.Text = "🚪";
            lblIconDoor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardOccupiedBeds
            // 
            cardOccupiedBeds.BackColor = Color.White;
            cardOccupiedBeds.BorderStyle = BorderStyle.FixedSingle;
            cardOccupiedBeds.Controls.Add(lblTitleOccupiedBeds);
            cardOccupiedBeds.Controls.Add(lblValOccupiedBeds);
            cardOccupiedBeds.Controls.Add(pnlIconOccupiedBeds);
            cardOccupiedBeds.Location = new Point(776, 8);
            cardOccupiedBeds.Name = "cardOccupiedBeds";
            cardOccupiedBeds.Size = new Size(372, 76);
            cardOccupiedBeds.TabIndex = 2;
            // 
            // lblTitleOccupiedBeds
            // 
            lblTitleOccupiedBeds.AutoSize = true;
            lblTitleOccupiedBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOccupiedBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleOccupiedBeds.Location = new Point(14, 12);
            lblTitleOccupiedBeds.Name = "lblTitleOccupiedBeds";
            lblTitleOccupiedBeds.Size = new Size(80, 12);
            lblTitleOccupiedBeds.TabIndex = 0;
            lblTitleOccupiedBeds.Text = "OCCUPIED BEDS";
            // 
            // lblValOccupiedBeds
            // 
            lblValOccupiedBeds.AutoSize = true;
            lblValOccupiedBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValOccupiedBeds.ForeColor = Color.FromArgb(245, 158, 11);
            lblValOccupiedBeds.Location = new Point(14, 30);
            lblValOccupiedBeds.Name = "lblValOccupiedBeds";
            lblValOccupiedBeds.Size = new Size(28, 32);
            lblValOccupiedBeds.TabIndex = 1;
            lblValOccupiedBeds.Text = "0";
            // 
            // pnlIconOccupiedBeds
            // 
            pnlIconOccupiedBeds.BackColor = Color.FromArgb(254, 243, 199);
            pnlIconOccupiedBeds.Controls.Add(lblIconOccupied);
            pnlIconOccupiedBeds.Location = new Point(314, 16);
            pnlIconOccupiedBeds.Name = "pnlIconOccupiedBeds";
            pnlIconOccupiedBeds.Size = new Size(42, 42);
            pnlIconOccupiedBeds.TabIndex = 2;
            // 
            // lblIconOccupied
            // 
            lblIconOccupied.Dock = DockStyle.Fill;
            lblIconOccupied.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIconOccupied.ForeColor = Color.FromArgb(245, 158, 11);
            lblIconOccupied.Location = new Point(0, 0);
            lblIconOccupied.Name = "lblIconOccupied";
            lblIconOccupied.Size = new Size(42, 42);
            lblIconOccupied.TabIndex = 0;
            lblIconOccupied.Text = "👥";
            lblIconOccupied.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardAvgRate
            // 
            cardAvgRate.BackColor = Color.White;
            cardAvgRate.BorderStyle = BorderStyle.FixedSingle;
            cardAvgRate.Controls.Add(lblTitleAvgRate);
            cardAvgRate.Controls.Add(lblValAvgRate);
            cardAvgRate.Controls.Add(pnlIconAvgRate);
            cardAvgRate.Location = new Point(1164, 8);
            cardAvgRate.Name = "cardAvgRate";
            cardAvgRate.Size = new Size(373, 76);
            cardAvgRate.TabIndex = 3;
            // 
            // lblTitleAvgRate
            // 
            lblTitleAvgRate.AutoSize = true;
            lblTitleAvgRate.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAvgRate.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleAvgRate.Location = new Point(14, 12);
            lblTitleAvgRate.Name = "lblTitleAvgRate";
            lblTitleAvgRate.Size = new Size(121, 12);
            lblTitleAvgRate.TabIndex = 0;
            lblTitleAvgRate.Text = "AVG. DAILY ROOM RATE";
            // 
            // lblValAvgRate
            // 
            lblValAvgRate.AutoSize = true;
            lblValAvgRate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAvgRate.ForeColor = Color.FromArgb(15, 23, 42);
            lblValAvgRate.Location = new Point(14, 30);
            lblValAvgRate.Name = "lblValAvgRate";
            lblValAvgRate.Size = new Size(43, 32);
            lblValAvgRate.TabIndex = 1;
            lblValAvgRate.Text = "₱0";
            // 
            // pnlIconAvgRate
            // 
            pnlIconAvgRate.BackColor = Color.FromArgb(250, 245, 255);
            pnlIconAvgRate.Controls.Add(lblIconPeso);
            pnlIconAvgRate.Location = new Point(315, 16);
            pnlIconAvgRate.Name = "pnlIconAvgRate";
            pnlIconAvgRate.Size = new Size(42, 42);
            pnlIconAvgRate.TabIndex = 2;
            // 
            // lblIconPeso
            // 
            lblIconPeso.Dock = DockStyle.Fill;
            lblIconPeso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconPeso.ForeColor = Color.FromArgb(168, 85, 247);
            lblIconPeso.Location = new Point(0, 0);
            lblIconPeso.Name = "lblIconPeso";
            lblIconPeso.Size = new Size(42, 42);
            lblIconPeso.TabIndex = 0;
            lblIconPeso.Text = "₱";
            lblIconPeso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxForm
            // 
            groupBoxForm.BackColor = Color.White;
            groupBoxForm.Controls.Add(lblBedId);
            groupBoxForm.Controls.Add(txtBedId);
            groupBoxForm.Controls.Add(lblRoomNumber);
            groupBoxForm.Controls.Add(txtRoomNumber);
            groupBoxForm.Controls.Add(lblBedNumber);
            groupBoxForm.Controls.Add(txtBedNumber);
            groupBoxForm.Controls.Add(lblRoomType);
            groupBoxForm.Controls.Add(cmbRoomType);
            groupBoxForm.Controls.Add(lblDailyRate);
            groupBoxForm.Controls.Add(txtDailyRate);
            groupBoxForm.Controls.Add(lblStatus);
            groupBoxForm.Controls.Add(cmbStatus);
            groupBoxForm.Controls.Add(btnAdd);
            groupBoxForm.Controls.Add(btnUpdate);
            groupBoxForm.Controls.Add(btnDelete);
            groupBoxForm.Controls.Add(btnClear);
            groupBoxForm.Controls.Add(btnRefresh);
            groupBoxForm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxForm.ForeColor = Color.FromArgb(15, 23, 42);
            groupBoxForm.Location = new Point(0, 86);
            groupBoxForm.Name = "groupBoxForm";
            groupBoxForm.Size = new Size(410, 462);
            groupBoxForm.TabIndex = 4;
            groupBoxForm.TabStop = false;
            groupBoxForm.Text = "Room && Bed Details";
            // 
            // lblBedId
            // 
            lblBedId.AutoSize = true;
            lblBedId.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBedId.ForeColor = Color.FromArgb(71, 85, 105);
            lblBedId.Location = new Point(16, 24);
            lblBedId.Name = "lblBedId";
            lblBedId.Size = new Size(45, 15);
            lblBedId.TabIndex = 0;
            lblBedId.Text = "Bed ID";
            // 
            // txtBedId
            // 
            txtBedId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBedId.Location = new Point(16, 42);
            txtBedId.Name = "txtBedId";
            txtBedId.Size = new Size(378, 24);
            txtBedId.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.ForeColor = Color.FromArgb(71, 85, 105);
            lblRoomNumber.Location = new Point(16, 74);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(88, 15);
            lblRoomNumber.TabIndex = 2;
            lblRoomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(16, 92);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(182, 24);
            txtRoomNumber.TabIndex = 3;
            // 
            // lblBedNumber
            // 
            lblBedNumber.AutoSize = true;
            lblBedNumber.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBedNumber.ForeColor = Color.FromArgb(71, 85, 105);
            lblBedNumber.Location = new Point(212, 74);
            lblBedNumber.Name = "lblBedNumber";
            lblBedNumber.Size = new Size(76, 15);
            lblBedNumber.TabIndex = 4;
            lblBedNumber.Text = "Bed Number";
            // 
            // txtBedNumber
            // 
            txtBedNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBedNumber.Location = new Point(212, 92);
            txtBedNumber.Name = "txtBedNumber";
            txtBedNumber.Size = new Size(182, 24);
            txtBedNumber.TabIndex = 5;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.ForeColor = Color.FromArgb(71, 85, 105);
            lblRoomType.Location = new Point(16, 124);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(69, 15);
            lblRoomType.TabIndex = 6;
            lblRoomType.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Ward", "Semi-Private", "Private", "ICU" });
            cmbRoomType.Location = new Point(16, 142);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(378, 24);
            cmbRoomType.TabIndex = 7;
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDailyRate.ForeColor = Color.FromArgb(71, 85, 105);
            lblDailyRate.Location = new Point(16, 174);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(85, 15);
            lblDailyRate.TabIndex = 8;
            lblDailyRate.Text = "Daily Rate (₱)";
            // 
            // txtDailyRate
            // 
            txtDailyRate.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailyRate.Location = new Point(16, 192);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(182, 24);
            txtDailyRate.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(71, 85, 105);
            lblStatus.Location = new Point(212, 174);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied" });
            cmbStatus.Location = new Point(212, 192);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 24);
            cmbStatus.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(37, 99, 235);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+ Add Bed / Room";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(51, 65, 85);
            btnUpdate.Location = new Point(212, 304);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 36);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Edit / Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(252, 165, 165);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(220, 38, 38);
            btnDelete.Location = new Point(16, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 36);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(212, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 36);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new Point(16, 396);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(378, 36);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "⟳  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(51, 65, 85);
            txtSearch.Location = new Point(426, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍  Search bed ID, room #, or room type...";
            txtSearch.Size = new Size(320, 24);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(754, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 26);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblShowingEntries
            // 
            lblShowingEntries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowingEntries.ForeColor = Color.FromArgb(100, 116, 139);
            lblShowingEntries.Location = new Point(1348, 92);
            lblShowingEntries.Name = "lblShowingEntries";
            lblShowingEntries.Size = new Size(189, 18);
            lblShowingEntries.TabIndex = 6;
            lblShowingEntries.Text = "Showing: 0 entries";
            lblShowingEntries.TextAlign = ContentAlignment.TopRight;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.FixedSingle;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeight = 40;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(241, 245, 249);
            dgvRooms.Location = new Point(426, 120);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 40;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1111, 428);
            dgvRooms.TabIndex = 7;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RnBManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(cardTotalBeds);
            Controls.Add(cardAvailableBeds);
            Controls.Add(cardOccupiedBeds);
            Controls.Add(cardAvgRate);
            Controls.Add(groupBoxForm);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblShowingEntries);
            Controls.Add(dgvRooms);
            Name = "RnBManagement";
            Size = new Size(1537, 558);
            cardTotalBeds.ResumeLayout(false);
            cardTotalBeds.PerformLayout();
            pnlIconTotalBeds.ResumeLayout(false);
            cardAvailableBeds.ResumeLayout(false);
            cardAvailableBeds.PerformLayout();
            pnlIconAvailBeds.ResumeLayout(false);
            cardOccupiedBeds.ResumeLayout(false);
            cardOccupiedBeds.PerformLayout();
            pnlIconOccupiedBeds.ResumeLayout(false);
            cardAvgRate.ResumeLayout(false);
            cardAvgRate.PerformLayout();
            pnlIconAvgRate.ResumeLayout(false);
            groupBoxForm.ResumeLayout(false);
            groupBoxForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel cardTotalBeds;
        private Label lblTitleTotalBeds;
        private Label lblValTotalBeds;
        private Panel pnlIconTotalBeds;
        private Label lblIconBed;
        private Panel cardAvailableBeds;
        private Label lblTitleAvailBeds;
        private Label lblValAvailBeds;
        private Panel pnlIconAvailBeds;
        private Label lblIconDoor;
        private Panel cardOccupiedBeds;
        private Label lblTitleOccupiedBeds;
        private Label lblValOccupiedBeds;
        private Panel pnlIconOccupiedBeds;
        private Label lblIconOccupied;
        private Panel cardAvgRate;
        private Label lblTitleAvgRate;
        private Label lblValAvgRate;
        private Panel pnlIconAvgRate;
        private Label lblIconPeso;
        private GroupBox groupBoxForm;
        private Label lblBedId;
        private TextBox txtBedId;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblBedNumber;
        private TextBox txtBedNumber;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblDailyRate;
        private TextBox txtDailyRate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblShowingEntries;
        private DataGridView dgvRooms;
        private ErrorProvider errorProvider1;
    }
}
