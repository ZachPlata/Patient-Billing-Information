using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ConsFeeSched : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        DataTable dtSchedules = new DataTable();

        public ConsFeeSched()
        {
            InitializeComponent();

            cmbSpecialization.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            colActions.Visible = false;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbSpecialization.SelectedIndexChanged += cmbSpecialization_SelectedIndexChanged;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            btnClearFilters.Click += btnClearFilters_Click;

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

                conn.Open();
                cmd.CommandText = "SELECT d.fee_schedule_id, d.doctor_id, u.full_name, u.specialty, d.standard_fee, d.follow_up_fee, d.schedule_days, u.is_active " +
                                  "FROM DoctorFeeSchedules d " +
                                  "INNER JOIN Users u ON d.doctor_id = u.user_id " +
                                  "ORDER BY u.full_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "DoctorFeeSchedules");
                conn.Close();

                if (ds.Tables["DoctorFeeSchedules"] != null)
                {
                    dtSchedules = ds.Tables["DoctorFeeSchedules"]!;
                }

                updateCards();
                filterData();
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

        void updateCards()
        {
            int activeCount = 0;
            List<string> specialties = new List<string>();
            decimal minStandardFee = 0;
            decimal totalStandardFee = 0;
            int totalRows = dtSchedules.Rows.Count;

            foreach (DataRow row in dtSchedules.Rows)
            {
                int isActive = Convert.ToInt32(row["is_active"]);
                if (isActive == 1)
                {
                    activeCount++;
                }

                string spec = row["specialty"].ToString() ?? "";
                if (spec != "" && !specialties.Contains(spec))
                {
                    specialties.Add(spec);
                }

                decimal stdFee = Convert.ToDecimal(row["standard_fee"]);
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
            lblValPediatricSpecs.Text = specialties.Count.ToString();
            lblValBaseFee.Text = "₱" + minStandardFee.ToString("N2");
            lblValAvgSpecialistFee.Text = "₱" + avgFee.ToString("N2");
        }

        void filterData()
        {
            dgvFeeSchedules.Rows.Clear();

            string search = txtSearch.Text.Trim().ToLower();
            string selectedSpec = cmbSpecialization.Text;
            string selectedStatus = cmbStatus.Text;

            foreach (DataRow row in dtSchedules.Rows)
            {
                int feeId = Convert.ToInt32(row["fee_schedule_id"]);
                string doctorName = row["full_name"].ToString() ?? "";
                string specialty = row["specialty"].ToString() ?? "";
                decimal standardFee = Convert.ToDecimal(row["standard_fee"]);
                decimal followUpFee = Convert.ToDecimal(row["follow_up_fee"]);
                string scheduleDays = row["schedule_days"].ToString() ?? "";
                int isActive = Convert.ToInt32(row["is_active"]);
                string statusText = (isActive == 1) ? "Active" : "Inactive";
                string scheduleCode = "FEE-" + feeId;

                bool matchSpec = (selectedSpec == "ALL" || specialty == selectedSpec);
                bool matchStatus = (selectedStatus == "ALL" || statusText == selectedStatus);
                bool matchSearch = (search == "" ||
                    scheduleCode.ToLower().Contains(search) ||
                    doctorName.ToLower().Contains(search) ||
                    specialty.ToLower().Contains(search) ||
                    scheduleDays.ToLower().Contains(search));

                if (matchSpec && matchStatus && matchSearch)
                {
                    int rowIndex = dgvFeeSchedules.Rows.Add(
                        scheduleCode,
                        doctorName,
                        specialty,
                        "Consultation",
                        "₱" + standardFee.ToString("N2"),
                        "₱" + followUpFee.ToString("N2"),
                        scheduleDays,
                        statusText,
                        "Edit / Delete"
                    );

                    dgvFeeSchedules.Rows[rowIndex].Tag = feeId;
                }
            }

            lblShowingEntries.Text = "Showing " + dgvFeeSchedules.Rows.Count + " entries";
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void cmbSpecialization_SelectedIndexChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void cmbStatus_SelectedIndexChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void btnClearFilters_Click(object? sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSpecialization.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            filterData();
        }

        public void EditSelectedSchedule()
        {
            if (dgvFeeSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            int feeScheduleId = Convert.ToInt32(dgvFeeSchedules.SelectedRows[0].Tag);
            editSelectedSchedule(feeScheduleId);
        }

        public void DeleteSelectedSchedule()
        {
            if (dgvFeeSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int feeScheduleId = Convert.ToInt32(dgvFeeSchedules.SelectedRows[0].Tag);
            string physician = dgvFeeSchedules.SelectedRows[0].Cells["colPhysician"].Value?.ToString() ?? "";
            deleteSelectedSchedule(feeScheduleId, physician);
        }

        public void OpenAddFeeScheduleDialog()
        {
            List<string> doctorIds = new List<string>();
            List<string> doctorNames = new List<string>();

            if (!loadDoctorList(doctorIds, doctorNames))
            {
                return;
            }

            AddFeeScheduleForm form = new AddFeeScheduleForm(doctorIds, doctorNames);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DialogResult answer = MessageBox.Show(
                    "Do you want to save records?",
                    "Saving Records",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                saveFeeSchedule(false, 0, form.DoctorIdValue, form.StandardFeeValue, form.FollowUpFeeValue, form.ScheduleDaysValue);
            }
        }

        void editSelectedSchedule(int feeScheduleId)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader? reader = null;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM DoctorFeeSchedules WHERE fee_schedule_id = " + feeScheduleId;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string doctorId = reader["doctor_id"].ToString() ?? "";
                    string standardFee = reader["standard_fee"].ToString() ?? "0";
                    string followUpFee = reader["follow_up_fee"].ToString() ?? "0";
                    string scheduleDays = reader["schedule_days"].ToString() ?? "";

                    reader.Close();
                    conn.Close();

                    List<string> doctorIds = new List<string>();
                    List<string> doctorNames = new List<string>();

                    if (!loadDoctorList(doctorIds, doctorNames))
                    {
                        return;
                    }

                    AddFeeScheduleForm form = new AddFeeScheduleForm(doctorIds, doctorNames, doctorId, standardFee, followUpFee, scheduleDays);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult answer = MessageBox.Show(
                            "Do you want to save records?",
                            "Saving Records",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (answer == DialogResult.No)
                        {
                            return;
                        }

                        saveFeeSchedule(true, feeScheduleId, form.DoctorIdValue, form.StandardFeeValue, form.FollowUpFeeValue, form.ScheduleDaysValue);
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        bool loadDoctorList(List<string> doctorIds, List<string> doctorNames)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataReader? reader = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "SELECT user_id, full_name FROM Users WHERE role = 'Doctor' ORDER BY full_name ASC";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctorIds.Add(reader["user_id"].ToString() ?? "");
                    doctorNames.Add(reader["full_name"].ToString() ?? "");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
                return false;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            if (doctorIds.Count == 0)
            {
                MessageBox.Show("No Doctor accounts found in Users table.");
                return false;
            }

            return true;
        }

        void saveFeeSchedule(bool isEdit, int feeScheduleId, string doctorId, decimal standardFee, decimal followUpFee, string scheduleDays)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                string safeDocId = doctorId.Replace("'", "''");
                string safeDays = scheduleDays.Replace("'", "''");

                if (isEdit)
                {
                    cmd.CommandText = "UPDATE DoctorFeeSchedules SET " +
                        "standard_fee = " + standardFee + ", " +
                        "follow_up_fee = " + followUpFee + ", " +
                        "schedule_days = '" + safeDays + "' " +
                        "WHERE fee_schedule_id = " + feeScheduleId;
                }
                else
                {
                    cmd.CommandText = "INSERT INTO DoctorFeeSchedules (doctor_id, standard_fee, follow_up_fee, schedule_days) VALUES (" +
                        "'" + safeDocId + "', " +
                        standardFee + ", " +
                        followUpFee + ", " +
                        "'" + safeDays + "')";
                }

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("RECORD SAVE");
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

        void deleteSelectedSchedule(int feeScheduleId, string physician)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete the fee schedule for " + physician + "?",
                "Delete Record",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "DELETE FROM DoctorFeeSchedules WHERE fee_schedule_id = " + feeScheduleId;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();

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
    }
}
