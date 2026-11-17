using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class RnBManagement : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        DataTable dtBeds = new DataTable();

        public RnBManagement()
        {
            InitializeComponent();

            cmbRoomType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            colActions.Visible = false;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
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
                cmd.CommandText = "SELECT bed_id, room_number, bed_number, room_type, daily_rate, is_occupied FROM RoomsBeds ORDER BY room_number ASC, bed_number ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "RoomsBeds");
                conn.Close();

                if (ds.Tables["RoomsBeds"] != null)
                {
                    dtBeds = ds.Tables["RoomsBeds"]!;
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
            int total = 0;
            int available = 0;
            int occupied = 0;
            decimal totalRate = 0;

            foreach (DataRow row in dtBeds.Rows)
            {
                total++;
                int isOccupied = Convert.ToInt32(row["is_occupied"]);

                if (isOccupied == 1)
                {
                    occupied++;
                }
                else
                {
                    available++;
                }

                totalRate = totalRate + Convert.ToDecimal(row["daily_rate"]);
            }

            decimal avgRate = 0;
            if (total > 0)
            {
                avgRate = totalRate / total;
            }

            lblValTotalBeds.Text = total.ToString();
            lblValAvailBeds.Text = available.ToString();
            lblValOccupiedBeds.Text = occupied.ToString();
            lblValAvgRate.Text = "₱" + avgRate.ToString("N2");
        }

        string mapFilterRoomType(string selectedFilter)
        {
            if (selectedFilter == "Pediatric ICU (PICU)" || selectedFilter == "Neonatal ICU (NICU)")
            {
                return "ICU";
            }
            else if (selectedFilter == "Pediatric Ward")
            {
                return "Ward";
            }
            else if (selectedFilter == "Isolation Unit")
            {
                return "Semi-Private";
            }
            else if (selectedFilter == "Private Deluxe Suite")
            {
                return "Private";
            }

            return selectedFilter;
        }

        void filterData()
        {
            dgvRooms.Rows.Clear();

            string search = txtSearch.Text.Trim().ToLower();
            string selectedType = mapFilterRoomType(cmbRoomType.Text);
            string selectedStatus = cmbStatus.Text;

            foreach (DataRow row in dtBeds.Rows)
            {
                string bedId = row["bed_id"].ToString() ?? "";
                string roomNumber = row["room_number"].ToString() ?? "";
                string bedNumber = row["bed_number"].ToString() ?? "";
                string roomType = row["room_type"].ToString() ?? "";
                decimal dailyRate = Convert.ToDecimal(row["daily_rate"]);
                int isOccupied = Convert.ToInt32(row["is_occupied"]);
                string statusText = (isOccupied == 1) ? "Occupied" : "Available";

                bool matchType = (selectedType == "ALL" || roomType == selectedType);
                bool matchStatus = (selectedStatus == "ALL" || statusText == selectedStatus);
                bool matchSearch = (search == "" ||
                    roomNumber.ToLower().Contains(search) ||
                    roomType.ToLower().Contains(search) ||
                    bedId.ToLower().Contains(search) ||
                    bedNumber.ToLower().Contains(search));

                if (matchType && matchStatus && matchSearch)
                {
                    int rowIndex = dgvRooms.Rows.Add(
                        roomNumber,
                        roomType,
                        bedId + " (Bed " + bedNumber + ")",
                        "₱" + dailyRate.ToString("N2"),
                        statusText,
                        "Edit / Delete"
                    );

                    dgvRooms.Rows[rowIndex].Tag = bedId;
                }
            }

            lblShowingEntries.Text = "Showing: " + dgvRooms.Rows.Count + " entries";
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void cmbRoomType_SelectedIndexChanged(object? sender, EventArgs e)
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
            cmbRoomType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            filterData();
        }

        public void EditSelectedBed()
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            string bedId = dgvRooms.SelectedRows[0].Tag?.ToString() ?? "";
            editSelectedBed(bedId);
        }

        public void DeleteSelectedBed()
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string bedId = dgvRooms.SelectedRows[0].Tag?.ToString() ?? "";
            string roomNumber = dgvRooms.SelectedRows[0].Cells["colRoomNo"].Value?.ToString() ?? "";
            string currentStatus = dgvRooms.SelectedRows[0].Cells["colStatus"].Value?.ToString() ?? "";
            deleteSelectedBed(bedId, roomNumber, currentStatus);
        }

        public void OpenAddBedDialog()
        {
            AddRoomBedForm form = new AddRoomBedForm();
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

                saveBedRecord(false, form.BedIdValue, form.RoomNumberValue, form.BedNumberValue, form.RoomTypeValue, form.DailyRateValue, form.IsOccupiedValue);
            }
        }

        void editSelectedBed(string bedId)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader? reader = null;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM RoomsBeds WHERE bed_id = '" + bedId.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string roomNumber = reader["room_number"].ToString() ?? "";
                    string bedNumber = reader["bed_number"].ToString() ?? "";
                    string roomType = reader["room_type"].ToString() ?? "Ward";
                    string dailyRate = reader["daily_rate"].ToString() ?? "0";
                    int isOccupied = Convert.ToInt32(reader["is_occupied"]);

                    reader.Close();
                    conn.Close();

                    AddRoomBedForm form = new AddRoomBedForm(bedId, roomNumber, bedNumber, roomType, dailyRate, isOccupied);
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

                        saveBedRecord(true, form.BedIdValue, form.RoomNumberValue, form.BedNumberValue, form.RoomTypeValue, form.DailyRateValue, form.IsOccupiedValue);
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

        void saveBedRecord(bool isEdit, string bedId, string roomNumber, string bedNumber, string roomType, decimal dailyRate, int isOccupied)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                string safeBedId = bedId.Replace("'", "''");
                string safeRoomNo = roomNumber.Replace("'", "''");
                string safeBedNo = bedNumber.Replace("'", "''");
                string safeType = roomType.Replace("'", "''");

                if (isEdit)
                {
                    cmd.CommandText = "UPDATE RoomsBeds SET " +
                        "room_number = '" + safeRoomNo + "', " +
                        "bed_number = '" + safeBedNo + "', " +
                        "room_type = '" + safeType + "', " +
                        "daily_rate = " + dailyRate + ", " +
                        "is_occupied = " + isOccupied + " " +
                        "WHERE bed_id = '" + safeBedId + "'";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO RoomsBeds (bed_id, room_number, bed_number, room_type, daily_rate, is_occupied) VALUES (" +
                        "'" + safeBedId + "', " +
                        "'" + safeRoomNo + "', " +
                        "'" + safeBedNo + "', " +
                        "'" + safeType + "', " +
                        dailyRate + ", " +
                        isOccupied + ")";
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

        void deleteSelectedBed(string bedId, string roomNumber, string currentStatus)
        {
            if (currentStatus == "Occupied")
            {
                MessageBox.Show("Cannot delete an Occupied bed.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete Bed " + bedId + " in Room " + roomNumber + "?",
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
                cmd.CommandText = "DELETE FROM RoomsBeds WHERE bed_id = '" + bedId.Replace("'", "''") + "'";
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
