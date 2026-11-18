using System;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AddLabTestForm : Form
    {
        public string TestCodeValue = "";
        public string TestNameValue = "";
        public string CategoryValue = "Hematology";
        public decimal PriceValue = 0;
        public string TurnaroundValue = "";
        public int IsActiveValue = 1;

        public AddLabTestForm()
        {
            InitializeComponent();
            Text = "Add New Lab Test";
            cmbDepartment.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtPrice.Text = "500.00";
            txtTurnaround.Text = "2 Hours";
        }

        public AddLabTestForm(string testCode, string testName, string category, string price, string turnaround, int isActive)
        {
            InitializeComponent();
            Text = "Edit Lab Test";

            txtTestCode.Text = testCode;
            txtTestCode.ReadOnly = true;
            txtTestName.Text = testName;

            cmbDepartment.SelectedItem = category;
            if (cmbDepartment.SelectedIndex == -1)
            {
                cmbDepartment.SelectedIndex = 0;
            }

            txtPrice.Text = price;
            txtTurnaround.Text = turnaround;
            cmbStatus.SelectedIndex = (isActive == 1) ? 0 : 1;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            string testCode = txtTestCode.Text.Trim();
            string testName = txtTestName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string turnaround = txtTurnaround.Text.Trim();

            if (testCode == "" || testName == "" || priceText == "" || turnaround == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(priceText, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid non-negative Price.");
                return;
            }

            TestCodeValue = testCode;
            TestNameValue = testName;
            CategoryValue = cmbDepartment.Text;
            PriceValue = price;
            TurnaroundValue = turnaround;
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
