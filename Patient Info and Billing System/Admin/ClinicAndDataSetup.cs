using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ClinicAndDataSetup : UserControl
    {
        string connStr = "server=localhost; database=metro_care_db; uid=root";

        public ClinicAndDataSetup()
        {
            InitializeComponent();
            updateTabCounts();
            btnTabRoomBed.PerformClick();
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
            panelContent.Controls.Clear();
            RnBManagement form = new RnBManagement();
            panelContent.Controls.Add(form);
            form.Show();
            updateTabCounts();
        }

        private void btnTabLabTests_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            LabTestCatalog form = new LabTestCatalog();
            panelContent.Controls.Add(form);
            form.Show();
            updateTabCounts();
        }

        private void btnTabMedicine_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            MedCatalog form = new MedCatalog();
            panelContent.Controls.Add(form);
            form.Show();
            updateTabCounts();
        }

        private void btnTabConsultation_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            ConsFeeSched form = new ConsFeeSched();
            panelContent.Controls.Add(form);
            form.Show();
            updateTabCounts();
        }

        private void btnTabSpecialties_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            DoctorSpecialties form = new DoctorSpecialties();
            panelContent.Controls.Add(form);
            form.Show();
            updateTabCounts();
        }

        void updateTabCounts()
        {
            int roomCount = getTableCount("RoomsBeds");
            int labCount = getTableCount("LabTestCatalog");
            int medCount = getTableCount("MedicineCatalog");
            int feeCount = getTableCount("DoctorFeeSchedules");
            int specCount = getTableCount("DoctorSpecialties");

            btnTabRoomBed.Text = "🛏  Room && Bed Management  (" + roomCount + ")";
            btnTabLabTests.Text = "\U0001f9ea  Laboratory Tests Catalog  (" + labCount + ")";
            btnTabMedicine.Text = "💊  Medicine Catalog  (" + medCount + ")";
            btnTabConsultation.Text = "\U0001f9d1‍⚕️  Consultation Fee Schedules  (" + feeCount + ")";
            btnTabSpecialties.Text = "\U0001fa7a  Doctor Specialties  (" + specCount + ")";
        }

        int getTableCount(string tableName)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
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

        private void lblBreadcrumb2_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveBadge_Click(object sender, EventArgs e)
        {

        }
    }
}
