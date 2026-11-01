using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class ClinicAndDataSetup : UserControl
    {
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
            panelContent.Controls.Clear();
            LabTestCatalog form = new LabTestCatalog();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnTabMedicine_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            MedCatalog form = new MedCatalog();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnTabConsultation_Click(object sender, EventArgs e)
        {
            ActiveButton((Button)sender);
            panelContent.Controls.Clear();
            ConsFeeSched form = new ConsFeeSched();
            panelContent.Controls.Add(form);
            form.Show();
        }
    }
}
