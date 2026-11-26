using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class MedCatalog : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";
        DataTable dtMedicines = new DataTable();

        public MedCatalog()
        {
            InitializeComponent();

            cmbPackagingUnit.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            colActions.Visible = false;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbPackagingUnit.SelectedIndexChanged += cmbPackagingUnit_SelectedIndexChanged;
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
                cmd.CommandText = "SELECT medicine_code, name, dosage_unit, category, unit_price, stock_quantity, is_active FROM MedicineCatalog ORDER BY name ASC";
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(ds, "MedicineCatalog");
                conn.Close();

                if (ds.Tables["MedicineCatalog"] != null)
                {
                    dtMedicines = ds.Tables["MedicineCatalog"]!;
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
            int oralLiquids = 0;
            decimal totalPrice = 0;

            foreach (DataRow row in dtMedicines.Rows)
            {
                total++;
                int isActive = Convert.ToInt32(row["is_active"]);
                if (isActive == 1)
                {
                    active++;
                }

                string dosage = (row["dosage_unit"].ToString() ?? "").ToLower();
                string category = (row["category"].ToString() ?? "").ToLower();
                if (dosage.Contains("bottle") || dosage.Contains("syrup") || dosage.Contains("suspension") || category.Contains("liquid"))
                {
                    oralLiquids++;
                }

                totalPrice = totalPrice + Convert.ToDecimal(row["unit_price"]);
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

        void filterData()
        {
            dgvMedicines.Rows.Clear();

            string search = txtSearch.Text.Trim().ToLower();
            string selectedUnit = cmbPackagingUnit.Text;
            string selectedStatus = cmbStatus.Text;

            foreach (DataRow row in dtMedicines.Rows)
            {
                string medCode = row["medicine_code"].ToString() ?? "";
                string medName = row["name"].ToString() ?? "";
                string dosageUnit = row["dosage_unit"].ToString() ?? "";
                string category = row["category"].ToString() ?? "";
                decimal unitPrice = Convert.ToDecimal(row["unit_price"]);
                int stockQty = Convert.ToInt32(row["stock_quantity"]);
                int isActive = Convert.ToInt32(row["is_active"]);
                string statusText = (isActive == 1) ? "Active" : "Inactive";

                bool matchUnit = (selectedUnit == "ALL" ||
                    dosageUnit.ToLower().Contains(selectedUnit.Replace("Per ", "").ToLower()) ||
                    category == selectedUnit);
                bool matchStatus = (selectedStatus == "ALL" || statusText == selectedStatus);
                bool matchSearch = (search == "" ||
                    medCode.ToLower().Contains(search) ||
                    medName.ToLower().Contains(search) ||
                    category.ToLower().Contains(search) ||
                    dosageUnit.ToLower().Contains(search));

                if (matchUnit && matchStatus && matchSearch)
                {
                    int rowIndex = dgvMedicines.Rows.Add(
                        medCode,
                        medName,
                        category,
                        dosageUnit,
                        "Stock: " + stockQty,
                        "₱" + unitPrice.ToString("N2"),
                        statusText,
                        "Edit / Delete"
                    );

                    dgvMedicines.Rows[rowIndex].Tag = medCode;
                }
            }

            lblShowingEntries.Text = "Showing " + dgvMedicines.Rows.Count + " entries";
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            filterData();
        }

        private void cmbPackagingUnit_SelectedIndexChanged(object? sender, EventArgs e)
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
            cmbPackagingUnit.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            filterData();
        }

        public void EditSelectedMedicine()
        {
            if (dgvMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            string medCode = dgvMedicines.SelectedRows[0].Tag?.ToString() ?? "";
            editSelectedMedicine(medCode);
        }

        public void DeleteSelectedMedicine()
        {
            if (dgvMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string medCode = dgvMedicines.SelectedRows[0].Tag?.ToString() ?? "";
            string medName = dgvMedicines.SelectedRows[0].Cells["colBrandName"].Value?.ToString() ?? "";
            deleteSelectedMedicine(medCode, medName);
        }

        public void OpenAddMedicineDialog()
        {
            AddMedicineForm form = new AddMedicineForm();
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

                saveMedicineRecord(false, form.MedicineCodeValue, form.MedicineNameValue, form.DosageUnitValue, form.CategoryValue, form.UnitPriceValue, form.StockQuantityValue, form.IsActiveValue);
            }
        }

        void editSelectedMedicine(string medCode)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader? reader = null;

            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM MedicineCatalog WHERE medicine_code = '" + medCode.Replace("'", "''") + "'";
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string medName = reader["name"].ToString() ?? "";
                    string dosageUnit = reader["dosage_unit"].ToString() ?? "";
                    string category = reader["category"].ToString() ?? "";
                    string unitPrice = reader["unit_price"].ToString() ?? "0";
                    string stockQty = reader["stock_quantity"].ToString() ?? "0";
                    int isActive = Convert.ToInt32(reader["is_active"]);

                    reader.Close();
                    conn.Close();

                    AddMedicineForm form = new AddMedicineForm(medCode, medName, dosageUnit, category, unitPrice, stockQty, isActive);
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

                        saveMedicineRecord(true, form.MedicineCodeValue, form.MedicineNameValue, form.DosageUnitValue, form.CategoryValue, form.UnitPriceValue, form.StockQuantityValue, form.IsActiveValue);
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

        void saveMedicineRecord(bool isEdit, string medCode, string medName, string dosageUnit, string category, decimal unitPrice, int stockQty, int isActive)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();

                string safeCode = medCode.Replace("'", "''");
                string safeName = medName.Replace("'", "''");
                string safeDosage = dosageUnit.Replace("'", "''");
                string safeCat = category.Replace("'", "''");

                if (isEdit)
                {
                    cmd.CommandText = "UPDATE MedicineCatalog SET " +
                        "name = '" + safeName + "', " +
                        "dosage_unit = '" + safeDosage + "', " +
                        "category = '" + safeCat + "', " +
                        "unit_price = " + unitPrice + ", " +
                        "stock_quantity = " + stockQty + ", " +
                        "is_active = " + isActive + " " +
                        "WHERE medicine_code = '" + safeCode + "'";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO MedicineCatalog (medicine_code, name, dosage_unit, category, unit_price, stock_quantity, is_active) VALUES (" +
                        "'" + safeCode + "', " +
                        "'" + safeName + "', " +
                        "'" + safeDosage + "', " +
                        "'" + safeCat + "', " +
                        unitPrice + ", " +
                        stockQty + ", " +
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

        void deleteSelectedMedicine(string medCode, string medName)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete Medicine " + medName + " (" + medCode + ")?",
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
                cmd.CommandText = "DELETE FROM MedicineCatalog WHERE medicine_code = '" + medCode.Replace("'", "''") + "'";
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
