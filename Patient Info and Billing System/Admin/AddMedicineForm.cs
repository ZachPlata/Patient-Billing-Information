using System;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AddMedicineForm : Form
    {
        public string MedicineCodeValue = "";
        public string MedicineNameValue = "";
        public string DosageUnitValue = "";
        public string CategoryValue = "";
        public decimal UnitPriceValue = 0;
        public int StockQuantityValue = 0;
        public int IsActiveValue = 1;

        public AddMedicineForm()
        {
            InitializeComponent();
            Text = "Add New Medicine";
            txtDosageUnit.Text = "Per Bottle";
            txtCategory.Text = "Analgesic";
            txtUnitPrice.Text = "100.00";
            txtStockQty.Text = "50";
            cmbStatus.SelectedIndex = 0;
        }

        public AddMedicineForm(string medCode, string medName, string dosageUnit, string category, string unitPrice, string stockQty, int isActive)
        {
            InitializeComponent();
            Text = "Edit Medicine";

            txtMedicineCode.Text = medCode;
            txtMedicineCode.ReadOnly = true;
            txtMedicineName.Text = medName;
            txtDosageUnit.Text = dosageUnit;
            txtCategory.Text = category;
            txtUnitPrice.Text = unitPrice;
            txtStockQty.Text = stockQty;
            cmbStatus.SelectedIndex = (isActive == 1) ? 0 : 1;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            string medCode = txtMedicineCode.Text.Trim();
            string medName = txtMedicineName.Text.Trim();
            string dosageUnit = txtDosageUnit.Text.Trim();
            string category = txtCategory.Text.Trim();
            string priceText = txtUnitPrice.Text.Trim();
            string stockText = txtStockQty.Text.Trim();

            if (medCode == "" || medName == "" || dosageUnit == "" || category == "" || priceText == "" || stockText == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            decimal price;
            int stock;
            if (!decimal.TryParse(priceText, out price) || price < 0 ||
                !int.TryParse(stockText, out stock) || stock < 0)
            {
                MessageBox.Show("Please enter valid non-negative Price and Stock Quantity.");
                return;
            }

            MedicineCodeValue = medCode;
            MedicineNameValue = medName;
            DosageUnitValue = dosageUnit;
            CategoryValue = category;
            UnitPriceValue = price;
            StockQuantityValue = stock;
            IsActiveValue = (cmbStatus.Text == "Active") ? 1 : 0;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
