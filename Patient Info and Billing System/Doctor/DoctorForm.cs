using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Doctor
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrDashboard dashboard = new DrDashboard();
            dashboard.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dashboard);

            ActiveButton((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientForm patientform = new PatientForm();
            patientform.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(patientform);

            ActiveButton((Button)sender);

        }

        public void OpenHealthCheckup()
        {
            DocHealthCheckUp doccheckupform = new DocHealthCheckUp();
            doccheckupform.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(doccheckupform);
            ActiveButton(btnHlthCheckup);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenHealthCheckup();
        }

        private void SideNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void healthCheck2_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActiveButton(Button currentButton)
        {
            btnDrDashboard.BackColor = Color.FromArgb(17, 34, 64);
            btnHlthCheckup.BackColor = Color.FromArgb(17, 34, 64);
            btnPatientRecord.BackColor = Color.FromArgb(17, 34, 64);
            currentButton.BackColor = Color.FromArgb(37, 99, 235);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
