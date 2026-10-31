namespace Patient_Info_and_Billing_System.Admin
{
    partial class LabTestCatalog
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pnlIconAvgRate = new Panel();
            lblIconPeso = new Label();
            panelFilterBar = new Panel();
            txtSearch = new TextBox();
            lblFilterRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblFilterStatus = new Label();
            cmbStatus = new ComboBox();
            btnClearFilters = new Button();
            lblShowingEntries = new Label();
            cardAvgRate = new Panel();
            lblTitleAvgRate = new Label();
            lblValAvgRate = new Label();
            cardTotalBeds = new Panel();
            lblTitleTotalBeds = new Label();
            lblValTotalBeds = new Label();
            pnlIconTotalBeds = new Panel();
            lblIconBed = new Label();
            dgvRooms = new DataGridView();
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
            colRoomNo = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colBedId = new DataGridViewTextBoxColumn();
            colDailyRate = new DataGridViewTextBoxColumn();
            turnaround_time = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            pnlIconAvgRate.SuspendLayout();
            panelFilterBar.SuspendLayout();
            cardAvgRate.SuspendLayout();
            cardTotalBeds.SuspendLayout();
            pnlIconTotalBeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            cardAvailableBeds.SuspendLayout();
            pnlIconAvailBeds.SuspendLayout();
            cardOccupiedBeds.SuspendLayout();
            pnlIconOccupiedBeds.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIconAvgRate
            // 
            pnlIconAvgRate.BackColor = Color.FromArgb(250, 245, 255);
            pnlIconAvgRate.Controls.Add(lblIconPeso);
            pnlIconAvgRate.Location = new Point(266, 13);
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
            // panelFilterBar
            // 
            panelFilterBar.Controls.Add(txtSearch);
            panelFilterBar.Controls.Add(lblFilterRoomType);
            panelFilterBar.Controls.Add(cmbRoomType);
            panelFilterBar.Controls.Add(lblFilterStatus);
            panelFilterBar.Controls.Add(cmbStatus);
            panelFilterBar.Controls.Add(btnClearFilters);
            panelFilterBar.Controls.Add(lblShowingEntries);
            panelFilterBar.Location = new Point(0, 84);
            panelFilterBar.Name = "panelFilterBar";
            panelFilterBar.Size = new Size(1339, 32);
            panelFilterBar.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(51, 65, 85);
            txtSearch.Location = new Point(0, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍  Search room, code, name...";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblFilterRoomType
            // 
            lblFilterRoomType.AutoSize = true;
            lblFilterRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterRoomType.ForeColor = Color.FromArgb(71, 85, 105);
            lblFilterRoomType.Location = new Point(265, 6);
            lblFilterRoomType.Name = "lblFilterRoomType";
            lblFilterRoomType.Size = new Size(79, 15);
            lblFilterRoomType.TabIndex = 1;
            lblFilterRoomType.Text = "Department:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.BackColor = Color.White;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "ALL", "Pediatric ICU (PICU)", "Pediatric Ward", "Isolation Unit", "Private Deluxe Suite", "Neonatal ICU (NICU)" });
            cmbRoomType.Location = new Point(345, 3);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(115, 23);
            cmbRoomType.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterStatus.ForeColor = Color.FromArgb(71, 85, 105);
            lblFilterStatus.Location = new Point(475, 6);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(45, 15);
            lblFilterStatus.TabIndex = 3;
            lblFilterStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "ALL", "Available", "Occupied", "Cleaning" });
            cmbStatus.Location = new Point(528, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(100, 23);
            cmbStatus.TabIndex = 4;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.Transparent;
            btnClearFilters.Cursor = Cursors.Hand;
            btnClearFilters.FlatAppearance.BorderSize = 0;
            btnClearFilters.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClearFilters.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilters.ForeColor = Color.FromArgb(100, 116, 139);
            btnClearFilters.Location = new Point(638, 2);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(70, 25);
            btnClearFilters.TabIndex = 5;
            btnClearFilters.Text = "↺ Clear";
            btnClearFilters.UseVisualStyleBackColor = false;
            // 
            // lblShowingEntries
            // 
            lblShowingEntries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowingEntries.ForeColor = Color.FromArgb(100, 116, 139);
            lblShowingEntries.Location = new Point(1190, 6);
            lblShowingEntries.Name = "lblShowingEntries";
            lblShowingEntries.Size = new Size(149, 18);
            lblShowingEntries.TabIndex = 6;
            lblShowingEntries.Text = "Showing: 0 entries";
            lblShowingEntries.TextAlign = ContentAlignment.TopRight;
            // 
            // cardAvgRate
            // 
            cardAvgRate.BackColor = Color.White;
            cardAvgRate.BorderStyle = BorderStyle.FixedSingle;
            cardAvgRate.Controls.Add(lblTitleAvgRate);
            cardAvgRate.Controls.Add(lblValAvgRate);
            cardAvgRate.Controls.Add(pnlIconAvgRate);
            cardAvgRate.Location = new Point(984, 8);
            cardAvgRate.Name = "cardAvgRate";
            cardAvgRate.Size = new Size(322, 70);
            cardAvgRate.TabIndex = 17;
            // 
            // lblTitleAvgRate
            // 
            lblTitleAvgRate.AutoSize = true;
            lblTitleAvgRate.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAvgRate.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleAvgRate.Location = new Point(12, 10);
            lblTitleAvgRate.Name = "lblTitleAvgRate";
            lblTitleAvgRate.Size = new Size(110, 12);
            lblTitleAvgRate.TabIndex = 0;
            lblTitleAvgRate.Text = "AVERAGE TEST TARIFF";
            // 
            // lblValAvgRate
            // 
            lblValAvgRate.AutoSize = true;
            lblValAvgRate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAvgRate.ForeColor = Color.FromArgb(15, 23, 42);
            lblValAvgRate.Location = new Point(12, 26);
            lblValAvgRate.Name = "lblValAvgRate";
            lblValAvgRate.Size = new Size(43, 32);
            lblValAvgRate.TabIndex = 1;
            lblValAvgRate.Text = "₱0";
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
            cardTotalBeds.Size = new Size(322, 70);
            cardTotalBeds.TabIndex = 14;
            // 
            // lblTitleTotalBeds
            // 
            lblTitleTotalBeds.AutoSize = true;
            lblTitleTotalBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleTotalBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleTotalBeds.Location = new Point(12, 10);
            lblTitleTotalBeds.Name = "lblTitleTotalBeds";
            lblTitleTotalBeds.Size = new Size(114, 12);
            lblTitleTotalBeds.TabIndex = 0;
            lblTitleTotalBeds.Text = "CATALOGED LAB TESTS";
            lblTitleTotalBeds.Click += lblTitleTotalBeds_Click;
            // 
            // lblValTotalBeds
            // 
            lblValTotalBeds.AutoSize = true;
            lblValTotalBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValTotalBeds.ForeColor = Color.FromArgb(15, 23, 42);
            lblValTotalBeds.Location = new Point(12, 26);
            lblValTotalBeds.Name = "lblValTotalBeds";
            lblValTotalBeds.Size = new Size(28, 32);
            lblValTotalBeds.TabIndex = 1;
            lblValTotalBeds.Text = "0";
            // 
            // pnlIconTotalBeds
            // 
            pnlIconTotalBeds.BackColor = Color.FromArgb(239, 246, 255);
            pnlIconTotalBeds.Controls.Add(lblIconBed);
            pnlIconTotalBeds.Location = new Point(266, 13);
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
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.ColumnHeadersHeight = 36;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomNo, colRoomType, colBedId, colDailyRate, turnaround_time, colStatus, colActions });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle8.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle8;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(241, 245, 249);
            dgvRooms.Location = new Point(0, 108);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.RowTemplate.Height = 42;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1339, 355);
            dgvRooms.TabIndex = 19;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // cardAvailableBeds
            // 
            cardAvailableBeds.BackColor = Color.White;
            cardAvailableBeds.BorderStyle = BorderStyle.FixedSingle;
            cardAvailableBeds.Controls.Add(lblTitleAvailBeds);
            cardAvailableBeds.Controls.Add(lblValAvailBeds);
            cardAvailableBeds.Controls.Add(pnlIconAvailBeds);
            cardAvailableBeds.Location = new Point(328, 7);
            cardAvailableBeds.Name = "cardAvailableBeds";
            cardAvailableBeds.Size = new Size(322, 70);
            cardAvailableBeds.TabIndex = 15;
            // 
            // lblTitleAvailBeds
            // 
            lblTitleAvailBeds.AutoSize = true;
            lblTitleAvailBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblTitleAvailBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleAvailBeds.Location = new Point(12, 10);
            lblTitleAvailBeds.Name = "lblTitleAvailBeds";
            lblTitleAvailBeds.Size = new Size(104, 12);
            lblTitleAvailBeds.TabIndex = 0;
            lblTitleAvailBeds.Text = "ACTIVE TEST PANELS";
            // 
            // lblValAvailBeds
            // 
            lblValAvailBeds.AutoSize = true;
            lblValAvailBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAvailBeds.ForeColor = Color.FromArgb(16, 185, 129);
            lblValAvailBeds.Location = new Point(12, 26);
            lblValAvailBeds.Name = "lblValAvailBeds";
            lblValAvailBeds.Size = new Size(28, 32);
            lblValAvailBeds.TabIndex = 1;
            lblValAvailBeds.Text = "0";
            // 
            // pnlIconAvailBeds
            // 
            pnlIconAvailBeds.BackColor = Color.FromArgb(236, 253, 245);
            pnlIconAvailBeds.Controls.Add(lblIconDoor);
            pnlIconAvailBeds.Location = new Point(266, 13);
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
            cardOccupiedBeds.Location = new Point(656, 7);
            cardOccupiedBeds.Name = "cardOccupiedBeds";
            cardOccupiedBeds.Size = new Size(322, 70);
            cardOccupiedBeds.TabIndex = 16;
            // 
            // lblTitleOccupiedBeds
            // 
            lblTitleOccupiedBeds.AutoSize = true;
            lblTitleOccupiedBeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOccupiedBeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleOccupiedBeds.Location = new Point(12, 10);
            lblTitleOccupiedBeds.Name = "lblTitleOccupiedBeds";
            lblTitleOccupiedBeds.Size = new Size(152, 12);
            lblTitleOccupiedBeds.TabIndex = 0;
            lblTitleOccupiedBeds.Text = "AVERAGE TURNAROUND (TAT)";
            // 
            // lblValOccupiedBeds
            // 
            lblValOccupiedBeds.AutoSize = true;
            lblValOccupiedBeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValOccupiedBeds.ForeColor = Color.FromArgb(245, 158, 11);
            lblValOccupiedBeds.Location = new Point(12, 26);
            lblValOccupiedBeds.Name = "lblValOccupiedBeds";
            lblValOccupiedBeds.Size = new Size(28, 32);
            lblValOccupiedBeds.TabIndex = 1;
            lblValOccupiedBeds.Text = "0";
            // 
            // pnlIconOccupiedBeds
            // 
            pnlIconOccupiedBeds.BackColor = Color.FromArgb(254, 243, 199);
            pnlIconOccupiedBeds.Controls.Add(lblIconOccupied);
            pnlIconOccupiedBeds.Location = new Point(266, 13);
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
            // colRoomNo
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42);
            colRoomNo.DefaultCellStyle = dataGridViewCellStyle2;
            colRoomNo.HeaderText = "TEST CODE";
            colRoomNo.MinimumWidth = 6;
            colRoomNo.Name = "colRoomNo";
            colRoomNo.ReadOnly = true;
            colRoomNo.Width = 175;
            // 
            // colRoomType
            // 
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 65, 85);
            colRoomType.DefaultCellStyle = dataGridViewCellStyle3;
            colRoomType.HeaderText = "LABORATORY TEST NAME";
            colRoomType.MinimumWidth = 6;
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            colRoomType.Width = 350;
            // 
            // colBedId
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(37, 99, 235);
            colBedId.DefaultCellStyle = dataGridViewCellStyle4;
            colBedId.HeaderText = "CATEGORY";
            colBedId.MinimumWidth = 6;
            colBedId.Name = "colBedId";
            colBedId.ReadOnly = true;
            colBedId.Width = 230;
            // 
            // colDailyRate
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(15, 23, 42);
            colDailyRate.DefaultCellStyle = dataGridViewCellStyle5;
            colDailyRate.HeaderText = "PRICE (₱)";
            colDailyRate.MinimumWidth = 6;
            colDailyRate.Name = "colDailyRate";
            colDailyRate.ReadOnly = true;
            colDailyRate.Width = 140;
            // 
            // turnaround_time
            // 
            turnaround_time.HeaderText = "TURNAROUND TIME";
            turnaround_time.Name = "turnaround_time";
            turnaround_time.ReadOnly = true;
            turnaround_time.Width = 200;
            // 
            // colStatus
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colStatus.DefaultCellStyle = dataGridViewCellStyle6;
            colStatus.HeaderText = "CURRENT STATUS";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 150;
            // 
            // colActions
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(100, 116, 139);
            colActions.DefaultCellStyle = dataGridViewCellStyle7;
            colActions.HeaderText = "ACTIONS";
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Width = 93;
            // 
            // LabTestCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelFilterBar);
            Controls.Add(cardAvgRate);
            Controls.Add(cardTotalBeds);
            Controls.Add(dgvRooms);
            Controls.Add(cardAvailableBeds);
            Controls.Add(cardOccupiedBeds);
            Name = "LabTestCatalog";
            Size = new Size(1339, 479);
            pnlIconAvgRate.ResumeLayout(false);
            panelFilterBar.ResumeLayout(false);
            panelFilterBar.PerformLayout();
            cardAvgRate.ResumeLayout(false);
            cardAvgRate.PerformLayout();
            cardTotalBeds.ResumeLayout(false);
            cardTotalBeds.PerformLayout();
            pnlIconTotalBeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            cardAvailableBeds.ResumeLayout(false);
            cardAvailableBeds.PerformLayout();
            pnlIconAvailBeds.ResumeLayout(false);
            cardOccupiedBeds.ResumeLayout(false);
            cardOccupiedBeds.PerformLayout();
            pnlIconOccupiedBeds.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIconAvgRate;
        private Label lblIconPeso;
        private Panel panelFilterBar;
        private TextBox txtSearch;
        private Label lblFilterRoomType;
        private ComboBox cmbRoomType;
        private Label lblFilterStatus;
        private ComboBox cmbStatus;
        private Button btnClearFilters;
        private Label lblShowingEntries;
        private Panel cardAvgRate;
        private Label lblTitleAvgRate;
        private Label lblValAvgRate;
        private Panel cardTotalBeds;
        private Label lblTitleTotalBeds;
        private Label lblValTotalBeds;
        private Panel pnlIconTotalBeds;
        private Label lblIconBed;
        private DataGridView dgvRooms;
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
        private DataGridViewTextBoxColumn colRoomNo;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colBedId;
        private DataGridViewTextBoxColumn colDailyRate;
        private DataGridViewTextBoxColumn turnaround_time;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colActions;
    }
}
