using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class MedCatalog : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

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
                cmd.CommandText = "SELECT medicine_code AS 'Code', name AS 'Medicine Name', dosage_unit AS 'Dosage Unit', category AS 'Category', unit_price AS 'Unit Price', stock_quantity AS 'Stock', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM MedicineCatalog ORDER BY name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "abc");
                dgvMedicines.DataSource = ds;
                dgvMedicines.DataMember = "abc";
                conn.Close();

                lblShowingEntries.Text = "Showing " + dgvMedicines.Rows.Count + " entries";
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
            int oralLiquids = 0;
            decimal totalPrice = 0;

            foreach (DataRow row in dt.Rows)
            {
                total++;
                string status = row["Status"].ToString();
                if (status == "Active")
                {
                    active++;
                }

                string dosage = row["Dosage Unit"].ToString().ToLower();
                string category = row["Category"].ToString().ToLower();
                if (dosage.IndexOf("bottle") >= 0 || dosage.IndexOf("syrup") >= 0 || dosage.IndexOf("suspension") >= 0 || category.IndexOf("liquid") >= 0)
                {
                    oralLiquids++;
                }

                totalPrice = totalPrice + Convert.ToDecimal(row["Unit Price"]);
            }

            decimal avgPrice = 0;
            if (total > 0)
            {
                avgPrice = totalPrice / total;
            }

            lblValCatalogedMeds.Text = total.ToString();
            lblValActiveFormulary.Text = active.ToString();
            lblValOralLiquids.Text = oralLiquids.ToString();
            lblValAvgUnitPrice.Text = "₱" + avgPrice.ToString("N2");
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
                cmd.CommandText = "SELECT medicine_code AS 'Code', name AS 'Medicine Name', dosage_unit AS 'Dosage Unit', category AS 'Category', unit_price AS 'Unit Price', stock_quantity AS 'Stock', CASE WHEN is_active = 1 THEN 'Active' ELSE 'Inactive' END AS 'Status' FROM MedicineCatalog WHERE medicine_code LIKE @search OR name LIKE @search OR category LIKE @search OR dosage_unit LIKE @search ORDER BY name ASC";
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
                cmbStatus.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
