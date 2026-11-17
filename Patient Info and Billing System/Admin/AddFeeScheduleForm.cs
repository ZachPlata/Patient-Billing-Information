using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AddFeeScheduleForm : Form
    {
        private List<string> docIds = new List<string>();

        public string DoctorIdValue = "";
        public decimal StandardFeeValue = 0;
        public decimal FollowUpFeeValue = 0;
        public string ScheduleDaysValue = "";

        public AddFeeScheduleForm(List<string> doctorIds, List<string> doctorNames)
        {
            InitializeComponent();
            Text = "Add Fee Schedule";
            loadDoctors(doctorIds, doctorNames, "");
            txtStandardFee.Text = "500.00";
            txtFollowUpFee.Text = "300.00";
            txtScheduleDays.Text = "Mon - Fri";
        }

        public AddFeeScheduleForm(List<string> doctorIds, List<string> doctorNames, string doctorId, string standardFee, string followUpFee, string scheduleDays)
        {
            InitializeComponent();
            Text = "Edit Fee Schedule";
            loadDoctors(doctorIds, doctorNames, doctorId);
            cmbDoctor.Enabled = false;
            txtStandardFee.Text = standardFee;
            txtFollowUpFee.Text = followUpFee;
            txtScheduleDays.Text = scheduleDays;
        }

        void loadDoctors(List<string> doctorIds, List<string> doctorNames, string selectedDoctorId)
        {
            docIds = doctorIds;
            cmbDoctor.Items.Clear();

            for (int i = 0; i < doctorNames.Count; i++)
            {
                cmbDoctor.Items.Add(doctorNames[i]);
                if (doctorIds[i] == selectedDoctorId)
                {
                    cmbDoctor.SelectedIndex = i;
                }
            }

            if (cmbDoctor.SelectedIndex == -1 && cmbDoctor.Items.Count > 0)
            {
                cmbDoctor.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (cmbDoctor.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Physician.");
                return;
            }

            string stdText = txtStandardFee.Text.Trim();
            string followText = txtFollowUpFee.Text.Trim();
            string daysText = txtScheduleDays.Text.Trim();

            if (stdText == "" || followText == "" || daysText == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            decimal stdValue;
            decimal followValue;
            if (!decimal.TryParse(stdText, out stdValue) || stdValue < 0 ||
                !decimal.TryParse(followText, out followValue) || followValue < 0)
            {
                MessageBox.Show("Please enter valid non-negative fee amounts.");
                return;
            }

            DoctorIdValue = docIds[cmbDoctor.SelectedIndex];
            StandardFeeValue = stdValue;
            FollowUpFeeValue = followValue;
            ScheduleDaysValue = daysText;

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
