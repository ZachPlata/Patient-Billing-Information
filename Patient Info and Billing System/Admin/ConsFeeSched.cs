using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ConsFeeSched : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";
        List<string> doctorIds = new List<string>();

        public ConsFeeSched()
        {
            InitializeComponent();
            loadDoctors();
            clearFields();
            loaddata();
        }

        void loadDoctors()
        {
            doctorIds.Clear();
            cmbDoctor.Items.Clear();

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT user_id, full_name FROM Users WHERE role = 'Doctor' ORDER BY full_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctorIds.Add(reader["user_id"].ToString());
                    cmbDoctor.Items.Add(reader["full_name"].ToString());
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT d.fee_schedule_id AS 'Schedule ID', u.full_name AS 'Physician', u.specialty AS 'Specialization', d.standard_fee AS 'Standard Fee', d.follow_up_fee AS 'Follow-Up Fee', d.schedule_days AS 'Schedule Days', CASE WHEN u.is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM DoctorFeeSchedules d INNER JOIN Users u ON d.doctor_id = u.user_id ORDER BY u.full_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvFeeSchedules.DataSource = ds;
                dgvFeeSchedules.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvFeeSchedules.Rows.Count + " entries";
                updateCards(ds.Tables["abc"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        void updateCards(DataTable dt)
        {
            if (dt == null)
            {
                return;
            }

            int activeCount = 0;
            decimal minStandardFee = 0;
            decimal totalStandardFee = 0;
            int totalRows = dt.Rows.Count;

            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                if (status == "Active")
                {
                    activeCount++;
                }

                decimal stdFee = Convert.ToDecimal(row["Standard Fee"]);
                totalStandardFee = totalStandardFee + stdFee;

                if (minStandardFee == 0 || stdFee < minStandardFee)
                {
                    minStandardFee = stdFee;
                }
            }

            decimal avgFee = 0;
            if (totalRows > 0)
            {
                avgFee = totalStandardFee / totalRows;
            }

            lblValActiveSchedules.Text = activeCount.ToString();
            lblValPediatricSpecs.Text = getSpecialtyCount().ToString();
            lblValBaseFee.Text = "₱" + minStandardFee.ToString("N2");
            lblValAvgSpecialistFee.Text = "₱" + avgFee.ToString("N2");
        }

        int getSpecialtyCount()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT COUNT(DISTINCT u.specialty) FROM DoctorFeeSchedules d INNER JOIN Users u ON d.doctor_id = u.user_id WHERE u.specialty IS NOT NULL AND u.specialty <> ''";
                cmd.Connection = conn;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
            catch
            {
                return 0;
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
            errorProvider1.Clear();
            txtScheduleId.Clear();
            cmbDoctor.Enabled = true;
            if (cmbDoctor.Items.Count > 0)
            {
                cmbDoctor.SelectedIndex = 0;
            }
            else
            {
                cmbDoctor.SelectedIndex = -1;
            }
            txtStandardFee.Text = "500.00";
            txtFollowUpFee.Text = "300.00";
            txtScheduleDays.Text = "Mon - Fri";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cmbDoctor.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbDoctor, "Please select an Attending Physician.");
                cmbDoctor.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal stdFee = 0;
            if (!decimal.TryParse(txtStandardFee.Text.Trim(), out stdFee) || stdFee < 0)
            {
                errorProvider1.SetError(txtStandardFee, "Please enter a valid non-negative Standard Fee.");
                txtStandardFee.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal followFee = 0;
            if (!decimal.TryParse(txtFollowUpFee.Text.Trim(), out followFee) || followFee < 0)
            {
                errorProvider1.SetError(txtFollowUpFee, "Please enter a valid non-negative Follow-Up Fee.");
                txtFollowUpFee.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtScheduleDays.Text.Trim() == "")
            {
                errorProvider1.SetError(txtScheduleDays, "Schedule Days is required.");
                txtScheduleDays.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            string selectedDoctorId = doctorIds[cmbDoctor.SelectedIndex];

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO DoctorFeeSchedules (doctor_id, standard_fee, follow_up_fee, schedule_days) VALUES (@doctor_id, @standard_fee, @follow_up_fee, @schedule_days)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@doctor_id", selectedDoctorId);
                cmd.Parameters.AddWithValue("@standard_fee", stdFee);
                cmd.Parameters.AddWithValue("@follow_up_fee", followFee);
                cmd.Parameters.AddWithValue("@schedule_days", txtScheduleDays.Text.Trim());
                cmd.ExecuteNonQuery();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtScheduleId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtScheduleId, "Please select a record from the table first.");
                txtScheduleId.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal stdFee = 0;
            if (!decimal.TryParse(txtStandardFee.Text.Trim(), out stdFee) || stdFee < 0)
            {
                errorProvider1.SetError(txtStandardFee, "Please enter a valid non-negative Standard Fee.");
                txtStandardFee.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal followFee = 0;
            if (!decimal.TryParse(txtFollowUpFee.Text.Trim(), out followFee) || followFee < 0)
            {
                errorProvider1.SetError(txtFollowUpFee, "Please enter a valid non-negative Follow-Up Fee.");
                txtFollowUpFee.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtScheduleDays.Text.Trim() == "")
            {
                errorProvider1.SetError(txtScheduleDays, "Schedule Days is required.");
                txtScheduleDays.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            DialogResult answer;
            answer = MessageBox.Show("Do you want to save records?", "Saving Records",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "UPDATE DoctorFeeSchedules SET standard_fee = @standard_fee, follow_up_fee = @follow_up_fee, schedule_days = @schedule_days WHERE fee_schedule_id = @fee_schedule_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@fee_schedule_id", Convert.ToInt32(txtScheduleId.Text.Trim()));
                cmd.Parameters.AddWithValue("@standard_fee", stdFee);
                cmd.Parameters.AddWithValue("@follow_up_fee", followFee);
                cmd.Parameters.AddWithValue("@schedule_days", txtScheduleDays.Text.Trim());
                cmd.ExecuteNonQuery();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtScheduleId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtScheduleId, "Please select a record to delete.");
                txtScheduleId.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            DialogResult answer;
            answer = MessageBox.Show("Do you want to delete this record?", "Deleting Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "DELETE FROM DoctorFeeSchedules WHERE fee_schedule_id = @fee_schedule_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@fee_schedule_id", Convert.ToInt32(txtScheduleId.Text.Trim()));
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Record deleted.");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            loadDoctors();
            clearFields();
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                loaddata();
                return;
            }
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT d.fee_schedule_id AS 'Schedule ID', u.full_name AS 'Physician', u.specialty AS 'Specialization', d.standard_fee AS 'Standard Fee', d.follow_up_fee AS 'Follow-Up Fee', d.schedule_days AS 'Schedule Days', CASE WHEN u.is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM DoctorFeeSchedules d INNER JOIN Users u ON d.doctor_id = u.user_id WHERE u.full_name LIKE @search OR u.specialty LIKE @search OR d.schedule_days LIKE @search ORDER BY u.full_name ASC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvFeeSchedules.DataSource = ds;
                dgvFeeSchedules.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvFeeSchedules.Rows.Count + " entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dgvFeeSchedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFeeSchedules.Rows.Count)
            {
                DataGridViewRow row = dgvFeeSchedules.Rows[e.RowIndex];
                txtScheduleId.Text = row.Cells[0].Value.ToString();
                cmbDoctor.Text = row.Cells[1].Value.ToString();
                cmbDoctor.Enabled = false;
                txtStandardFee.Text = row.Cells[3].Value.ToString();
                txtFollowUpFee.Text = row.Cells[4].Value.ToString();
                txtScheduleDays.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
