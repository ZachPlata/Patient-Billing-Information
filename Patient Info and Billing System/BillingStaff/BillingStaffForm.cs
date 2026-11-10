using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.BillingStaff
{
    public partial class BillingStaffForm : Form
    {
        public BillingStaffForm()
        {
            InitializeComponent();
        }
        private void SetActiveButton(Button selectedButton)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPatientRecord_Click(object sender, EventArgs e)
        {

            uc_PatientBillingRec frm = new uc_PatientBillingRec();



            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btnPatientRecord);
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
