using Patient_Info_and_Billing_System.LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Patient_Info_and_Billing_System.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();


        }
        public static string usertype;

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer.Text = DateTime.Now.ToLongTimeString();
        }
        private void ActiveButton(Button currentButton)
        {
            btnAdminDashboard.BackColor = Color.FromArgb(17, 34, 64);
            btnClncDtSet.BackColor = Color.FromArgb(17, 34, 64);
            btnUserManagement.BackColor = Color.FromArgb(17, 34, 64);
            btnALAT.BackColor = Color.FromArgb(17, 34, 64);
            currentButton.BackColor = Color.FromArgb(37, 99, 235);

        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ActiveButton((Button)sender);
            borja1 form = new borja1();
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ActiveButton((Button)sender);
            AdminUserManagement form = new AdminUserManagement();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnClncDtSet_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ActiveButton((Button)sender);
            ClinicAndDataSetup form = new ClinicAndDataSetup();
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnALAT_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ActiveButton((Button)sender);
            Access_Logs___Audit_Trail form = new Access_Logs___Audit_Trail();
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnAdminDashboard.PerformClick();
        }

        private void SideNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            SignIn frm = new SignIn();
            frm.Show();
            this.Close();
        }
    }
}
