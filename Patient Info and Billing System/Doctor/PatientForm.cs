using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Doctor
{
    public partial class PatientForm : UserControl
    {
        string connstring = "server=localhost; database=patientbillingdb; uid=root";

        public PatientForm()
        {
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT patient_id, full_name, date_of_birth, contact_number FROM Patients ORDER BY full_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                patrecordDataGridView.Rows.Clear();

                while (reader.Read())
                {
                    DateTime birthDate = Convert.ToDateTime(reader["date_of_birth"]);
                    int age = DateTime.Now.Year - birthDate.Year;
                    if (birthDate > DateTime.Now.AddYears(-age))
                    {
                        age--;
                    }

                    patrecordDataGridView.Rows.Add(
                        reader["patient_id"].ToString(),
                        reader["full_name"].ToString(),
                        age.ToString(),
                        reader["contact_number"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error patient records load: " + ex.Message, "Database Error",
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

        void clearFields()
        {
            textBox5.Clear();
            fullnameTxtbox.Clear();
            birthdayTxtbox.Clear();
            ageTxtbox.Clear();
            genderCmbBox.SelectedIndex = -1;
            statusCmbBox.SelectedIndex = -1;
            addressTxtbox.Clear();
            contactnoTxtbox.Clear();
            emrgncycontactpersonTxtbox.Clear();
            emrgncycontactnoTxtbox.Clear();
            bloodtypeCmbbox.SelectedIndex = -1;
            allergiesTxtbox.Clear();
            currentmedTxtbox.Clear();
            medhistoryTxtbox.Clear();
            totalbillTxtbox.Clear();
            totalpaidTxtbox.Clear();
            balanceTxtbox.Clear();
            patrecordDataGridView.Rows.Clear();
            visithistoryDataGridView.Rows.Clear();
        }

        private void patrecordDataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object cellValue = patrecordDataGridView.Rows[e.RowIndex].Cells[0].Value;
            if (cellValue == null)
            {
                return;
            }

            string patientId = cellValue.ToString();
            if (patientId == "")
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM Patients WHERE patient_id = '" + patientId + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox5.Text = reader["patient_id"].ToString();
                    fullnameTxtbox.Text = reader["full_name"].ToString();
                    genderCmbBox.Text = reader["gender"].ToString();
                    statusCmbBox.Text = reader["current_status"].ToString();
                    contactnoTxtbox.Text = reader["contact_number"].ToString();
                    addressTxtbox.Text = reader["address"].ToString();
                    emrgncycontactpersonTxtbox.Text = reader["emergency_contact_name"].ToString();
                    emrgncycontactnoTxtbox.Text = reader["emergency_contact_phone"].ToString();
                    bloodtypeCmbbox.Text = reader["blood_type"].ToString();
                    allergiesTxtbox.Text = reader["allergies"].ToString();

                    DateTime birthDate = Convert.ToDateTime(reader["date_of_birth"]);
                    birthdayTxtbox.Text = birthDate.ToString("yyyy-MM-dd");

                    int age = DateTime.Now.Year - birthDate.Year;
                    if (birthDate > DateTime.Now.AddYears(-age))
                    {
                        age--;
                    }
                    ageTxtbox.Text = age.ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT h.checkup_date, u.full_name, h.final_diagnosis, h.clinical_notes " +
                    "FROM HealthCheckups h LEFT JOIN Users u ON h.doctor_id = u.user_id " +
                    "WHERE h.patient_id = '" + patientId + "' ORDER BY h.checkup_date DESC";
                reader = cmd.ExecuteReader();
                visithistoryDataGridView.Rows.Clear();
                string historyText = "";

                while (reader.Read())
                {
                    string visitDate = Convert.ToDateTime(reader["checkup_date"]).ToString("yyyy-MM-dd");
                    string doctorName = reader["full_name"].ToString() ?? "";
                    string diagnosis = reader["final_diagnosis"].ToString() ?? "";
                    string notes = reader["clinical_notes"].ToString() ?? "";

                    visithistoryDataGridView.Rows.Add(visitDate, doctorName, diagnosis, notes);

                    if (diagnosis != "")
                    {
                        if (historyText == "")
                        {
                            historyText = diagnosis;
                        }
                        else
                        {
                            historyText = historyText + "; " + diagnosis;
                        }
                    }
                }
                medhistoryTxtbox.Text = historyText;
                reader.Close();

                // 3. Load current medications
                cmd.CommandText = "SELECT medicine_name, dosage, frequency FROM PrescriptionItems " +
                    "WHERE patient_id = '" + patientId + "' ORDER BY date_prescribed DESC";
                reader = cmd.ExecuteReader();
                string medsText = "";

                while (reader.Read())
                {
                    string entry = reader["medicine_name"].ToString() + " (" +
                        reader["dosage"].ToString() + ", " + reader["frequency"].ToString() + ")";

                    if (medsText == "")
                    {
                        medsText = entry;
                    }
                    else
                    {
                        medsText = medsText + "; " + entry;
                    }
                }
                currentmedTxtbox.Text = medsText;
                reader.Close();

                // 4. Load billing summary
                cmd.CommandText = "SELECT IFNULL(SUM(total_amount), 0), IFNULL(SUM(amount_paid), 0), IFNULL(SUM(remaining_balance), 0) " +
                    "FROM BillingRecords WHERE patient_id = '" + patientId + "'";
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    totalbillTxtbox.Text = Convert.ToDecimal(reader[0]).ToString("N2");
                    totalpaidTxtbox.Text = Convert.ToDecimal(reader[1]).ToString("N2");
                    balanceTxtbox.Text = Convert.ToDecimal(reader[2]).ToString("N2");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient details: " + ex.Message, "Database Error",
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

        private void searchBtn_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                loaddata();
                return;
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT patient_id, full_name, date_of_birth, contact_number FROM Patients " +
                    "WHERE patient_id LIKE '%" + textBox1.Text.Trim() + "%' " +
                    "OR full_name LIKE '%" + textBox1.Text.Trim() + "%' " +
                    "ORDER BY full_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                patrecordDataGridView.Rows.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime birthDate = Convert.ToDateTime(reader["date_of_birth"]);
                        int age = DateTime.Now.Year - birthDate.Year;
                        if (birthDate > DateTime.Now.AddYears(-age))
                        {
                            age--;
                        }

                        patrecordDataGridView.Rows.Add(
                            reader["patient_id"].ToString(),
                            reader["full_name"].ToString(),
                            age.ToString(),
                            reader["contact_number"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching patient: " + ex.Message, "Database Error",
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

        private void adpatientBtn_Click(object? sender, EventArgs e)
        {
            if (fullnameTxtbox.Text.Trim() == "" || birthdayTxtbox.Text.Trim() == "" || genderCmbBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in Full Name, Birthday, and Gender.");
                return;
            }

            DateTime birthDate;
            if (!DateTime.TryParse(birthdayTxtbox.Text.Trim(), out birthDate))
            {
                MessageBox.Show("Please enter a valid birthday (yyyy-MM-dd).");
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

            string newPatientId = "PAT-" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.ToString("HHmmss");
            string status = "Outpatient";
            if (statusCmbBox.Text != "")
            {
                status = statusCmbBox.Text;
            }

            string allergies = "None known";
            if (allergiesTxtbox.Text.Trim() != "")
            {
                allergies = allergiesTxtbox.Text.Trim();
            }

            string bloodTypeValue = "NULL";
            if (bloodtypeCmbbox.Text != "")
            {
                bloodTypeValue = "'" + bloodtypeCmbbox.Text + "'";
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO Patients (patient_id, full_name, date_of_birth, gender, contact_number, address, " +
                    "emergency_contact_name, emergency_contact_phone, blood_type, allergies, current_status) VALUES (" +
                    "'" + newPatientId + "', " +
                    "'" + fullnameTxtbox.Text.Trim() + "', " +
                    "'" + birthDate.ToString("yyyy-MM-dd") + "', " +
                    "'" + genderCmbBox.Text + "', " +
                    "'" + contactnoTxtbox.Text.Trim() + "', " +
                    "'" + addressTxtbox.Text.Trim() + "', " +
                    "'" + emrgncycontactpersonTxtbox.Text.Trim() + "', " +
                    "'" + emrgncycontactnoTxtbox.Text.Trim() + "', " +
                    bloodTypeValue + ", " +
                    "'" + allergies + "', " +
                    "'" + status + "')";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORD SAVE");
                clearFields();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Database Error",
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

        private void updateBtn_Click(object? sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Please select a patient record first.");
                return;
            }

            DateTime birthDate;
            if (!DateTime.TryParse(birthdayTxtbox.Text.Trim(), out birthDate))
            {
                MessageBox.Show("Please enter a valid birthday (yyyy-MM-dd).");
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

            string status = "Outpatient";
            if (statusCmbBox.Text != "")
            {
                status = statusCmbBox.Text;
            }

            string allergies = "None known";
            if (allergiesTxtbox.Text.Trim() != "")
            {
                allergies = allergiesTxtbox.Text.Trim();
            }

            string bloodTypeValue = "NULL";
            if (bloodtypeCmbbox.Text != "")
            {
                bloodTypeValue = "'" + bloodtypeCmbbox.Text + "'";
            }

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "UPDATE Patients SET " +
                    "full_name = '" + fullnameTxtbox.Text.Trim() + "', " +
                    "date_of_birth = '" + birthDate.ToString("yyyy-MM-dd") + "', " +
                    "gender = '" + genderCmbBox.Text + "', " +
                    "contact_number = '" + contactnoTxtbox.Text.Trim() + "', " +
                    "address = '" + addressTxtbox.Text.Trim() + "', " +
                    "emergency_contact_name = '" + emrgncycontactpersonTxtbox.Text.Trim() + "', " +
                    "emergency_contact_phone = '" + emrgncycontactnoTxtbox.Text.Trim() + "', " +
                    "blood_type = " + bloodTypeValue + ", " +
                    "allergies = '" + allergies + "', " +
                    "current_status = '" + status + "' " +
                    "WHERE patient_id = '" + textBox5.Text.Trim() + "'";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORD SAVE");
                clearFields();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message, "Database Error",
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

        private void deactivateBtn_Click(object? sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Please select a patient record first.");
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

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "UPDATE Patients SET current_status = 'Discharged' WHERE patient_id = '" + textBox5.Text.Trim() + "'";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                MessageBox.Show("RECORD SAVE");
                clearFields();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deactivating patient: " + ex.Message, "Database Error",
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

        private void button3_Click(object? sender, EventArgs e)
        {
            clearFields();
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                Control parentPanel = this.Parent;
                DocHealthCheckUp checkupForm = new DocHealthCheckUp();
                checkupForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(checkupForm);
            }
        }

        private void label22_Click(object? sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object? sender, EventArgs e)
        {

        }

        private void label7_Click(object? sender, EventArgs e)
        {

        }

        private void fullnameTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void birthdayTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void genderCmbBox_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void statusCmbBox_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void ageTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void contactnoTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void addressTxtbox_MaskInputRejected(object? sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bloodtypeCmbbox_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void emrgncycontactnoTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void allergiesTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void medhistoryTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void currentmedTxtbox_MaskInputRejected(object? sender, MaskInputRejectedEventArgs e)
        {

        }

        private void totalbillTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void totalpaidTxtbox_TextChanged(object? sender, EventArgs e)
        {

        }

        private void balanceTxtbox_MaskInputRejected(object? sender, MaskInputRejectedEventArgs e)
        {

        }

        private void genderCmbBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
