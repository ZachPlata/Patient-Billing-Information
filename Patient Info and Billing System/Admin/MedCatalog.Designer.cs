namespace Patient_Info_and_Billing_System.Admin
{
    partial class MedCatalog
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            cardCatalogedMeds = new Panel();
            lblTitleCatalogedMeds = new Label();
            lblValCatalogedMeds = new Label();
            pnlIconCatalogedMeds = new Panel();
            lblIconMeds = new Label();
            cardActiveFormulary = new Panel();
            lblTitleActiveFormulary = new Label();
            lblValActiveFormulary = new Label();
            pnlIconActiveFormulary = new Panel();
            lblIconActiveFormulary = new Label();
            cardOralLiquids = new Panel();
            lblTitleOralLiquids = new Label();
            lblValOralLiquids = new Label();
            pnlIconOralLiquids = new Panel();
            lblIconOralLiquids = new Label();
            cardAvgUnitPrice = new Panel();
            lblTitleAvgUnitPrice = new Label();
            lblValAvgUnitPrice = new Label();
            pnlIconAvgUnitPrice = new Panel();
            lblIconAvgUnitPrice = new Label();
            panelFilterBar = new Panel();
            txtSearch = new TextBox();
            lblFilterPackaging = new Label();
            cmbPackagingUnit = new ComboBox();
            lblFilterStatus = new Label();
            cmbStatus = new ComboBox();
            btnClearFilters = new Button();
            lblShowingEntries = new Label();
            dgvMedicines = new DataGridView();
            colDrugCode = new DataGridViewTextBoxColumn();
            colBrandName = new DataGridViewTextBoxColumn();
            colGenericName = new DataGridViewTextBoxColumn();
            colDosageStrength = new DataGridViewTextBoxColumn();
            colPackagingUnit = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            cardCatalogedMeds.SuspendLayout();
            pnlIconCatalogedMeds.SuspendLayout();
            cardActiveFormulary.SuspendLayout();
            pnlIconActiveFormulary.SuspendLayout();
            cardOralLiquids.SuspendLayout();
            pnlIconOralLiquids.SuspendLayout();
            cardAvgUnitPrice.SuspendLayout();
            pnlIconAvgUnitPrice.SuspendLayout();
            panelFilterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // cardCatalogedMeds
            // 
            cardCatalogedMeds.BackColor = Color.White;
            cardCatalogedMeds.BorderStyle = BorderStyle.FixedSingle;
            cardCatalogedMeds.Controls.Add(lblTitleCatalogedMeds);
            cardCatalogedMeds.Controls.Add(lblValCatalogedMeds);
            cardCatalogedMeds.Controls.Add(pnlIconCatalogedMeds);
            cardCatalogedMeds.Location = new Point(0, 8);
            cardCatalogedMeds.Name = "cardCatalogedMeds";
            cardCatalogedMeds.Size = new Size(322, 70);
            cardCatalogedMeds.TabIndex = 0;
            // 
            // lblTitleCatalogedMeds
            // 
            lblTitleCatalogedMeds.AutoSize = true;
            lblTitleCatalogedMeds.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCatalogedMeds.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleCatalogedMeds.Location = new Point(12, 10);
            lblTitleCatalogedMeds.Name = "lblTitleCatalogedMeds";
            lblTitleCatalogedMeds.Size = new Size(117, 12);
            lblTitleCatalogedMeds.TabIndex = 0;
            lblTitleCatalogedMeds.Text = "CATALOGED MEDICINES";
            // 
            // lblValCatalogedMeds
            // 
            lblValCatalogedMeds.AutoSize = true;
            lblValCatalogedMeds.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValCatalogedMeds.ForeColor = Color.FromArgb(15, 23, 42);
            lblValCatalogedMeds.Location = new Point(12, 26);
            lblValCatalogedMeds.Name = "lblValCatalogedMeds";
            lblValCatalogedMeds.Size = new Size(28, 32);
            lblValCatalogedMeds.TabIndex = 1;
            lblValCatalogedMeds.Text = "0";
            // 
            // pnlIconCatalogedMeds
            // 
            pnlIconCatalogedMeds.BackColor = Color.FromArgb(239, 246, 255);
            pnlIconCatalogedMeds.Controls.Add(lblIconMeds);
            pnlIconCatalogedMeds.Location = new Point(266, 13);
            pnlIconCatalogedMeds.Name = "pnlIconCatalogedMeds";
            pnlIconCatalogedMeds.Size = new Size(42, 42);
            pnlIconCatalogedMeds.TabIndex = 2;
            // 
            // lblIconMeds
            // 
            lblIconMeds.Dock = DockStyle.Fill;
            lblIconMeds.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIconMeds.ForeColor = Color.FromArgb(37, 99, 235);
            lblIconMeds.Location = new Point(0, 0);
            lblIconMeds.Name = "lblIconMeds";
            lblIconMeds.Size = new Size(42, 42);
            lblIconMeds.TabIndex = 0;
            lblIconMeds.Text = "💊";
            lblIconMeds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardActiveFormulary
            // 
            cardActiveFormulary.BackColor = Color.White;
            cardActiveFormulary.BorderStyle = BorderStyle.FixedSingle;
            cardActiveFormulary.Controls.Add(lblTitleActiveFormulary);
            cardActiveFormulary.Controls.Add(lblValActiveFormulary);
            cardActiveFormulary.Controls.Add(pnlIconActiveFormulary);
            cardActiveFormulary.Location = new Point(339, 8);
            cardActiveFormulary.Name = "cardActiveFormulary";
            cardActiveFormulary.Size = new Size(322, 70);
            cardActiveFormulary.TabIndex = 1;
            // 
            // lblTitleActiveFormulary
            // 
            lblTitleActiveFormulary.AutoSize = true;
            lblTitleActiveFormulary.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleActiveFormulary.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleActiveFormulary.Location = new Point(12, 10);
            lblTitleActiveFormulary.Name = "lblTitleActiveFormulary";
            lblTitleActiveFormulary.Size = new Size(134, 12);
            lblTitleActiveFormulary.TabIndex = 0;
            lblTitleActiveFormulary.Text = "ACTIVE FORMULARY LINES";
            // 
            // lblValActiveFormulary
            // 
            lblValActiveFormulary.AutoSize = true;
            lblValActiveFormulary.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValActiveFormulary.ForeColor = Color.FromArgb(16, 185, 129);
            lblValActiveFormulary.Location = new Point(12, 26);
            lblValActiveFormulary.Name = "lblValActiveFormulary";
            lblValActiveFormulary.Size = new Size(28, 32);
            lblValActiveFormulary.TabIndex = 1;
            lblValActiveFormulary.Text = "0";
            // 
            // pnlIconActiveFormulary
            // 
            pnlIconActiveFormulary.BackColor = Color.FromArgb(236, 253, 245);
            pnlIconActiveFormulary.Controls.Add(lblIconActiveFormulary);
            pnlIconActiveFormulary.Location = new Point(266, 13);
            pnlIconActiveFormulary.Name = "pnlIconActiveFormulary";
            pnlIconActiveFormulary.Size = new Size(42, 42);
            pnlIconActiveFormulary.TabIndex = 2;
            // 
            // lblIconActiveFormulary
            // 
            lblIconActiveFormulary.Dock = DockStyle.Fill;
            lblIconActiveFormulary.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconActiveFormulary.ForeColor = Color.FromArgb(16, 185, 129);
            lblIconActiveFormulary.Location = new Point(0, 0);
            lblIconActiveFormulary.Name = "lblIconActiveFormulary";
            lblIconActiveFormulary.Size = new Size(42, 42);
            lblIconActiveFormulary.TabIndex = 0;
            lblIconActiveFormulary.Text = "✔";
            lblIconActiveFormulary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardOralLiquids
            // 
            cardOralLiquids.BackColor = Color.White;
            cardOralLiquids.BorderStyle = BorderStyle.FixedSingle;
            cardOralLiquids.Controls.Add(lblTitleOralLiquids);
            cardOralLiquids.Controls.Add(lblValOralLiquids);
            cardOralLiquids.Controls.Add(pnlIconOralLiquids);
            cardOralLiquids.Location = new Point(678, 8);
            cardOralLiquids.Name = "cardOralLiquids";
            cardOralLiquids.Size = new Size(322, 70);
            cardOralLiquids.TabIndex = 2;
            // 
            // lblTitleOralLiquids
            // 
            lblTitleOralLiquids.AutoSize = true;
            lblTitleOralLiquids.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOralLiquids.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleOralLiquids.Location = new Point(12, 10);
            lblTitleOralLiquids.Name = "lblTitleOralLiquids";
            lblTitleOralLiquids.Size = new Size(153, 12);
            lblTitleOralLiquids.TabIndex = 0;
            lblTitleOralLiquids.Text = "ORAL LIQUIDS / SUSPENSIONS";
            // 
            // lblValOralLiquids
            // 
            lblValOralLiquids.AutoSize = true;
            lblValOralLiquids.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValOralLiquids.ForeColor = Color.FromArgb(79, 70, 229);
            lblValOralLiquids.Location = new Point(12, 26);
            lblValOralLiquids.Name = "lblValOralLiquids";
            lblValOralLiquids.Size = new Size(28, 32);
            lblValOralLiquids.TabIndex = 1;
            lblValOralLiquids.Text = "0";
            // 
            // pnlIconOralLiquids
            // 
            pnlIconOralLiquids.BackColor = Color.FromArgb(238, 242, 255);
            pnlIconOralLiquids.Controls.Add(lblIconOralLiquids);
            pnlIconOralLiquids.Location = new Point(266, 13);
            pnlIconOralLiquids.Name = "pnlIconOralLiquids";
            pnlIconOralLiquids.Size = new Size(42, 42);
            pnlIconOralLiquids.TabIndex = 2;
            // 
            // lblIconOralLiquids
            // 
            lblIconOralLiquids.Dock = DockStyle.Fill;
            lblIconOralLiquids.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIconOralLiquids.ForeColor = Color.FromArgb(99, 102, 241);
            lblIconOralLiquids.Location = new Point(0, 0);
            lblIconOralLiquids.Name = "lblIconOralLiquids";
            lblIconOralLiquids.Size = new Size(42, 42);
            lblIconOralLiquids.TabIndex = 0;
            lblIconOralLiquids.Text = "🍶";
            lblIconOralLiquids.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardAvgUnitPrice
            // 
            cardAvgUnitPrice.BackColor = Color.White;
            cardAvgUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            cardAvgUnitPrice.Controls.Add(lblTitleAvgUnitPrice);
            cardAvgUnitPrice.Controls.Add(lblValAvgUnitPrice);
            cardAvgUnitPrice.Controls.Add(pnlIconAvgUnitPrice);
            cardAvgUnitPrice.Location = new Point(1017, 8);
            cardAvgUnitPrice.Name = "cardAvgUnitPrice";
            cardAvgUnitPrice.Size = new Size(322, 70);
            cardAvgUnitPrice.TabIndex = 3;
            // 
            // lblTitleAvgUnitPrice
            // 
            lblTitleAvgUnitPrice.AutoSize = true;
            lblTitleAvgUnitPrice.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAvgUnitPrice.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleAvgUnitPrice.Location = new Point(12, 10);
            lblTitleAvgUnitPrice.Name = "lblTitleAvgUnitPrice";
            lblTitleAvgUnitPrice.Size = new Size(136, 12);
            lblTitleAvgUnitPrice.TabIndex = 0;
            lblTitleAvgUnitPrice.Text = "AVERAGE UNIT PRICE (SRP)";
            // 
            // lblValAvgUnitPrice
            // 
            lblValAvgUnitPrice.AutoSize = true;
            lblValAvgUnitPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValAvgUnitPrice.ForeColor = Color.FromArgb(15, 23, 42);
            lblValAvgUnitPrice.Location = new Point(12, 26);
            lblValAvgUnitPrice.Name = "lblValAvgUnitPrice";
            lblValAvgUnitPrice.Size = new Size(50, 32);
            lblValAvgUnitPrice.TabIndex = 1;
            lblValAvgUnitPrice.Text = "₱ 0";
            // 
            // pnlIconAvgUnitPrice
            // 
            pnlIconAvgUnitPrice.BackColor = Color.FromArgb(250, 245, 255);
            pnlIconAvgUnitPrice.Controls.Add(lblIconAvgUnitPrice);
            pnlIconAvgUnitPrice.Location = new Point(266, 13);
            pnlIconAvgUnitPrice.Name = "pnlIconAvgUnitPrice";
            pnlIconAvgUnitPrice.Size = new Size(42, 42);
            pnlIconAvgUnitPrice.TabIndex = 2;
            // 
            // lblIconAvgUnitPrice
            // 
            lblIconAvgUnitPrice.Dock = DockStyle.Fill;
            lblIconAvgUnitPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconAvgUnitPrice.ForeColor = Color.FromArgb(71, 85, 105);
            lblIconAvgUnitPrice.Location = new Point(0, 0);
            lblIconAvgUnitPrice.Name = "lblIconAvgUnitPrice";
            lblIconAvgUnitPrice.Size = new Size(42, 42);
            lblIconAvgUnitPrice.TabIndex = 0;
            lblIconAvgUnitPrice.Text = "🏷";
            lblIconAvgUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFilterBar
            // 
            panelFilterBar.Controls.Add(txtSearch);
            panelFilterBar.Controls.Add(lblFilterPackaging);
            panelFilterBar.Controls.Add(cmbPackagingUnit);
            panelFilterBar.Controls.Add(lblFilterStatus);
            panelFilterBar.Controls.Add(cmbStatus);
            panelFilterBar.Controls.Add(btnClearFilters);
            panelFilterBar.Controls.Add(lblShowingEntries);
            panelFilterBar.Location = new Point(0, 84);
            panelFilterBar.Name = "panelFilterBar";
            panelFilterBar.Size = new Size(1339, 32);
            panelFilterBar.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(51, 65, 85);
            txtSearch.Location = new Point(0, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍  Search brand, generic, or drug code...";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblFilterPackaging
            // 
            lblFilterPackaging.AutoSize = true;
            lblFilterPackaging.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterPackaging.ForeColor = Color.FromArgb(71, 85, 105);
            lblFilterPackaging.Location = new Point(265, 6);
            lblFilterPackaging.Name = "lblFilterPackaging";
            lblFilterPackaging.Size = new Size(93, 15);
            lblFilterPackaging.TabIndex = 1;
            lblFilterPackaging.Text = "Packaging Unit:";
            // 
            // cmbPackagingUnit
            // 
            cmbPackagingUnit.BackColor = Color.White;
            cmbPackagingUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPackagingUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPackagingUnit.FormattingEnabled = true;
            cmbPackagingUnit.Items.AddRange(new object[] { "ALL", "Per Bottle", "Per Nebule", "Per Sachet", "Per Vial", "Per Blister Pack", "Per Box" });
            cmbPackagingUnit.Location = new Point(365, 3);
            cmbPackagingUnit.Name = "cmbPackagingUnit";
            cmbPackagingUnit.Size = new Size(120, 23);
            cmbPackagingUnit.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterStatus.ForeColor = Color.FromArgb(71, 85, 105);
            lblFilterStatus.Location = new Point(495, 6);
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
            cmbStatus.Items.AddRange(new object[] { "ALL", "Active", "Inactive" });
            cmbStatus.Location = new Point(545, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(95, 23);
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
            btnClearFilters.Location = new Point(650, 2);
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
            lblShowingEntries.Location = new Point(1150, 6);
            lblShowingEntries.Name = "lblShowingEntries";
            lblShowingEntries.Size = new Size(189, 18);
            lblShowingEntries.TabIndex = 6;
            lblShowingEntries.Text = "Showing 0 entries";
            lblShowingEntries.TextAlign = ContentAlignment.TopRight;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.AllowUserToDeleteRows = false;
            dgvMedicines.AllowUserToResizeRows = false;
            dgvMedicines.BackgroundColor = Color.White;
            dgvMedicines.BorderStyle = BorderStyle.None;
            dgvMedicines.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMedicines.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicines.ColumnHeadersHeight = 36;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMedicines.Columns.AddRange(new DataGridViewColumn[] { colDrugCode, colBrandName, colGenericName, colDosageStrength, colPackagingUnit, colUnitPrice, colStatus, colActions });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle9.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvMedicines.DefaultCellStyle = dataGridViewCellStyle9;
            dgvMedicines.EnableHeadersVisualStyles = false;
            dgvMedicines.GridColor = Color.FromArgb(241, 245, 249);
            dgvMedicines.Location = new Point(0, 122);
            dgvMedicines.MultiSelect = false;
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersVisible = false;
            dgvMedicines.RowHeadersWidth = 51;
            dgvMedicines.RowTemplate.Height = 42;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new Size(1339, 350);
            dgvMedicines.TabIndex = 5;
            // 
            // colDrugCode
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(37, 99, 235);
            colDrugCode.DefaultCellStyle = dataGridViewCellStyle2;
            colDrugCode.HeaderText = "DRUG CODE";
            colDrugCode.MinimumWidth = 6;
            colDrugCode.Name = "colDrugCode";
            colDrugCode.ReadOnly = true;
            colDrugCode.Width = 110;
            // 
            // colBrandName
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            colBrandName.DefaultCellStyle = dataGridViewCellStyle3;
            colBrandName.HeaderText = "BRAND NAME";
            colBrandName.MinimumWidth = 6;
            colBrandName.Name = "colBrandName";
            colBrandName.ReadOnly = true;
            colBrandName.Width = 190;
            // 
            // colGenericName
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 85, 105);
            colGenericName.DefaultCellStyle = dataGridViewCellStyle4;
            colGenericName.HeaderText = "GENERIC NAME";
            colGenericName.MinimumWidth = 6;
            colGenericName.Name = "colGenericName";
            colGenericName.ReadOnly = true;
            colGenericName.Width = 220;
            // 
            // colDosageStrength
            // 
            colDosageStrength.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 85, 105);
            colDosageStrength.DefaultCellStyle = dataGridViewCellStyle5;
            colDosageStrength.HeaderText = "DOSAGE UNIT / STRENGTH";
            colDosageStrength.MinimumWidth = 6;
            colDosageStrength.Name = "colDosageStrength";
            colDosageStrength.ReadOnly = true;
            // 
            // colPackagingUnit
            // 
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(51, 65, 85);
            colPackagingUnit.DefaultCellStyle = dataGridViewCellStyle6;
            colPackagingUnit.HeaderText = "PACKAGING / DISPENSING UNIT";
            colPackagingUnit.MinimumWidth = 6;
            colPackagingUnit.Name = "colPackagingUnit";
            colPackagingUnit.ReadOnly = true;
            colPackagingUnit.Width = 210;
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(15, 23, 42);
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle7;
            colUnitPrice.HeaderText = "UNIT PRICE (₱)";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colUnitPrice.Width = 130;
            // 
            // colStatus
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colStatus.DefaultCellStyle = dataGridViewCellStyle8;
            colStatus.HeaderText = "STATUS";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 95;
            // 
            // colActions
            // 
            colActions.HeaderText = "ACTIONS";
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Width = 80;
            // 
            // MedCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelFilterBar);
            Controls.Add(cardAvgUnitPrice);
            Controls.Add(cardCatalogedMeds);
            Controls.Add(dgvMedicines);
            Controls.Add(cardActiveFormulary);
            Controls.Add(cardOralLiquids);
            Name = "MedCatalog";
            Size = new Size(1339, 479);
            cardCatalogedMeds.ResumeLayout(false);
            cardCatalogedMeds.PerformLayout();
            pnlIconCatalogedMeds.ResumeLayout(false);
            cardActiveFormulary.ResumeLayout(false);
            cardActiveFormulary.PerformLayout();
            pnlIconActiveFormulary.ResumeLayout(false);
            cardOralLiquids.ResumeLayout(false);
            cardOralLiquids.PerformLayout();
            pnlIconOralLiquids.ResumeLayout(false);
            cardAvgUnitPrice.ResumeLayout(false);
            cardAvgUnitPrice.PerformLayout();
            pnlIconAvgUnitPrice.ResumeLayout(false);
            panelFilterBar.ResumeLayout(false);
            panelFilterBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cardCatalogedMeds;
        private Label lblTitleCatalogedMeds;
        private Label lblValCatalogedMeds;
        private Panel pnlIconCatalogedMeds;
        private Label lblIconMeds;
        private Panel cardActiveFormulary;
        private Label lblTitleActiveFormulary;
        private Label lblValActiveFormulary;
        private Panel pnlIconActiveFormulary;
        private Label lblIconActiveFormulary;
        private Panel cardOralLiquids;
        private Label lblTitleOralLiquids;
        private Label lblValOralLiquids;
        private Panel pnlIconOralLiquids;
        private Label lblIconOralLiquids;
        private Panel cardAvgUnitPrice;
        private Label lblTitleAvgUnitPrice;
        private Label lblValAvgUnitPrice;
        private Panel pnlIconAvgUnitPrice;
        private Label lblIconAvgUnitPrice;
        private Panel panelFilterBar;
        private TextBox txtSearch;
        private Label lblFilterPackaging;
        private ComboBox cmbPackagingUnit;
        private Label lblFilterStatus;
        private ComboBox cmbStatus;
        private Button btnClearFilters;
        private Label lblShowingEntries;
        private DataGridView dgvMedicines;
        private DataGridViewTextBoxColumn colDrugCode;
        private DataGridViewTextBoxColumn colBrandName;
        private DataGridViewTextBoxColumn colGenericName;
        private DataGridViewTextBoxColumn colDosageStrength;
        private DataGridViewTextBoxColumn colPackagingUnit;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colActions;
    }
}
