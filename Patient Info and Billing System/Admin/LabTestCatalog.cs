using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class LabTestCatalog : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        DataTable dtLabTests = new DataTable();

        public LabTestCatalog()
        {
            InitializeComponent();

            cmbDepartment.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            colActions.Visible = false;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            btnClearFilters.Click += btnClearFilters_Click;

            loaddata();
        }

        private void lblValAvgTurnaround_Click(object? sender, EventArgs e)
        {

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
                cmd.CommandText = "SELECT test_code, test_name, category, price, turnaround_time, is_active FROM LabTestCatalog ORDER BY test_name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "LabTestCatalog");
                conn.Close();

                if (ds.Tables["LabTestCatalog"] != null)
                {
                    dtLabTests = ds.Tables["LabTestCatalog"]!;
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
            int active = 0;
            decimal totalPrice = 0;

            foreach (DataRow row in dtLabTests.Rows)
            {
                total++;
                int isActive = Convert.ToInt32(row["is_active"]);
                if (isActive == 1)
                {
                    active++;
                }

                totalPrice = totalPrice + Convert.ToDecimal(row["price"]);
            }

            decimal avgPrice = 0;
            if (total > 0)
            {
                avgPrice = totalPrice / total;
            }

            lblValCatalogedTests.Text = total.ToString();
            lblValActivePanels.Text = active.ToString();
            lblValAvgTurnaround.Text = total > 0 ? (dtLabTests.Rows[0]["turnaround_time"].ToString() ?? "~ 0 Hrs") : "~ 0 Hrs";
            lblValAvgTariff.Text = "₱" + avgPrice.ToString("N2");
        }

        void filterData()
        {
            dgvLabTests.Rows.Clear();

            string search = txtSearch.Text.Trim().ToLower();
            string selectedDept = cmbDepartment.Text;
            string selectedStatus = cmbStatus.Text;

            foreach (DataRow row in dtLabTests.Rows)
            {
                string testCode = row["test_code"].ToString() ?? "";
                string testName = row["test_name"].ToString() ?? "";
                string category = row["category"].ToString() ?? "";
                decimal price = Convert.ToDecimal(row["price"]);
                string turnaround = row["turnaround_time"].ToString() ?? "";
                int isActive = Convert.ToInt32(row["is_active"]);
                string statusText = (isActive == 1) ? "Active" : "Inactive";

                bool matchDept = (selectedDept == "ALL" || category == selectedDept);
                bool matchStatus = (selectedStatus == "ALL" || statusText == selectedStatus);
                bool matchSearch = (search == "" ||
                    testCode.ToLower().Contains(search) ||
                    testName.ToLower().Contains(search) ||
                    category.ToLower().Contains(search));

                if (matchDept && matchStatus && matchSearch)
                {
                    int rowIndex = dgvLabTests.Rows.Add(
                        testCode,
                        testName,
                        category,
                        turnaround,
                        "₱" + price.ToString("N2"),
                        "Standard",
                        statusText,
                        "Edit / Delete"
                    );

                    dgvLabTests.Rows[rowIndex].Tag = testCode;
                }
            }

            lblShowingEntries.Text = "Showing: " + dgvLabTests.Rows.Count + " entries";
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void cmbDepartment_SelectedIndexChanged(object? sender, EventArgs e)
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
            cmbDepartment.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            filterData();
        }

        public void EditSelectedLabTest()
        {
            if (dgvLabTests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            string testCode = dgvLabTests.SelectedRows[0].Tag?.ToString() ?? "";
            editSelectedLabTest(testCode);
        }

        public void DeleteSelectedLabTest()
        {
            if (dgvLabTests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string testCode = dgvLabTests.SelectedRows[0].Tag?.ToString() ?? "";
            string testName = dgvLabTests.SelectedRows[0].Cells["colTestName"].Value?.ToString() ?? "";
            deleteSelectedLabTest(testCode, testName);
        }

        public void OpenAddLabTestDialog()
        {
            AddLabTestForm form = new AddLabTestForm();
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

                saveLabTestRecord(false, form.TestCodeValue, form.TestNameValue, form.CategoryValue, form.PriceValue, form.TurnaroundValue, form.IsActiveValue);
            }
        }

        void editSelectedLabTest(string testCode)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader? reader = null;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM LabTestCatalog WHERE test_code = '" + testCode.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string testName = reader["test_name"].ToString() ?? "";
                    string category = reader["category"].ToString() ?? "Hematology";
                    string price = reader["price"].ToString() ?? "0";
                    string turnaround = reader["turnaround_time"].ToString() ?? "";
                    int isActive = Convert.ToInt32(reader["is_active"]);

                    reader.Close();
                    conn.Close();

                    AddLabTestForm form = new AddLabTestForm(testCode, testName, category, price, turnaround, isActive);
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

                        saveLabTestRecord(true, form.TestCodeValue, form.TestNameValue, form.CategoryValue, form.PriceValue, form.TurnaroundValue, form.IsActiveValue);
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

        void saveLabTestRecord(bool isEdit, string testCode, string testName, string category, decimal price, string turnaround, int isActive)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                string safeCode = testCode.Replace("'", "''");
                string safeName = testName.Replace("'", "''");
                string safeCat = category.Replace("'", "''");
                string safeTat = turnaround.Replace("'", "''");

                if (isEdit)
                {
                    cmd.CommandText = "UPDATE LabTestCatalog SET " +
                        "test_name = '" + safeName + "', " +
                        "category = '" + safeCat + "', " +
                        "price = " + price + ", " +
                        "turnaround_time = '" + safeTat + "', " +
                        "is_active = " + isActive + " " +
                        "WHERE test_code = '" + safeCode + "'";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO LabTestCatalog (test_code, test_name, category, price, turnaround_time, is_active) VALUES (" +
                        "'" + safeCode + "', " +
                        "'" + safeName + "', " +
                        "'" + safeCat + "', " +
                        price + ", " +
                        "'" + safeTat + "', " +
                        isActive + ")";
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

        void deleteSelectedLabTest(string testCode, string testName)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete Lab Test " + testName + " (" + testCode + ")?",
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
                cmd.CommandText = "DELETE FROM LabTestCatalog WHERE test_code = '" + testCode.Replace("'", "''") + "'";
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
