using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.BillingStaff
{
    public partial class uc_PaymentHistory : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

        public uc_PaymentHistory()
        {
            InitializeComponent();
            loaddata();
        }

        private void uc_PaymentHistory_Load(object sender, EventArgs e)
        {
            loaddata();
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
                cmd.CommandText = "SELECT pr.payment_id AS 'Payment ID', " +
                    "p.full_name AS 'Patient Name', " +
                    "pr.payment_date AS 'Date Paid', " +
                    "pr.amount_paid AS 'Amount Paid', " +
                    "pr.payment_method AS 'Payment Method', " +
                    "pr.official_receipt_number AS 'Receipt Number' " +
                    "FROM PaymentRecords pr " +
                    "INNER JOIN Patients p ON pr.patient_id = p.patient_id " +
                    "ORDER BY pr.payment_date DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "paymentHistoryTable");
                dgvPaymentHistory.DataSource = ds;
                dgvPaymentHistory.DataMember = "paymentHistoryTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment history: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void searchHistory(string keyword)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter();

                conn.Open();
                cmd.CommandText = "SELECT pr.payment_id AS 'Payment ID', " +
                    "p.full_name AS 'Patient Name', " +
                    "pr.payment_date AS 'Date Paid', " +
                    "pr.amount_paid AS 'Amount Paid', " +
                    "pr.payment_method AS 'Payment Method', " +
                    "pr.official_receipt_number AS 'Receipt Number' " +
                    "FROM PaymentRecords pr " +
                    "INNER JOIN Patients p ON pr.patient_id = p.patient_id " +
                    "WHERE pr.payment_id LIKE '%" + keyword + "%' " +
                    "OR p.full_name LIKE '%" + keyword + "%' " +
                    "OR pr.official_receipt_number LIKE '%" + keyword + "%' " +
                    "ORDER BY pr.payment_date DESC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "paymentHistoryTable");
                dgvPaymentHistory.DataSource = ds;
                dgvPaymentHistory.DataMember = "paymentHistoryTable";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching payment history: " + ex.Message);
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
            txtPaymentId.Text = row.Cells["Payment ID"].Value?.ToString() ?? "";
            txtPatientName.Text = row.Cells["Patient Name"].Value?.ToString() ?? "";
            txtDatePaid.Text = row.Cells["Date Paid"].Value?.ToString() ?? "";
            txtAmountPaid.Text = row.Cells["Amount Paid"].Value?.ToString() ?? "";
            txtPaymentMethod.Text = row.Cells["Payment Method"].Value?.ToString() ?? "";
            txtReceiptNumber.Text = row.Cells["Receipt Number"].Value?.ToString() ?? "";
        }

        private void dgvPaymentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPaymentHistory.Rows.Count)
            {
                DataGridViewRow row = dgvPaymentHistory.Rows[e.RowIndex];
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
                searchHistory(txtSearch.Text.Trim());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                loaddata();
                clearFields();
                return;
            }

            searchHistory(txtSearch.Text.Trim());

            if (dgvPaymentHistory.Rows.Count > 0)
            {
                PopulateFieldsFromRow(dgvPaymentHistory.Rows[0]);
            }
            else
            {
                MessageBox.Show("No Record Found");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            clearFields();
            loaddata();
        }

        void clearFields()
        {
            txtPaymentId.Clear();
            txtPatientName.Clear();
            txtDatePaid.Clear();
            txtAmountPaid.Clear();
            txtPaymentMethod.Clear();
            txtReceiptNumber.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
