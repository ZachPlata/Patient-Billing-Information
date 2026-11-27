using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class DoctorSpecialties : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";

        public DoctorSpecialties()
        {
            InitializeComponent();
            createTableIfMissing();
            clearFields();
            loaddata();
        }

        void createTableIfMissing()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS DoctorSpecialties (" +
                                  "specialty_id INT NOT NULL AUTO_INCREMENT, " +
                                  "specialty_name VARCHAR(100) NOT NULL, " +
                                  "description VARCHAR(255) DEFAULT NULL, " +
                                  "is_active TINYINT(1) NOT NULL DEFAULT 1, " +
                                  "PRIMARY KEY (specialty_id), " +
                                  "UNIQUE KEY uq_specialty_name (specialty_name))";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
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

        void loaddata()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT specialty_id AS 'ID', specialty_name AS 'Specialty Name', description AS 'Description', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM DoctorSpecialties ORDER BY specialty_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvSpecialties.DataSource = ds;
                dgvSpecialties.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvSpecialties.Rows.Count + " entries";
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
            int active = 0;
            int inactive = 0;

            foreach (DataRow row in dt.Rows)
            {
                total++;
                string status = row["Status"].ToString();
                if (status == "Active")
                {
                    active++;
                }
                else
                {
                    inactive++;
                }
            }

            lblValTotalSpecs.Text = total.ToString();
            lblValActiveSpecs.Text = active.ToString();
            lblValInactiveSpecs.Text = inactive.ToString();
            lblValAssignedDoctors.Text = getAssignedDoctorCount().ToString();
        }

        int getAssignedDoctorCount()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE role = 'Doctor' AND specialty IS NOT NULL AND specialty <> ''";
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
            txtSpecialtyId.Clear();
            txtSpecialtyName.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = 0;
            txtSpecialtyName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSpecialtyName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Specialty Name.");
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

            int isActive = 0;
            if (cmbStatus.Text == "Active")
            {
                isActive = 1;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO DoctorSpecialties (specialty_name, description, is_active) VALUES (@specialty_name, @description, @is_active)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@specialty_name", txtSpecialtyName.Text.Trim());
                cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@is_active", isActive);
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
            if (txtSpecialtyId.Text.Trim() == "" || txtSpecialtyName.Text.Trim() == "")
            {
                MessageBox.Show("Please select a record from the table first.");
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

            int isActive = 0;
            if (cmbStatus.Text == "Active")
            {
                isActive = 1;
            }

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = "UPDATE DoctorSpecialties SET specialty_name = @specialty_name, description = @description, is_active = @is_active WHERE specialty_id = @specialty_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@specialty_id", Convert.ToInt32(txtSpecialtyId.Text.Trim()));
                cmd.Parameters.AddWithValue("@specialty_name", txtSpecialtyName.Text.Trim());
                cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@is_active", isActive);
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
            if (txtSpecialtyId.Text.Trim() == "")
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
                cmd.CommandText = "DELETE FROM DoctorSpecialties WHERE specialty_id = @specialty_id";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@specialty_id", Convert.ToInt32(txtSpecialtyId.Text.Trim()));
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
                cmd.CommandText = "SELECT specialty_id AS 'ID', specialty_name AS 'Specialty Name', description AS 'Description', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM DoctorSpecialties WHERE specialty_name LIKE @search OR description LIKE @search ORDER BY specialty_name ASC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvSpecialties.DataSource = ds;
                dgvSpecialties.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvSpecialties.Rows.Count + " entries";
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

        private void dgvSpecialties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSpecialties.Rows.Count)
            {
                DataGridViewRow row = dgvSpecialties.Rows[e.RowIndex];
                txtSpecialtyId.Text = row.Cells[0].Value.ToString();
                txtSpecialtyName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                cmbStatus.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
