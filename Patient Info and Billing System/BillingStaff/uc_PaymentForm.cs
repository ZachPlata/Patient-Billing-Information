using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.BillingStaff
{
    public partial class uc_PaymentForm : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";
        string selectedPatientId = "";

        public uc_PaymentForm()
        {
            InitializeComponent();
            generateIds();
            loaddata();
        }

        private void uc_PaymentForm_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        void generateIds()
        {
            string stamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            txtPaymentId.Text = "PAY-" + stamp;
            txtReceiptNumber.Text = "OR-" + stamp;
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT b.bill_id AS 'Bill ID', p.patient_id AS 'Patient ID', p.full_name AS 'Patient Name', " +
                    "b.total_amount AS 'Total Amount', b.amount_paid AS 'Amount Paid', b.remaining_balance AS 'Remaining Balance', " +
                    "b.billing_status AS 'Status' " +
                    "FROM BillingRecords b " +
                    "INNER JOIN Patients p ON b.patient_id = p.patient_id " +
                    "WHERE b.billing_status IN ('Unpaid', 'Partial') " +
                    "ORDER BY b.created_at DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "billsTable");
                dgvBills.DataSource = ds;
                dgvBills.DataMember = "billsTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading billing records: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void searchBills(string keyword)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT b.bill_id AS 'Bill ID', p.patient_id AS 'Patient ID', p.full_name AS 'Patient Name', " +
                    "b.total_amount AS 'Total Amount', b.amount_paid AS 'Amount Paid', b.remaining_balance AS 'Remaining Balance', " +
                    "b.billing_status AS 'Status' " +
                    "FROM BillingRecords b " +
                    "INNER JOIN Patients p ON b.patient_id = p.patient_id " +
                    "WHERE b.billing_status IN ('Unpaid', 'Partial') " +
                    "AND (b.bill_id LIKE '%" + keyword + "%' OR p.full_name LIKE '%" + keyword + "%') " +
                    "ORDER BY b.created_at DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "billsTable");
                dgvBills.DataSource = ds;
                dgvBills.DataMember = "billsTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching billing records: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void PopulateFieldsFromRow(DataGridViewRow row)
        {
            txtBillId.Text = row.Cells["Bill ID"].Value?.ToString() ?? "";
            selectedPatientId = row.Cells["Patient ID"].Value?.ToString() ?? "";
            txtPatientName.Text = row.Cells["Patient Name"].Value?.ToString() ?? "";

            decimal amountDue = 0;
            if (row.Cells["Remaining Balance"].Value != null)
            {
                decimal.TryParse(row.Cells["Remaining Balance"].Value?.ToString(), out amountDue);
            }

            txtAmountDue.Text = amountDue.ToString("0.00");
            txtAmountPaid.Text = "";
            txtRemainingBalance.Text = amountDue.ToString("0.00");
            errorProvider1.Clear();
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBills.Rows.Count)
            {
                DataGridViewRow row = dgvBills.Rows[e.RowIndex];
                PopulateFieldsFromRow(row);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                loaddata();
            }
            else
            {
                searchBills(txtSearch.Text.Trim());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                loaddata();
                return;
            }

            searchBills(txtSearch.Text.Trim());

            if (dgvBills.Rows.Count > 0)
            {
                PopulateFieldsFromRow(dgvBills.Rows[0]);
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            loaddata();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            decimal amountDue = 0;
            decimal amountPaid = 0;

            if (!decimal.TryParse(txtAmountDue.Text, out amountDue))
            {
                txtRemainingBalance.Text = "0.00";
                return;
            }

            if (decimal.TryParse(txtAmountPaid.Text, out amountPaid))
            {
                decimal remaining = amountDue - amountPaid;
                if (remaining < 0)
                {
                    remaining = 0;
                }
                txtRemainingBalance.Text = remaining.ToString("0.00");
            }
            else
            {
                txtRemainingBalance.Text = amountDue.ToString("0.00");
            }
        }

        string GetSelectedPaymentMethod()
        {
            if (radCash.Checked)
            {
                return "Cash";
            }
            if (radGcash.Checked)
            {
                return "GCash";
            }
            if (radCreditCard.Checked)
            {
                return "Credit card";
            }
            return "";
        }

        string GetCashierUserId(MySqlConnection conn)
        {
            string userId = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            cmd.CommandText = "SELECT user_id FROM Users WHERE role = 'Billing' LIMIT 1";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                userId = reader[0].ToString() ?? "";
            }
            reader.Close();

            if (userId == "")
            {
                cmd.CommandText = "SELECT user_id FROM Users LIMIT 1";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = reader[0].ToString() ?? "";
                }
                reader.Close();
            }

            return userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtBillId.Text == "" || selectedPatientId == "")
            {
                errorProvider1.SetError(txtPatientName, "Please select a patient billing record from the list.");
                return;
            }

            decimal amountDue = 0;
            if (!decimal.TryParse(txtAmountDue.Text, out amountDue) || amountDue <= 0)
            {
                errorProvider1.SetError(txtAmountDue, "Invalid amount due.");
                return;
            }

            decimal amountPaid = 0;
            if (!decimal.TryParse(txtAmountPaid.Text, out amountPaid) || amountPaid <= 0)
            {
                errorProvider1.SetError(txtAmountPaid, "Please enter a valid payment amount.");
                txtAmountPaid.Focus();
                return;
            }

            if (amountPaid > amountDue)
            {
                errorProvider1.SetError(txtAmountPaid, "Amount paid cannot be greater than the amount due.");
                txtAmountPaid.Focus();
                return;
            }

            string paymentMethod = GetSelectedPaymentMethod();
            if (paymentMethod == "")
            {
                errorProvider1.SetError(grpPaymentMethod, "Please select a payment method.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReceiptNumber.Text))
            {
                errorProvider1.SetError(txtReceiptNumber, "Official receipt number is required.");
                txtReceiptNumber.Focus();
                return;
            }

            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            decimal remainingAfter = amountDue - amountPaid;
            string newStatus = "Partial";
            if (remainingAfter <= 0)
            {
                remainingAfter = 0;
                newStatus = "Paid";
            }

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                string cashierUserId = GetCashierUserId(conn);
                if (cashierUserId == "")
                {
                    MessageBox.Show("No user account found in Users table to record as cashier.");
                    conn.Close();
                    return;
                }

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO PaymentRecords " +
                    "(payment_id, bill_id, patient_id, amount_due_before, amount_paid, remaining_balance_after, payment_method, official_receipt_number, cashier_user_id, payment_date) " +
                    "VALUES (" +
                    "'" + txtPaymentId.Text.Trim() + "', " +
                    "'" + txtBillId.Text.Trim() + "', " +
                    "'" + selectedPatientId + "', " +
                    amountDue.ToString("0.00") + ", " +
                    amountPaid.ToString("0.00") + ", " +
                    remainingAfter.ToString("0.00") + ", " +
                    "'" + paymentMethod + "', " +
                    "'" + txtReceiptNumber.Text.Trim() + "', " +
                    "'" + cashierUserId + "', " +
                    "'" + dtpPaymentDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                cmd.ExecuteNonQuery();

                MySqlCommand updateCmd = new MySqlCommand();
                updateCmd.Connection = conn;
                updateCmd.CommandText = "UPDATE BillingRecords SET " +
                    "amount_paid = amount_paid + " + amountPaid.ToString("0.00") + ", " +
                    "billing_status = '" + newStatus + "' " +
                    "WHERE bill_id = '" + txtBillId.Text.Trim() + "'";
                updateCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("RECORD SAVE");
                clearFields();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void clearFields()
        {
            selectedPatientId = "";
            txtBillId.Clear();
            txtPatientName.Clear();
            txtAmountDue.Clear();
            txtAmountPaid.Clear();
            txtRemainingBalance.Clear();
            radCash.Checked = false;
            radGcash.Checked = false;
            radCreditCard.Checked = false;
            dtpPaymentDate.Value = DateTime.Now;
            errorProvider1.Clear();
            generateIds();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
