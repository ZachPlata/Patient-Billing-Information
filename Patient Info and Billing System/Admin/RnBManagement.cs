using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class RnBManagement : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";

        public RnBManagement()
        {
            InitializeComponent();
            clearFields();
            loaddata();
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
                cmd.CommandText = "SELECT bed_id AS 'Bed ID', room_number AS 'Room #', bed_number AS 'Bed #', room_type AS 'Room Type', daily_rate AS 'Daily Rate', CASE WHEN is_occupied = 1 THEN 'Occupied' ELSE 'Available' END AS 'Status' FROM RoomsBeds ORDER BY room_number ASC, bed_number ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvRooms.DataSource = ds;
                dgvRooms.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing: " + dgvRooms.Rows.Count + " entries";
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

            int total = 0;
            int available = 0;
            int occupied = 0;
            decimal totalRate = 0;

            foreach (DataRow row in dt.Rows)
            {
                total++;
                string status = row["Status"].ToString();
                if (status == "Occupied")
                {
                    occupied++;
                }
                else
                {
                    available++;
                }

                totalRate = totalRate + Convert.ToDecimal(row["Daily Rate"]);
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

        void clearFields()
        {
            txtBedId.Clear();
            txtBedId.ReadOnly = false;
            txtRoomNumber.Clear();
            txtBedNumber.Clear();
            cmbRoomType.SelectedIndex = 0;
            txtDailyRate.Text = "1000.00";
            cmbStatus.SelectedIndex = 0;
            txtBedId.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBedId.Text.Trim() == "" || txtRoomNumber.Text.Trim() == "" || txtBedNumber.Text.Trim() == "" || txtDailyRate.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            decimal rateValue = 0;
            if (!decimal.TryParse(txtDailyRate.Text.Trim(), out rateValue) || rateValue < 0)
            {
                MessageBox.Show("Please enter a valid Daily Rate.");
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

            int isOccupied = 0;
            if (cmbStatus.Text == "Occupied")
            {
                isOccupied = 1;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO RoomsBeds (bed_id, room_number, bed_number, room_type, daily_rate, is_occupied) VALUES (@bed_id, @room_number, @bed_number, @room_type, @daily_rate, @is_occupied)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@bed_id", txtBedId.Text.Trim());
                cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@bed_number", txtBedNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@room_type", cmbRoomType.Text);
                cmd.Parameters.AddWithValue("@daily_rate", rateValue);
                cmd.Parameters.AddWithValue("@is_occupied", isOccupied);
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
            if (txtBedId.Text.Trim() == "" || txtRoomNumber.Text.Trim() == "" || txtBedNumber.Text.Trim() == "" || txtDailyRate.Text.Trim() == "")
            {
                MessageBox.Show("Please select a record from the table first.");
                return;
            }

            decimal rateValue = 0;
            if (!decimal.TryParse(txtDailyRate.Text.Trim(), out rateValue) || rateValue < 0)
            {
                MessageBox.Show("Please enter a valid Daily Rate.");
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

            int isOccupied = 0;
            if (cmbStatus.Text == "Occupied")
            {
                isOccupied = 1;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "UPDATE RoomsBeds SET room_number = @room_number, bed_number = @bed_number, room_type = @room_type, daily_rate = @daily_rate, is_occupied = @is_occupied WHERE bed_id = @bed_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@bed_id", txtBedId.Text.Trim());
                cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@bed_number", txtBedNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@room_type", cmbRoomType.Text);
                cmd.Parameters.AddWithValue("@daily_rate", rateValue);
                cmd.Parameters.AddWithValue("@is_occupied", isOccupied);
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
            if (txtBedId.Text.Trim() == "")
            {
                MessageBox.Show("Please select a record to delete.");
                return;
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
                cmd.CommandText = "DELETE FROM RoomsBeds WHERE bed_id = @bed_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@bed_id", txtBedId.Text.Trim());
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
            clearFields();
            loaddata();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT bed_id AS 'Bed ID', room_number AS 'Room #', bed_number AS 'Bed #', room_type AS 'Room Type', daily_rate AS 'Daily Rate', CASE WHEN is_occupied = 1 THEN 'Occupied' ELSE 'Available' END AS 'Status' FROM RoomsBeds WHERE bed_id LIKE @search OR room_number LIKE @search OR room_type LIKE @search ORDER BY room_number ASC, bed_number ASC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvRooms.DataSource = ds;
                dgvRooms.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing: " + dgvRooms.Rows.Count + " entries";
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

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRooms.Rows.Count)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                txtBedId.Text = row.Cells[0].Value.ToString();
                txtBedId.ReadOnly = true;
                txtRoomNumber.Text = row.Cells[1].Value.ToString();
                txtBedNumber.Text = row.Cells[2].Value.ToString();
                cmbRoomType.Text = row.Cells[3].Value.ToString();
                txtDailyRate.Text = row.Cells[4].Value.ToString();
                cmbStatus.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
