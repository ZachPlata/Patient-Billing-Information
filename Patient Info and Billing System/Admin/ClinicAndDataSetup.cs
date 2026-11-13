using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ClinicAndDataSetup : UserControl
    {
        private enum SetupTab
        {
            RoomBed,
            LabTest,
            Medicine,
            Consultation
        }

        private SetupTab currentTab = SetupTab.RoomBed;

        public ClinicAndDataSetup()
        {
            InitializeComponent();

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
            RnBManagement form = new RnBManagement();
            panelContent.Controls.Add(form);
            form.Show();
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
            LabTestCatalog form = new LabTestCatalog();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnTabMedicine_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.Medicine;
            btnAddData.Text = "+ Add New Medicine";

            panelContent.Controls.Clear();
            MedCatalog form = new MedCatalog();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnTabConsultation_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            currentTab = SetupTab.Consultation;
            btnAddData.Text = "+ Add Fee Schedule";

            panelContent.Controls.Clear();
            ConsFeeSched form = new ConsFeeSched();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            switch (currentTab)
            {
                case SetupTab.RoomBed:
                    MessageBox.Show("Add New Bed / Room clicked");
                    break;
                case SetupTab.LabTest:
                    MessageBox.Show("Add New Lab Test clicked");
                    break;
                case SetupTab.Medicine:
                    MessageBox.Show("Add New Medicine clicked");
                    break;
                case SetupTab.Consultation:
                    MessageBox.Show("Add Fee Schedule clicked");
                    break;
            }
        }

        private void lblTitleIcon_Click(object sender, EventArgs e)
        {

        }

        private void panelTabUnderline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {

        }
    }
}
