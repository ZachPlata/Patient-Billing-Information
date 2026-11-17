using System;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AddRoomBedForm : Form
    {
        public string BedIdValue = "";
        public string RoomNumberValue = "";
        public string BedNumberValue = "";
        public string RoomTypeValue = "Ward";
        public decimal DailyRateValue = 0;
        public int IsOccupiedValue = 0;

        public AddRoomBedForm()
        {
            InitializeComponent();
            Text = "Add New Bed / Room";
            cmbRoomType.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtDailyRate.Text = "1000.00";
        }

        public AddRoomBedForm(string bedId, string roomNumber, string bedNumber, string roomType, string dailyRate, int isOccupied)
        {
            InitializeComponent();
            Text = "Edit Bed / Room";

            txtBedId.Text = bedId;
            txtBedId.ReadOnly = true;
            txtRoomNumber.Text = roomNumber;
            txtBedNumber.Text = bedNumber;

            cmbRoomType.SelectedItem = roomType;
            if (cmbRoomType.SelectedIndex == -1)
            {
                cmbRoomType.SelectedIndex = 0;
            }

            txtDailyRate.Text = dailyRate;
            cmbStatus.SelectedIndex = (isOccupied == 1) ? 1 : 0;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            string bedId = txtBedId.Text.Trim();
            string roomNumber = txtRoomNumber.Text.Trim();
            string bedNumber = txtBedNumber.Text.Trim();
            string rateText = txtDailyRate.Text.Trim();

            if (bedId == "" || roomNumber == "" || bedNumber == "" || rateText == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            decimal rateValue;
            if (!decimal.TryParse(rateText, out rateValue) || rateValue < 0)
            {
                MessageBox.Show("Please enter a valid Daily Rate.");
                return;
            }

            BedIdValue = bedId;
            RoomNumberValue = roomNumber;
            BedNumberValue = bedNumber;
            RoomTypeValue = cmbRoomType.Text;
            DailyRateValue = rateValue;
            IsOccupiedValue = (cmbStatus.Text == "Occupied") ? 1 : 0;

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
