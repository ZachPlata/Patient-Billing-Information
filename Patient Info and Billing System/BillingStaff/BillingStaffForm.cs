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
            btnDrDashboard.BackColor = Color.FromArgb(17, 34, 64);
            btnPatientRecord.BackColor = Color.FromArgb(17, 34, 64);
            btnHlthCheckup.BackColor = Color.FromArgb(17, 34, 64);
            button1.BackColor = Color.FromArgb(17, 34, 64);
            selectedButton.BackColor = Color.FromArgb(37, 99, 235);
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

        private void btnHlthCheckup_Click(object sender, EventArgs e)
        {
            uc_PaymentForm frm = new uc_PaymentForm();
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(btnHlthCheckup);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_PaymentHistory frm = new uc_PaymentHistory();
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frm);
            frm.Show();
            SetActiveButton(button1);
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
