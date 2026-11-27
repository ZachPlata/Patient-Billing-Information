using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class admin_dashboard : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root; pwd=;";
        bool isProcessingPayment = false;

        public admin_dashboard()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;

            Column1.DataPropertyName = "bill_id";
            Column2.DataPropertyName = "patient_id";
            Column3.DataPropertyName = "full_name";
            Column4.DataPropertyName = "admission_date";
            Column5.DataPropertyName = "discharge_date";
            Column6.DataPropertyName = "billing_status";
            Column7.DataPropertyName = "total_amount";
            Column8.DataPropertyName = "due_date";
            Column9.DataPropertyName = "remaining_balance";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Unpaid");
            comboBox1.Items.Add("Partial");
            comboBox1.Items.Add("Paid");
            comboBox1.Items.Add("Cancelled");
            comboBox1.SelectedIndex = 0;

            this.Load += admin_dashboard_Load;
            textBox1.TextChanged += textBox1_TextChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button5.Click += button5_Click;
        }

        void NavigateToControl(UserControl nextControl)
        {
            Control? container = this.Parent;
            if (container != null)
            {
                container.Controls.Clear();
                nextControl.Dock = DockStyle.Fill;
                container.Controls.Add(nextControl);
                nextControl.Show();
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            NavigateToControl(new borja1());
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            NavigateToControl(new AdminUserManagement());
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            NavigateToControl(new ClinicAndDataSetup());
        }

        private void admin_dashboard_Load(object? sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                string searchKeyword = textBox1.Text.Trim();
                string selectedStatus = comboBox1.SelectedItem?.ToString() ?? "All";

                string query = "SELECT b.bill_id, b.patient_id, p.full_name, " +
                    "a.admission_date, a.discharge_date, b.billing_status, " +
                    "b.total_amount, b.due_date, b.remaining_balance " +
                    "FROM BillingRecords b " +
                    "INNER JOIN Patients p ON b.patient_id = p.patient_id " +
                    "LEFT JOIN Admissions a ON b.admission_id = a.admission_id " +
                    "WHERE 1 = 1 ";

                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    query += "AND (b.bill_id LIKE @search OR b.patient_id LIKE @search OR p.full_name LIKE @search) ";
                    cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");
                }

                if (selectedStatus != "All")
                {
                    query += "AND b.billing_status = @status ";
                    cmd.Parameters.AddWithValue("@status", selectedStatus);
                }

                query += "ORDER BY b.created_at DESC";

                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "billingTable");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "billingTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading billing records: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            loaddata();
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            loaddata();
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            if (isProcessingPayment)
            {
                return;
            }

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a billing record first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            string billId = row.Cells["Column1"].Value?.ToString() ?? string.Empty;
            string patientId = row.Cells["Column2"].Value?.ToString() ?? string.Empty;
            string patientName = row.Cells["Column3"].Value?.ToString() ?? string.Empty;
            string billingStatus = row.Cells["Column6"].Value?.ToString() ?? string.Empty;

            decimal totalAmount = 0;
            decimal remainingBalance = 0;
            decimal.TryParse(row.Cells["Column7"].Value?.ToString(), out totalAmount);
            decimal.TryParse(row.Cells["Column9"].Value?.ToString(), out remainingBalance);

            if (string.IsNullOrEmpty(billId))
            {
                MessageBox.Show("Invalid billing record selected.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (billingStatus == "Paid" || remainingBalance <= 0)
            {
                MessageBox.Show("This bill is already fully paid.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (billingStatus == "Cancelled")
            {
                MessageBox.Show("Cancelled bills cannot be settled.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowPaymentDialog(billId, patientId, patientName, totalAmount, remainingBalance);
        }

        void ShowPaymentDialog(string billId, string patientId, string patientName, decimal totalAmount, decimal remainingBalance)
        {
            Form paymentForm = new Form();
            paymentForm.Text = "Settle / Pay Bill - " + billId;
            paymentForm.Size = new Size(440, 360);
            paymentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            paymentForm.StartPosition = FormStartPosition.CenterParent;
            paymentForm.MaximizeBox = false;
            paymentForm.MinimizeBox = false;

            Label lblInfo = new Label();
            lblInfo.Location = new Point(20, 15);
            lblInfo.Size = new Size(385, 110);
            lblInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            lblInfo.Text = "Bill Ref #: " + billId + "\n" +
                           "Patient ID: " + patientId + "\n" +
                           "Patient Name: " + patientName + "\n" +
                           "Total Amount: ₱" + totalAmount.ToString("N2") + "\n" +
                           "Remaining Balance: ₱" + remainingBalance.ToString("N2");

            Label lblMethod = new Label();
            lblMethod.Location = new Point(20, 138);
            lblMethod.Size = new Size(130, 23);
            lblMethod.Text = "Payment Method:";

            ComboBox cmbMethod = new ComboBox();
            cmbMethod.Location = new Point(160, 135);
            cmbMethod.Size = new Size(240, 28);
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.Items.Add("Cash");
            cmbMethod.Items.Add("GCash");
            cmbMethod.Items.Add("Credit card");
            cmbMethod.Items.Add("Debit card");
            cmbMethod.Items.Add("Bank Transfer");
            cmbMethod.Items.Add("HMO/Insurance");
            cmbMethod.SelectedIndex = 0;

            Label lblAmount = new Label();
            lblAmount.Location = new Point(20, 180);
            lblAmount.Size = new Size(130, 23);
            lblAmount.Text = "Payment Amount:";

            TextBox txtPayAmount = new TextBox();
            txtPayAmount.Location = new Point(160, 177);
            txtPayAmount.Size = new Size(240, 27);
            txtPayAmount.Text = remainingBalance.ToString("0.00");

            Label lblNotes = new Label();
            lblNotes.Location = new Point(20, 222);
            lblNotes.Size = new Size(130, 23);
            lblNotes.Text = "Notes (Optional):";

            TextBox txtNotes = new TextBox();
            txtNotes.Location = new Point(160, 219);
            txtNotes.Size = new Size(240, 27);

            Button btnConfirm = new Button();
            btnConfirm.Text = "Confirm Payment";
            btnConfirm.Location = new Point(160, 268);
            btnConfirm.Size = new Size(135, 36);

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(305, 268);
            btnCancel.Size = new Size(95, 36);
            btnCancel.DialogResult = DialogResult.Cancel;

            btnConfirm.Click += delegate (object? s, EventArgs ev)
            {
                if (isProcessingPayment)
                {
                    return;
                }

                decimal payAmount = 0;
                if (string.IsNullOrWhiteSpace(txtPayAmount.Text) || !decimal.TryParse(txtPayAmount.Text.Trim(), out payAmount))
                {
                    MessageBox.Show("Please enter a valid numeric payment amount.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPayAmount.Focus();
                    return;
                }

                if (payAmount <= 0)
                {
                    MessageBox.Show("Payment amount must be greater than zero.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPayAmount.Focus();
                    return;
                }

                if (payAmount > remainingBalance)
                {
                    MessageBox.Show("Payment amount cannot be greater than the remaining balance (₱" + remainingBalance.ToString("N2") + ").",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPayAmount.Focus();
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "Confirm payment of ₱" + payAmount.ToString("N2") + " for Bill " + billId + "?",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                string method = cmbMethod.SelectedItem?.ToString() ?? "Cash";
                string notes = txtNotes.Text.Trim();

                btnConfirm.Enabled = false;
                button5.Enabled = false;
                isProcessingPayment = true;

                try
                {
                    bool saved = ProcessBillPayment(billId, patientId, payAmount, method, notes);
                    if (saved)
                    {
                        paymentForm.DialogResult = DialogResult.OK;
                        paymentForm.Close();
                        loaddata();
                    }
                }
                finally
                {
                    isProcessingPayment = false;
                    button5.Enabled = true;
                    if (!paymentForm.IsDisposed)
                    {
                        btnConfirm.Enabled = true;
                    }
                }
            };

            paymentForm.Controls.Add(lblInfo);
            paymentForm.Controls.Add(lblMethod);
            paymentForm.Controls.Add(cmbMethod);
            paymentForm.Controls.Add(lblAmount);
            paymentForm.Controls.Add(txtPayAmount);
            paymentForm.Controls.Add(lblNotes);
            paymentForm.Controls.Add(txtNotes);
            paymentForm.Controls.Add(btnConfirm);
            paymentForm.Controls.Add(btnCancel);
            paymentForm.CancelButton = btnCancel;

            paymentForm.ShowDialog(this);
        }

        string GetActiveCashierUserId(MySqlConnection conn, MySqlTransaction trans)
        {
            MySqlCommand cmdUser = new MySqlCommand();
            cmdUser.Connection = conn;
            cmdUser.Transaction = trans;
            cmdUser.CommandText = "SELECT user_id FROM Users WHERE is_active = 1 " +
                "ORDER BY CASE WHEN role = 'Admin' THEN 0 WHEN role = 'Billing' THEN 1 ELSE 2 END LIMIT 1";

            MySqlDataReader reader = cmdUser.ExecuteReader();
            string userId = string.Empty;
            if (reader.Read())
            {
                userId = reader["user_id"].ToString() ?? string.Empty;
            }
            reader.Close();
            return userId;
        }

        bool ProcessBillPayment(string billId, string patientId, decimal payAmount, string paymentMethod, string notes)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlTransaction? trans = null;

            try
            {
                conn.Open();
                trans = conn.BeginTransaction();

                // Lock and verify latest bill balance to prevent duplicate/overpayment submissions
                MySqlCommand cmdCheck = new MySqlCommand();
                cmdCheck.Connection = conn;
                cmdCheck.Transaction = trans;
                cmdCheck.CommandText = "SELECT remaining_balance, billing_status FROM BillingRecords WHERE bill_id = @billId FOR UPDATE";
                cmdCheck.Parameters.AddWithValue("@billId", billId);

                decimal currentRemaining = 0;
                string currentStatus = string.Empty;
                MySqlDataReader readerCheck = cmdCheck.ExecuteReader();
                if (!readerCheck.Read())
                {
                    readerCheck.Close();
                    trans.Rollback();
                    MessageBox.Show("Billing record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                currentRemaining = Convert.ToDecimal(readerCheck["remaining_balance"]);
                currentStatus = readerCheck["billing_status"].ToString() ?? string.Empty;
                readerCheck.Close();

                if (currentStatus == "Paid" || currentStatus == "Cancelled" || currentRemaining <= 0)
                {
                    trans.Rollback();
                    MessageBox.Show("This bill can no longer be paid (Status: " + currentStatus + ").", "Duplicate / Invalid Payment",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (payAmount > currentRemaining)
                {
                    trans.Rollback();
                    MessageBox.Show("Payment exceeds the current remaining balance of ₱" + currentRemaining.ToString("N2") + ".",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string cashierUserId = GetActiveCashierUserId(conn, trans);
                if (string.IsNullOrEmpty(cashierUserId))
                {
                    trans.Rollback();
                    MessageBox.Show("No active staff user found in Users table to record as cashier.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                decimal remainingAfter = currentRemaining - payAmount;
                string newStatus = "Partial";
                if (remainingAfter <= 0)
                {
                    remainingAfter = 0;
                    newStatus = "Paid";
                }

                string uniqueSuffix = DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
                string paymentId = "PAY-" + uniqueSuffix;
                string receiptNo = "OR-" + uniqueSuffix;

                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = conn;
                cmdInsert.Transaction = trans;
                cmdInsert.CommandText = "INSERT INTO PaymentRecords " +
                    "(payment_id, bill_id, patient_id, amount_due_before, amount_paid, remaining_balance_after, payment_method, official_receipt_number, cashier_user_id, payment_date, notes) " +
                    "VALUES (@paymentId, @billId, @patientId, @dueBefore, @amountPaid, @remainingAfter, @method, @receiptNo, @cashierId, NOW(), @notes)";
                cmdInsert.Parameters.AddWithValue("@paymentId", paymentId);
                cmdInsert.Parameters.AddWithValue("@billId", billId);
                cmdInsert.Parameters.AddWithValue("@patientId", patientId);
                cmdInsert.Parameters.AddWithValue("@dueBefore", currentRemaining);
                cmdInsert.Parameters.AddWithValue("@amountPaid", payAmount);
                cmdInsert.Parameters.AddWithValue("@remainingAfter", remainingAfter);
                cmdInsert.Parameters.AddWithValue("@method", paymentMethod);
                cmdInsert.Parameters.AddWithValue("@receiptNo", receiptNo);
                cmdInsert.Parameters.AddWithValue("@cashierId", cashierUserId);
                cmdInsert.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(notes) ? DBNull.Value : notes);
                cmdInsert.ExecuteNonQuery();

                // Do not manually update generated column remaining_balance
                MySqlCommand cmdUpdate = new MySqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.Transaction = trans;
                cmdUpdate.CommandText = "UPDATE BillingRecords SET amount_paid = amount_paid + @payAmount, billing_status = @newStatus WHERE bill_id = @billId";
                cmdUpdate.Parameters.AddWithValue("@payAmount", payAmount);
                cmdUpdate.Parameters.AddWithValue("@newStatus", newStatus);
                cmdUpdate.Parameters.AddWithValue("@billId", billId);
                cmdUpdate.ExecuteNonQuery();

                trans.Commit();
                conn.Close();

                MessageBox.Show("Payment saved successfully.\nOfficial Receipt: " + receiptNo + "\nNew Status: " + newStatus +
                    "\nRemaining Balance: ₱" + remainingAfter.ToString("N2"),
                    "Payment Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    try
                    {
                        trans.Rollback();
                    }
                    catch
                    {
                    }
                }
                MessageBox.Show("Database Error: " + ex.Message, "Transaction Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigateToControl(new Access_Logs___Audit_Trail());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
