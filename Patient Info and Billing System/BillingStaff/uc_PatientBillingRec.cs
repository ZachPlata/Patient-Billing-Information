using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System
{
    public partial class uc_PatientBillingRec : UserControl
    {
        string selectedPatientId = "";

        public uc_PatientBillingRec()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT patient_id AS `Patient ID`, full_name AS `Patient Name`, gender AS `Gender`, contact_number AS `Contact No.`, blood_type AS `Blood Type`, current_status AS `Status` FROM Patients";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                PatBillRec_DGV.DataSource = ds;
                PatBillRec_DGV.DataMember = "abc";
                lblRecordCount.Text = PatBillRec_DGV.Rows.Count + " patient(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void LoadBillingsAndEquipment(string patientId, string visitDate)
        {
            txtBillings.Clear();
            txtEquipmentUsed.Clear();

            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.Connection = conn;


                if (visitDate == "")
                {
                    cmd.CommandText = "SELECT bill_id, billing_status, total_amount, amount_paid, remaining_balance, DATE_FORMAT(created_at, '%Y-%m-%d') AS bill_date FROM BillingRecords WHERE patient_id = '" + patientId + "' ORDER BY created_at DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT bill_id, billing_status, total_amount, amount_paid, remaining_balance, DATE_FORMAT(created_at, '%Y-%m-%d') AS bill_date FROM BillingRecords WHERE patient_id = '" + patientId + "' AND DATE(created_at) = '" + visitDate + "' ORDER BY created_at DESC";
                }

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtBillings.Text += reader["bill_date"].ToString() + " | " + reader["bill_id"].ToString() + " [" + reader["billing_status"].ToString() + "]\r\n" +
                        "  Total: " + reader["total_amount"].ToString() + " | Paid: " + reader["amount_paid"].ToString() + " | Bal: " + reader["remaining_balance"].ToString() + "\r\n\r\n";
                }
                if (txtBillings.Text == "")
                {
                    if (visitDate == "")
                    {
                        txtBillings.Text = "No billing records found.";
                    }
                    else
                    {
                        txtBillings.Text = "No billing record found for " + visitDate + ".";
                    }
                }
                reader.Close();


                if (visitDate == "")
                {
                    cmd.CommandText = "SELECT li.item_type, li.description, li.quantity, li.unit_price, li.subtotal FROM BillingLineItems li INNER JOIN BillingRecords b ON li.bill_id = b.bill_id WHERE b.patient_id = '" + patientId + "' ORDER BY li.item_id DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT li.item_type, li.description, li.quantity, li.unit_price, li.subtotal FROM BillingLineItems li INNER JOIN BillingRecords b ON li.bill_id = b.bill_id WHERE b.patient_id = '" + patientId + "' AND DATE(b.created_at) = '" + visitDate + "' ORDER BY li.item_id DESC";
                }

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEquipmentUsed.Text += "[" + reader["item_type"].ToString() + "] " + reader["description"].ToString() + "\r\n" +
                        "  Qty: " + reader["quantity"].ToString() + " x " + reader["unit_price"].ToString() + " = " + reader["subtotal"].ToString() + "\r\n\r\n";
                }
                if (txtEquipmentUsed.Text == "")
                {
                    if (visitDate == "")
                    {
                        txtEquipmentUsed.Text = "No equipment or drugs used.";
                    }
                    else
                    {
                        txtEquipmentUsed.Text = "No equipment or drugs used on " + visitDate + ".";
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void uc_PatientBillingRec_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT patient_id AS `Patient ID`, full_name AS `Patient Name`, gender AS `Gender`, contact_number AS `Contact No.`, blood_type AS `Blood Type`, current_status AS `Status` FROM Patients WHERE patient_id LIKE '%" + txtSearch.Text + "%' OR full_name LIKE '%" + txtSearch.Text + "%'";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                PatBillRec_DGV.DataSource = ds;
                PatBillRec_DGV.DataMember = "abc";
                lblRecordCount.Text = PatBillRec_DGV.Rows.Count + " patient(s)";

                if (PatBillRec_DGV.Rows.Count == 0)
                {
                    MessageBox.Show("No Record Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            loaddata();
        }

        private void PatBillRec_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedPatientId = PatBillRec_DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPatientName.Text = PatBillRec_DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            lstVisitHistory.Items.Clear();

            MySqlConnection conn = new MySqlConnection("server=localhost; database=patientbillingdb; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT DATE_FORMAT(scheduled_date, '%Y-%m-%d') AS visit_date, CONCAT('Appointment - ', reason) AS details FROM Appointments WHERE patient_id = '" + selectedPatientId + "' " +
                    "UNION " +
                    "SELECT DATE_FORMAT(admission_date, '%Y-%m-%d') AS visit_date, CONCAT('Admitted - ', status) AS details FROM Admissions WHERE patient_id = '" + selectedPatientId + "' " +
                    "UNION " +
                    "SELECT DATE_FORMAT(checkup_date, '%Y-%m-%d') AS visit_date, CONCAT('Checkup - ', chief_complaint) AS details FROM HealthCheckups WHERE patient_id = '" + selectedPatientId + "' " +
                    "ORDER BY visit_date DESC";

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstVisitHistory.Items.Add(reader["visit_date"].ToString() + " | " + reader["details"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            LoadBillingsAndEquipment(selectedPatientId, "");
        }

        private void lstVisitHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVisitHistory.SelectedIndex < 0 || selectedPatientId == "")
            {
                return;
            }

            string selectedVisit = lstVisitHistory.SelectedItem.ToString();
            if (selectedVisit.Length >= 10)
            {
                string visitDate = selectedVisit.Substring(0, 10);
                LoadBillingsAndEquipment(selectedPatientId, visitDate);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (selectedPatientId == "")
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            lstVisitHistory.SelectedIndex = -1;
            LoadBillingsAndEquipment(selectedPatientId, "");
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            selectedPatientId = "";
            txtPatientName.Clear();
            lstVisitHistory.Items.Clear();
            txtBillings.Clear();
            txtEquipmentUsed.Clear();
        }

        private void lblTableTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
