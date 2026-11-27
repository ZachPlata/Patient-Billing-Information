using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class MedCatalog : UserControl
    {
        string connStr = "server=localhost; database=patientbillingdb; uid=root";

        public MedCatalog()
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
                cmd.CommandText = "SELECT medicine_code, name, dosage_unit, category, unit_price, stock_quantity, is_active FROM MedicineCatalog ORDER BY name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvMedicines.DataSource = ds;
                dgvMedicines.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvMedicines.Rows.Count + " entries";
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

                cmd.CommandText = "SELECT COUNT(*) FROM MedicineCatalog";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValCatalogedMeds.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM MedicineCatalog WHERE is_active = 1";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValActiveFormulary.Text = reader[0].ToString();
                }
                reader.Close();

                cmd.CommandText = "SELECT COUNT(*) FROM MedicineCatalog WHERE dosage_unit LIKE '%bottle%' OR dosage_unit LIKE '%syrup%' OR dosage_unit LIKE '%suspension%' OR category LIKE '%liquid%'";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblValOralLiquids.Text = reader[0].ToString();
                }
                reader.Close();

                decimal avgPrice = 0;
                cmd.CommandText = "SELECT AVG(unit_price) FROM MedicineCatalog";
                reader = cmd.ExecuteReader();
                if (reader.Read() && reader[0] != DBNull.Value)
                {
                    avgPrice = Convert.ToDecimal(reader[0]);
                }
                reader.Close();
                lblValAvgUnitPrice.Text = "₱" + avgPrice.ToString("N2");

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
            txtMedCode.Clear();
            txtMedCode.ReadOnly = false;
            txtMedName.Clear();
            txtDosageUnit.Text = "Per Bottle";
            txtCategory.Text = "Analgesic";
            txtUnitPrice.Text = "100.00";
            txtStockQty.Text = "50";
            cmbStatus.SelectedIndex = 0;
            txtMedCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtMedCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMedCode, "Medicine Code is required.");
                txtMedCode.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtMedName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMedName, "Medicine Name is required.");
                txtMedName.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtDosageUnit.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDosageUnit, "Dosage Unit is required.");
                txtDosageUnit.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtCategory.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCategory, "Category is required.");
                txtCategory.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal priceValue = 0;
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out priceValue) || priceValue < 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Please enter a valid non-negative Price.");
                txtUnitPrice.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            int stockValue = 0;
            if (!int.TryParse(txtStockQty.Text.Trim(), out stockValue) || stockValue < 0)
            {
                errorProvider1.SetError(txtStockQty, "Please enter a valid non-negative Stock Quantity.");
                txtStockQty.Focus();
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
                cmd.CommandText = "INSERT INTO MedicineCatalog (medicine_code, name, dosage_unit, category, unit_price, stock_quantity, is_active) VALUES (@medicine_code, @name, @dosage_unit, @category, @unit_price, @stock_quantity, @is_active)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@medicine_code", txtMedCode.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtMedName.Text.Trim());
                cmd.Parameters.AddWithValue("@dosage_unit", txtDosageUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@unit_price", priceValue);
                cmd.Parameters.AddWithValue("@stock_quantity", stockValue);
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

            if (txtMedCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMedCode, "Please select a record from the table first.");
                txtMedCode.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtMedName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMedName, "Medicine Name is required.");
                txtMedName.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtDosageUnit.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDosageUnit, "Dosage Unit is required.");
                txtDosageUnit.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtCategory.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCategory, "Category is required.");
                txtCategory.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            decimal priceValue = 0;
            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out priceValue) || priceValue < 0)
            {
                errorProvider1.SetError(txtUnitPrice, "Please enter a valid non-negative Price.");
                txtUnitPrice.Focus();
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            int stockValue = 0;
            if (!int.TryParse(txtStockQty.Text.Trim(), out stockValue) || stockValue < 0)
            {
                errorProvider1.SetError(txtStockQty, "Please enter a valid non-negative Stock Quantity.");
                txtStockQty.Focus();
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
                cmd.CommandText = "UPDATE MedicineCatalog SET name = @name, dosage_unit = @dosage_unit, category = @category, unit_price = @unit_price, stock_quantity = @stock_quantity, is_active = @is_active WHERE medicine_code = @medicine_code";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@medicine_code", txtMedCode.Text.Trim());
                cmd.Parameters.AddWithValue("@name", txtMedName.Text.Trim());
                cmd.Parameters.AddWithValue("@dosage_unit", txtDosageUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@unit_price", priceValue);
                cmd.Parameters.AddWithValue("@stock_quantity", stockValue);
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

            if (txtMedCode.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMedCode, "Please select a record to delete.");
                txtMedCode.Focus();
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
                cmd.CommandText = "DELETE FROM MedicineCatalog WHERE medicine_code = @medicine_code";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@medicine_code", txtMedCode.Text.Trim());
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
                cmd.CommandText = "SELECT medicine_code, name, dosage_unit, category, unit_price, stock_quantity, is_active FROM MedicineCatalog WHERE medicine_code LIKE @search OR name LIKE @search OR category LIKE @search OR dosage_unit LIKE @search ORDER BY name ASC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvMedicines.DataSource = ds;
                dgvMedicines.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvMedicines.Rows.Count + " entries";
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

        private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMedicines.Rows.Count)
            {
                DataGridViewRow row = dgvMedicines.Rows[e.RowIndex];
                txtMedCode.Text = row.Cells[0].Value.ToString();
                txtMedCode.ReadOnly = true;
                txtMedName.Text = row.Cells[1].Value.ToString();
                txtDosageUnit.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[3].Value.ToString();
                txtUnitPrice.Text = row.Cells[4].Value.ToString();
                txtStockQty.Text = row.Cells[5].Value.ToString();
                string activeVal = row.Cells[6].Value.ToString();
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
