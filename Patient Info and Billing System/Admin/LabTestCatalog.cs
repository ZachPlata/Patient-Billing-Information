using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class LabTestCatalog : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";

        public LabTestCatalog()
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
                cmd.CommandText = "SELECT test_code AS 'Test Code', test_name AS 'Test Name', category AS 'Department', price AS 'Price', turnaround_time AS 'Turnaround', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM LabTestCatalog ORDER BY test_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvLabTests.DataSource = ds;
                dgvLabTests.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing: " + dgvLabTests.Rows.Count + " entries";
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
            decimal totalPrice = 0;

            foreach (DataRow row in dt.Rows)
            {
                total++;
                string status = row["Status"].ToString();
                if (status == "Active")
                {
                    active++;
                }

                totalPrice = totalPrice + Convert.ToDecimal(row["Price"]);
            }

            decimal avgPrice = 0;
            if (total > 0)
            {
                avgPrice = totalPrice / total;
            }

            lblValCatalogedTests.Text = total.ToString();
            lblValActivePanels.Text = active.ToString();
            if (total > 0)
            {
                lblValAvgTurnaround.Text = dt.Rows[0]["Turnaround"].ToString();
            }
            else
            {
                lblValAvgTurnaround.Text = "~ 0 Hrs";
            }
            lblValAvgTariff.Text = "₱" + avgPrice.ToString("N2");
        }

        void clearFields()
        {
            errorProvider1.Clear();
            txtTestCode.Clear();
            txtTestCode.ReadOnly = false;
            txtTestName.Clear();
            cmbDepartment.SelectedIndex = 0;
            txtPrice.Text = "500.00";
            txtTurnaround.Text = "2 Hours";
            cmbStatus.SelectedIndex = 0;
            txtTestCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtTestCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTestCode, "Test Code is required.");
                txtTestCode.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTestName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTestName, "Test Name is required.");
                txtTestName.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cmbDepartment.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbDepartment, "Department is required.");
                cmbDepartment.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal priceValue = 0;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out priceValue) || priceValue < 0)
            {
                errorProvider1.SetError(txtPrice, "Please enter a valid Price.");
                txtPrice.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTurnaround.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTurnaround, "Turnaround Time is required.");
                txtTurnaround.Focus();
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
                cmd.CommandText = "INSERT INTO LabTestCatalog (test_code, test_name, category, price, turnaround_time, is_active) VALUES (@test_code, @test_name, @category, @price, @turnaround_time, @is_active)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@test_code", txtTestCode.Text.Trim());
                cmd.Parameters.AddWithValue("@test_name", txtTestName.Text.Trim());
                cmd.Parameters.AddWithValue("@category", cmbDepartment.Text.Trim());
                cmd.Parameters.AddWithValue("@price", priceValue);
                cmd.Parameters.AddWithValue("@turnaround_time", txtTurnaround.Text.Trim());
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

            if (txtTestCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTestCode, "Please select a record from the table first.");
                txtTestCode.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTestName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTestName, "Test Name is required.");
                txtTestName.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cmbDepartment.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbDepartment, "Department is required.");
                cmbDepartment.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal priceValue = 0;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out priceValue) || priceValue < 0)
            {
                errorProvider1.SetError(txtPrice, "Please enter a valid Price.");
                txtPrice.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtTurnaround.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTurnaround, "Turnaround Time is required.");
                txtTurnaround.Focus();
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
                cmd.CommandText = "UPDATE LabTestCatalog SET test_name = @test_name, category = @category, price = @price, turnaround_time = @turnaround_time, is_active = @is_active WHERE test_code = @test_code";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@test_code", txtTestCode.Text.Trim());
                cmd.Parameters.AddWithValue("@test_name", txtTestName.Text.Trim());
                cmd.Parameters.AddWithValue("@category", cmbDepartment.Text.Trim());
                cmd.Parameters.AddWithValue("@price", priceValue);
                cmd.Parameters.AddWithValue("@turnaround_time", txtTurnaround.Text.Trim());
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

            if (txtTestCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTestCode, "Please select a record to delete.");
                txtTestCode.Focus();
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
                cmd.CommandText = "DELETE FROM LabTestCatalog WHERE test_code = @test_code";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@test_code", txtTestCode.Text.Trim());
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
                cmd.CommandText = "SELECT test_code AS 'Test Code', test_name AS 'Test Name', category AS 'Department', price AS 'Price', turnaround_time AS 'Turnaround', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM LabTestCatalog WHERE test_code LIKE @search OR test_name LIKE @search OR category LIKE @search ORDER BY test_name ASC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvLabTests.DataSource = ds;
                dgvLabTests.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing: " + dgvLabTests.Rows.Count + " entries";
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

        private void dgvLabTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLabTests.Rows.Count)
            {
                DataGridViewRow row = dgvLabTests.Rows[e.RowIndex];
                txtTestCode.Text = row.Cells[0].Value.ToString();
                txtTestCode.ReadOnly = true;
                txtTestName.Text = row.Cells[1].Value.ToString();
                cmbDepartment.Text = row.Cells[2].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtTurnaround.Text = row.Cells[4].Value.ToString();
                cmbStatus.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
