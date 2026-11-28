using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System
{
    public partial class uc_PatientUtil : UserControl
    {
        public uc_PatientUtil()
        {
            InitializeComponent();
            PatUtil_EqCatComboBox.SelectedIndexChanged += PatUtil_EqCatComboBox_SelectedIndexChanged;
            PatUtil_EqDrgComboBox.SelectedIndexChanged += PatUtil_EqDrgComboBox_SelectedIndexChanged;
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=metro_care_db; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            conn.Open();

            string filter = "";
            if (PatUtil_PatIdTxtBox.Text.Trim() != "")
            {
                filter = " WHERE b.patient_id = '" + PatUtil_PatIdTxtBox.Text.Trim() + "' ";
            }

            cmd.CommandText = "SELECT b.patient_id AS `Patient ID`, " +
                              "COALESCE(CONCAT(r.room_number, ' (', r.bed_id, ')'), 'Outpatient / None') AS `Room`, " +
                              "li.item_type AS `Category`, " +
                              "li.description AS `Equipment / Drug / Room`, " +
                              "li.quantity AS `Qty`, " +
                              "li.unit_price AS `Price`, " +
                              "li.subtotal AS `Total` " +
                              "FROM BillingLineItems li " +
                              "INNER JOIN BillingRecords b ON li.bill_id = b.bill_id " +
                              "LEFT JOIN Admissions a ON b.admission_id = a.admission_id " +
                              "LEFT JOIN RoomsBeds r ON a.bed_id = r.bed_id " +
                              filter +
                              "ORDER BY li.item_id DESC";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(ds, "abc");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "abc";
            conn.Close();

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"] != null && row.Cells["Total"].Value != null && row.Cells["Total"].Value != DBNull.Value)
                {
                    decimal val;
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out val))
                    {
                        total += val;
                    }
                }
            }
            label9.Text = "Estimated Cost: ₱ " + total.ToString("N2");
        }

        private void uc_PatientUtil_Load(object sender, EventArgs e)
        {
            loaddata();

            PatUtil_EqCatComboBox.Items.Clear();
            PatUtil_EqCatComboBox.Items.Add("Medication");
            PatUtil_EqCatComboBox.Items.Add("Laboratory");
            PatUtil_EqCatComboBox.Items.Add("RoomBed");
            PatUtil_EqCatComboBox.Items.Add("Other");

            PatUtil_QtTextBox.Text = "1";
        }

        private void PatUtil_EqCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatUtil_EqDrgComboBox.Items.Clear();
            PatUtil_EqIdNoComboBox.Clear();

            MySqlConnection conn = new MySqlConnection("server=localhost; database=metro_care_db; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            if (PatUtil_EqCatComboBox.Text == "Medication")
            {
                conn.Open();
                cmd.CommandText = "SELECT name FROM MedicineCatalog WHERE is_active = 1 ORDER BY name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PatUtil_EqDrgComboBox.Items.Add(reader.GetString("name"));
                }
                conn.Close();
            }
            else if (PatUtil_EqCatComboBox.Text == "Laboratory")
            {
                conn.Open();
                cmd.CommandText = "SELECT test_name FROM LabTestCatalog WHERE is_active = 1 ORDER BY test_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PatUtil_EqDrgComboBox.Items.Add(reader.GetString("test_name"));
                }
                conn.Close();
            }
            else if (PatUtil_EqCatComboBox.Text == "RoomBed")
            {
                conn.Open();
                cmd.CommandText = "SELECT CONCAT(room_number, ' - ', bed_number, ' (', room_type, ')') AS room_label FROM RoomsBeds ORDER BY room_number ASC, bed_number ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PatUtil_EqDrgComboBox.Items.Add(reader.GetString("room_label"));
                }
                conn.Close();
            }
        }

        private void PatUtil_EqDrgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatUtil_EqDrgComboBox.Text == "")
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost; database=metro_care_db; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            if (PatUtil_EqCatComboBox.Text == "Medication")
            {
                conn.Open();
                cmd.CommandText = "SELECT medicine_code FROM MedicineCatalog WHERE name = '" + PatUtil_EqDrgComboBox.Text.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    PatUtil_EqIdNoComboBox.Text = reader.GetString("medicine_code");
                }
                conn.Close();
            }
            else if (PatUtil_EqCatComboBox.Text == "Laboratory")
            {
                conn.Open();
                cmd.CommandText = "SELECT test_code FROM LabTestCatalog WHERE test_name = '" + PatUtil_EqDrgComboBox.Text.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    PatUtil_EqIdNoComboBox.Text = reader.GetString("test_code");
                }
                conn.Close();
            }
            else if (PatUtil_EqCatComboBox.Text == "RoomBed")
            {
                conn.Open();
                cmd.CommandText = "SELECT bed_id FROM RoomsBeds WHERE CONCAT(room_number, ' - ', bed_number, ' (', room_type, ')') = '" + PatUtil_EqDrgComboBox.Text.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    PatUtil_EqIdNoComboBox.Text = reader.GetString("bed_id");
                }
                conn.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void util_BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            if (PatUtil_PatIdTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter or search a Patient ID first.", "Missing Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PatUtil_EqDrgComboBox.Text.Trim() == "")
            {
                MessageBox.Show("Please select an item.", "Missing Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = PatUtil_EqCatComboBox.Text;
            if (category == "")
            {
                MessageBox.Show("Please select a valid category.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost; database=metro_care_db; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            conn.Open();
            cmd.Connection = conn;

            // 1. Get unit price from Admin's Clinic & Data Setup tables
            string unitPrice = "50.00";
            if (category == "Medication")
            {
                cmd.CommandText = "SELECT unit_price FROM MedicineCatalog WHERE name = '" + PatUtil_EqDrgComboBox.Text.Replace("'", "''") + "'";
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    unitPrice = reader["unit_price"].ToString();
                }
                reader.Close();
            }
            else if (category == "Laboratory")
            {
                cmd.CommandText = "SELECT price FROM LabTestCatalog WHERE test_name = '" + PatUtil_EqDrgComboBox.Text.Replace("'", "''") + "'";
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    unitPrice = reader["price"].ToString();
                }
                reader.Close();
            }
            else if (category == "RoomBed")
            {
                cmd.CommandText = "SELECT daily_rate FROM RoomsBeds WHERE bed_id = '" + PatUtil_EqIdNoComboBox.Text.Trim() + "'";
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    unitPrice = reader["daily_rate"].ToString();
                }
                reader.Close();
            }

            // 2. Find active bill for this patient (or create one)
            string billId = "";
            cmd.CommandText = "SELECT bill_id FROM BillingRecords WHERE patient_id = '" + PatUtil_PatIdTxtBox.Text.Trim() + "' AND billing_status != 'Paid' ORDER BY created_at DESC LIMIT 1";
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                billId = reader.GetString("bill_id");
                reader.Close();
            }
            else
            {
                reader.Close();
                billId = "BILL-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                cmd.CommandText = "INSERT INTO BillingRecords (bill_id, patient_id, billing_status, total_amount, amount_paid, due_date, breakdown_notes) VALUES ('" + billId + "', '" + PatUtil_PatIdTxtBox.Text.Trim() + "', 'Unpaid', 0.00, 0.00, DATE_ADD(NOW(), INTERVAL 7 DAY), 'Patient Utilization')";
                cmd.ExecuteNonQuery();
            }

            // 3. Insert utilized item with database price
            string itemDesc = PatUtil_EqDrgComboBox.Text.Trim();
            if (PatUtil_Notes.Text.Trim() != "")
            {
                itemDesc = itemDesc + " (" + PatUtil_Notes.Text.Trim() + ")";
            }

            cmd.CommandText = "INSERT INTO BillingLineItems (bill_id, item_type, description, quantity, unit_price) VALUES (" +
                "'" + billId + "'," +
                "'" + category + "'," +
                "'" + itemDesc.Replace("'", "''") + "'," +
                PatUtil_QtTextBox.Text.Trim() + "," +
                unitPrice + ")";
            cmd.ExecuteNonQuery();

            // 4. Update total_amount on BillingRecords
            cmd.CommandText = "UPDATE BillingRecords SET total_amount = (SELECT COALESCE(SUM(subtotal), 0) FROM BillingLineItems WHERE bill_id = '" + billId + "') WHERE bill_id = '" + billId + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("RECORD SAVED");
            loaddata();
        }

        private void RegPat_BtnClr_Click(object sender, EventArgs e)
        {
            PatUtil_PatIdTxtBox.Clear();
            PatUtil_PatNameTxtBox.Clear();
            PatUtil_PatStatus.Clear();
            PatUtil_RoomTxtBox.Clear();
            PatUtil_DoctorTxtBox.Clear();
            PatUtil_AdmittedTxtBox.Clear();
            PatUtil_EqIdNoComboBox.Clear();
            PatUtil_QtTextBox.Text = "1";
            PatUtil_Notes.Clear();
            PatUtil_EqCatComboBox.SelectedIndex = -1;
            PatUtil_EqDrgComboBox.SelectedIndex = -1;
            loaddata();
        }

        private void patUtil_Search_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=metro_care_db; uid=root");
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            conn.Open();
            cmd.CommandText = "SELECT p.full_name, " +
                  "p.current_status AS 'status', " +
                  "COALESCE(a.bed_id, 'None') AS 'room', " +
                  "COALESCE(u.full_name, 'Unassigned') AS 'attending_doctor', " +
                  "COALESCE(DATE_FORMAT(a.admission_date, '%Y-%m-%d'), 'N/A') AS 'admitted' " +
                  "FROM Patients p " +
                  "LEFT JOIN Admissions a ON p.patient_id = a.patient_id AND a.status = 'Admitted' " +
                  "LEFT JOIN Users u ON p.assigned_doctor_id = u.user_id " +
                  "WHERE p.patient_id = '" + PatUtil_PatIdTxtBox.Text.Trim() + "'";
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                PatUtil_PatNameTxtBox.Text = reader.GetString("full_name");
                PatUtil_PatStatus.Text = reader.GetString("status");
                PatUtil_RoomTxtBox.Text = reader.GetString("room");
                PatUtil_DoctorTxtBox.Text = reader.GetString("attending_doctor");
                PatUtil_AdmittedTxtBox.Text = reader.GetString("admitted");
                conn.Close();
                loaddata();
            }
            else
            {
                conn.Close();
                MessageBox.Show("No Record Found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void util_BtnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
