using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class RnBManagement : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

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
                cmd.CommandText = "SELECT bed_id, room_number, bed_number, room_type, daily_rate, is_occupied FROM RoomsBeds ORDER BY room_number ASC, bed_number ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvRooms.DataSource = ds;
                dgvRooms.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing: " + dgvRooms.Rows.Count + " entries";
                updateCards();
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
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            try
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT COUNT(*) FROM RoomsBeds";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValTotalBeds.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM RoomsBeds WHERE is_occupied = 0";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValAvailBeds.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM RoomsBeds WHERE is_occupied = 1";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValOccupiedBeds.Text = reader[0].ToString();
                }
                reader.Close();

                decimal avgRate = 0;
                cmd.CommandText = "SELECT AVG(daily_rate) FROM RoomsBeds";
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader[0] != DBNull.Value)
                {
                    avgRate = Convert.ToDecimal(reader[0]);
                }
                reader.Close();
                lblValAvgRate.Text = "₱" + avgRate.ToString("N2");

                conn.Close();
            }
            catch
            {
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
            errorProvider1.Clear();

            if (txtBedId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBedId, "Bed ID is required.");
                txtBedId.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtRoomNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txtRoomNumber, "Room Number is required.");
                txtRoomNumber.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtBedNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBedNumber, "Bed Number is required.");
                txtBedNumber.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal rateValue = 0;
            if (!decimal.TryParse(txtDailyRate.Text.Trim(), out rateValue) || rateValue < 0)
            {
                errorProvider1.SetError(txtDailyRate, "Please enter a valid Daily Rate.");
                txtDailyRate.Focus();
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
            errorProvider1.Clear();

            if (txtBedId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBedId, "Please select a record from the table first.");
                txtBedId.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtRoomNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txtRoomNumber, "Room Number is required.");
                txtRoomNumber.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtBedNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBedNumber, "Bed Number is required.");
                txtBedNumber.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal rateValue = 0;
            if (!decimal.TryParse(txtDailyRate.Text.Trim(), out rateValue) || rateValue < 0)
            {
                errorProvider1.SetError(txtDailyRate, "Please enter a valid Daily Rate.");
                txtDailyRate.Focus();
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
            errorProvider1.Clear();

            if (txtBedId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtBedId, "Please select a record to delete.");
                txtBedId.Focus();
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
                cmd.CommandText = "SELECT bed_id, room_number, bed_number, room_type, daily_rate, is_occupied FROM RoomsBeds WHERE bed_id LIKE @search OR room_number LIKE @search OR room_type LIKE @search ORDER BY room_number ASC, bed_number ASC";
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
                string occVal = row.Cells[5].Value.ToString();
                if (occVal == "1" || occVal == "True")
                {
                    cmbStatus.Text = "Occupied";
                }
                else
                {
                    cmbStatus.Text = "Available";
                }
            }
        }
    }
}
