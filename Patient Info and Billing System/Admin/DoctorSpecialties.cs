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
                cmd.CommandText = "SELECT specialty_id, specialty_name, description, is_active FROM DoctorSpecialties ORDER BY specialty_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvSpecialties.DataSource = ds;
                dgvSpecialties.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvSpecialties.Rows.Count + " entries";
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

                cmd.CommandText = "SELECT COUNT(*) FROM DoctorSpecialties";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValTotalSpecs.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM DoctorSpecialties WHERE is_active = 1";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValActiveSpecs.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM DoctorSpecialties WHERE is_active = 0";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValInactiveSpecs.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE role = 'Doctor' AND specialty IS NOT NULL AND specialty <> ''";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValAssignedDoctors.Text = reader[0].ToString();
                }
                reader.Close();

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
            txtSpecialtyId.Clear();
            txtSpecialtyName.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = 0;
            txtSpecialtyName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtSpecialtyName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSpecialtyName, "Specialty Name is required.");
                txtSpecialtyName.Focus();
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
            errorProvider1.Clear();

            if (txtSpecialtyId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSpecialtyId, "Please select a record from the table first.");
                txtSpecialtyId.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtSpecialtyName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSpecialtyName, "Specialty Name is required.");
                txtSpecialtyName.Focus();
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
            errorProvider1.Clear();

            if (txtSpecialtyId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSpecialtyId, "Please select a record to delete.");
                txtSpecialtyId.Focus();
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
                cmd.CommandText = "SELECT specialty_id, specialty_name, description, is_active FROM DoctorSpecialties WHERE specialty_name LIKE @search OR description LIKE @search ORDER BY specialty_name ASC";
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
                string activeVal = row.Cells[3].Value.ToString();
                if (activeVal == "1" || activeVal == "True")
                {
                    cmbStatus.Text = "Active";
                }
                else
                {
                    cmbStatus.Text = "Inactive";
                }
            }
        }
    }
}
