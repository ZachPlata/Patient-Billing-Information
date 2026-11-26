using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ClinicAndDataSetup : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

        private enum SetupTab
        {
            RoomBed,
            LabTest,
            Medicine,
            Consultation
        }

        private SetupTab currentTab = SetupTab.RoomBed;

        private RnBManagement? rnbControl;
        private LabTestCatalog? labControl;
        private MedCatalog? medControl;
        private ConsFeeSched? consControl;

        public ClinicAndDataSetup()
        {
            InitializeComponent();

            updateTabCounts();
            btnTabRoomBed.PerformClick();
        }

        private void cardOccupiedBeds_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActiveButton(Button currentButton)
        {
            panelTabUnderline.Left = currentButton.Left;
            panelTabUnderline.Width = currentButton.Width;
            panelTabUnderline.BringToFront();
        }

        private void btnTabRoomBed_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.RoomBed;
            btnAddData.Text = "+ Add New Bed / Room";

            panelContent.Controls.Clear();
            rnbControl = new RnBManagement();
            panelContent.Controls.Add(rnbControl);
            rnbControl.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTabLabTests_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.LabTest;
            btnAddData.Text = "+ Add New Lab Test";

            panelContent.Controls.Clear();
            labControl = new LabTestCatalog();
            panelContent.Controls.Add(labControl);
            labControl.Show();
        }

        private void btnTabMedicine_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.Medicine;
            btnAddData.Text = "+ Add New Medicine";

            panelContent.Controls.Clear();
            medControl = new MedCatalog();
            panelContent.Controls.Add(medControl);
            medControl.Show();
        }

        private void btnTabConsultation_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.Consultation;
            btnAddData.Text = "+ Add Fee Schedule";

            panelContent.Controls.Clear();
            consControl = new ConsFeeSched();
            panelContent.Controls.Add(consControl);
            consControl.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            switch (currentTab)
            {
                case SetupTab.RoomBed:
                    if (rnbControl != null)
                    {
                        rnbControl.OpenAddBedDialog();
                    }
                    break;
                case SetupTab.LabTest:
                    if (labControl != null)
                    {
                        labControl.OpenAddLabTestDialog();
                    }
                    break;
                case SetupTab.Medicine:
                    if (medControl != null)
                    {
                        medControl.OpenAddMedicineDialog();
                    }
                    break;
                case SetupTab.Consultation:
                    if (consControl != null)
                    {
                        consControl.OpenAddFeeScheduleDialog();
                    }
                    break;
            }

            updateTabCounts();
        }

        private void lblTitleIcon_Click(object sender, EventArgs e)
        {

        }

        private void panelTabUnderline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            switch (currentTab)
            {
                case SetupTab.RoomBed:
                    if (rnbControl != null)
                    {
                        rnbControl.loaddata();
                    }
                    break;
                case SetupTab.LabTest:
                    if (labControl != null)
                    {
                        labControl.loaddata();
                    }
                    break;
                case SetupTab.Medicine:
                    if (medControl != null)
                    {
                        medControl.loaddata();
                    }
                    break;
                case SetupTab.Consultation:
                    if (consControl != null)
                    {
                        consControl.loaddata();
                    }
                    break;
            }

            updateTabCounts();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {

        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            switch (currentTab)
            {
                case SetupTab.RoomBed:
                    if (rnbControl != null)
                    {
                        rnbControl.EditSelectedBed();
                    }
                    break;
                case SetupTab.LabTest:
                    if (labControl != null)
                    {
                        labControl.EditSelectedLabTest();
                    }
                    break;
                case SetupTab.Medicine:
                    if (medControl != null)
                    {
                        medControl.EditSelectedMedicine();
                    }
                    break;
                case SetupTab.Consultation:
                    if (consControl != null)
                    {
                        consControl.EditSelectedSchedule();
                    }
                    break;
            }

            updateTabCounts();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            switch (currentTab)
            {
                case SetupTab.RoomBed:
                    if (rnbControl != null)
                    {
                        rnbControl.DeleteSelectedBed();
                    }
                    break;
                case SetupTab.LabTest:
                    if (labControl != null)
                    {
                        labControl.DeleteSelectedLabTest();
                    }
                    break;
                case SetupTab.Medicine:
                    if (medControl != null)
                    {
                        medControl.DeleteSelectedMedicine();
                    }
                    break;
                case SetupTab.Consultation:
                    if (consControl != null)
                    {
                        consControl.DeleteSelectedSchedule();
                    }
                    break;
            }

            updateTabCounts();
        }

        void updateTabCounts()
        {
            int roomCount = getTableCount("RoomsBeds");
            int labCount = getTableCount("LabTestCatalog");
            int medCount = getTableCount("MedicineCatalog");
            int feeCount = getTableCount("DoctorFeeSchedules");

            btnTabRoomBed.Text = "🛏  Room & Bed Management  ( " + roomCount + " )";
            btnTabLabTests.Text = "\U0001f9ea  Laboratory Tests Catalog  (" + labCount + ")";
            btnTabMedicine.Text = "💊  Medicine Catalog  (" + medCount + ")";
            btnTabConsultation.Text = "\U0001f9d1‍⚕️  Consultation Fee Schedules  (" + feeCount + ")";
        }

        int getTableCount(string tableName)
        {
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM " + tableName;
                cmd.Connection = conn;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return count;
            }
            catch
            {
                return 0;
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
